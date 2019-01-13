using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Assembly.CallingConvention;
using Dz3n.UIEditor;
using escript;

namespace Memcall
{
    public partial class MemcallWnd : Form
    {
        #region invokes
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private Process sProcess = null;
        public IntPtr Address = IntPtr.Zero;
        private int sItem = -1;
        public List<dynamic> Arguments = new List<dynamic>();
        Type[] CompatibleTypes = { typeof(Nullable), typeof(string), typeof(int), typeof(byte), typeof(long), typeof(bool), typeof(float), typeof(double), typeof(uint), typeof(ulong) };
        public bool WaitForProcess = false;
        public bool WaitingForProcess = false;
        public List<string> LastAddresses = new List<string>();
        public string ProjectPath = null;
        public int SelectedItem
        {
            get { return sItem; }
            set
            {
                sItem = value;
                if (sItem == -1)
                {
                    gbArgProps.Enabled = false;
                    gbArgProps.Text = "Argument Properties";
                }
                else
                {
                    gbArgProps.Enabled = true;
                    if (Arguments[value] != null)
                    {
                        gbArgProps.Text = Arguments[value].ToString() + $" [{SelectedItem}] Properties";
                        cbArgType.Text = Arguments[value].GetType().Name;
                        tbArgValue.Text = Arguments[value].ToString();
                    }
                    else
                    {
                        gbArgProps.Text = $"[{SelectedItem}] Properties";
                        cbArgType.Text = "null";
                        tbArgValue.Text = "";
                    }
                }
            }
        }
        public bool IsRelative = false;
        public Process SelectedProcess
        {
            get { return sProcess; }
            set
            {
                LastAddresses.Clear();
                sProcess = value;
                if (sProcess != null)
                {
                    btnProcess.Text = $"[{value.Id}] {value.ProcessName}";
                    btnInvoke.Enabled = true;
                }
                else
                {
                    btnProcess.Text = "Select process...";
                    btnInvoke.Enabled = false;
                    labelInformation.Text = "";
                }
            }
        }

        public MemcallWnd(string[] args)
        {
            InitializeComponent();
            Icon = Properties.Resources.Logo1;
            
            Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            labelTitle.Text = String.Format("Dz3n.Memcall v{0}", v.ToString());
            SelectedProcess = null;
            SelectedItem = -1;

            escript.API.WriteEvent += API_WriteEvent;
            escript.API.WriteLineEvent += API_WriteLineEvent;
            escript.API.Start();
            
            Cmd.Process("PrintIntro");
            Cmd.Process("echo ESCRIPT {ver} connected to Memcall!");


            foreach (var type in CompatibleTypes)
            {
                //cbReturn.Items.Add(type.Name);
                cbArgType.Items.Add(type.Name);
            }
            try
            {
                if(File.Exists(args[0]))
                    ProjectPath = args[0];

                foreach (var arg in args)
                {
                    if (arg.StartsWith("-adr:")) cbAddress.Text = arg.Split(':')[1];
                    if (arg.StartsWith("-proc:"))
                    {
                        int pid = int.Parse(arg.Split(':')[1]);
                        SelectedProcess = Process.GetProcessById(pid);
                    }
                }
            }
            catch { }
        }

        public CallingConventions CallingConvention = CallingConventions.Cdecl;

        public void GetArgByIndex(int idx)
        {
            
        }

        public bool AppendPublics(Process p)
        {
            try
            {
                MemorySharp s = new MemorySharp(p);
                var i = s.Modules.MainModule.Information;
                string text = $"Base Address: 0x{i.BaseAddress.ToString("X4")}\r\nState: {i.State.ToString()}\r\nType: {i.Type.ToString()}";

                labelInformation.Text = text;
                return true;
            }
            catch (Win32Exception)
            {
                Program.Msg("The process is x64, Memcall works only with x86 =(");
                return false;

            }
            catch (Exception ex)
            {
                Program.Msg("Can't fetch process information!\r\n" + ex.ToString());
                return false;
            }
        }

        private void API_WriteLineEvent(object text)
        {
            tbLog.AppendText(text.ToString() + Environment.NewLine);
        }

        private void API_WriteEvent(object text)
        {
            tbLog.AppendText(text.ToString());
        }


        public void CheckProcess()
        {
            while(true)
            {
                if (SelectedProcess != null)
                {
                    try
                    {
                        if (SelectedProcess.HasExited)
                            throw new Exception("Process has exited");


                        WaitingForProcess = false;
                    }
                    catch (Exception ex)
                    {
                        WaitingForProcess = true;
                        if (WaitForProcess)
                        {
                            btnProcess.Text = $"[{SelectedProcess.Id}] {SelectedProcess.ProcessName} - CLOSED";
                            foreach (var p in Process.GetProcessesByName(SelectedProcess.ProcessName))
                            {
                                Invoke(new Action(() =>
                                {
                                    SelectedProcess = p;
                                }));
                                    continue;
                            }
                            continue;
                        }
                        

                        Invoke(new Action(() =>
                        {
                            if( Program.ShowError($"Something happened to the selected process ({SelectedProcess.ProcessName}). Message: {ex.Message}\r\n\r\nPress Yes to wait for reopening\r\nPress No to deselect process", "Process Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                WaitForProcess = true;
                            }
                            else
                                SelectedProcess = null;
                        }));
                    }
                }
                Thread.Sleep(2000);
            }
        }

        private void MemcallWnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcList pWnd = new ProcList(this);
            if(pWnd.ShowDialog() == DialogResult.OK)
            {
                SelectedProcess = pWnd.SelectedProcess;
                WaitForProcess = pWnd.WaitFor;
            }
        }

        private void MemcallWnd_Deactivate(object sender, EventArgs e)
        {
            if (!Program.DoAero(this, panel1))
                panel1.BackColor = Color.White;//System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private void MemcallWnd_Activated(object sender, EventArgs e)
        {
            if (!Program.DoAero(this, panel1))
                panel1.BackColor = Color.White; //System.Drawing.SystemColors.GradientActiveCaption;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public bool IsItInHex(string n)
        {
            if (n.StartsWith("0x") || n.Any(char.IsLetter))
            {
                return true;
            }

            return false;
        }

        public string HexProc(string n)
        {
            n = n.Trim();

            if (n.StartsWith("0x"))
                n = n.Substring(2);

            return n;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            new AboutWnd().ShowDialog();
        }

        private void MemcallWnd_Load(object sender, EventArgs e)
        {
            new Thread(() => {
                FileAssociation.AssociateESCRIPT("Memcall Project", System.Reflection.Assembly.GetExecutingAssembly().Location, ".memcall", "Memcall");
                FileAssociation.SHChangeNotify(FileAssociation.SHCNE_ASSOCCHANGED, FileAssociation.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
            }).Start();

            new Thread(CheckProcess).Start();

            Program.DoAero(this, panel1);
            
            if (ProjectPath != null)
                LoadProject(ProjectPath);
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            if(WaitingForProcess)
            {
                Program.Msg("Process " + SelectedProcess.ProcessName + " is closed");
                return;
            }
            IsRelative = cbIsRelative.Checked;
            try
            {
                string n = cbAddress.Text;
                if (n.StartsWith("0x")) n = n.Substring(2);
                if (n.Contains("/")) n = n.Split('/')[0];
                n = n.Trim();

                uint v = 0;

                try
                {
                    v = uint.Parse(n, System.Globalization.NumberStyles.HexNumber);
                    Address = (IntPtr)v;
                }
                catch
                {
                    v = uint.Parse(n);
                    Address = (IntPtr)v;
                }

                if (Address == IntPtr.Zero)
                    throw new Exception();


            }
            catch { Program.Msg("Can't convert Address"); return; }
            btnInvoke.Enabled = false;
            tbLog.Clear();
            new Thread(WorkFly).Start();
        }

        private void WorkFly()
        {
            try
            {
                WriteLine("Adr: 0x" + Address.ToString("X4") + ", args: " + Arguments.Count, ConsoleColor.Gray, true);
                dynamic result = null;

                Process.EnterDebugMode();

                MemorySharp m = new MemorySharp(SelectedProcess);

                if (cbActivateWindow.Checked)
                    m.Windows.MainWindow.Activate();

                List<dynamic> args = Arguments.ToList();
                for(int i = 0; i < args.Count; i++)
                {
                    if (args[i] == null)
                        args[i] = IntPtr.Zero;
                }

                result = m[Address, IsRelative].Execute(CallingConvention, args.ToArray<dynamic>());


                string r = "";

                if (result == null)
                    r = "null";

                else if (result.GetType() == typeof(string))
                    r = "\"" + result.ToString() + "\"";

                else
                {
                    r = $"({result.GetType().Name}) {result.ToString()}";
                    if(cbReturnHex.Checked && result != null)
                    {
                        try
                        {
                            r += "\r\n > HEX: 0x" + result.ToString("X4");
                        }
                        catch
                        {
                            r += $"\r\n > HEX: Can't convert {result.GetType().Name} to hex";
                        }
                    }
                }

                WriteLine($" > RESULT: " + r, ConsoleColor.Green, true);
            }
            catch (Exception ex)
            {
                WriteLine("ERROR:\r\n" + ex.ToString(), ConsoleColor.Red, true);
            }
            finally
            {
                this.Invoke(new Action(() =>
                {
                    SelectedProcess = SelectedProcess; // update button state
                }));
            }
        }

        public void WriteLine(object text, ConsoleColor color = ConsoleColor.Black, bool invoke = false)
        {
            if(invoke)
            {
                Invoke(new Action(() => { WriteLine(text, color, false); }));
                return;
            }

            EConsole.WriteLine(text, color);
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            GlobalVars.SendMessage(tbLog.Handle, GlobalVars.WM_VSCROLL, (IntPtr)GlobalVars.SB_PAGEBOTTOM, IntPtr.Zero);
            //tbLog.Select(tbLog.TextLength, tbLog.TextLength);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddArgument(null);
        }

        public void AddArgument(object argument)
        {
            Arguments.Add(argument);
            RefreshArgsList();
            lbArgs.SelectedIndex = Arguments.Count - 1;
        }

        public void RefreshArgsList()
        {
            lbArgs.Items.Clear();
            for (int i = 0; i < Arguments.Count; i++)
            {
                if(Arguments[i] == null)
                    lbArgs.Items.Add($"[{i}] (null)");
                else if (Arguments[i].GetType() == typeof(string))
                {
                    lbArgs.Items.Add($"[{i}] \"{Arguments[i].ToString()}\" ({Arguments[i].GetType().Name})");
                }
                else
                    lbArgs.Items.Add($"[{i}] {Arguments[i].ToString()} ({Arguments[i].GetType().Name})");
            }
        }
        
        

        private void lbArgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedItem = lbArgs.SelectedIndex;
            }
            catch
            {
                SelectedItem = -1;
            }
        }

        private void btnApplyProps_Click(object sender, EventArgs e)
        {
            string type = cbArgType.Text.ToLower();
            string value = tbArgValue.Text;
            try
            {
                if (type == "string")
                {
                    Arguments[SelectedItem] = value;
                }
                else if (type == "int" || type == "integer" || type == "int32")
                {
                    if (IsItInHex(value))
                        Arguments[SelectedItem] = int.Parse(HexProc(value), System.Globalization.NumberStyles.HexNumber);
                    else
                        Arguments[SelectedItem] = int.Parse(value);
                }
                else if (type == "long" || type == "int64")
                {
                    if (IsItInHex(value))
                        Arguments[SelectedItem] = long.Parse(HexProc(value), System.Globalization.NumberStyles.HexNumber);
                    else
                        Arguments[SelectedItem] = long.Parse(value);
                }
                else if (type == "boolean" || type == "bool")
                {
                    Arguments[SelectedItem] = bool.Parse(value);
                }
                else if (type == "float" || type == "single")
                {
                    Arguments[SelectedItem] = float.Parse(value);
                }
                else if (type == "double")
                {
                    Arguments[SelectedItem] = double.Parse(value);
                }
                else if (type == "byte")
                {
                    if (IsItInHex(value))
                        Arguments[SelectedItem] = byte.Parse(HexProc(value), System.Globalization.NumberStyles.HexNumber);
                    else
                        Arguments[SelectedItem] = byte.Parse(value);
                }
                else if (type == "uint" || type == "uint32")
                {
                    if (IsItInHex(value))
                        Arguments[SelectedItem] = uint.Parse(HexProc(value), System.Globalization.NumberStyles.HexNumber);
                    else
                        Arguments[SelectedItem] = uint.Parse(value);
                }
                else if (type == "ulong" || type == "uint64")
                {
                    if (IsItInHex(value))
                        Arguments[SelectedItem] = ulong.Parse(HexProc(value), System.Globalization.NumberStyles.HexNumber);
                    else
                        Arguments[SelectedItem] = ulong.Parse(value);
                }
                else if (type == "null" || type == "nullable")
                {
                    Arguments[SelectedItem] = null;
                }
                RefreshArgsList();
                lbArgs.SelectedIndex = SelectedItem;
                //SelectedItem = -1;
            }
            catch (Exception ex)
            {
                Program.Msg(ex.GetType().Name + ": " + ex.Message + "\r\nAre you sure that " + type + " is right type for " + value + "?");
            }
        }

        private void tbArgValue_TextChanged(object sender, EventArgs e)
        {
            string text = tbArgValue.Text;
            if (cbAutoType.Checked)
            {
                if(text.StartsWith("0x"))
                {
                    cbArgType.Text = "uint";
                    return;
                }

                if(text.Length == 0)
                {
                    cbArgType.Text = "null";
                    return;
                }
                try
                {
                    bool.Parse(tbArgValue.Text);
                    cbArgType.Text = "Boolean";
                    return;
                }
                catch { }
                try
                {
                    long.Parse(tbArgValue.Text);
                    cbArgType.Text = "Long";
                    return;
                }
                catch { }
                try
                {
                    float.Parse(tbArgValue.Text);
                    cbArgType.Text = "Float";
                    return;
                }
                catch { }
                try
                {
                    double.Parse(tbArgValue.Text);
                    cbArgType.Text = "Double";
                    return;
                }
                catch { }

                cbArgType.Text = "String";
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    Arguments.Remove(Arguments[lbArgs.SelectedIndex]);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Arguments.Clear();
                }
            }
            catch { }
            RefreshArgsList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // down
            int current = SelectedItem;
            int n = current + 1;
            if (n >= Arguments.Count) return;
            object old = Arguments[n];
            object obj = Arguments[current];
            Arguments[n] = obj;
            Arguments[current] = old;

            RefreshArgsList();
            lbArgs.SelectedIndex = n;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // up
            int current = SelectedItem;
            int n = current - 1;
            if (n <= -1) return;
            object old = Arguments[n];
            object obj = Arguments[current];
            Arguments[n] = obj;
            Arguments[current] = old;

            RefreshArgsList();
            lbArgs.SelectedIndex = n;
        }

        private void cbCC_TextChanged(object sender, EventArgs e)
        {
            if (cbCC.Text.ToLower().StartsWith("fastcall")) CallingConvention = CallingConventions.Fastcall;
            else if (cbCC.Text.ToLower().StartsWith("stdcall")) CallingConvention = CallingConventions.Stdcall;
            else if (cbCC.Text.ToLower().StartsWith("thiscall")) CallingConvention = CallingConventions.Thiscall;
            else if (cbCC.Text.ToLower().StartsWith("cdecl")) CallingConvention = CallingConventions.Cdecl;
        }

        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAddress_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void btnOpen_Click(object sender, EventArgs e)
        {
            object a = Cmd.Process("FileDialog Open EXE||*.exe|*.exe");
            string b = "";
            if (a != null)
                b = (string)a;

            if(b != "null")
            {
                FileInfo p = new FileInfo(b);
                Process start = new Process();
                start.StartInfo.WorkingDirectory = p.Directory.FullName;
                start.StartInfo.FileName = p.FullName;
                start.Start();
                Thread.Sleep(1000);
                SelectedProcess = start;
            }
        }

        private void cbAddress_Leave(object sender, EventArgs e)
        {

            string t = cbAddress.Text;
            if (!t.Contains("// saved")) t += " // saved";

            if (LastAddresses.Contains(t))
                return;

            LastAddresses.Add(t);
            cbAddress.AutoCompleteCustomSource.Add(t);
            cbAddress.Items.Add(t);

            if (LastAddresses.Count <= 1)
                WriteLine("\r\nNew address added to the list. It will be cleared if you change the process. Save project to save this list. If you want to add another one, just enter it in Address box and unfocus it.");
        }

        private void panelOld_Click(object sender, EventArgs e)
        {
            //    Form1 form = new Form1(new string[] { });
            //    form.Show();
        }

        public void LoadProject(string f)
        {

            escript.Cmd.Process("SetStatus Memcall - Open Project||Loading Project: " + f);

            try
            {
                SelectedItem = -1;
                XmlSerializer xml = new XmlSerializer(typeof(ProjectClass));
                using (FileStream fs = new FileStream(f, FileMode.OpenOrCreate))
                {
                    ProjectClass ser = (ProjectClass)xml.Deserialize(fs);

                    if (SelectedProcess == null && ser.ProcessName.Length >= 1)
                    {
                        foreach (var p in Process.GetProcessesByName(ser.ProcessName))
                        {
                            SelectedProcess = p;
                        }
                    }

                    Arguments = ser.Arguments.ToList();
                    LastAddresses = ser.Addresses.ToList();
                    foreach(var adr in LastAddresses)
                    {
                        cbAddress.AutoCompleteCustomSource.Add(adr);
                        cbAddress.Items.Add(adr);
                    }
                    RefreshArgsList();
                }
                EConsole.WriteLine("Project loaded");
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.ToString(), "Load Project Error");
            }
            escript.Cmd.Process("HideStatus");
        }

        private void btnOpenArgs_Click(object sender, EventArgs e)
        {
            string f = Cmd.Process("FileDialog Open UI Editor Project||Memcall Project (*.memcall)|*.memcall|All Files (*.*)|*.*");
            if (f == "null") return;
            LoadProject(f);
        }

        private void btnSaveArgs_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveDialog = new System.Windows.Forms.SaveFileDialog();
            saveDialog.Title = "Save UIEditor project as...";
            saveDialog.Filter = "Memcall Project (*.memcall)|*.memcall|All Files (*.*)|*.*";
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string f = saveDialog.FileName;
                escript.Cmd.Process("SetStatus Memcall - Save Project||Saving Project: " + f);
                try
                {
                    ProjectClass sClass = new ProjectClass();
                    sClass.Arguments = Arguments.ToList();
                    sClass.Addresses = LastAddresses.ToList();
                    if (SelectedProcess != null)
                        sClass.ProcessName = SelectedProcess.ProcessName;

                    XmlSerializer xml = new XmlSerializer(typeof(ProjectClass));
                    if (File.Exists(f)) File.Delete(f);
                    using (FileStream fs = new FileStream(f, FileMode.OpenOrCreate))
                    {
                        xml.Serialize(fs, sClass);

                        EConsole.WriteLine("Serialization completed!", ConsoleColor.Green);
                    }

                }
                catch (Exception ex)
                {
                    Program.ShowError(ex.ToString(), "Save Project Error");
                }

                escript.Cmd.Process("HideStatus");
            }
            else return;
        }

        private void btnProcess_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                SelectedProcess = null;
        }

        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            btnOpen_Click(null, null);
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            btnSaveArgs_Click(null, null);
        }
    }
}
