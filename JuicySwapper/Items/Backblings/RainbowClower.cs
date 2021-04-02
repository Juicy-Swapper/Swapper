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
    public partial class RainbowClover : Form
    {
        bool enabled = Settings.Default.RainbowCloverEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Rainbow Clover";

        public RainbowClover()
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

        string Backpack = "8C 0A 00 04 84 88 04 82 06 00 00 00 00 00 00 00 00 03 31 00 20 00 80 57 09 40 00 00 00 D7 05 18 06 30 01 48 07 80 07 10 08 38 08 18 6E 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 46 5F 4D 45 44 5F 4D 65 63 68 61 6E 69 63 61 6C 5F 45 6E 67 69 6E 65 65 72 5F 42 61 63 6B 2F 46 58 2F 43 43 50 4D 5F 00 98 2E 5F 43 00 69 4D 65 73 68 65 50 00 88 2E 46 70 5F 41 6E 69 6D 42 50 00 98 2E 5F 43 00 48 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 43 50 41 50 6C 61 79 65 72 2F 43 6F 6D 6D 6F 6E 53 63 61 6C 65 53 65 74 74 69 6E 67 73 2F 46 65 6D 6F 75 72 63 65 00 13 53 63 72 69 70 74 2F 43 6F 65 55 4F 62 6A 65 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 16 41 74 74 61 63 68 6D 65 6E 74 4F 76 72 69 64 65 10 53 6F 63 6B 65 74 4E 0B 42 52 00 0C 42 79 74 65 50 72 6F 70 65 72 74 79 00 11 54 79 70 65 00 05 1E 43 1D 43 75 73 74 6F 6D 79 1B 13 00 24 44 65 66 61 75 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0C 0F 50 65 72 6D 69 74 74 65 64 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 07 61 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 6C 65 74 61 6C 00 12 53 6F 66 74 00 00 64 C1 95 FA D5 C1 9B A7 E9 DA C4 D8 60 93 69 16 CA BD A0 9C B9 3B FF 4B 18 38 E9 BC F5 16 00 17 AE 7A 2B B5 D6 C4 11 6D E4 6D 54 C8 E5 88 6A 22 2C 03 7B 11 14 8F 45 09 66 F1 13 02 D3 CD B3 4C E2 04 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 8E 78 8A FA 6A 71 D9 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 F4 70 4F FF 64 4C DA A9 79 F1 D0 49 02 33 24 9A DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 93 9F 1A E0 9A 04 84 BE 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 57 09 22 00 14 01 01 79 2A 12 87 0F B2 7B 1A 86 19 9E 0B 00 00 00 04 00 01 01 A4 7F E4 7F 78 3C 94 DA 01 02 01 02 02 03 0E FD FF FF FF 05 00 02 01 02 07 04 04 03 03 03 01 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 95 C0 96 96 92 92 92 92 92 92 41 00 20 87 49 79 D0 82 01 79 F8 C8 7C F8 F8 F8 C0 7D E8 99 82 01 7A F8 81 01 87 82 01 79 F8 B8 34 87 53 56 4A 58 48 79 90 87 4E 87 87 23 8F 87 8A 8E 43 91 25 87 87 24 87 87 95 2C 31 27 49 87 87 6C 36 7A F8 47 51 28 31 48 40 28 F1 28 8F 7B E8 79 70 22 30 87 79 90 87 59 48 79 A0 42 6A 31 87 57 37 48 21 25 87 87 8F 25 7E 24 00 90 00 30 32 99 99 39 40 40 40 40 40 39 B9 39 40 40 40 40 87 42 5C 59 99 D9 87 62 3E 7D 87 7C 51 00 30 00 24 00 11 00 34 00 70 00 28 00 9A 00 2A 00 6B 00 8A 00 8A 00 72 00 26 00 9A 00 0B 00 A3 00 8C 00 59 00 E5 02 4A 00 49 00 0F 00 15 00 67 00 D2 00 23 00 18 00 45 00 D0 00 07 01 5F 00 08 01 EC 01 8E 00 86 00 1F 00 5F 00 4B 00 1D 00 7C 00 3B 00 26 00 44 00 3E 01 1A 00 13 00 19 00 FD 00 15 00 82 00 C8 01 50 00 5C 01 E0 01 16 00 99 02 60 00 08 03 42 00 DF 05 47 07 08 00 10 00 58 00 38 00 50 00 10 00 87 07 48 00 08 00 28 00 98 00 10 00 90 00 49 00 80 00 08 00 24 00 0E 00 47 00 5C 00 00 00 00 00 13 0E 0E 15 4F 91 8C 0A 00 04 84 88";
        string Backpack1 = "8C 06 00 04 69 88 04 67 06 00 00 00 00 00 00 00 00 03 27 00 20 00 80 57 09 40 00 00 00 D7 05 18 06 30 01 48 07 80 07 10 08 38 08 18 6E 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 4D 5F 4D 45 44 5F 4C 75 63 6B 79 5F 52 69 64 65 72 2F 46 58 2F 42 50 00 98 2E 5F 43 69 4D 65 73 68 65 88 2E 70 2F 5F 41 6E 69 6D 42 6C 75 65 70 72 69 6E 74 98 48 43 68 61 72 61 63 74 65 72 50 61 72 74 43 4D 65 63 68 61 6E 69 63 61 6C 45 6E 67 69 6E 65 65 72 00 41 50 6C 61 79 65 72 2F 43 6F 6D 6D 6F 6E 53 63 61 6C 65 53 65 74 74 69 6E 67 65 6D 6F 75 72 63 65 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 16 41 74 74 61 63 68 6D 65 6E 74 4F 76 65 72 72 69 64 65 10 53 6F 63 6B 65 74 4E 0B 42 52 00 0C 42 79 74 65 50 72 6F 70 65 72 74 79 00 11 54 79 70 65 00 05 1E 1D 43 75 73 74 6F 6D 79 1B 13 00 24 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0C 0F 50 65 72 6D 69 74 74 65 64 00 0C 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 61 67 65 00 15 4D 6F 64 69 66 69 65 72 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 00 00 64 C1 95 FA D5 C1 9B A7 E9 DA C4 D8 60 93 69 16 CA BD A0 9C B9 3B FF 4B 18 38 E9 BC F5 16 00 17 AE 7A 2B B5 D6 C4 11 6D E4 6D 54 C8 E5 88 6A 22 2C 03 7B 11 14 8F 45 09 66 F1 13 02 D3 CD B3 4C E2 04 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 73 8E 78 8A FA 6A 71 D9 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 F4 70 4F FF 64 4C DA A9 79 F1 D0 49 02 33 24 9A DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 93 9F 1A E0 9A 04 84 BE 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 57 09 00 22 00 14 01 01 00 79 2A 12 87 0F B2 7B 1A 86 19 9E 0B 00 04 00 01 A4 7F E4 7F 78 3C 94 DA 01 02 01 02 02 03 0E FD FF FF FF 05 00 02 01 02 07 04 04 03 03 03 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 7A 58 03 03 02 02 02 02 02 02 D9 DF DF E8 D4 FD FD D5 38 16 38 80 38 FD EB 38 EC FD FD C8 FE CF FD E4 38 F0 CC 51 83 DC 43 E0 E5 FF DF 87 CA 83 DA 01 CB CB CF D1 CB DD EF D3 F5 38 DB E1 CC D1 DC D8 CC 35 C8 EB 38 D9 38 CC CA D0 FF E7 C8 CC C5 38 DA EE D1 CB DC D3 DC CB E3 CB F7 CB CF D3 05 05 D5 D8 D8 D8 D8 95 D5 15 D5 98 D8 58 D8 57 05 E5 E5 E5 48 EB D7 D7 D9 EF 44 00 00 55 08 04 07 0C 06 00 08 00 02 14 04 03 0E 00 03 00 09 12 02 1F 03 2C 16 02 01 07 0D 0F 03 0B 00 0D 08 0F 07 10 25 06 0E 07 07 03 05 1B 03 0E 0C 16 08 0B 01 05 05 0D 05 10 0B 17 14 18 0E 0D 20 2F 0A 26 2D 00 08 00 00 08 08 00 00 00 08 08 00 04 04 07 04 00 00 00 00 2D 03 03 30 03 00 45 2B 02 4C 16 4C 0B 5A 06 01 11 00 0A 09 15 02 0F 16 04 0F 03 04 08 05 00 05 08 04 07 05 06 03 01 FF 00 06 05 04 02 06 20 56 96 78 69 0B 20 68 E2 AA EA 26 66 3F 6A 50 10 DC 03 00 80 20 35 00 00 40 5E 12 15 18 96 35 C3 60 60 C4 A1 40 F0 13 05 04 44 70 60 02 21 42";

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
                Settings.Default.RainbowCloverEnabled = true;
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
                Settings.Default.RainbowCloverEnabled = false;
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
