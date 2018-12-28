using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Dz3n.UIEditor
{

    class FileAssociation
    {
        public static string FILE_EXTENSION = ".mwoui";
        public const long SHCNE_ASSOCCHANGED = 0x8000000L;
        public const uint SHCNF_IDLIST = 0x0U;
        public static string ProductName = "Dz3n.UIEditor";
        
        public static void AssociateESCRIPT(string description, string icon, string FILE_EXTENSION = ".mwoui", string ProductName = "Dz3n.UIEditor")
        {
#if !IsCore
            Registry.ClassesRoot.CreateSubKey(FILE_EXTENSION).SetValue("", ProductName);

            if (ProductName != null && ProductName.Length > 0)
            {
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(ProductName))
                {
                    if (description != null)
                        key.SetValue("", description);

                    if (icon != null)
                        key.CreateSubKey("DefaultIcon").SetValue("", icon + ",1");

                    key.CreateSubKey(@"Shell\Open\Command").SetValue("", ToShortPathName(Application.ExecutablePath) + " \"%1\" %*");

                    key.CreateSubKey(@"Shell\editNotepad").SetValue("", "Edit");
                    key.CreateSubKey(@"Shell\editNotepad").SetValue("Icon", "");
                    key.CreateSubKey(@"Shell\editNotepad\Command").SetValue("", "notepad.exe" + " \"%1\"");
                    
                }
            }
#endif
        }

        public static bool IsAssociated
        {
#if IsCore
            get { return false; }
#else
            get { return (Registry.ClassesRoot.OpenSubKey(FILE_EXTENSION, false) != null); }
#endif
        }

        public static void Remove()
        {
#if !IsCore
            Registry.ClassesRoot.DeleteSubKeyTree(FILE_EXTENSION);
            Registry.ClassesRoot.DeleteSubKeyTree(ProductName);
#endif
        }
#if !IsCore
        [DllImport("shell32.dll", SetLastError = true)]
        public static extern void SHChangeNotify(long wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath, [Out]StringBuilder lpszShortPath, uint cchBuffer);

        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            uint iRet = GetShortPathName(longName, s, iSize);
            return s.ToString();
        }
#endif
    }
}
