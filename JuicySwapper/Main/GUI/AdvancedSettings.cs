using JuicySwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class AdvancedSettings : Form
    {
        public AdvancedSettings()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            new BackupVerify().ShowDialog();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            DialogResult restart = MessageBox.Show("Are you sure you want to restart?", "Juicy Swapper", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (restart == DialogResult.Yes)
                Process.Start(Application.ExecutablePath);
            else
               Environment.Exit(0);
        }

        private void openPakButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Settings.Default.InstallationPath);
        }

        private void checkPakButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Settings.Default.InstallationPath + $"\\FortniteGame\\Content\\Paks\\global.ucas"))
                MessageBox.Show("Successfully found ucas.", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("Could not find ucas!", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fortniteButton_Click(object sender, EventArgs e)
        {
            new FortniteLaunch().ShowDialog();
            Process.Start($"{Settings.Default.InstallationPath}\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe");
            Settings.Default.openfortnite = true;
            Environment.Exit(0);
        }
    }
}
