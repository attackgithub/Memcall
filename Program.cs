using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Memcall
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach(var p in Process.GetProcessesByName("Memcall"))
            {
                try
                {
                    if (p.Id != Process.GetCurrentProcess().Id)
                    {
                        p.Kill();
                        p.WaitForExit();
                    }
                }
                catch { }
            }

            try
            {
                FileInfo escriptInfo = new FileInfo(Path.Combine(new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName, "escript.exe"));
                if (escriptInfo.Exists)
                    escriptInfo.Delete();

                if (!ESChecker.Check(ESChecker.Solution.ExtractFromAssembly, "5.0.0", "escript.exe", "Memcall.escript.exe"))
                {
                    ShowError("Can't continue without ESCRIPT.");
                    Environment.Exit(1);
                }
                WriteResourceToFile("Memcall.MemorySharp.dll", "MemorySharp.dll");
                WriteResourceToFile("Memcall.Fasm.NET.dll", "Fasm.NET.dll");
            }
            catch (Exception ex)
            {
                ShowError("Can't extract DLLs:\r\n\r\n" + ex.ToString());
                Environment.Exit(1);
            }

            Run(args);
        }
        
        static void Run(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MemcallWnd(args));
        }

        public static bool DoAero(Form form, Panel panel)
        {
            if (Aero.DwmIsCompositionEnabled())
            {
                panel.BackColor = System.Drawing.Color.White;
                return true;
            }

            return false;
        }
        public static DialogResult ShowError(string text, string caption = "Memcall Error", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(text, caption, buttons, MessageBoxIcon.Error);
        }
        public static DialogResult Msg(string text, string caption = "Memcall", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(text, caption, buttons);
        }

        public static void WriteResourceToFile(string resourceName, string fileName)
        {
            using (var resource = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }
    }
}
