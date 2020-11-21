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
    public partial class BansheeRen : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Banshee";

        public BansheeRen()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.BansheeRenEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        private static byte[] Body = new byte[36] { 108, 83, 107, 105, 110, 115, 47, 66, 82, 95, 48, 51, 47, 77, 97, 116, 101, 114, 105, 97, 108, 69, 68, 95, 67, 109, 109, 97, 110, 100, 111, 95, 66, 82, 48, 51 };

        private static byte[] Body1 = new byte[36] { 108, 83, 107, 105, 110, 115, 47, 66, 82, 95, 48, 51, 47, 77, 97, 116, 101, 114, 105, 97, 108, 69, 68, 95, 67, 109, 109, 97, 110, 100, 111, 74, 117, 105, 99, 121 };

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
                if (SwapUtilities.CheckIfCanSwap("Renegade"))
                    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.BansheeRenEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body added";
                }

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
                    Settings.Default.BansheeRenEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body removed";
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
