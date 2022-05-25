using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace University_Nwe_Version.Servise
{
    internal class Manues
    {
        public static void Main_menue()
        {
            Console.Title = "Cambridge";
            Console.WriteLine("\t\tWelcome!");
            Console.WriteLine("   Lorem Ipsum is simply dummy text of the printing  \n" +
                "   and typesetting industry. Lorem Ipsum has been the industry's standard dummy  \n" +
                "   text ever since the 1500s, when an unknown printer took a galley  \n" +
                "   of type and scrambled it to make a type specimen book. It has  \n" +
                "   survived not only five centuries, but also the leap into electronic  \n" +
                "   typesetting, remaining essentially unchanged. It was popularised in  \n" +
                "   the 1960s with the release of Letraset sheets containing Lorem  \n" +
                "   Ipsum passages, and more recently with desktop publishing  \n" +
                "   software like Aldus PageMaker including versions of Lorem Ipsum.  \n");

            Console.WriteLine("\t1)LogIn\t\t2)SingUp\t0)Close");
            Console.Write("--> "); string choose_manues = Console.ReadLine();

            switch (choose_manues)
            {
                case "1": Login_menue(); break;
                case "2": SingUp_menue(); break;
                case "0": Environment.Exit(0); break;
            }

        }
        static void SingUp_menue()
        {
           
        retry:
            Console.WriteLine("\t\tLog in");
            Console.Write("  Status ( 1/Teacher or 2/Student ): ");
            string st = Console.ReadLine();

            if (st == "1" || st == "2")
            {

                Console.Write("  Login : ");
                string log = Console.ReadLine();
                Console.Write("  Password : ");
                string pss = Console.ReadLine();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Commond Error!");
                goto retry;
            }


        }
        static void Login_menue()
        {

        }
        static void Admin_menue()
        {

        }
    }
}
