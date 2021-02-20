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
    public partial class EliteAgent : Form
    {
        bool enabled = Settings.Default.EliteAgentEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Elite Agent";

        public EliteAgent()
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

        string Body = "Skins/BR_51/MaterialED_CmmandoBR051";
        string Body1 = "Skins/BR_43/MaterialED_CmmandoBR043";

        string Hair = "kPlayerBodiesSoldier_01s/BR_51/MaterialED_Cmmando_Hair_051";
        string Hair1 = "kPlayerBodiesSoldier_01s/BR_51/MaterialED_Cmmando_Hair_kae";

        string GenderOffset = "/Game/Athena/Heroes/Meshes/Bodies/CP_106_Body_F_Taxi";

        string Invalid = "Parts/Female/Medium/Head";
        string Invalid1 = "Parts/Female/Medium/0000";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Whiplash"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.EliteAgentEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body 1/2 added";
            }

            Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GenderOffset);

            long Offfset_Current = Settings.Default.current_offset;
            bool Swap2 = Researcher.Convert(Offfset_Current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[Log] Body 2/2 added";

            bool Swap3 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Hair, Hair1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[Log] Hair added";

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
                Settings.Default.EliteAgentEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body 1/2 removed";
            }

            Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GenderOffset);

            long Offfset_Current = Settings.Default.current_offset;
            bool Swap2 = Researcher.Revert(Offfset_Current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[Log] Body 2/2 removed";

            bool Swap3 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Hair, Hair1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[Log] Hair removed";

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
