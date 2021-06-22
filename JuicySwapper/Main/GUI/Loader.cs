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
            //removed accounts as of some person deleted the whole thing

            if (!File.Exists("JuicySwapper_Encryption.dll"))
                Encryption();

            //MongoCRUD db = new MongoCRUD("JuicySwapper");

            //db.Accounts<UserModel>("Juicy", true); //

            //long temp = db.Accounts<UserModel>("Juicy", false);

            //long temp1 = db.Accounts<UserModel>("Juicy", true);

            //Num = temp + temp1;
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

            String pakPath = Settings.Default.pakPath;
            String pak = pakPath + "\\pakchunk100_s3-WindowsClient.ucas";

            if (!File.Exists(pak))
            {
                //ucas
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.ucas", pakPath + "\\pakchunk100_s3-WindowsClient.ucas");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.ucas", pakPath + "\\pakchunk100_s4-WindowsClient.ucas");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.ucas", pakPath + "\\pakchunk100_s5-WindowsClient.ucas");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.ucas", pakPath + "\\pakchunk100_s17-WindowsClient.ucas");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.ucas", pakPath + "\\pakchunk100_s22-WindowsClient.ucas");

                //utoc
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.utoc", pakPath + "\\pakchunk100_s3-WindowsClient.utoc");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.utoc", pakPath + "\\pakchunk100_s4-WindowsClient.utoc");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.utoc", pakPath + "\\pakchunk100_s5-WindowsClient.utoc");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.utoc", pakPath + "\\pakchunk100_s17-WindowsClient.utoc");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.utoc", pakPath + "\\pakchunk100_s22-WindowsClient.utoc");

                //pak
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.pak", pakPath + "\\pakchunk100_s3-WindowsClient.pak");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.pak", pakPath + "\\pakchunk100_s4-WindowsClient.pak");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.pak", pakPath + "\\pakchunk100_s5-WindowsClient.pak");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.pak", pakPath + "\\pakchunk100_s17-WindowsClient.pak");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.pak", pakPath + "\\pakchunk100_s22-WindowsClient.pak");

                //sig
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.sig", pakPath + "\\pakchunk100_s3-WindowsClient.sig");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.sig", pakPath + "\\pakchunk100_s4-WindowsClient.sig");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.sig", pakPath + "\\pakchunk100_s5-WindowsClient.sig");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.sig", pakPath + "\\pakchunk100_s17-WindowsClient.sig");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.sig", pakPath + "\\pakchunk100_s22-WindowsClient.sig");

            }
        }
    }
}
