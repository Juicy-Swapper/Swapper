using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JuicySwapper.Main.Classes;
using System.IO;
using JuicySwapper.Properties;
using System.Net;
using Newtonsoft.Json;
using static JuicySwapper.Api.SatusAPI;
using System.Threading;
using JuicySwapper.Api;
using System.Linq;

namespace JuicySwapper.Main.GUI
{
    public partial class Loader : Form
    {
        public byte holder = 0;
        public static long Num;
        public Loader()
        {

            JuicyUtilities.SetRPCSTAT2($"Loading - 0%");
            Settings.Default.InstallationPath = EpicGames.GetEpicInstallLocations().FirstOrDefault(x => x.AppName == "Fortnite")?.InstallLocation;
            CheckForIllegalCrossThreadCalls = false;
            Settings.Default.pakPath = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";
            Settings.Default.Save();
            InitializeComponent();
            JuicyUtilities.DiscordRPC.Initialize();
            JuicyUtilities.CloseEpicProcesses();
            SwapUtilities.Requestoffsets();
            SwapUtilities.RequestPaks();
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            holder += 4;
            var adv = new List<string> { ".", "..", "..." };
            Random random = new Random();
            int i = random.Next(adv.Count);
            string strg = adv[i];
            label1.Text = "Getting data from Juicy's API" + strg;
            label2.Text = holder + "%";
            JuicyUtilities.SetRPCSTAT2($"Loading - {holder}%");
            if (holder == 100)
            {
                timer1.Enabled = false;
                Hide();

                if (Settings.Default.MusicAct == true)
                {
                    JuicyUtilities MusicController = new JuicyUtilities();
                    MusicController.MusicControl(true);
                }

                string[] args = Settings.Default.LauncherArgs.Split(' ');

                Settings.Default.Name = args[1];
                Settings.Default.Save();

                Hide();
                var Home = new Home();
                Message paidlogin = new Message(Resources.Juicylogin);
                paidlogin.ShowDialog();
                Home.Closed += (s, arg) => Close();
                Home.Show();
            };
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!File.Exists("JuicySwapper_Encryption.dll"))
                Encryption();

            SwapUtilities SwapUtilities = new SwapUtilities();

            foreach (var file in SwapUtilities.GetSwapPath())
            {
                if (!File.Exists(file))
                {
                    var toc = file.Replace(".ucas", ".utoc");
                    var pak = file.Replace(".ucas", ".pak");
                    var sig = file.Replace(".ucas", ".sig");

                    File.Copy(file.Replace("100", "10"), file);
                    File.Copy(toc.Replace("100", "10"), toc);
                    File.Copy(pak.Replace("100", "10"), pak);
                    File.Copy(sig.Replace("100", "10"), sig);
                }
            }



        }

        public static void Encryption()
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

        

        void fortniteversion()
        {
            var stringer = EpicGames.GetEpicInstallLocations().FirstOrDefault(x => x.AppName == "Fortnite")?.AppVersion;
            MessageBox.Show(stringer);
            Clipboard.SetText(stringer);
        }

    }
}
