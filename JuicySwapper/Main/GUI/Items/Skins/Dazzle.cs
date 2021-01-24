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
    public partial class Dazzle : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Dazzle";

        public Dazzle()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.DazzleEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        string Body = "Skins/BR_51/MaterialED_CmmandoBR051";
        string Body1 = "Skins/BR_31/MaterialED_CmmandoBR031";
        string Hair = "kPlayerBodiesSoldier_01s/BR_51/MaterialED_Cmmando_Hair_051";
        string Hair1 = "kPlayerBodiesSoldier_01s/BR_00/Ma1erialED_Cmmando_Hair_kae";

        string GenderOffset = "/Game/Athena/Heroes/Meshes/Bodies/CP_106_Body_F_Taxi";
        string Invalid = "Parts/Female/Medium/Head";
        string Invalid1 = "Parts/Female/Medium/He1d";

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
                //if (SwapUtilities.CheckIfCanSwap("Whiplash"))
                //    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.DazzleEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added";
                }


                Researcher.GetOffset(SwapOffsets[6], SwapPath[0], GenderOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap2 = Researcher.Convert(Offset_current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added";

                bool Swap3 = Researcher.Convert(SwapOffsets[1], SwapPath[1], Hair, Hair1, 0, 0, false, false);
                if (Swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Hair added";

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
                    Settings.Default.DazzleEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 removed";
                }

                Researcher.GetOffset(0, SwapPath[0], GenderOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap2 = Researcher.Revert(Offset_current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 removed";

                bool Swap3 = Researcher.Revert(SwapOffsets[1], SwapPath[1], Hair, Hair1, 0, 0, false, false);
                if (Swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Hair removed";

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
