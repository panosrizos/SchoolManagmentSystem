using System;


namespace Rizos_PrivateSchool_PartB
{
    class Standard_Messages   // Συχνα και επαναλαμβανόμενα μυνήματα που υπάρχουν στον κώδικα του προγράμματος
    {
        public static void Error() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tError Generated!Wrong Input.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AlreadyExists()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tThe record already exists. ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SuccessfullInsert()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tRecords Inserted Successfully");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowInsertOptions() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tMENU\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t1. Add new Course\n");
            Console.WriteLine("\t2. Add new Trainer\n");
            Console.WriteLine("\t3. Add new Assignment\n");
            Console.WriteLine("\t4. Add new Student\n");
            Console.WriteLine("\t5. Insert Student into Course\n");
            Console.WriteLine("\t6. Insert Trainer into Course\n");
            Console.WriteLine("\t7. Relate a Student with Course and Assignments\n");
            Console.Write("\t8. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Return to Main Menu\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t0. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LogOut\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tChoice : ");

        }

        public static void ShowSyntheticOption() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tMENU\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t1. Print All Synthetic Data\n");
            Console.WriteLine("\t2. Go Back to Start Menu\n");
            Console.Write("\t0. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LogOut\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tChoice : ");
        }

        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\tRIZOS PRIVATE SCHOOL SYSTEM   ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");

        }

        public static void ShowContinueOrBack() 
        {
            Console.WriteLine("\n\tPress C to Continue Adding : ");
            Console.WriteLine("\tPress B to go Back to Menu : ");
            Console.Write("\t                           : ");
        }
    }
}
