using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;

namespace JuicySwapper.Items.Skins
{
    public partial class sunbird : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "sunbird";

        public sunbird()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.sunbirdEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        string Body = "Characters/Player/Female/Medium/BodFztec_Eclipse/ed";
        string Body1 = "Characters/Player/Female/Medium/BodFztec_EclipJuicy";
        string Hat = "Player/Female/Medium/BodAztec_Eclipsed_Body";
        string Hat1 = "Player/Female/Medium/BodAztec_Eclipsed_iody";
        string Head = "Player/Female/Medium/BodAztec_Eclipsed_FacAcc";
        string Head1 = "Player/Female/Medium/B0dAztec_Eclipsed_FacAcc";

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RichTextBoxInfo.Clear();
            RichTextBoxInfo.Text += "[LOG] Starting...";

            if (convertButton.Text == "Convert")
            {
                if (SwapUtilities.CheckIfCanSwap("TacticsOfficer"))
                    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.sunbirdEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body added";
                }

                bool Swap2 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Hat, Hat1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Hat added";

                bool Swap3 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Head, Head1, 0, 0, false, false);
                if (Swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Head added";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                bool Swap1 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.sunbirdEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body removed";
                }

                bool Swap2 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Hat, Hat1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Hat removed";

                bool Swap3 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Head, Head1, 0, 0, false, false);
                if (Swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Head removed";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");
                convertButton.Text = "Convert";
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();

            if (!File.Exists(SwapPath[0]))
            {
                PakError a = new PakError(); a.ShowDialog();
                return;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
