using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizos_PrivateSchool_PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        // Η Κύρια μέθοδος του προγράμματος.
        public static void Run()
        {
            Standard_Messages.Welcome();
            Menu.IntroInitialOrSynthetic();
        }
    }
}

