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
    public partial class SkullySplitter : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Skully Splitter";

        public SkullySplitter()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.SkullySplitterEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        string SwapOffset = "WID_Hrvest_Pickaxe_SkullBriteEclipse";
        string Mat = "Materials/MIb";
        string Mat1 = "Materials/M1b";

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
                //if (SwapUtilities.CheckIfCanSwap("Minty"))
                    //return;

                Researcher.GetOffset(0, SwapPath[2], SwapOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap1 = Researcher.Convert(Offset_current, SwapPath[2], Mat, Mat1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.SkullySplitterEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Mat added";
                }

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                Researcher.GetOffset(0, SwapPath[2], SwapOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap1 = Researcher.Revert(29000000, SwapPath[2], Mat, Mat1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.SkullySplitterEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Mat removed";
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
