using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class Interaction  // Κλάσση που εμπεριέχει μεθόδους χρήσιμες για απόσπαση πληροφοριών απο τον χρήστη 
                      //  κυρίως για την πλοήγηση στο σύστημα
    {
        public static string StringAnswer()
        {                                             // Μέθοδος που δέχεται String. Χρησιμοποιείται συχνά!
            string choice = string.Empty;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            choice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return choice;
        }


        // Ακολουθούν μέθοδοι που ζητούν απο τον χρήστη να αποφασίσει αν θα συνεχίσει να δημιουργεί νέες προσθήκες
        // ή αν θέλει να επιστρεψει στο αρχικο κατα κύριο λόγο μενου
    
        public static string CheckContinueOrNot()  
        {
            string answer = string.Empty;

            Standard_Messages.ShowContinueOrBack();
            answer = StringAnswer();
            while (!(answer.ToUpper() == "B" || answer.ToUpper() == "C"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tChoose Between C Or B");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t                           : ");
                answer = StringAnswer();

            }
            return answer;
        }

        public static void ContinueAddingCourseOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Insert.InsertCourse();
                Standard_Messages.ShowContinueOrBack();
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Menu.InsertMenu();
            }
        }


        public static void ContinueAddingTrainerOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Insert.InsertTrainer();
                Standard_Messages.ShowContinueOrBack();
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B") MoveTools.BackOptionToInsertMenu();

        }


        public static void ContinueAddingAsOrNot()
        {
            string answer = CheckContinueOrNot();
            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Insert.InsertAssignment();
                Standard_Messages.ShowContinueOrBack();
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B") MoveTools.BackOptionToInsertMenu();
        }


        public static void ContinueAddingStudOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Insert.InsertStudent();
                Standard_Messages.ShowContinueOrBack();
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B")  MoveTools.BackOptionToInsertMenu();
            
        }

        public static void ContinueAddingStudPerCourseOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Insert.InsertStudentsPerCourse();
                Standard_Messages.ShowContinueOrBack();
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B") MoveTools.BackOptionToInsertMenu();
        }


        public static void ContinueAddingTrainerPerCourseOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Insert.InsertTrainerPerCourse();
                Standard_Messages.ShowContinueOrBack();
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B") MoveTools.BackOptionToInsertMenu();
        }


        public static void ContinueAddingAssignmentPerCourseOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Standard_Messages.Welcome();
                Insert.InsertStudentPerCoursePerAss();
                Standard_Messages.ShowContinueOrBack();
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B") MoveTools.BackOptionToInsertMenu();
        }

    }
}
