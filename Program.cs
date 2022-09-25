using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_1
{
    internal class Program
    {
        private class description
        {
            private string candDesc;
            public string Desc
            {
                get { return candDesc; }
                set { candDesc = value; }
            }
        }

        interface Menu
        {
            bool MainMenu();
            void ExpMenu();
            void EdcMenu();
        }


        class MyMenu : Menu 
        {
            public void EdcMenu()
            {
                Console.WriteLine("Education/Training");
                Console.WriteLine("1) Software Engineering (Year 1).");
                Console.WriteLine("2) Software Engineering (Year 2).");
                Console.WriteLine("3) Go back");
                Console.WriteLine("\nSelect an option.");
                
                int option = Convert.ToInt32(Console.ReadLine());

            }

            public void ExpMenu()
            {
                char ch;
                Console.WriteLine("Experience/Job History");
                Console.WriteLine("a) Ceridian(2021)");
                Console.WriteLine("b) seaman Diving Center(2019)");
                Console.WriteLine("c) Go back");
                Console.WriteLine("\nSelect an option.");
                ch = Convert.ToChar(Console.ReadLine());

                switch (Char.ToLower(ch))
                {
                    case 'a':
                        Console.WriteLine("Job description at Ceridian: \n--training on oop, web, database and git. \n--working in teams");
                        ExpMenu();
                        break;
                    case 'b':
                        Console.WriteLine("Job description at seaman diving center: \n--answering phone calls. \n--attending to customers.");
                        ExpMenu();
                        break;
                    case 'c':
                        Console.Clear();
                        MainMenu();
                        break;
                    default:
                        ExpMenu();
                        break;
                }
            }

            public bool MainMenu()
            {
                Console.WriteLine("Contents of my CV");
                Console.WriteLine("1) Experience/ Job history");
                Console.WriteLine("2) Education/ Training");
                Console.WriteLine("3) Skills");
                Console.WriteLine("4) Technological Skills");
                Console.WriteLine("5) Contact Details");
                Console.WriteLine("6) Exit application");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ExpMenu();
                        return false;
                    case "2":
                        EdcMenu();
                        return false;
                    case "3":
                        Console.WriteLine("skills description: \n--communication \n--problem solving \n--Team work \n--Time management");
                        return true;
                    case "4":
                        Console.WriteLine("Technological skills:\n--sql \n--Java \n--html \n--Flutter \n--c++");
                        return true;
                    case "5":
                        Console.WriteLine("contact details:\nName:\tNelly Sooben\nEmail:\tabc@gmail.com\nPhone Number:\t12345678\n");
                        return true;
                    case "6":
                        return false;
                    default:
                        return true;
                }
            }
        }

        static void Main(string[] args)
        {
            description obj = new description();

            obj.Desc = "I'm a student of software engineering in my second year of studies at the university of Mauritius\nI'm looking for an opportunity as intern and eager to learn more.\n";

            Console.WriteLine("Introduction:\n" + obj.Desc);

            MyMenu menu = new MyMenu();

            bool showMenu = true;

            while (showMenu)
            {
                showMenu = menu.MainMenu();
            }
        }

    }
}
