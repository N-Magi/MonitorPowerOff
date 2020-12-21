using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace MonitorPowerOff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MonitorOFF");
            win32.PostMessage((IntPtr)0xFFFF, 0x0112, 0xF170, 2);
        }
    }

    class win32
    {
        [DllImport("User32.dll")]
        public static extern void PostMessage(IntPtr hwind, ushort wMsg, ushort wParam, short lParam);
    }
}
