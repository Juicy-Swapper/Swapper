using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Media;
using System.Net;
using System.Windows.Forms;
using static JuicySwapper.Classes.Json_Api.SatusAPI;

namespace JuicySwapper.Main.GUI
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            Message();
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Process.Start("JuicySwapper_Updater.exe");
            Environment.Exit(0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DevMode_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        void Message()
        {
            var StatusAPI = new WebClient().DownloadString("https://juicyswapper.xyz/api/status.json");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

            string text = $"You are using an older version of Juicy\nSwapper! Please update the swapper by\npressing the 'UPDATE' button, and " +
                $"please\njoin the Discord if you require any assistance.\n\nNewest Build: v{StatusResponse.Version}\nCurrent Build: v{Application.ProductVersion}";

            label2.Text = text;
        }
    }
}
