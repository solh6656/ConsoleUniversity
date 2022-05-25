using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Nwe_Version.Models
{
    internal class Teacher : User
    {
        public string Subjekt { get; set; }
        public string[] Class_Schedule { get; set; }
        private int selary { get; set; }

        public int Selary
        {
            get { return selary; }
            set { selary = value; }
        }


    }
}
