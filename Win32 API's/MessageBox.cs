using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Security.Principal;

class Program
{

    [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]

    static extern int MessageBox(IntPtr hWnd, String lpMessage, String caption, int type);
   static void Main()
    {
        MessageBox(IntPtr.Zero, "Hello world", "My Message Box", 0 );
    }
    
}
