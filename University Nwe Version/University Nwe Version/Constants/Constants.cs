using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Nwe_Version.Constants
{
    internal class Constants
    {
        static readonly string TDbPath = @"..\..\..\Database\Teachers.json";
        static readonly string SDbPath = @"..\..\..\Database\Students.json";
        static readonly string AdminPassword = "IamAdmin";
        static readonly string[] Courses = { "Bac-end", "Front-End", "Database" };
        static readonly string[] Couple_Of_Days_Morning = { "Tuesday | 9:00", "Thursday | 9:00", "Saturday | 9:00" };
        static readonly string[] Couple_Of_Days_Evening = { "Tuesday | 14:00", "Thursday | 14:00", "Saturday | 14:00" };
    
        static readonly string[] Odd_Days_Morning = { "Monday | 9:00", "Wednesday | 9:00", "Friday | 9:00" };
        static readonly string[] Odd_Days_Evening = { "Monday | 14:00", "Wednesday | 14:00", "Friday | 14:00" };
    }
}