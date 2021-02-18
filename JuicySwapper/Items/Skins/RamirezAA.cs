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
    public partial class RamirezAA : Form
    {
        bool enabled = Settings.Default.RamirezAAEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Ramirez";

        public RamirezAA()
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

        string Body = "lSkins/BR_06/MaterialEDBody_BR06";
        string Body1 = "lSkins/BR_06/MJterialEDBody_BR06";

        byte[] Glasses = { 73, 0, 106, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 11, 0, 111, 3, 80, 97, 114, 116, 115, 47, 72, 97, 116, 115, 47, 71, 108, 97, 115, 115, 101, 115, 68, 0, 248, 66, 82, 48, 54, 95, 70 };
        byte[] Glasses1 = { 73, 0, 106, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 11, 0, 111, 3, 80, 97, 114, 116, 115, 47, 72, 97, 116, 115, 47, 71, 108, 97, 115, 115, 101, 115, 68, 0, 248, 66, 74, 117, 105, 99, 121 };

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("ArcticAssassin"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.RamirezAAEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = ByteResearcher.Convert(SwapOffsets[0], SwapPath[0], Glasses, Glasses1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Glasses removed";

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
                Settings.Default.RamirezAAEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = ByteResearcher.Revert(SwapOffsets[0], SwapPath[0], Glasses, Glasses1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Glasses Added";

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
