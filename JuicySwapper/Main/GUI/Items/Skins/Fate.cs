using JuicySwapper.IO;
using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI.Items.Skins
{
    public partial class Fate : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Fate";
        public Fate()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.FateEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        string Pos = "/Game/Athena/Heroes/Meshes/Bodies/CP_Body_Commando_F_Davinci";
        string Mat = "jSkins//Material";
        string Mat1 = "jSkins//M1terial";
        string HPos = "CP_Hat_F_Commando_Davinci";
        string HMat = "/Material";
        string HMat1 = "/Mat1rial";

        string GPos = "/Game/Athena/Heroes/Meshes/Bodies/CP_Body_Commando_F_Davinci";
        string Gender = "Parts/Female/Medium/Head";
        string Gender1 = "Parts/Female/Medium/He1d";

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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RichTextBoxInfo.Clear();
            RichTextBoxInfo.Text += "[LOG] Starting...";

            if (convertButton.Text == "Convert")
            {
                //if (SwapUtilities.CheckIfCanSwap("AssaultTrooper"))
                //    return;

                Researcher.GetOffset(0, SwapPath[0], Pos);

                bool Swap1 = Researcher.Convert(Settings.Default.current_offset, SwapPath[0], Mat, Mat1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.FateEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added";
                }

                Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GPos);

                long Offset_current = Settings.Default.current_offset;
                bool Swap2 = Researcher.Convert(Offset_current, SwapPath[0], Gender, Gender1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added";

                Researcher.GetOffset(200000000, SwapPath[1], HPos);

                bool Swap3 = Researcher.Convert(Offset_current, SwapPath[1], HMat, HMat1, 0, 0, false, false);
                if (Swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Hat added";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                Researcher.GetOffset(0, SwapPath[0], Pos);

                bool Swap1 = Researcher.Revert(SwapOffsets[0], SwapPath[0], Mat, Mat1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.FateEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 removed";
                }

                Researcher.GetOffset(SwapOffsets[5], SwapPath[0], GPos);

                long Offset_current = Settings.Default.current_offset;
                bool Swap2 = Researcher.Revert(Offset_current, SwapPath[0], Gender, Gender1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 removed";


                Researcher.GetOffset(200000000, SwapPath[1], HPos);

                bool Swap3 = Researcher.Revert(Offset_current, SwapPath[1], HMat, HMat1, 0, 0, false, false);
                if (Swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Hat removed";


                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");
                convertButton.Text = "Convert";
            }
        }
    }
}
