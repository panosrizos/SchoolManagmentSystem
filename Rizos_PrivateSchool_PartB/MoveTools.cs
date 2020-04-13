using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rizos_PrivateSchool_PartB
{
    class MoveTools  // Μέθοδοι για την υλοποίηση των εντολών του χρήστη για πλοήγηση μέσα στο σύστημα.
    {      
        public static void GoBack()
        {
            string answer = string.Empty;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\n\tPress B to Main Menu : ");
                answer = Interaction.StringAnswer();

            } while (!(answer.ToUpper() == "B"));

            GobackStartmenu();
        }


        public static void GobackStartmenu()
        {
            Console.Clear();
            Standard_Messages.Welcome();
            Menu.IntroInitialOrSynthetic();
        }

        public static void LogOut()
        {
            Console.Clear();
            Standard_Messages.Welcome();
            Console.WriteLine("\tYou selected LogOut");
            Thread.Sleep(2000);
            Console.Clear();
        }


        public static void BackOptionToInsertMenu()
        {
            Console.Clear();
            Standard_Messages.Welcome();
            Menu.InsertMenu();
        }


    }
}
