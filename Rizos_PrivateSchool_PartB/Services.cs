using System;
using System.Configuration;
using System.Data.SqlClient;


namespace Rizos_PrivateSchool_PartB
{
    class Services  // Κλάσση που εμπεριέχει μεθόδους χρήσιμες για την εισαγωγή δεδομένων 
    {

        public static string ConString = ConfigurationManager.ConnectionStrings["Sindesi_School"].ConnectionString;

        // Μεταφορά Μαθήματος στην Βάση
        public static void CourseTransfer(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            SqlConnection con = new SqlConnection(ConString);
            string qr = "Insert into Course (Title, Stream , Type , StartDate , EndDate) VALUES (@Title, @Stream , @Type ,@StartDate , @EndDate)";

            SqlCommand cmd = new SqlCommand(qr, con);

            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Stream", stream);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Standard_Messages.SuccessfullInsert();
                Interaction.ContinueAddingCourseOrNot();
            }
            catch (SqlException e)
            {
                Standard_Messages.Error();
                e.ToString();
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }


        // Μεταφορά Μαθητή στην Βάση δεδομένων
        public static void StudentTransfer(string firstName, string lastName, DateTime dateOfBirth, object tuitionFees)
        {
            SqlConnection con = new SqlConnection(ConString);
            string qr = "Insert into Student (FirstName, LastName , DateOfBirth , TuitionFees) VALUES (@FirstName, @LastName , @DateOfBirth , @TuitionFees)";

            SqlCommand cmd = new SqlCommand(qr, con);

            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@TuitionFees", tuitionFees ?? (object)DBNull.Value);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Standard_Messages.SuccessfullInsert();
                Interaction.ContinueAddingStudOrNot();
            }
            catch (SqlException e)
            {
                Standard_Messages.Error();
                Console.WriteLine(e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }


        // Μεταφορά Assignment στην Βάση δεδομένων
        public static void AssignmentTransfer(string description, string title, object subDate, object oral, object total)
        {
            SqlConnection con = new SqlConnection(ConString);
            string qr = "Insert into Assignment ( Title ,Description, SubDateTime , Oralmark, TotalMark) VALUES (@Title, @Description , @SubDateTime , @Oralmark, @TotalMark)";

            SqlCommand cmd = new SqlCommand(qr, con);


            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@SubDateTime", subDate);
            cmd.Parameters.AddWithValue("@Oralmark", oral ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@TotalMark", total ?? (object)DBNull.Value);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Standard_Messages.SuccessfullInsert();
                Interaction.ContinueAddingAsOrNot();
            }
            catch (SqlException e)
            {
                Standard_Messages.Error();
                Console.WriteLine(e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }


        // Μεταφορά Καθηγητή στην Βάση δεδομένων
        public static void TrainerTransfer(string firstname, string lastname, string subject)
        {
            SqlConnection con = new SqlConnection(ConString);
            string qr = "Insert into Trainer (FirstName , LastName , Subject) VALUES (@FirstName , @LastName , @Subject)";

            SqlCommand cmd = new SqlCommand(qr, con);

            cmd.Parameters.AddWithValue("@FirstName", firstname);
            cmd.Parameters.AddWithValue("@LastName", lastname);
            cmd.Parameters.AddWithValue("@Subject", subject);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Standard_Messages.SuccessfullInsert();
                Interaction.ContinueAddingTrainerOrNot();
            }
            catch (SqlException e)
            {
                Standard_Messages.Error();
                Console.WriteLine(e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }

        }
      

        // Δημιουργία μιας νέας σχέσης Καθηγητή και Μαθήματος .Μεταφορά σχέσης στην Βάση δεδομένων
        public static void TrainerPerCourseTransfer(int course_id, int trainer_id)
        {
            SqlConnection con = new SqlConnection(ConString);
            string qr = "Insert into TrainerPerCourse (Course_ID , Trainer_ID) VALUES (@Course_ID , @Trainer_ID)";

            SqlCommand cmd = new SqlCommand(qr, con);

            cmd.Parameters.AddWithValue("@Course_ID", course_id);
            cmd.Parameters.AddWithValue("@Trainer_ID", trainer_id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Standard_Messages.SuccessfullInsert();
                Interaction.ContinueAddingTrainerPerCourseOrNot();
            }
            catch (SqlException e) when (e.Number == 2627 || e.Number==547)
            {
                Standard_Messages.Error();
                Standard_Messages.AlreadyExists();
                Interaction.ContinueAddingTrainerPerCourseOrNot();
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
        // Δημιουργία μιας νέας σχέσης μεταξύ Μαθητή και Μαθήματος .Μεταφορά σχέσης στην Βάση δεδομένων
        public static void StudentPerCourseTransfer(int course_id, int student_id)
        {
            SqlConnection con = new SqlConnection(ConString);
            string qr = "Insert into StudentPerCourse (Course_ID , Student_ID) VALUES (@Course_ID , @Student_ID)";

            SqlCommand cmd = new SqlCommand(qr, con);

            cmd.Parameters.AddWithValue("@Course_ID", course_id);
            cmd.Parameters.AddWithValue("@Student_ID", student_id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Standard_Messages.SuccessfullInsert();
                Interaction.ContinueAddingStudPerCourseOrNot();
            }
            catch (SqlException e) when (e.Number == 2627 || e.Number == 547)
            {
                Standard_Messages.Error();
                Standard_Messages.AlreadyExists();
                Interaction.ContinueAddingStudPerCourseOrNot();
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

        // Δημιουργία μιας νέας τριπλής σχέσης μεταξύ Μαθητή , Μαθήματος και Assignment  .Μεταφορά σχέσης στην Βάση δεδομένων
        public static void AssignmentPerCoursePerStudentTransfer(int course_id, int assignment_id, int studentId)
        {
            SqlConnection con = new SqlConnection(ConString);
            string qr = @"Insert into AssignmentPerCourse (Course_ID , Assignment_ID ) VALUES (@Course_ID , @Assignment_ID) 
                         Insert into StudentPerCourse (Course_ID , Student_ID) VALUES (@Course_ID , @Student_ID)";

            SqlCommand cmd = new SqlCommand(qr, con);

            cmd.Parameters.AddWithValue("@Course_ID", course_id);
            cmd.Parameters.AddWithValue("@Assignment_ID", assignment_id);
            cmd.Parameters.AddWithValue("@Student_ID", studentId);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Standard_Messages.SuccessfullInsert();
                Interaction.ContinueAddingAssignmentPerCourseOrNot();
            }
            catch (SqlException e) when (e.Number == 2627 || e.Number == 547)
            {
                Standard_Messages.Error();
                Standard_Messages.AlreadyExists();
                Interaction.ContinueAddingAssignmentPerCourseOrNot();
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

    }
}
