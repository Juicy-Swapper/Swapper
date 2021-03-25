using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;
using System.ComponentModel;

namespace JuicySwapper.Items.Pickaxes
{
    public partial class SkullySplitter : Form
    {
        bool enabled = Settings.Default.SkullySplitterEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Skully Splitter";

        public SkullySplitter()
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

        string SwapOffset = "WID_Hrvest_Pickaxe_SkullBriteEclipse";
        string Mat = "Materials/MIb";
        string Mat1 = "Materials/M1b";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("Dominator"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            Researcher.GetOffset(0, SwapPath[2], SwapOffset);

            long Offset_current = Settings.Default.current_offset;
            bool Swap1 = Researcher.Convert(Offset_current, SwapPath[2], Mat, Mat1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SkullySplitterEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mat added";
            }

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

            Researcher.GetOffset(0, SwapPath[2], SwapOffset);

            long Offset_current = Settings.Default.current_offset;
            bool Swap1 = Researcher.Revert(Offset_current, SwapPath[2], Mat, Mat1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SkullySplitterEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mat removed";
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
    }
}
