using System;
using System.IO;
using System.Net;
using ballsBetter.Functions;

namespace ballsBetter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Functions.balls.runBalls();
            Functions.Wallpaper.changeWallpaper();
        }
    }

}