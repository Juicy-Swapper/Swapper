using JuicySwapper.Properties;
using System;
using System.Media;
using System.Windows.Forms;
using JuicySwapper.Main.Classes;

namespace JuicySwapper.Main.GUI
{
    public partial class CheckIfSwapMesg : Form
    {
        public CheckIfSwapMesg()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            label1.Text = $"A skin using {SwapUtilities.SkinSwapped} is already converted.";
            label2.Text = $"{SwapUtilities.SkinSwappedFor} has been swapped for {SwapUtilities.SkinSwapped}\nif this is an error on our end, please reset config in Settings.";
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
