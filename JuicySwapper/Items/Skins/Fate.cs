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
    public partial class Fate : Form
    {
        bool enabled = Settings.Default.FateEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Fate";

        public Fate()
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

        string Pos = "/Game/Athena/Heroes/Meshes/Bodies/CP_Body_Commando_F_Davinci";
        string Mat = "jSkins//Material";
        string Mat1 = "jSkins//M1terial";
        string HPos = "CP_Hat_F_Commando_Davinci";
        string HMat = "/Material";
        string HMat1 = "/Mat1rial";

        string GPos = "/Game/Athena/Heroes/Meshes/Bodies/CP_Body_Commando_F_Davinci";
        string Gender = "Parts/Female/Medium/Head";
        string Gender1 = "Parts/Female/Medium/He1d";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("Dominator"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            Researcher.GetOffset(0, SwapPath[0], Pos);

            bool Swap1 = Researcher.Convert(Settings.Default.current_offset, SwapPath[0], Mat, Mat1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.FateEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body 1/2 added";
            }

            Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GPos);

            long Offset_current = Settings.Default.current_offset;
            bool Swap2 = Researcher.Convert(Offset_current, SwapPath[0], Gender, Gender1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Body 2/2 added";

            Researcher.GetOffset(181545520, SwapPath[1], HPos);

            bool Swap3 = Researcher.Convert(Offset_current, SwapPath[1], HMat, HMat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat added";

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

            Researcher.GetOffset(0, SwapPath[0], Pos);

            bool Swap1 = Researcher.Revert(SwapOffsets[0], SwapPath[0], Mat, Mat1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.FateEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body 1/2 removed";
            }

            Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GPos);

            long Offset_current = Settings.Default.current_offset;
            bool Swap2 = Researcher.Revert(Offset_current, SwapPath[0], Gender, Gender1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Body 2/2 removed";


            Researcher.GetOffset(181545520, SwapPath[1], HPos);

            bool Swap3 = Researcher.Revert(Offset_current, SwapPath[1], HMat, HMat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat removed";

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
