using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static JuicySwapper.Classes.Json_Api.SatusAPI;

namespace JuicySwapper.Main.GUI
{
    public partial class Annoucement : Form
    {
        public Annoucement()
        {
            InitializeComponent();
            ActiveControl = label1;
            MessageForm();
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DevMode_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        void MessageForm()
        {
            var StatusAPI = new WebClient().DownloadString("https://juicyswapper.xyz/api/status.json");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
            string text = StatusResponse.AnnoucementMessage;
            label2.Text = text;
        }
    }
}
