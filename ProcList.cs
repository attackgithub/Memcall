using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Assembly.CallingConvention;
using System.Windows.Forms;

namespace Memcall
{
    public partial class ProcList : Form
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process(
     [In] Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid hProcess,
     [Out, MarshalAs(UnmanagedType.Bool)] out bool wow64Process
     );

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr processHandle,
             [Out, MarshalAs(UnmanagedType.Bool)] out bool wow64Process);
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);
        public Process SelectedProcess = null;
        public string proc = "";
        public MemcallWnd mWnd = null;
        public bool WaitFor { get { return cbWait.Checked; } }
        public List<object[]> Processes = new List<object[]>();
        public ProcList(MemcallWnd m)
        {
            mWnd = m;
            InitializeComponent();
            this.Icon = Properties.Resources.Logo1;
            FullRefresh();
            pRefresh();
        }

        public void FullRefresh()
        {

            Processes.Clear();
            foreach (var p in Process.GetProcesses())
            {
                string user = GetProcessUser(p);
                string stattime = "";
                try
                {
                    stattime = p.StartTime.ToString();
                }
                catch { }
                string modules = "";
                if (checkBox1.Checked)
                {
                    try
                    {
                        modules = p.Modules.Count.ToString();
                    }
                    catch (Win32Exception) { continue; }
                    catch { }
                }
                object[] o = new object[] { p.Id, p.ProcessName, p.MainWindowTitle, user, modules, stattime };
                Processes.Add(o);
                //listBox1.Items.Add(p.ProcessName);
            }
        }
        

        public void pRefresh()
        {

            dataGridView1.Rows.Clear();
            foreach(var o in Processes)
            {
                if (tbSearch.Text.Length >= 1)
                {
                    if (o[1].ToString().ToLower().Contains(tbSearch.Text.ToLower()) || o[0].ToString().Contains(tbSearch.Text))
                    {
                        dataGridView1.Rows.Add(o);
                    }
                }
                else
                    dataGridView1.Rows.Add(o);
            }
           
        }
        private static string GetProcessUser(Process process)
        {
            IntPtr processHandle = IntPtr.Zero;
            try
            {
                OpenProcessToken(process.Handle, 8, out processHandle);
                System.Security.Principal.WindowsIdentity wi = new System.Security.Principal.WindowsIdentity(processHandle);
                string user = wi.Name;
                return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\") + 1) : user;
            }
            catch
            {
                return "null";
            }
            finally
            {
                if (processHandle != IntPtr.Zero)
                {
                    CloseHandle(processHandle);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                proc = listBox1.SelectedItem.ToString();
                this.Close();
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FullRefresh();
            pRefresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch { }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Selected = true;
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                int pid = int.Parse(selectedRow.Cells[0].Value.ToString());
                SelectedProcess = Process.GetProcessById(pid);
                proc = SelectedProcess.ProcessName;
                labelTitle.Text = $"ID: {SelectedProcess.Id}, Name: {SelectedProcess.ProcessName}";
            }
            catch { }
        }

        private void ProcList_Load(object sender, EventArgs e)
        {
            Program.DoAero(this, panel2);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mWnd != null && SelectedProcess != null)
                if (!mWnd.AppendPublics(SelectedProcess))
                {
                    SelectedProcess = null;
                }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mWnd.btnOpen_Click(sender, e);
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            pRefresh();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                btnOK_Click(sender, null);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, null);
            }
            else
            {
                tbSearch.Focus();
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
            tbSearch.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FullRefresh();
            pRefresh();
        }
    }
}
