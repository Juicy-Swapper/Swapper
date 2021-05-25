using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;
using System.ComponentModel;
using System.Globalization;

namespace JuicySwapper.Items.Skins
{
    public partial class SparkleSpecialist : Form
    {
        bool enabled = Settings.Default.SparkleSpecialistEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Sparkle Specialist";

        public SparkleSpecialist()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ActiveControl = ActionButton;
            Text = placeholder;

            if (enabled)
                ActionButton.Image = Resources.RevertBtn;
            else
                ActionButton.Image = Resources.ConvertBtn;
        }

        string Body = "8C 0A 00 05 10 88 05 0E 00 00 00 00 00 00 00 00 00 03 8E 20 00 80 C6 09 40 00 00 00 4A 06 90 06 70 01 00 08 28 08 B8 E0 04 34 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 30 31 35 5F 5F 42 6F 64 79 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 55 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 72 30 31 46 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 2E 5F 43 00 6C 53 6B 69 6E 73 2F 54 56 5F 31 39 2F 4D 61 74 65 72 69 61 6C 45 44 5F 43 6D 6D 61 6E 64 6F 5F 54 56 31 39 00 85 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 12 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 C9 0F 19 36 A1 14 CB 13 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 AA C6 CB 39 7F 59 C1 AC 30 D2 8E C3 83 FD F1 B7 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B FF 54 4A 21 04 D5 B2 4A 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 C6 09 12 00 15 01 01 FF FF FF FF FF FF FF FF D8 4B 14 F3 8B 06 D6 21 FD DC 9A 0B 04 00 01 00 03 06 00 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 00 00 00 04 02 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 B6 C8 95 96 92 92 92 92 99 99 41 87 87 87 87 87 37 37 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 87 8E 42 79 7A F8 F8 F8 F8 D0 79 90 F9 F8 F8 F8 F8 D0 48 87 82 01 79 F8 90 7C F8 F8 F8 90 87 87 2E 8C 2E 87 01 79 D0 89 87 87 46 91 25 87 87 24 87 87 8C 23 87 87 4E 87 8A 87 87 4D 49 24 32 79 A0 CF 20 20 28 79 20 32 20 40 87 29 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 31 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 55 40 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 59 00 30 00 23 00 36 00 18 00 11 00 46 00 60 00 E7 00 06 01 18 00 57 00 68 00 1F 01 67 00 21 00 8A 00 27 00 BF 02 6E 00 87 00 15 00 AB 00 3A 01 60 00 22 00 26 00 1E 01 51 00 71 00 16 04 15 00 38 00 AD 00 1D 00 19 00 15 00 0C 00 44 01 35 00 5B 00 26 00 64 00 45 01 1A 00 17 01 15 00 F3 01 1D 00 13 00 28 02 60 00 26 01 15 00 60 00 26 01 40 00 99 01 72 01 1D 03 5E 03 1E 01 17 00 5F 02 6D 00 21 00 31 00 82 00 3D 00 10 00 51 06 08 00 9E 01 08 00 10 00 48 00 10 00 DE 01 48 00 08 00 28 00 88 00 10 00 88 00 AB 08 80 00 08 00 9C 00 23 00 10 00 00 00 00 0A 11 FE 15 00 8C 0A 00 05 10 88 05 0E 00 00";
        string Body1 = "8C 06 00 04 B6 88 04 B4 00 00 00 00 00 00 00 00 00 03 56 20 00 80 C6 09 40 4A 06 90 06 70 01 00 08 28 08 B8 E0 04 34 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 30 31 35 5F 5F 79 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 64 69 75 6D 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 55 46 5F 5F 53 6F 6C 72 00 66 2E 46 65 5F 41 6E 69 6D 42 50 00 88 2E 5F 43 00 6C 53 6B 69 6E 52 5F 30 35 2F 4D 61 69 61 6C 45 44 5F 43 6F 6D 6D 61 6E 64 6F 5F 42 52 30 35 00 85 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 00 0C 42 6F 6F 6C 16 62 53 75 70 70 73 43 6F 6C 6F 72 53 77 61 74 63 79 74 65 11 50 61 72 74 00 05 12 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 45 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 61 6C 00 15 46 6C 61 67 49 78 00 11 73 00 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 C9 0F 19 36 A1 14 CB 13 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 AA C6 CB 39 7F 59 C1 AC 30 D2 8E C3 83 FD F1 B7 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B FF 54 4A 21 04 D5 B2 4A 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 C6 09 12 00 15 01 01 FF FF FF FF FF FF FF FF D8 4B 14 00 F3 8B 06 D6 21 FD DC 9A 0B 04 01 01 00 03 06 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 04 02 80 05 01 08 01 00 00 00 00 00 00 00 00 00 80 1C 03 C5 42 02 02 02 02 05 05 D9 D3 C5 D3 C7 03 D3 C9 FF FD 3D D0 C6 C7 C5 D8 F8 FE FA 3D DC FF FD FF C7 C7 CF CF FF FD DB 01 CB CB CB 43 DF C7 C7 C4 1F DD CB D2 FD 1F C8 C8 CC ED D0 D2 C8 D8 CF FF F9 EC CA D0 D8 FE D2 E6 FB D2 EC DC F9 8C 8C D1 E0 DF C7 D0 D2 FA FF C5 7B C7 CC E0 D9 D8 EB F7 E3 D8 CA D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 9D E0 F5 FB 47 65 C8 35 67 00 00 5D 03 08 0B 0D 0E 09 00 09 0E 08 0F 08 06 0A 0E 00 0F 00 17 0F 09 02 1D 08 0F 17 06 0F 0D 03 12 08 0A 06 10 0E 16 09 09 2E 0D 00 05 05 09 0D 04 1C 0D 03 0E 0C 1D 02 1F 0D 1B 05 0B 10 08 1E 0D 08 11 1A 02 25 26 16 0F 02 19 17 05 09 09 0A 05 08 29 00 16 08 00 16 00 00 33 00 04 0B 08 00 00 39 02 27 00 15 01 06 08 33 09 16 01 44 44 06 54 0F 01 2D 01 04 00 08 04 5B 08 13 02 0F 13 09 03 03 08 00 01 02 04 05 07 0B 02 06 01 01 01 02 00 03 08 03 02 FF 05 06 00 0D 01 01 21 3D 0F 40 8E 85 80 62 C0 B0 52 01 08 C0 E0 50 4D 8A 13 62 3D 12 84 6A 41 A0 02 B0 01 C0 45 AD 10 98 09 32 20 AA 06 C4 40 14 55 7A 7B B0 2C 1C 0A 06 44";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("Jennifer"))
            //    return; 

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SparkleSpecialistEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }
            ActionButton.Image = Resources.RevertBtn;
            LogBox.Text += "\n[LOG] Converted!";
        }

        private void RevertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Revert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SparkleSpecialistEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }
            ActionButton.Image = Resources.ConvertBtn;
            LogBox.Text += "\n[LOG] Reverted!";
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();

            if (!File.Exists(SwapPath[0]))
            {
                Message FortnitePathExp = new Message(Resources.pakfileerror);
                FortnitePathExp.ShowDialog();
                return;
            }
            if (enabled)
                RevertBytes.RunWorkerAsync();
            else
                ConvertBytes.RunWorkerAsync();
        }

        private void ConvertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConvertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void RevertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RevertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }

        private void SkinImage_Click(object sender, EventArgs e)
        {

        }
    }
}
