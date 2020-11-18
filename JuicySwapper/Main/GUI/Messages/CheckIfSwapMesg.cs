using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Main.GUI
{
    public partial class CheckIfSwapMesg : Form
    {
        public CheckIfSwapMesg()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            label1.Text = "A skin using " + Settings.Default.SkinSwapped + " is already converted.";
            label2.Text = Settings.Default.SkinSwappedFor + " has been swapped for " + Settings.Default.SkinSwapped + "\nif this is an error on our end, please reset config in Settings.";
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            new SettingsMenu().ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PakError_Load(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }
    }
}
