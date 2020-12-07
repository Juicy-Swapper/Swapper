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

        string SwapOffset = "WID_Hrvest_Pickaxe_CandyCane";
        string Mat = "IMaterias/MI";
        string Mat1 = "IMateri1s/MI";
        string FX = "/FX/Pdle_FX";
        string FX1 = "/FX/P1le_FX";

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
                //    return;

                Researcher.GetOffset(0, SwapPath[2], SwapOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap1 = Researcher.Convert(Offset_current, SwapPath[2], FX, FX1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.candyaxeEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] FX added";
                }

                bool Swap2 = Researcher.Convert(Offset_current, SwapPath[2], Mat, Mat1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Mat added";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                Researcher.GetOffset(0, SwapPath[2], SwapOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap1 = Researcher.Revert(Offset_current, SwapPath[2], FX, FX1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.candyaxeEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] FX removed";
                }

                bool Swap2 = Researcher.Revert(Offset_current, SwapPath[2], Mat, Mat1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Mat added";

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
