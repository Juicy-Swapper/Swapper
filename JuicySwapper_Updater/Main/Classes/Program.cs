using JuicySwapper_Updater.Main.GUI;
using System;
using System.Windows.Forms;

namespace JuicySwapper_Updater.Main.Classes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Updater());
        }
    }
}
