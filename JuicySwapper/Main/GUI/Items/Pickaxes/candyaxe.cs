using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;

namespace JuicySwapper.Items.Pickaxes
{
    public partial class candyaxe : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Candy Axe";

        public candyaxe()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.candyaxeEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        private static byte[] Body = new byte[58] { 47, 71, 97, 109, 101, 47, 87, 101, 97, 112, 111, 110, 115, 47, 70, 79, 82, 84, 95, 77, 101, 108, 101, 101, 47, 80, 105, 99, 107, 97, 120, 101, 95, 49, 53, 47, 84, 101, 120, 116, 117, 114, 101, 115, 47, 84, 95, 95, 76, 105, 103, 104, 116, 115, 104, 111, 119, 50 };

        private static byte[] Body1 = new byte[58] { 47, 71, 97, 109, 101, 47, 87, 101, 97, 112, 111, 110, 115, 47, 70, 79, 82, 84, 95, 77, 101, 108, 101, 101, 47, 80, 105, 99, 107, 97, 120, 101, 95, 49, 53, 47, 84, 101, 120, 116, 117, 114, 101, 115, 47, 84, 95, 95, 76, 105, 103, 104, 74, 117, 105, 99, 121, 50 };

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
                if (SwapUtilities.CheckIfCanSwap("Trooper"))
                    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[2], SwapPath[2], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.candyaxeEnabled = true;
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
                bool Swap1 = Researcher.Revert(SwapOffsets[2], SwapPath[2], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.candyaxeEnabled = false;
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
