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
    public partial class BattleShroud : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Battle Shroud ";

        public BattleShroud()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.BattleShroudEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        string Mat = "EagleFirMI__Cap";
        string Mat1 = "Eag1eFirMI__Cap";
        string FX = "eEffects/Fort_Characters/Athena_Parts/DrkEagle_Fire_Backpack";
        string FX1 = "eEffects/Fort_Characters/Athena1Parts/DrkEagle_Fire_Backpack";

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();
            //temp
            int[] TempSwapOffsets = SwapUtilities.GetSwapOffsetTemp();
            string[] TempSwapPath = SwapUtilities.GetSwapPathTemp();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RichTextBoxInfo.Clear();
            RichTextBoxInfo.Text += "[LOG] Starting...";

            if (convertButton.Text == "Convert")
            {
                if (SwapUtilities.CheckIfCanSwap("RedShield"))
                    return;

                bool Swap1 = Researcher.Convert(TempSwapOffsets[0], TempSwapPath[0], Mat, Mat1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.BattleShroudEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Mats added";
                }

                bool Swap2 = Researcher.Convert(TempSwapOffsets[1], TempSwapPath[1], FX, FX1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] FX added";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                bool Swap1 = Researcher.Revert(TempSwapOffsets[0], TempSwapPath[0], Mat, Mat1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.BattleShroudEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Mats removed";
                }

                bool Swap2 = Researcher.Revert(TempSwapOffsets[1], TempSwapPath[1], FX, FX1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] FX removed";

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
