using JuicySwapper.Api;
using JuicySwapper.Main.GUI;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading;
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

            if (!File.Exists("JuicySwapper_Encryption.dll"))
                Encryption();

            Application.Run(new Loader());
        }

        static void Encryption()
        {
            var StatusAPI = new WebClient().DownloadString($"{API.HOST}/{API.Status}");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

            WebClient ProgramClient = new WebClient();

            ProgramClient.Proxy = null;
            ProgramClient.DownloadFileAsync(new Uri(StatusResponse.Encryption), "JuicySwapper_Encryption.dll");

            while (ProgramClient.IsBusy)
                Thread.Sleep(1000);

            if (!File.Exists("JuicySwapper_Encryption.dll"))
                MessageBox.Show("Encryption did not downloaded!");
        }
    }
}
