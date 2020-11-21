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
    public partial class SparkleSpecialist : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Sparkle Specialist";

        public SparkleSpecialist()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.SparkleSpecialistEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        private static byte[] Body = new byte[35] { 83, 107, 105, 110, 115, 47, 84, 86, 95, 49, 57, 47, 77, 97, 116, 101, 114, 105, 97, 108, 69, 68, 95, 67, 109, 109, 97, 110, 100, 111, 95, 84, 86, 49, 57 };

        private static byte[] Body1 = new byte[35] { 83, 107, 105, 110, 115, 47, 66, 82, 95, 48, 53, 47, 77, 97, 116, 101, 114, 105, 97, 108, 69, 68, 95, 67, 109, 109, 97, 110, 100, 111, 95, 66, 82, 48, 53  };

        private static byte[] Invalid = new byte[15] { 67, 83, 112, 101, 99, 105, 97, 108, 105, 122, 115, 47, 72, 83, 70 };

        private static byte[] Invalid1 = new byte[15] { 67, 83, 112, 106, 117, 105, 99, 121, 105, 122, 115, 47, 72, 83, 70 };

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
                if (SwapUtilities.CheckIfCanSwap("AssaultTrooper"))
                    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.SparkleSpecialistEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added";
                }

                bool Swap2 = Researcher.Convert(SwapOffsets[5], SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                bool Swap1 = Researcher.Revert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.SparkleSpecialistEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 removed";
                }

                bool Swap2 = Researcher.Revert(SwapOffsets[5], SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 removed";

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
