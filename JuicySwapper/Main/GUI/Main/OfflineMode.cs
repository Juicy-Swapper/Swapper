using JuicySwapper.Main.Classes;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Media;
using System.Net;
using System.Windows.Forms;
using static JuicySwapper.Classes.Json_Api.SatusAPI;

namespace JuicySwapper.Main.GUI
{ 
    public partial class OfflineMode : Form
    {
        public OfflineMode()
        {
            InitializeComponent();
            var StatusAPI = new WebClient().DownloadString($"{Api.HOST}/{Api.Status}");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

            dialogMsgTextLabel.Text = $"Juicy Swapper v2 is currently offline, so you" +
                $"\naren't able to launch the swapper at this time." +
                $"\nMake sure to join our Discord for more info." +
                $"\n\nReason: {StatusResponse.OfflineMessage}";
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
