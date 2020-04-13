using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class AssignmentValues   // Κλάσση που είναι υπεύθυνη για την απόσπαση στοιχείων για τα Assignment
    {
        public static string GetDescription()
        {
            Console.Write("\tGive the Description : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string description = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(description) || string.IsNullOrWhiteSpace(description) || description.Length < 5)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Description needs at least five characters )");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Description : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                description = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return description;
        }

        public static string GetTitle()
        {
            Console.Write("\tGive the Title       : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string title = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title) || title.Length < 5)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(title needs at least five characters )");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tType the Title    : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                title = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return title;
        }
        public static DateTime GetSubDate()
        {
            DateTime paradosh = new DateTime();

            Console.Write("\tGive the SubDate e.g (13/2/2020)    : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out paradosh) || !(paradosh > DateTime.UtcNow))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input Or Passed Date! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the SubDate   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return paradosh;
        }

        public static object GetOralMark()
        {
            string input;
            Console.Write("\tGive the OralMark (Not necessary)   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            input = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            double? oral = string.IsNullOrWhiteSpace(input) ? (double?)null : Convert.ToDouble(input);
            if (oral is null) return (object)DBNull.Value;
            else return Convert.ToDecimal(input);

        }


        public static object GetTotalMark()
        {
            string input;
            Console.Write("\tGive the TotalMark (Not necessary)  : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            input = Console.ReadLine();
            double? total = string.IsNullOrWhiteSpace(input) ? (double?)null : Convert.ToDouble(input);
            if (total is null) return (object)DBNull.Value;
            else return Convert.ToDecimal(input);
        }





    }
}
