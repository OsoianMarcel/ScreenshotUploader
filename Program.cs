using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace App
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{4c7f9d08de74a476a7aa24b68a26f1bf}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                mutex.ReleaseMutex();
            }
            else
            {
                Helpers.SingleInstance.PostMessage(
                    (IntPtr)Helpers.SingleInstance.HWND_BROADCAST,
                    Helpers.SingleInstance.WM_ACTIVATE_ME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
        }
    }
}