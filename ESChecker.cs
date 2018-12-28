using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memcall
{
    public class ESChecker
    {
        public enum Solution
        {
            Download,
            ExtractFromAssembly
        };

        public static bool Check()
        {
            return Check(Solution.Download);
        }

        public static bool Check(Solution solution, string minVersion = "5.0.7009", string fileName = "escript.exe", string assemblyPath = null)
        {
            FileInfo escriptInfo = new FileInfo(Path.Combine(new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName, fileName));
            if (!escriptInfo.Exists)
            {

                if (solution == Solution.Download)
                {
                    var msg = MessageBox.Show($"ESCRIPT is required, but not found in program's directory.\r\nDo you want to download it?", "ESCRIPT Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        Download(fileName);
                        return true;
                    }
                    else return false;
                }
                else if (solution == Solution.ExtractFromAssembly && assemblyPath != null)
                {
                    try
                    {
                        WriteResourceToFile(assemblyPath, fileName);
                        return true;
                    }
                    catch
                    {
                        if (File.Exists(escriptInfo.FullName)) escriptInfo.Delete();
                        while (File.Exists(escriptInfo.FullName) == true) { Thread.Sleep(10); }

                    }
                }

                return Check(Solution.Download, minVersion, assemblyPath, fileName); // If assemblyPath is null or error, let's download it
            }
            else
            {
                if (minVersion != null)
                {
                    try
                    {
                        int major = int.Parse(minVersion.Split('.')[0]);
                        int minor = int.Parse(minVersion.Split('.')[1]);
                        int build = int.Parse(minVersion.Split('.')[2]);

                        Version escriptVersion = new Version(FileVersionInfo.GetVersionInfo(escriptInfo.FullName).FileVersion);

                        if (escriptVersion.Major < major || escriptVersion.Minor < minor || escriptVersion.Build < build)
                        {
                            var msg = MessageBox.Show($"ESCRIPT's version is {escriptVersion.ToString()}, but the minimal version is {minVersion}. Can't continue.\r\n\r\nDo you want to install the right version?", "ESCRIPT Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (msg == DialogResult.Yes)
                            {
                                escriptInfo.Delete();
                                while (File.Exists(escriptInfo.FullName) == true) { Thread.Sleep(10); }

                                return Check(solution, minVersion, assemblyPath, fileName);
                            }
                            else return false;
                        }
                        else return true; // Version Check OK
                    }
                    catch (Exception ex)
                    {
                        var msg = MessageBox.Show($"ESCRIPT is broken ({ex.GetType().Name}: {ex.Message}).\r\nDo you want to reinstall it?", "ESCRIPT Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (msg == DialogResult.Yes)
                        {
                            escriptInfo.Delete();
                            while (File.Exists(escriptInfo.FullName) == true) { Thread.Sleep(10); }

                            return Check(solution, minVersion, assemblyPath, fileName);
                        }
                        else return false;
                    }
                }
                return true;
            }
        }

        private static void Download(string fileName = "escript.exe")
        {
            string url = "https://raw.githubusercontent.com/feel-the-dz3n/escript-stuff/master/UpdateFiles/escript-beta.exe";
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, fileName);

        }

        private static void WriteResourceToFile(string resourceName, string fileName)
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
