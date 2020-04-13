using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rizos_PrivateSchool_PartB
{
    public class Menu
    {
        // Αρχικό Μενού. Επιλογή ανάμεσα σε Συνθετικές πληροφορίες ή Εισαγωγή.

        public static void IntroInitialOrSynthetic()
        {
            string choice = string.Empty;
            Console.WriteLine("\t1.You can Insert Data.\n");
            Console.WriteLine("\t2.You can use Synthetic Data.\n");
            Console.Write("\t0. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LogOut\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\tChoose ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1,2 or 0 : ");
            choice =Interaction.StringAnswer();
            while (!(choice == "1" || choice == "2" || choice == "0"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!Choose Between (1,2,0)");
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\tChoose ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("1,2 or 0 : ");
                choice = Interaction.StringAnswer();
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (choice == "1")    // Περίπτωση εισαγωγής
            {
                Console.Clear();
                Standard_Messages.Welcome(); 
                InsertMenu();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                SyntheticMenu();  // Μπορούμε να δούμε όλα τα δεδομένα της βάσης
            }
            else if (choice == "0")
            {
                MoveTools.LogOut(); // Αποσύνδεση χρήστη , απο το σύστημα
            }
        }

        // Μενού με 7 επιλογές εισαγωγής και δύο επιλογές για την μεταφορά μας μέσα στο σύστημα 
        public static void InsertMenu()
        {
            string answer = string.Empty;
            Standard_Messages.ShowInsertOptions();
            answer = Interaction.StringAnswer();
            while (!(answer == "1" || answer == "2" || answer == "3" || answer == "4" 
                || answer == "5" || answer == "6" || answer == "7" || answer == "8" || answer == "0"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tChoose Between (1,2,3,4,5,0)");
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tChoice : ");
                answer = Interaction.StringAnswer();
            }
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    Insert.InsertCourse();
                    break;
                case "2":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    Insert.InsertTrainer();
                    break;
                case "3":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    Insert.InsertAssignment();
                    break;
                case "4":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    Insert.InsertStudent();
                    break;
                case "5":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    Insert.InsertStudentsPerCourse();
                    break;
                case "6":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    Insert.InsertTrainerPerCourse();
                    break;
                case "7":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    Insert.InsertStudentPerCoursePerAss();
                    break;
                case "8":
                    MoveTools.GobackStartmenu();
                    break;
                case "0":
                    MoveTools.LogOut();
                    break;
            }
        }

        // Συνθετικό Μενού
        public static void SyntheticMenu()
        {
            string answer = string.Empty;
            Standard_Messages.ShowSyntheticOption();
            answer = Interaction.StringAnswer();
            while (!(answer == "1" || answer == "2" || answer == "0"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tChoose Between (1,2,0)");
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tChoice : ");
                answer = Interaction.StringAnswer();

            }
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    TablePrinting.PrintAllTables();  // Εκτύπωση όλων των στοιχείων
                    MoveTools.GoBack();
                    break;
                case "2":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    MoveTools.GobackStartmenu();  // Μεταφορά πίσω στο αρχικό μενου
                    break;
                case "0":
                    Console.Clear();
                    Standard_Messages.Welcome();
                    MoveTools.LogOut(); // Αποσύνδεση
                    break;
            }
        }
    }
}
