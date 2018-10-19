using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Assembly.CallingConvention;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Memcall
{
    public partial class Form1 : Form
    {
        public static string ccbox_text = "Cdecl";
        private List<ArgumentInfo> ArgList = new List<ArgumentInfo>();
        public Form1(string[] args)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Logo1;
            try
            {
                foreach (var arg in args)
                {
                    if (arg.StartsWith("-adr:")) FuncAdr.Text = arg.Split(':')[1];
                    if (arg.StartsWith("-proc:")) procBox.Text = arg.Split(':')[1];
                }
            }
            catch { }
            Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Memcall by Dz3n [v{0} x86]", v.ToString());
        }

        private void InvokeBtn_Click(object sender, EventArgs e)
        {
            InvokeBtn.Enabled = false;
            ccbox_text = CCBox.Text;
            if (!FuncAdr.Text.StartsWith("0x")) { FuncAdr.Text = "0x" + FuncAdr.Text; }
            new Thread(Work).Start();
        }

        public void SetResult(string txt)
        {
            resultBox.BeginInvoke(new Action(delegate { resultBox.Text = txt; }));
        }
        public IntPtr HexStrToPtr(string hexString1)
        {
            string hexString = hexString1.Substring(2);
            long decAgain = long.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            return new IntPtr(decAgain);
        }

        public dynamic GetArg(int i)
        {
            try
            {
                if (ArgList[i].StringArg.Length >= 1)
                {
                    return ArgList[i].StringArg;
                }
                else if (ArgList[i].ArgType.StartsWith("hex"))
                {
                    return ArgList[i].HexIntArg;
                }
                else if (ArgList[i].ArgType.StartsWith("int"))
                {
                    return ArgList[i].IntArg;
                }
                else if (ArgList[i].ArgType.StartsWith("uint"))
                {
                    return ArgList[i].UintArg;
                }
                else if (ArgList[i].ArgType.StartsWith("float"))
                {
                    return ArgList[i].FloatArg;
                }
            }
            catch { }
            return null;
        }
        public CallingConventions GetCC()
        {
            if (ccbox_text.StartsWith("Fastcall")) return CallingConventions.Fastcall;
            if (ccbox_text.StartsWith("Stdcall")) return CallingConventions.Stdcall;
            if (ccbox_text.StartsWith("Thiscall")) return CallingConventions.Thiscall;
            return CallingConventions.Cdecl;
        }
        public object GetValueFromPtr(MemorySharp m, IntPtr adr)
        {
            string result = "ERROR";
            try
            {
                if (retHEX.Checked)
                {
                    result = "0x" + m.Read<int>(adr, false).ToString("X4");
                }
                if (retINT.Checked)
                {
                    result = m.Read<int>(adr, false).ToString();
                }
                if (retUINT.Checked)
                {
                    result = m.Read<uint>(adr, false).ToString();
                }
                if (retFLOAT.Checked)
                {
                    result = m.Read<float>(adr, false).ToString();
                }
                if (retSTRING.Checked)
                {
                    result = m.ReadString(adr, false);
                }
            }
            catch { }
            return result;
        }
        private T getTT<T>(CallingConventions cc, MemorySharp m, IntPtr adr, dynamic parametr0, dynamic parametr1, dynamic parametr2, dynamic parametr3, dynamic parametr4, dynamic parametr5, dynamic parametr6, dynamic parametr7, dynamic parametr8, dynamic parametr9)
        {
            T result;
            if (parametr0 != null && parametr1 == null) result = m[adr].Execute<T>(cc, parametr0);
            else if (parametr1 != null && parametr2 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1);
            else if (parametr2 != null && parametr3 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2);
            else if (parametr3 != null && parametr4 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2, parametr3);
            else if (parametr4 != null && parametr5 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2, parametr3, parametr4);
            else if (parametr5 != null && parametr6 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5);
            else if (parametr6 != null && parametr7 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6);
            else if (parametr7 != null && parametr8 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7);
            else if (parametr8 != null && parametr9 == null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8);
            else if (parametr9 != null) result = m[adr].Execute<T>(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8, parametr9);
            else result = m[adr].Execute<T>(cc);
            return result;
        }
        public void Work()
        {
            try
            {

                string hexString = FuncAdr.Text;
                hexString = hexString.Substring(2);
                long decAgain = long.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                IntPtr adr = new IntPtr(decAgain);
                if (!minus0x4.Checked) adr -= 0x400000;


                SetResult("Address: 0x" + adr.ToString("X4") + "\r\nCC: " + ccbox_text);

                Process.EnterDebugMode();
                Process p = Process.GetProcessesByName(procBox.Text).FirstOrDefault();
                MemorySharp m = new MemorySharp(p);
                // 0x004113E0

                SetResult("Calling function");
                dynamic parametr0 = GetArg(0);
                dynamic parametr1 = GetArg(1);
                dynamic parametr2 = GetArg(2);
                dynamic parametr3 = GetArg(3);
                dynamic parametr4 = GetArg(4);
                dynamic parametr5 = GetArg(5);
                dynamic parametr6 = GetArg(6);
                dynamic parametr7 = GetArg(7);
                dynamic parametr8 = GetArg(8);
                dynamic parametr9 = GetArg(9);
                CallingConventions cc = GetCC();


                string returnedValue = "nothing";
                if (!isReturns.Checked)
                {
                    if (parametr0 != null && parametr1 == null) m[adr].Execute(cc, parametr0);
                    else if (parametr1 != null && parametr2 == null) m[adr].Execute(cc, parametr0, parametr1);
                    else if (parametr2 != null && parametr3 == null) m[adr].Execute(cc, parametr0, parametr1, parametr2);
                    else if (parametr3 != null && parametr4 == null) m[adr].Execute(cc, parametr0, parametr1, parametr2, parametr3);
                    else if (parametr4 != null && parametr5 == null) m[adr].Execute(cc, parametr0, parametr1, parametr2, parametr3, parametr4);
                    else if (parametr5 != null && parametr6 == null) m[adr].Execute(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5);
                    else if (parametr6 != null && parametr7 == null) m[adr].Execute(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6);
                    else if (parametr7 != null && parametr8 == null) m[adr].Execute(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7);
                    else if (parametr8 != null && parametr9 == null) m[adr].Execute(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8);
                    else if (parametr9 != null) m[adr].Execute(cc, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8, parametr9);
                    else m[adr].Execute(cc);

                }
                else
                {
                    object result = "nothing/error";

                    if (retHEX.Checked)
                    {
                        result = "0x" + getTT<int>(cc, m, adr, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8, parametr9).ToString("X4");
                    }
                    if (retINT.Checked)
                    {
                        result = getTT<int>(cc, m, adr, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8, parametr9).ToString();
                    }
                    if (retUINT.Checked)
                    {
                        result = getTT<uint>(cc, m, adr, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8, parametr9).ToString();
                    }
                    if (retFLOAT.Checked)
                    {
                        result = getTT<float>(cc, m, adr, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8, parametr9).ToString();
                    }
                    if (retSTRING.Checked)
                    {
                        result = getTT<string>(cc, m, adr, parametr0, parametr1, parametr2, parametr3, parametr4, parametr5, parametr6, parametr7, parametr8, parametr9);
                    }

                    returnedValue = result.ToString();
                }

                SetResult(String.Format("Function 0x{0} called\r\nReturned value: {1}", adr.ToString("X4"), returnedValue));


                //m.Dispose();
            }
            catch (Exception ex)
            {
                SetResult(ex.ToString());
            }
            InvokeBtn.BeginInvoke(new Action(delegate { InvokeBtn.Enabled = true; }));
        }

        private void naAdd_Click(object sender, EventArgs e)
        {
            if (ArgList.Count >= 10)
            {
                MessageBox.Show("Sorry, you can't add more than 10 arguments");
                return;
            }
            ArgumentInfo aInfo = new ArgumentInfo();
            try
            {
                if (naHex.Checked)
                {

                    if (!naArg.Text.StartsWith("0x")) naArg.Text = "0x" + naArg.Text;
                    string hexString = naArg.Text;
                    hexString = hexString.Substring(2);
                    long decAgain = long.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                    aInfo.HexIntArg = Int64.Parse(decAgain.ToString());
                    aInfo.ArgType = "hex";
                }
                else if (naInt.Checked) { aInfo.IntArg = int.Parse(naArg.Text); aInfo.ArgType = "int"; }
                else if (naFloat.Checked) { aInfo.FloatArg = float.Parse(naArg.Text); aInfo.ArgType = "float"; }
                else if (naStr.Checked) { aInfo.StringArg = naArg.Text + "\0"; aInfo.ArgType = "string"; }
                else if (naUint.Checked) { aInfo.UintArg = uint.Parse(naArg.Text); aInfo.ArgType = "uint"; }
                else throw new Exception("Unknown argument/type");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Memcall: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ArgList.Add(aInfo);
            resultBox.Text = "New argument added";
            UpdateArgBox();

        }


        public void UpdateArgBox()
        {
            argBox.Items.Clear();
            for (int i = 0; i < ArgList.Count; i++)
            {
                string argStr = "";
                string argType = "";
                if (ArgList[i].StringArg.Length >= 1)
                {
                    argType = "string";
                    argStr = ArgList[i].StringArg;
                }
                else if (ArgList[i].ArgType.StartsWith("hex"))
                {
                    argType = "int/hex";
                    argStr = "0x" + ArgList[i].HexIntArg.ToString("X4");
                }
                else if (ArgList[i].ArgType.StartsWith("int"))
                {
                    argType = "int";
                    argStr = ArgList[i].IntArg.ToString();
                }
                else if (ArgList[i].ArgType.StartsWith("uint"))
                {
                    argType = "uint";
                    argStr = ArgList[i].UintArg.ToString();
                }
                else if (ArgList[i].ArgType.StartsWith("float"))
                {
                    argType = "float";
                    argStr = ArgList[i].FloatArg.ToString();
                }
                string aStr = String.Format("[{0}] ({1}) {2}", i + 1, argType, argStr);
                argBox.Items.Add(aStr);
            }
        }

        private void argRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Input example: [2] Type: int  -  542
                int id = int.Parse(argBox.SelectedItem.ToString().Split(']')[0].Replace("[", String.Empty)) - 1;
                ArgList.Remove(ArgList[id]);
                UpdateArgBox();
                resultBox.Text = "Argument #" + (id + 1) + " removed";
                // Result example: 2
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcList plist = new ProcList();
            plist.ShowDialog();
            procBox.Text = plist.proc;
        }

        private void thicallc_CheckedChanged(object sender, EventArgs e)
        {
            // if (thicallc.Checked) MessageBox.Show("Thiscalls will be added soon", "Memcall", MessageBoxButtons.OK);
            // thicallc.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AboutWnd().ShowDialog();
        }

        private void FuncAdr_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AboutWnd().ShowDialog();
        }

        private void InvokeBtn_Click_1(object sender, EventArgs e)
        {
            InvokeBtn_Click(sender, e);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            new AboutWnd().ShowDialog();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void naAdd_Click_1(object sender, EventArgs e)
        {
            naAdd_Click(sender, e);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
