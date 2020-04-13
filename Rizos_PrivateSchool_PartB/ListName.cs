using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class ListName
    {
        // Λεζάντες για όλες τις Λίστες
        public static void Course() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE COURSES OF THE SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Student()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE STUDENTS OF SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Trainers() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE TRAINERS OF SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Assignment() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE ASSAIGNMENTS OF SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AssignmentsPerCourse() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE ASSAIGNMENTS OF SCHOOL PER COURSE : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TrainerPerCourse() 
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE TRAINERS OF SCHOOL PER COURSE : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void StudentsPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE STUDENTS OF SCHOOL PER COURSE : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public static void StudentsCourseAssignment()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tALL THE ASSIGNMENTS OF STUDENTS PER COURSE : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public static void PrintStudentWithMoreCourses()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tSTUDENTS WITH TWO OR MORE COURSES : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
