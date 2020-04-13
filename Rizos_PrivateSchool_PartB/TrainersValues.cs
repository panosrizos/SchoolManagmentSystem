using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class TrainersValues   // Κλάσση που είναι υπεύθυνη για την απόσπαση στοιχείων για τους Καθηγητές
    {
        public static string GetFirstName()
        {

            string firstname;

            Console.Write("\tType the FirstName   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            firstname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(firstname) || string.IsNullOrWhiteSpace(firstname) || firstname.Length < 2)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(FirstName needs at least two characters without spaces)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tType the firstName   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                firstname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            return firstname;
        }

        public static string GetLastName()
        {
            string lastname;

            Console.Write("\tType the LastName    : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            lastname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(lastname) || string.IsNullOrWhiteSpace(lastname) || lastname.Length <= 2)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Lastname needs at least two characters without spaces)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tType the LastName    : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                lastname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            return lastname;
        }

        public static string GetTrainersSubject()
        {
            string subject = "";

            Console.Write("\tGive the Subject : 1. OOP  2. FrontEnd  3.SQL  4.Python_advance  5.Consulting  6.Algorithms: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string choice = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6")
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input!Select between the choices : 1. OOP  2. FrontEnd  3.SQL  4.Python_advance  5.Consulting  6.Algorithms");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Subject : 1. OOP  2. FrontEnd  3.SQL 4.Python_advance  5.Consulting  6.Algorithms : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.White;
            switch (choice)
            {
                case "1":
                    subject = "OOP";
                    break;
                case "2":
                    subject = "Front_End";
                    break;
                case "3":
                    subject = "SQL";
                    break;
                case "4":
                    subject = "Python_advance";
                    break;
                case "5":
                    subject = "Consulting";
                    break;
                case "6":
                    subject = "Algorithms";
                    break;
            }

            return subject;
        }

    }
}
