using JuicySwapper.Main.GUI;
using System;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// Ui idea from onizuka swapper
/// </summary>

namespace JuicySwapper
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Path.GetFileName(Path.GetDirectoryName(Environment.CurrentDirectory)) == "Temp")
            {
                MessageBox.Show("Juicy Swapper cannot be run from WinRAR! Please extract to a folder and try again.", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                JuicyUtilities.GetStatus();
                Application.Run(new Loader());
            }
        }
    }
}
