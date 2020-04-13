using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Rizos_PrivateSchool_PartB
{
    class TablePrinting // Κλασση για εκτύπωση των ζητουμένων απο την Βάση μας.
    {
        public static string ConString = ConfigurationManager.ConnectionStrings["Sindesi_School"].ConnectionString;

        public static void PrintAllTables() // Μέθοδος που περιέχει όλα τα tables
        {
            PrintAllStudents();
            PrintAllTrainers();
            PrintAllAssignments();
            PrintAllCourses();
            PrintAllStudentsPerCourse();
            PrintAllTrainersPerCourse();
            PrintAllAssignmentsPerCourse();
            PrintAllAssignmentsStudentPerCourse();
            PrintAllStudents_WithMoreThanOne_Courses();
        }

        public static void PrintAllStudents()          // Εκτύπωση όλων των Μαθητών
        {
            string qr = "Select * from Student";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.Student();
                while (reader.Read())
                {

                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-15} " +
                        $"{reader[2].ToString(),-15} {Convert.ToDateTime(reader[3]).ToString("dd/MM/yyyy"),-14} " +
                        $"{reader[4].ToString()}");
                }
            }
        }

        public static void PrintAllCourses()      // Εκτύπωση όλων των Μαθημάτων
        {
            string qr = "Select * from Course";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.Course();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-8}  {reader[2].ToString(),-10} " +
                        $" {Convert.ToDateTime(reader[4]).ToString("dd/MM/yyyy"),-10} " +
                        $" {Convert.ToDateTime(reader[5]).ToString("dd/MM/yyyy")}");
                }
            }
        }

        public static void PrintAllTrainers()    // Εκτύπωση όλων των Καθηγητών
        {
            string qr = "Select * from Trainer";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.Trainers();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-12}  {reader[2].ToString(),-15}");
                }
            }
        }

        public static void PrintAllAssignments()      // Εκτύπωση όλων των Assignment
        {
            string qr = "Select * from Assignment";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.Assignment();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-12}  {reader[2].ToString(),-10} " +
                        $" {Convert.ToDateTime(reader[3]).ToString("dd/MM/yyyy"),-15} {reader[4].ToString()}  {reader[5].ToString()}");
                }
            }
        }  

        public static void PrintAllStudentsPerCourse()     // Εκτύπωση όλων των Μαθητών ανα μάθημα
        {
            string qr = @"SELECT C.Title,C.[Type],C.Stream,A.Title as [Assignment Title],A.[Description]
                        from Assignment A  
                        INNER JOIN AssignmentPerCourse APC ON APC.Course_ID= A.Assignment_ID
                        INNER JOIN Course C ON APC.Course_ID = C.Course_ID";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.StudentsPerCourse();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-18}  {reader[2].ToString(),-10} " +
                        $" {reader[3].ToString(),-12} {reader[4].ToString()}");
                }
            }
        }
        public static void PrintAllTrainersPerCourse()  // Εκτύπωση όλων των Καθηγητών ανα Μάθημα
        {
            string qr = @"SELECT C.Title as [Course Title],C.[Type],C.Stream,T.FirstName as [Trainer FirstName],T.LastName 
            FROM Trainer T
            INNER JOIN TrainerPerCourse TPC ON TPC.Trainer_ID = T.Trainer_ID
            INNER JOIN Course C ON TPC.Course_ID = C.Course_ID
            ORDER BY C.Title,C.[Type], C.Stream; ";

            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.TrainerPerCourse();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-18} {reader[2].ToString(),-10} " +
                        $" {reader[3].ToString(),-10} {reader[4].ToString()}");
                }
            }
        }


        public static void PrintAllAssignmentsPerCourse()       // Εκτύπωση όλων των Assignment ανα μάθημα
        {
            string qr = @"SELECT C.Title as [Course Title],C.[Type],C.Stream,S.FirstName as [Student FirstName],S.LastName  
                          FROM Student S
                          INNER JOIN StudentPerCourse SPC ON SPC.Student_ID= S.Student_ID
                          INNER JOIN Course C ON SPC.Course_ID = C.Course_ID";


            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.AssignmentsPerCourse();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-18} {reader[2].ToString(),-10} " +
                        $" {reader[3].ToString(),-10} {reader[4].ToString()}");
                }
            }
        }
        
        public static void PrintAllAssignmentsStudentPerCourse()      // Εκτύπωση όλων των assignment  ανα Μαθητή και μάθημα 
        {
            string qr = @"SELECT S.Student_ID, S.FirstName,S.LastName,C.Title AS [Course Title],
            A.Title AS [Assignment Title],A.[Description] 
            FROM Student S
            INNER JOIN StudentPerCourse SPC ON SPC.Student_ID = S.Student_ID
            INNER JOIN Course C ON C.Course_ID = SPC.Course_ID
            INNER JOIN AssignmentPerCourse APC ON C.Course_ID = APC.Course_ID
            INNER JOIN Assignment A ON APC.Assignment_ID = A.Assignment_ID
            ORDER BY S.Student_ID,C.Title";


            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.StudentsCourseAssignment();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-5} {reader[1].ToString(),-15}  {reader[2].ToString(),-18} " +
                         $" {reader[3].ToString(),-6} {reader[4].ToString(),15}  {reader[5].ToString()}");
                }
            }
        } 
        
        public static void PrintAllStudents_WithMoreThanOne_Courses()  // Εκτύπωση όλων των μαθητων που έχουν πάνω απο ένα μάθημα
        {
            string qr = @"SELECT S.FirstName,S.LastName, COUNT(C.Course_ID ) AS [Courses]
            FROM STUDENT S,StudentPerCourse SPC, Course C
            WHERE (S.Student_ID= SPC.Student_ID AND C.Course_ID= SPC.Course_ID)
            GROUP BY S.FirstName,S.LastName
            HAVING COUNT(C.Course_ID)>1
            ORDER BY  COUNT(C.Course_ID ) DESC";


            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ListName.PrintStudentWithMoreCourses();
                while (reader.Read())
                {
                    Console.WriteLine($"\t{ reader[0].ToString(),-12} {reader[1].ToString(),-12}  {reader[2].ToString()}");
                }
            }
        }
    }
}
