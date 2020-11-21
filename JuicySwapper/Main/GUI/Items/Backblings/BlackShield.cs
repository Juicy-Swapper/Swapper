using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;

namespace JuicySwapper.Items.BackBlings
{
    public partial class BlackShield : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Black Shield";

        public BlackShield()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.BlackShieldEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        private static byte[] mats = new byte[30] { 67, 73, 99, 101, 74, 77, 97, 108, 101, 95, 67, 111, 109, 109, 97, 110, 100, 111, 66, 82, 95, 107, 110, 105, 103, 104, 116, 86, 48, 49 };

        private static byte[] mats1 = new byte[30] { 67, 73, 99, 101, 74, 77, 97, 108, 101, 95, 67, 111, 109, 109, 97, 110, 100, 111, 66, 82, 95, 107, 110, 105, 103, 74, 117, 105, 99, 121 };

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
                if (SwapUtilities.CheckIfCanSwap("RedShield"))
                    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[3], SwapPath[3], mats, mats1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.BlackShieldEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Mats added";
                }

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                bool Swap1 = Researcher.Revert(SwapOffsets[3], SwapPath[3], mats, mats1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.BlackShieldEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Mats removed";
                }

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
