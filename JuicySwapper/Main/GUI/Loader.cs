using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JuicySwapper.Main.Classes;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Loader : Form
    {
        public byte holder = 0;
        public static long Num; 
        public Loader()
        {
            InitializeComponent();
            JuicyUtilities.DiscordRPC.Initialize();
            JuicyUtilities.SetRPCAction("In Dashboard", "");
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
            if (holder == 100)
            {
                timer1.Enabled = false;
                Hide();
                var Open = new Login();
                Open.Closed += (s, args) => Close();
                Open.Show();
            };
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            MongoCRUD db = new MongoCRUD("JuicySwapper");

            db.Accounts<UserModel>("Juicy");

            Num = db.Accounts<UserModel>("Juicy");
        }
    }
}
