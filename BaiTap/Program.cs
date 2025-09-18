using System.Runtime.InteropServices;

namespace BaiTap
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [STAThread]
        static void Main()
        {
            AllocConsole();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}