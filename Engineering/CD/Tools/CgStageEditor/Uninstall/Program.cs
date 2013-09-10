using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uninstall
{
    class Program
    {
        static void Main(string[] args)
        {
            string sysroot = System.Environment.SystemDirectory;
            System.Diagnostics.Process.Start(sysroot + "\\msiexec.exe", "/x {194D9AE7-0B11-411C-82FA-0278B121B9C4} /qr");
        }
    }
}
