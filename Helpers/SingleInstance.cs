using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace App.Helpers
{
    class SingleInstance
    {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_ACTIVATE_ME = RegisterWindowMessage("WM_ACTIVATE_ME");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}
