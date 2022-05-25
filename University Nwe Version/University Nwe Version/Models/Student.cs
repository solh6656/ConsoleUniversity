using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Nwe_Version.Models
{
    internal class Student : User
    {
        public string Course { get; set; }
        public string[] Class_time { get; set; }
    }
}
