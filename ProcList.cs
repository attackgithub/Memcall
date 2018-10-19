using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memcall
{
    public partial class ProcList : Form
    {
        public string proc = "";
        public ProcList()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Logo1;
            foreach (var p in Process.GetProcesses())
            {
                listBox1.Items.Add(p.ProcessName);
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
    }
}
