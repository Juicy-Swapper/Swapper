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
    public partial class ReconExpert : Form
    {
        bool enabled = Settings.Default.ReconExpertEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Recon Expert";

        public ReconExpert()
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

        string Body = "lSkins/BR_03/MaterialED_Cmmando_BR03";
        string Body1 = "lSkins/TV_14/MaterialED_Cmmando_TV14";
        string GenderOffset = "/Game/Athena/Heroes/Meshes/Bodies/CP_013_";
        string Invalid = "Heads/F_MED_BLK_Red_";
        string Invalid1 = "He1ds/F_MED_BLK_Red_";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Dominator"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.ReconExpertEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body 1/2 added";
            }

            Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GenderOffset);

            long Offset_current = Settings.Default.current_offset;
            bool Swap2 = Researcher.Convert(Offset_current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Body 2/2 removed";

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

            bool Swap1 = Researcher.Revert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.ReconExpertEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body 1/2 removed";
            }

            Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GenderOffset);

            long Offset_current = Settings.Default.current_offset;
            bool Swap2 = Researcher.Revert(Offset_current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Body 2/2 removed";

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
    }
}
