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

        private static byte[] Body = new byte[51] { 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 47, 80, 108, 97, 121, 101, 114, 47, 70, 101, 109, 97, 108, 101, 47, 77, 101, 100, 105, 117, 109, 47, 66, 111, 100, 70, 122, 116, 101, 99, 95, 69, 99, 108, 105, 112, 115, 101, 47, 101, 100 };

        private static byte[] Body1 = new byte[51] { 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 47, 80, 108, 97, 121, 101, 114, 47, 70, 101, 109, 97, 108, 101, 47, 77, 101, 100, 105, 117, 109, 47, 66, 111, 100, 70, 122, 116, 101, 99, 95, 69, 99, 108, 105, 112, 74, 117, 105, 99, 121 };

        private static byte[] Hat = new byte[43] { 80, 108, 97, 121, 101, 114, 47, 70, 101, 109, 97, 108, 101, 47, 77, 101, 100, 105, 117, 109, 47, 66, 111, 100, 65, 122, 116, 101, 99, 95, 69, 99, 108, 105, 112, 115, 101, 100, 95, 66, 111, 100, 121 };

        private static byte[] Hat1 = new byte[43] { 80, 108, 97, 121, 101, 114, 47, 70, 101, 109, 97, 108, 101, 47, 77, 101, 100, 105, 117, 109, 47, 66, 111, 100, 65, 122, 116, 101, 99, 95, 69, 99, 108, 105, 112, 115, 101, 100, 74, 117, 105, 99, 121 };

        private static byte[] Head = new byte[45] { 80, 108, 97, 121, 101, 114, 47, 70, 101, 109, 97, 108, 101, 47, 77, 101, 100, 105, 117, 109, 47, 66, 111, 100, 65, 122, 116, 101, 99, 95, 69, 99, 108, 105, 112, 115, 101, 100, 95, 70, 97, 99, 65, 99, 99 };

        private static byte[] Head1 = new byte[45] { 80, 108, 97, 121, 101, 114, 47, 70, 101, 109, 97, 108, 101, 47, 77, 101, 100, 105, 117, 109, 47, 66, 111, 100, 65, 122, 116, 101, 99, 95, 69, 99, 108, 105, 112, 115, 101, 100, 95, 70, 74, 117, 105, 99, 121 };

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
