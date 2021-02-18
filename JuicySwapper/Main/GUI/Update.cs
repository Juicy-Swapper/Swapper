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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void DevMode_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Process.Start("JuicySwapper_Updater.exe");
            Environment.Exit(0);
        }

        private void DiscordBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
