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

            bool Debug = true; //true bypass //false release

            if (Debug)
            {
                //owners bypass
                args = "BYPASS ADMIN ADMIN".Split(' ');

                Settings.Default.LauncherArgs = String.Join(" ", args);
                Settings.Default.Save();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                JuicyUtilities.GetStatus();
                Application.Run(new Loader());

            }
            else
            {
                try
                {
                    if (!args[0].Contains("OppyxPn89INV4HVH5z1x"))
                    {
                        MessageBox.Show("Wrong Args Please launch from the juicy launcher");
                        return;
                    }

                    Settings.Default.LauncherArgs = String.Join(" ", args);
                    Settings.Default.Save();

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //JuicyUtilities.GetStatus();
                    Application.Run(new Loader());
                }
                catch
                {
                    MessageBox.Show("No args Found");
                    return;
                }
            } 
        }

        static void GUID()
        {
            Guid g = Guid.NewGuid();
            MessageBox.Show(g.ToString());
            Clipboard.SetText(g.ToString());
        }
    }
}
