using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class StudentValues  // Κλάση στην οποία εμπεριέχονται μέθοδοι για να πάρουμε τιμές στα στοιχεία των μαθητών
    {



        public static string GetFirstName()
        {
            ;
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
            return  firstname;
        }




        public static string GetLastName()
        {
            string lastname;

            Console.Write("\tType the LastName    : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            lastname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(lastname) || string.IsNullOrWhiteSpace(lastname) || lastname.Length < 2)
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



        public static DateTime GetBirthDate()
        {
            DateTime birth = new DateTime();
            DateTime from = new DateTime(1940, 01, 01);
            DateTime until = new DateTime(2010, 01, 01);

            Console.Write("\tGive the BirthDate   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out birth) || !(birth > from && birth < until))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input!Give a valid BirthDate! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the BirthDate   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return birth;
        }

        public static string AskforTuitionFees() 
        {
            Console.Write("\tGive positive(!) TuitionFees (Not necessary) : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string input = Console.ReadLine();
            return input;
        }

        public static object GetTuitionFees()
        {
            string input = AskforTuitionFees();
            decimal? fees = string.IsNullOrWhiteSpace(input) ? (decimal?)null : Convert.ToDecimal(input);
            if (fees < 0) return AskforTuitionFees();
            else if (fees is null) return (object)DBNull.Value;
            else return Convert.ToDecimal(input);
        }

    }
}
