using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class CourseValues      // Κλάσση που είναι υπεύθυνη για την απόσπαση στοιχείων για τα Μαθήματα
    {
        
        public static string GetCourseTitle()
        {
            Console.Write("\tGive the Title       : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string title = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title) || title.Length <= 2)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(title needs at least two characters)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Title       : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                title = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return title;
        }
        public static string GetCourseStream()
        {
            string stream;

            Console.Write("\tGive the Stream      : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            stream = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(stream) || string.IsNullOrWhiteSpace(stream))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Wrong-empty Input.)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Stream      : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                stream = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return stream;

        }

        public static string GetCourseType()
        {
            string type;

            Console.Write("\tGive the Type        : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            type = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(type) || string.IsNullOrWhiteSpace(type))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Wrong-empty Input.)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Type        : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                type = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return type;

        }

        public static DateTime GetStartDate()
        {
            DateTime date = new DateTime();

            Console.Write("\tGive the StartDate   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out date) || date <= DateTime.UtcNow)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input or Passed Date! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the StartDate   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return date;
        }

        public static DateTime GetEndDate(DateTime dt)
        {
            DateTime date = new DateTime();

            Console.Write("\tGive the EndDate     : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out date) || (date < dt))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input or earlier than StartDate ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the EndDate     : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return date;

        }

    }
}
