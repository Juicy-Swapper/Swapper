using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;
using System.ComponentModel;

namespace JuicySwapper.Items.Skins
{
    public partial class sunbird : Form
    {
        bool enabled = Settings.Default.sunbirdEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "sunbird";

        public sunbird()
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

        string Body = "Characters/Player/Female/Medium/BodFztec_Eclipse/ed";
        string Body1 = "Characters/Player/Female/Medium/BodFztec_EclipJuicy";
        string Hat = "Player/Female/Medium/BodAztec_Eclipsed_Body";
        string Hat1 = "Player/Female/Medium/BodAztec_Eclipsed_iody";
        string Head = "Player/Female/Medium/BodAztec_Eclipsed_FacAcc";
        string Head1 = "Player/Female/Medium/B0dAztec_Eclipsed_FacAcc";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("Dominator"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.sunbirdEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Hat, Hat1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Hat added";

            bool Swap3 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Head, Head1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Head added";

            ActionButton.Image = Resources.RevertBtn;
            LogBox.Text += "\nConverted!";
        }

        private void RevertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.sunbirdEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Hat, Hat1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Hat removed";

            bool Swap3 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Head, Head1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Head removed";

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

        private void SkinImage_Click(object sender, EventArgs e)
        {

        }
    }
}
