using JuicySwapper.Api;
using JuicySwapper.Main.GUI;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JuicySwapper.Api.SatusAPI;

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            JuicyUtilities.GetStatus();
            Application.Run(new Loader());
        }

        static void GUID()
        {
            Guid g = Guid.NewGuid();
            MessageBox.Show(g.ToString());
            Clipboard.SetText(g.ToString());
        }
    }
}
