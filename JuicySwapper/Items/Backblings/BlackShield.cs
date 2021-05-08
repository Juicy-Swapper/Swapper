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

namespace JuicySwapper.Items.BackBlings
{
    public partial class BlackShield : Form
    {
        bool enabled = Settings.Default.BlackShieldEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "BlackShield";

        public BlackShield()
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

        string Backpack = "8C 0A 00 05 1E 88 05 1C 06 00 00 00 00 00 00 00 00 03 99 00 20 00 80 45 09 40 00 00 00 94 05 D8 05 68 01 40 07 78 07 08 08 30 08 18 67 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 4D 5F 4D 45 44 5F 57 65 67 61 6D 65 2F 4D 65 73 68 65 73 2F 53 4B 53 6B 65 6C 65 74 6F 6E 5F 41 6E 69 6D 42 6C 75 65 70 72 69 6E 74 00 93 2E 5F 43 00 4A 61 74 65 72 69 61 6C 6C 65 5F 43 6F 6D 6D 61 6E 64 6F 5F 42 52 5F 42 6C 63 6B 6B 6E 69 67 68 74 56 30 31 00 6A 2E 3B 65 73 68 53 68 69 65 6C 64 00 51 2E 47 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 4B 5F 3F 50 6C 61 79 65 72 2F 6F 6E 53 63 61 6C 65 53 65 74 74 69 6E 67 53 6F 75 72 63 65 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 16 41 74 74 61 63 68 6D 65 6E 74 76 65 72 72 69 64 65 10 53 6F 63 6B 65 74 4E 0B 5F 42 52 00 0C 42 79 65 11 54 79 70 65 00 05 1D 43 75 73 74 6F 6D 79 1B 13 00 1E 24 44 65 66 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 0B 49 6E 74 1D 0A 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 8A 53 78 0E 57 43 9D 64 AC 0E 58 32 1E CC 00 29 B2 9F 86 E9 BE CB 43 6E 14 64 46 E0 64 28 A1 3B ED 18 C1 06 15 C3 1E D5 45 F7 8D 34 8B 3D 8D 11 FB 67 1E BF DC 24 46 67 3A AD FE C7 DF A1 9E 94 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 BD A2 05 0B E9 03 BA FF 2E FE 00 0D 32 F2 44 33 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 02 05 01 D2 4E DB 4C 91 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 45 09 22 00 14 01 01 39 1F 9A 73 05 84 C6 2A 2E 8F 0B 00 00 00 04 00 01 01 25 EC F1 0E DB CE 96 A0 01 02 01 02 02 03 0F FD FF FF FF 02 01 02 08 02 04 02 04 02 05 03 03 03 05 80 05 01 03 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 B0 C0 96 96 92 92 92 92 92 92 41 87 87 87 87 87 87 4C 87 4B 40 87 87 87 83 01 79 F8 D8 7C F8 A0 27 87 87 8B 87 7E F8 F8 F8 F0 79 F8 90 F9 F8 A0 23 66 7A F8 F8 F0 79 B8 B1 87 53 5E 60 30 A9 21 79 90 27 4A 87 35 87 87 87 87 41 91 25 87 87 24 87 87 87 87 8C 2F 31 27 41 8F 49 69 36 47 51 28 31 48 40 28 F1 28 32 20 40 68 8C 7D E8 79 70 22 30 87 79 90 87 59 48 79 A0 42 32 87 4F 79 F8 59 7A 7D 98 FF 57 2F 50 41 40 87 92 30 22 7E 55 30 22 00 30 32 99 99 39 40 40 40 40 48 38 B9 39 40 40 40 40 87 42 5C 59 99 D9 87 62 3E 7C 90 87 26 79 5E 00 30 00 17 00 13 00 23 00 69 00 2A 00 95 00 0A 00 4C 00 6C 00 35 01 40 00 3D 00 53 00 0B 00 5C 00 DB 00 45 00 D9 00 49 00 32 00 48 00 54 00 15 00 65 00 1E 02 32 00 18 00 54 00 A1 00 45 00 13 01 6E 00 91 01 6E 00 66 00 1F 00 3F 00 63 00 1D 00 5C 00 15 00 0C 00 74 02 B8 00 5B 00 26 00 64 00 4D 01 1A 00 13 00 19 00 FD 00 15 00 82 00 42 00 4D 01 47 02 12 02 03 01 17 00 C7 01 5A 02 90 00 2F 00 3F 00 7E 04 56 03 3D 00 10 00 99 05 08 00 A6 01 08 00 10 00 58 00 38 00 50 00 10 00 7F 07 48 00 08 00 28 00 98 00 10 00 90 00 49 00 80 00 08 00 24 00 0E 00 4A 00 1E 00 64 00 00 00 00 0C FE 17 00 8C 0A 00 05 1E 88 05 1C 06 00 00 00";
        string Backpack1 = "8C 06 00 04 BF 88 04 BD 06 00 00 00 00 00 00 00 00 03 68 00 20 00 80 45 09 40 94 05 D8 05 68 01 40 07 78 07 08 08 30 08 18 67 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 4D 5F 4D 45 44 5F 57 65 67 2F 4D 65 73 68 53 4B 53 6B 65 6C 65 74 6F 6E 5F 41 6E 69 6D 42 6C 75 65 70 72 69 6E 74 00 93 2E 5F 43 00 4A 61 74 65 72 69 61 6C 6C 65 5F 43 6F 6D 6D 61 6E 64 6F 5F 42 52 5F 42 6C 6B 6E 69 67 68 74 6A 2E 3B 53 68 69 65 6C 64 51 2E 47 43 68 61 72 61 63 73 50 61 72 74 73 2F 4B 5F 56 30 31 00 3F 2F 50 6C 61 79 65 72 2F 6F 6E 53 63 53 65 74 74 69 6E 67 53 6F 75 72 63 65 00 13 2F 53 63 72 69 70 74 72 65 55 4F 62 6A 65 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 16 41 74 74 61 63 68 6D 65 6E 74 4F 76 65 72 72 69 64 65 10 53 6F 63 6B 65 74 4E 0B 42 52 00 0C 42 79 74 65 11 54 79 70 65 00 05 1D 43 75 73 74 6F 6D 79 1B 13 00 1E 24 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 17 45 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 0B 49 6E 74 1D 0A 15 46 6C 61 67 73 49 78 00 11 73 00 0C 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 8A 53 78 0E 57 43 9D 64 AC 0E 58 32 1E CC 00 29 B2 9F 86 E9 BE CB 43 6E 14 64 46 E0 64 28 A1 3B ED 18 C1 06 15 C3 1E D5 45 F7 8D 34 8B 3D 8D 11 FB 67 1E BF DC 24 46 67 3A AD FE C7 DF A1 9E 94 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 BD A2 05 0B E9 03 BA FF 2E FE 00 0D 32 F2 44 33 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 02 05 01 D2 4E DB 4C 91 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 45 09 22 00 14 01 01 00 67 39 1F 00 9A 73 05 84 C6 2A 2E 8F 0B 00 04 00 25 EC F1 0E DB CE 96 A0 01 02 01 02 02 03 0F 00 FD 00 08 02 04 02 04 02 05 03 03 03 05 80 05 01 03 01 00 00 00 00 00 00 00 00 00 84 18 03 C5 42 02 02 02 02 02 02 D9 C7 DC C7 DE D8 FF FD FF CB C7 CB FD FD D4 3D C4 C8 EF FD FD 11 C7 E1 E3 EC D0 0D FB CB DE C6 D3 C7 83 DA 01 CB CB CF D1 CB DD DF ED D3 DB 61 CC D1 DC D8 CC 2D D0 D2 C8 D8 EC FF F9 EC CA D0 FB E7 DC FD DA D2 DF FD E5 F9 FF C5 7B CB DC C7 CC E0 D9 D8 03 D0 CA F7 E3 D0 CA D3 52 05 05 D5 D8 D8 D8 D8 95 D5 15 92 98 D8 58 D8 57 05 E5 DD D8 60 EB 93 C5 F8 C5 CB F5 E7 20 01 94 00 4E 58 88 6D EF BC BE D5 B4 4A 59 0A AF DE D6 FB 03 48 14 00 75 44 CE 3D B2 79 4F E4 47 F9 BF 90 F8 57 5F 7A 5F 66 00 35 08 72 D9 22 CB 48 7F 36 15 AE 6B F1 63 90 9D B6 03 C6 1E 01 D4 0C C0 15 4E 63 5C 8F 44 89 6F FB BC 78 9A 90 F8 85 C6 00 00 34 03 28 02 15 56 18 01 11 04 0E 03 36 0B 11 03 2A 05 03 03 04 04 04 0C 04 02 0F 25 04 05 03 04 07 0B 06 05 02 0B 0D 02 01 00 00 01 06 03 02 FF 06 05 05 07 01 02 21 20 20 88 D0 35 11 02 23 70 20 55 42 C4 81 EE 48 03 67 06 20 00 18 4B CB 0A B6 00 00 08 12 40 A2 4A CD 5C 52 CF 7E 0E 44 54 59 88 29 1B 92 92 91 F9 1E A1 28 D0 00 44";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("DivaB"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[3], SwapPath[3], Backpack, Backpack1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.BlackShieldEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh added";
            }

            ActionButton.Image = Resources.RevertBtn;
            LogBox.Text += "\nConverted!";
        }

        private void RevertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Revert(SwapOffsets[3], SwapPath[3], Backpack, Backpack1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.BlackShieldEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh removed";
            }

            ActionButton.Image = Resources.ConvertBtn;
            LogBox.Text += "\nReverted!";
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
