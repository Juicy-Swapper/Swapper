using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Threading;
using JuicySwapper_Launcher.Main.Classes;
using JuicySwapper_Launcher.Properties;
using static JuicySwapper_Launcher.SatusAPI;

namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class Loader : Form
    {
        public byte holder = 0;
        public static long Num;
        public Loader()
        {
            InitializeComponent();
            JuicyUtilities_RPC.DiscordRPC.Initialize();
            JuicyUtilities_RPC.SetRPCLocation("Loader");
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
            
            if(Settings.Default.KeepSingedin == true)
            {
                if (holder > 80)
                    label1.Text = "Signing into " + Settings.Default.username;
                if (holder == 104)
                {
                    label2.Text = "100%";
                    timer1.Enabled = false;


                    var hwid = JuicyUtilities.GET_HARDWAREID;
                    var username = Settings.Default.username;
                    var password = Settings.Default.Password;

                    var Login = new Login();
                    var home = new Home();

                    try
                    {
                        MongoCRUD db = new MongoCRUD("JuicySwapper");

                        var onerec = db.LoadRecordByUsername<AccountInfo>("Users", username);

                        if (JuicySwapper_Encryption.Auth.DataBase.Decrypt(onerec.password, "") != password)
                        {
                            Hide();
                            Login.Closed += (s, arg) => Close();
                            Login.Show();
                            return;
                        }

                        if (onerec.HWID != hwid)
                        {
                            Hide();
                            Login.Closed += (s, arg) => Close();
                            Login.Show();
                            return;
                        }


                        Settings.Default.PFP = onerec.ProfilePicture;
                        Settings.Default.Save();

                        onerec.Online = true;
                        db.UpsertRecord("Users", onerec.username, onerec);

                        label2.Text = "100%";

                        home.Closed += (s, arg) => Close();
                        home.Show();
                        Hide();
                        return;
                    }
                    catch
                    {

                    }
                    home.Closed += (s, arg) => Close();
                    home.Show();
                    Hide();
                };
            }
            if (Settings.Default.KeepSingedin == false)
            {
                if (holder == 100)
                {
                    timer1.Enabled = false;

                    var Login = new Login();
                    Login.Closed += (s, arg) => Close();
                    Login.Show();
                    Hide();
                }
            }


        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var StatusAPI = new WebClient().DownloadString($"{API.HOST}/{API.Status}");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

            WebClient ProgramClient = new WebClient();

            ProgramClient.Proxy = null;
            ProgramClient.DownloadFileAsync(new Uri(StatusResponse.Encryption), "JuicySwapper_Encryption.dll");

            File.SetAttributes("JuicySwapper_Encryption.dll", FileAttributes.Hidden | FileAttributes.System);

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
