using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memcall
{
    [Serializable]
    public class ProjectClass
    {
        public string Name = "Memcall Project";
        public string Edited = DateTime.Now.ToString();
        public string ProcessName = "";
        public List<string> Addresses = new List<string>();
        public List<dynamic> Arguments = new List<dynamic>();

        public ProjectClass() { }
    }
}
