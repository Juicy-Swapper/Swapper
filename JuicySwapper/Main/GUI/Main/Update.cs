using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            this.ActiveControl = label1;
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
    }
}
