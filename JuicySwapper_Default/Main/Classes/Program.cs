using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Default
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Path.GetFileName(Path.GetDirectoryName(Environment.CurrentDirectory)) == "Temp")
            {
                MessageBox.Show("Juicy Swapper cannot be run from WinRAR! Please extract to a folder and try again.", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            try
            {
                if (!args[0].Contains("OppyxPn89INV4HVH5z1x"))
                {
                    MessageBox.Show("Wrong Args Please launch from the juicy launcher");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("No args Found");
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
