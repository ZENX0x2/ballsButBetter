using System;
using System.IO;
using System.Net;
using ballsBetter.Functions;

namespace ballsBetter
{
    class Program
    {

        static int areYouSure()
        {
            Console.WriteLine("Are you sure you want to run balls? It might harm your PC. | Y/N");

            string wtr = Console.ReadLine();

            wtr.ToLower();

            Console.WriteLine(wtr);

            if (wtr == "y")
            {
                Console.WriteLine("balls");

                runBalls();

                Console.ReadKey();

            }

            else if (wtr == "n")
            {
                Console.WriteLine("Not balls");

                Console.ReadKey();

                return 0;
            }

            else
            {
                Console.WriteLine("Invalid Answer");

                Console.ReadKey();
            }

            return 0;
        }

        static void runBalls()
        {
            string desktop = @"C:\Users\" + Environment.UserName + @"\Desktop\";
            string localFilename = @"C:\Users\" + Environment.UserName + @"\Desktop\balls.jpg";
            string logPath = @"C:\Users\" + Environment.UserName + @"\Documents\Balls\ballsLog.txt";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://i.redd.it/41ps5f0pnt771.png", localFilename);
                }
                for (int i = 0; i < 10000000; i++)
                {
                    string num = desktop + i.ToString() + ".jpg";
                    File.Copy(localFilename, num);

                    Console.WriteLine("Ball " + num);
                }



            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Wallpaper.changeWallpaper();
        }

        public static void Main(string[] args)
        {
            areYouSure();
        }
    }

}