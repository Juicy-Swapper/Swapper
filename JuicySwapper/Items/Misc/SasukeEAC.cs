using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;
using System.ComponentModel;
using System.Globalization;

namespace JuicySwapper.Items.Misc
{
    public partial class Sasuke : Form
    {
        bool enabled = Settings.Default.SasukeEACEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Sasuke EAC";

        public Sasuke()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ActiveControl = ActionButton;
            Text = placeholder;

            if (enabled)
                ActionButton.Image = Resources.RevertBtn;
            else
                ActionButton.Image = Resources.ConvertBtn;
        }

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("EAC"))
                return;

            ActionButton.Enabled = false;

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = JuicyUtilities.DownloadConvert("Sasuke");
            if (Swap1)
            {
                Settings.Default.SasukeEACEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] EAC added";
            }

            ActionButton.Image = Resources.RevertBtn;
            LogBox.Text += "\nConverted!";
        }

        private void RevertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            ActionButton.Enabled = false;

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = JuicyUtilities.DownloadRevert();
            if (Swap1)
            {
                Settings.Default.SasukeEACEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] EAC removed";
            }

            ActionButton.Image = Resources.ConvertBtn;
            LogBox.Text += "\nReverted!";
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();

            if (!File.Exists(SwapPath[0]))
            {
                Message FortnitePathExp = new Message(Resources.pakfileerror);
                FortnitePathExp.ShowDialog();
                return;
            }
            if (enabled)
                RevertBytes.RunWorkerAsync();
            else
                ConvertBytes.RunWorkerAsync();
        }

        private void ConvertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConvertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void RevertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RevertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }

        private void SkinImage_MouseEnter(object sender, EventArgs e)
        {
            SkinImage.Image = Resources.Sasuke;
        }

        private void SkinImage_MouseLeave(object sender, EventArgs e)
        {
            SkinImage.Image = Resources.SplashScreen;
        }
    }
}
