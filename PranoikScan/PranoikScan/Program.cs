using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PranoikScan
{
    class Program
    {
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [STAThread]
        static void Main(string[] args)
        {
            while (true)
            {
                IntPtr calcWindow = FindWindow(null, "EVE - Varl0n");

                if (SetForegroundWindow(calcWindow))
                    SendKeys.SendWait("v");

                Thread.Sleep(2000);
            }

        }
    }
}
