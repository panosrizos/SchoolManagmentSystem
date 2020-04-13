using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class IdSelection   // Κλάσση που είναι υπεύθυνη για να  δεχεται τα ID των αντικειμένων
    {
        public static int GetCourseId() 
        {

            Console.Write("\n\tChoose ID of the course you want : ");
            int idnum = Convert.ToInt32(Console.ReadLine());
            return idnum;
        }

        public static int GetStudentId()
        {

            Console.Write("\n\tChoose ID of the student you want : ");
            int idnum = Convert.ToInt32(Console.ReadLine());
            return idnum;
        }

        public static int GetAssignmentId()
        {

            Console.Write("\n\tChoose ID of the Assignment you want : ");
            int idnum = Convert.ToInt32(Console.ReadLine());
            return idnum;
        }

        public static int GetTrainerId()
        {

            Console.Write("\n\tChoose ID of the Trainer you want : ");
            int idnum = Convert.ToInt32(Console.ReadLine());
            return idnum;
        }

    }
}
