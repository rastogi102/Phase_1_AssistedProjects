using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_10_1._9_Inheritance
{
    public class CClass
    {
        public string ClassName { get; set; }
        public List<Teacher> Teachers { get; set; }

        public CClass()
        {
            Teachers = new List<Teacher>();
        }
    }
}
