using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class Insert    // Κλάσση που εμπεριέχει μεθόδους για την μεταφορά ολοκληρομένου μοντέλου στην Βάση δεδομένων.
    {
        public static void InsertCourse()
        {

            string t = CourseValues.GetCourseTitle();
            string s = CourseValues.GetCourseStream();
            string ty = CourseValues.GetCourseType();
            DateTime sd = CourseValues.GetStartDate();
            DateTime ed = CourseValues.GetEndDate(sd);
            Services.CourseTransfer(t, s, ty, sd, ed);
        }


        public static void InsertStudent()
        {
            string f = StudentValues.GetFirstName();
            string l = StudentValues.GetLastName();
            DateTime d = StudentValues.GetBirthDate();
            var fe = StudentValues.GetTuitionFees();
            Services.StudentTransfer(f, l, d, fe);

        }


        public static void InsertAssignment()
        {

            var t = AssignmentValues.GetTitle();
            var d = AssignmentValues.GetDescription();
            var g = AssignmentValues.GetSubDate();
            var x = AssignmentValues.GetOralMark();
            var o = AssignmentValues.GetTotalMark();
            Services.AssignmentTransfer(d, t, g, x, o);
        }


        public static void InsertTrainer()
        {
            var a = TrainersValues.GetFirstName();
            var b = TrainersValues.GetLastName();
            var c = TrainersValues.GetTrainersSubject();
            Services.TrainerTransfer(a, b, c);
        }


        public static void InsertStudentsPerCourse() 
        {   
            TablePrinting.PrintAllStudents();
            int b = IdSelection.GetStudentId();
            TablePrinting.PrintAllCourses();
            int a =IdSelection.GetCourseId();
            Services.StudentPerCourseTransfer(a, b);
        }

        public static void InsertTrainerPerCourse() 
        {
            TablePrinting.PrintAllTrainers();
            int b = IdSelection.GetTrainerId();
            TablePrinting.PrintAllCourses();
            int a = IdSelection.GetCourseId();
            Services.TrainerPerCourseTransfer(a, b);
        }



        public static void InsertStudentPerCoursePerAss() 
        {
            TablePrinting.PrintAllCourses();
            int a = IdSelection.GetCourseId();
            TablePrinting.PrintAllAssignments();
            int b = IdSelection.GetAssignmentId();
            TablePrinting.PrintAllStudents();
            int c = IdSelection.GetStudentId();
            Services.AssignmentPerCoursePerStudentTransfer(a,b,c);
            
        }

    }
}
