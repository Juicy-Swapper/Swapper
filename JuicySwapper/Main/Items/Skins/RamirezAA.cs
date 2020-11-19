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
    public partial class RamirezAA : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Ramirez";

        public RamirezAA()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.RamirezAAEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        private static byte[] Body = new byte[32] { 108, 83, 107, 105, 110, 115, 47, 66, 82, 95, 48, 54, 47, 77, 97, 116, 101, 114, 105, 97, 108, 69, 68, 66, 111, 100, 121, 95, 66, 82, 48, 54 };

        private static byte[] Body1 = new byte[32] { 108, 83, 107, 105, 110, 115, 47, 66, 82, 95, 48, 54, 47, 77, 97, 116, 101, 114, 105, 97, 108, 69, 68, 66, 111, 100, 121, 74, 117, 105, 99, 121 };

        private static byte[] Glasses = new byte[44] { 73, 0, 106, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 11, 0, 111, 3, 80, 97, 114, 116, 115, 47, 72, 97, 116, 115, 47, 71, 108, 97, 115, 115, 101, 115, 68, 0, 248, 66, 82, 48, 54, 95, 70 };

        private static byte[] Glasses1 = new byte[44] { 73, 0, 106, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 11, 0, 111, 3, 80, 97, 114, 116, 115, 47, 72, 97, 116, 115, 47, 71, 108, 97, 115, 115, 101, 115, 68, 0, 248, 66, 74, 117, 105, 99, 121 };

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
                if (SwapUtilities.CheckIfCanSwap("ArcticAssassin"))
                    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.RamirezAAEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body added";
                }

                bool Swap2 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Glasses, Glasses1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Glasses removed";

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
                    Settings.Default.RamirezAAEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body removed";
                }

                bool Swap2 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Glasses, Glasses1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Glasses Added";

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
