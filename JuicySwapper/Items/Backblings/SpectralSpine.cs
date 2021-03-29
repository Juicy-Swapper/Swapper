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
    public partial class SpectralSpine : Form
    {
        bool enabled = Settings.Default.SpectralSpineEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "BlackShield";

        public SpectralSpine()
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

        string Backpack = "8C 0A 00 04 82 88 04 80 06 00 00 00 00 00 00 00 00 03 36 00 20 00 80 FD 08 40 00 00 00 7D 05 C0 05 30 01 F0 06 28 07 B8 07 E0 18 60 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 5F 46 5F 4D 45 44 5F 48 69 67 68 54 6F 77 65 72 4D 61 6E 67 6F 2F 46 58 2F 43 43 50 4D 5F 00 80 2E 5F 43 00 61 4D 65 73 68 65 73 2F 5F 50 61 63 6B 00 7C 2E 68 5F 41 6E 69 6D 42 50 00 8C 2E 5F 43 00 44 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 43 50 74 3F 50 6C 61 79 65 72 2F 43 6F 6D 6D 6F 6E 53 63 61 6C 65 53 65 74 74 69 6E 67 73 2F 4D 6F 75 72 63 65 00 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 16 41 74 74 61 63 68 6D 65 6E 74 4F 76 72 69 64 65 10 53 6F 63 6B 65 74 4E 0B 42 52 00 0C 42 79 74 50 72 6F 70 65 72 74 79 00 11 54 79 70 65 00 05 1A 1D 43 75 73 74 6F 6D 79 1B 13 00 24 44 65 66 61 75 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 0A 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 07 61 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 00 00 00 00 64 C1 00 00 00 00 3C BB AA B2 FA D7 0D 5F 4B 0D CC 17 0B A2 FB C3 7A 2D 47 16 B0 C6 F4 25 BA 84 C2 EF 1E 4E 1E 43 E6 D5 E9 81 B4 46 E5 B5 5A 41 2D 12 FD 35 9D D2 A9 D0 84 79 EF B0 E4 60 3A AD FE C7 DF A1 9E 94 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B EC 23 E2 60 0A 57 19 49 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 79 F1 D0 49 02 33 24 9A 2E FE 00 0D 32 F2 44 33 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 02 05 01 D2 4E DB 4C 91 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 FD 08 22 00 14 01 01 1F 09 2A 00 12 75 3C 45 1A E9 90 BC B3 0B 00 00 00 04 00 01 01 25 EC F1 0E DB CE 96 A0 01 02 01 02 02 03 0E FD FF FF FF 05 00 02 01 02 07 04 04 03 03 03 01 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 94 C0 96 96 92 92 92 92 92 99 41 87 87 87 87 46 87 87 8A 87 4F 78 82 01 79 F0 7C F8 F8 F8 A0 7F B0 87 01 79 E0 81 01 87 82 01 79 F8 98 34 87 53 56 72 A1 30 79 90 87 4E 87 87 21 8F 87 87 46 91 25 87 87 24 87 87 95 2C 31 27 49 8F 87 6B 36 79 E0 47 51 28 31 48 40 28 F1 28 8F 7B E8 79 70 22 30 87 79 90 87 59 48 79 A0 42 32 87 5C 54 37 48 21 25 87 87 87 26 7E 00 30 32 99 99 39 40 40 40 40 40 32 B2 B9 40 40 40 40 87 42 5C 59 99 D9 87 62 3E 7D 87 7C 4E 00 30 00 0A 00 27 00 21 00 62 00 1E 00 82 00 1D 00 63 00 7E 00 7E 00 6A 00 22 00 8E 00 0B 00 97 00 22 02 A1 02 46 00 45 00 0D 00 15 00 65 00 CC 00 23 00 18 00 45 00 CA 00 01 01 5F 00 02 01 D6 01 8A 00 82 00 1F 00 5B 00 47 00 1D 00 78 00 3B 00 26 00 44 00 3A 01 1A 00 13 00 19 00 F9 00 15 00 82 00 42 00 D3 01 56 01 DA 01 16 00 8D 02 5E 00 F4 02 42 00 EF 06 08 00 10 00 58 00 38 00 50 00 10 00 2F 07 08 00 28 00 98 00 10 00 90 00 49 00 80 00 08 00 24 00 0E 00 47 00 5C 00 00 00 00 05 06 06 0D FC 0C 00 8C 0A 00 04 82 88 04 80";
        string Backpack1 = "8C 06 00 04 81 88 04 7F 06 00 00 00 00 00 00 00 00 03 35 00 20 00 80 FD 08 40 00 00 00 7D 05 C0 05 30 01 F0 06 28 07 B8 07 E0 18 60 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 5F 46 5F 4D 45 44 5F 48 69 67 68 54 6F 77 65 72 5F 4D 61 6E 67 6F 2F 46 58 2F 43 43 50 4D 00 80 4D 53 74 72 65 65 74 44 65 6D 6F 6E 42 50 5F 5F 50 2E 5F 43 00 61 4D 65 73 68 65 7C 2E 00 00 00 68 5F 41 6E 69 6D 42 70 00 8C 44 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 43 50 74 00 3F 50 6C 61 79 65 72 2F 43 6F 6D 6D 6F 6E 53 63 61 6C 65 53 65 74 74 69 6E 67 73 2F 4D 6F 75 72 63 65 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 16 41 74 74 61 63 68 6D 65 6E 74 4F 76 65 72 72 69 64 65 10 53 6F 63 6B 65 74 4E 0B 42 52 00 0C 42 79 74 65 50 72 6F 70 65 72 74 79 00 11 54 79 70 65 00 05 1A 1D 43 75 73 74 6F 6D 79 1B 13 00 24 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 0A 0C 04 4E 6F 6E 65 00 0E 07 61 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 64 C1 3C BB AA B2 FA D7 0D 5F 4B 0D CC 17 0B A2 FB C3 7A 2D 47 16 B0 C6 F4 25 BA 84 C2 EF 1E 4E 1E 43 E6 D5 E9 81 B4 46 E5 B5 5A 41 2D 12 FD 35 9D D2 A9 D0 84 79 EF B0 E4 60 3A AD FE C7 DF A1 9E 94 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B EC 23 E2 60 0A 57 19 49 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 79 F1 D0 49 02 33 24 9A 2E FE 00 0D 32 F2 44 33 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 02 05 01 D2 4E DB 4C 91 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 FD 08 22 00 14 01 01 00 1F 09 2A 12 75 3C 45 1A E9 90 BC B3 0B 00 04 00 01 25 EC F1 0E DB CE 96 A0 01 02 01 02 02 03 0E FD FF FF FF 05 00 02 01 02 07 04 04 03 03 03 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 7C 58 03 03 02 02 02 02 02 05 D9 DB DF F8 FE CD DF C8 CF D0 D1 05 DD 38 D6 CD FD F3 E4 D8 FD F5 38 FF D7 FE D8 38 D4 EC D1 E3 E3 F3 09 CC FE DF CB DB 01 CB CB CF D1 CB DD EF D3 E5 38 DB E1 CC D1 DC D8 CC 35 C8 EB 38 D9 38 CC CA D0 FF E7 C8 CC C5 38 DA D2 E7 C9 DC D3 DC C9 CB CB F7 C8 8A D3 D2 05 05 D5 D8 D8 D8 D8 95 D2 55 55 58 D8 58 D8 57 05 E5 E5 E5 48 EB D7 D7 D9 EF 44 00 00 5C 08 02 09 09 0A 01 05 06 09 08 09 02 06 00 0A 0A 0C 0C 0B 03 06 0F 02 07 01 13 06 03 14 1A 1A 0E 0D 05 0D 0D 0E 0B 00 0D 02 09 07 0A 2D 02 0A 07 03 0F 05 11 03 0E 0C 12 08 0B 01 05 01 0D 05 0D 1B 11 1E 12 0E 2D 0B 2B 0A 1D 2D 00 08 00 00 08 08 00 00 08 08 00 04 04 07 04 00 00 00 00 2B 03 03 1F 1B 10 08 00 2B 02 49 01 49 04 50 07 01 01 00 0A 0C 19 02 0F 16 04 0F 03 04 08 05 00 05 08 04 02 18 03 FF 06 05 04 02 06 22 54 51 D7 75 76 88 DE CC 30 71 4F 75 13 33 1F B6 10 18 D2 03 09 79 00 50 00 0C 08 20 50 C1 9E AE 66 08 06 46 9C 09 FC 9F 28 98 0C CD FB 2A 20 A2 2A 40 00 00 00 00 00 00 00 00 00";

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
                Settings.Default.SpectralSpineEnabled = true;
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
                Settings.Default.SpectralSpineEnabled = false;
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
