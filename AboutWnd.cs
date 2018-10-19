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
    public partial class AboutWnd : Form
    {
        public AboutWnd()
        {
            InitializeComponent();
            Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            vtext.Text = String.Format("Memcall v{0}", v.ToString());
            this.Icon = Properties.Resources.Logo1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCDv-eoYT6vZ9lNQ0L8ZLPEA");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCU40PNPpo8GBaWQwxtTCEQQ");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/feel-the-dz3n/Memcall");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/NMTQHHy");
        }
    }
}
