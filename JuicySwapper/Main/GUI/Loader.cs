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

namespace JuicySwapper.Main.GUI
{
    public partial class Loader : Form
    {
        public byte holder = 0;
        public static long Num; 
        public Loader()
        {
            JuicyUtilities.SetRPCSTAT2($"Loading - 0%");
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

                if (Settings.Default.MusicAct == "True")
                {
                    JuicyUtilities MusicController = new JuicyUtilities();
                    MusicController.MusicControl("True");
                }

                var Open = new Login();
                Open.Closed += (s, args) => Close();
                Open.Show();
            };
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            if (!File.Exists("JuicySwapper_Encryption.dll"))
                Encryption();

            MongoCRUD db = new MongoCRUD("JuicySwapper");

            db.Accounts<UserModel>("Juicy");

            Num = db.Accounts<UserModel>("Juicy");
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

        private void Loader_Load(object sender, EventArgs e)
        {

        }
    }
}
