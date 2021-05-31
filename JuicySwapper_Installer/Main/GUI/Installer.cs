using DiscordRPC;
using JuicySwapper_Installer.Main.Classes;
using System;
using System.Diagnostics;
using JuicySwapper_Installer.Properties;
using System.IO;
using System.Windows.Forms;

namespace JuicySwapper_Installer.Main.GUI
{
    public partial class Installer : Form
    {
        public DiscordRpcClient discordRpcClient_0 = new DiscordRpcClient("704324460291031047");
        string AppdataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static DiscordRpcClient rpcClient;
        public Installer()
        {
            InitializeComponent();
            Juicy.DiscordRPC.Initialize();
            Juicy.SetRPCAction("", "");
        }
        
        private void InstallButton_Click(object sender, EventArgs e)
        {
            Hide();
            var Setup = new Setup();
            Setup.Closed += (s, args) => Close();
            Setup.Show();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Discordinvite_Click(object sender, EventArgs e)
        {
            Process.Start($"juicyswapper.xyz/discord");
        }
    }
}
