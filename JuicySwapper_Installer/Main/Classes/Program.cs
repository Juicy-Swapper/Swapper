using JuicySwapper_Installer.Main.GUI;
using System;
using System.Windows.Forms;

namespace JuicySwapper_Installer.Main.Classes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Installer());
        }
    }
}
