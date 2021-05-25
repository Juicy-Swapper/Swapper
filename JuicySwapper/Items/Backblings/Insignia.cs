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
    public partial class Insignia : Form
    {
        bool enabled = Settings.Default.InsigniaEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Insignia";

        public Insignia()
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

        string Backpack = "8C 0A 00 04 85 88 04 83 06 00 00 00 00 00 00 00 00 03 36 00 20 00 80 EB 08 40 00 00 00 6B 05 B0 05 30 01 E0 06 18 07 A8 07 D0 18 5C 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 5F 46 5F 4D 45 44 5F 52 61 69 64 65 72 5F 53 69 6C 76 65 72 2F 46 58 2F 43 43 50 4D 00 7A 2E 5F 43 00 5D 4D 65 73 68 65 73 2F 5F 50 61 63 6B 00 76 2E 64 5F 41 6E 69 6D 42 50 00 86 2E 46 5F 43 00 48 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 43 50 5F 46 65 6D 61 6C 65 00 41 50 6C 61 79 65 72 2F 43 6F 6D 6D 6F 6E 53 63 61 6C 65 53 65 74 74 69 6E 67 73 2F 53 6F 75 72 63 65 00 13 2F 53 63 72 69 70 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 16 41 74 74 61 63 68 6D 65 6E 74 4F 76 72 69 64 65 10 53 6F 63 6B 65 74 4E 0B 42 52 00 0C 42 79 74 65 50 72 6F 70 65 72 74 79 00 11 54 79 70 65 00 05 1E 43 1D 43 75 73 74 6F 6D 79 1B 13 00 24 44 65 66 61 75 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0C 0F 50 65 72 6D 69 74 74 65 64 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 07 61 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 6C 65 74 61 6C 00 12 53 6F 66 74 4F 64 C1 D2 51 DE 50 91 63 34 69 91 25 B5 AB 7F 15 B9 12 9F 85 EC 55 83 07 43 7A 64 A7 15 45 8E E8 E3 EC 04 05 76 E4 1E C1 C9 CC 7D AB 3B 73 43 04 EE 91 1F 4E E8 67 39 BD 6C 73 13 02 D3 CD B3 4C E2 04 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 3A 77 22 D7 33 6B C6 D4 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 F4 70 4F FF 64 4C DA A9 79 F1 D0 49 02 33 24 9A DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 93 9F 1A E0 9A 04 84 BE 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 EB 08 22 00 14 01 01 0D 09 2A 00 12 A2 B5 DD 4B C2 73 8B 94 0B 00 00 00 04 00 01 01 A4 7F E4 7F 78 3C 94 DA 01 02 01 02 02 03 0E FD FF FF FF 05 00 02 01 02 07 04 04 03 03 03 01 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 93 C0 96 96 92 92 92 92 92 99 41 87 87 87 87 46 87 87 87 4F 70 82 01 79 E0 7C F8 F8 F8 90 7F A0 87 01 79 D0 81 01 87 82 01 7A F8 34 87 53 56 7B 30 87 79 90 87 4E 87 37 87 8F 87 47 91 25 87 87 24 87 87 95 2C 31 27 49 87 87 6C 36 7A F8 47 51 28 31 48 40 28 F1 28 8F 7B E8 79 70 22 30 87 79 90 87 59 48 79 A0 42 6A 31 87 57 37 48 21 25 87 87 8F 25 6F 38 22 00 30 32 99 99 39 40 40 40 40 40 32 B2 B9 40 40 40 40 87 42 5C 59 99 D9 87 62 3E 7D 87 7C 50 00 30 00 0A 00 2F 00 1F 00 5E 00 1C 00 7C 00 1B 00 5F 00 78 00 78 00 66 00 20 00 88 00 0B 00 91 00 0C 02 52 00 4A 00 49 00 3D 00 15 00 67 00 D2 00 23 00 18 00 45 00 D0 00 07 01 5F 00 08 01 DA 01 8E 00 86 00 1F 00 5F 00 4B 00 1D 00 7C 00 3B 00 26 00 44 00 3E 01 1A 00 13 00 19 00 FD 00 15 00 82 00 C8 01 50 00 5C 01 E0 01 16 00 99 02 60 00 FC 02 42 00 71 05 08 00 6E 01 08 00 10 00 58 00 38 00 50 00 10 00 1F 07 08 00 28 00 98 00 10 00 90 00 49 00 80 00 08 00 24 00 0E 00 47 00 5C 00 00 00 00 01 02 02 09 FE 09 00 8C 0A 00 04 85";
        string Backpack1 = "8C 06 00 04 3E 88 04 3C 06 00 00 00 00 00 00 00 00 03 01 00 20 00 80 EB 08 40 6B 05 B0 05 30 01 E0 06 18 07 A8 07 D0 18 5C 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73 2F 5F 46 5F 4D 45 44 5F 52 61 69 64 65 72 5F 53 69 6C 76 65 72 2F 7A 5D 4D 57 65 67 2F 4D 65 73 68 53 4B 76 2E 64 5F 50 41 6E 69 6D 42 50 00 86 2E 5F 43 00 48 43 68 61 72 61 63 74 65 72 73 50 61 72 74 50 46 65 6D 61 6C 65 00 41 2F 50 6C 61 79 2F 43 6F 6D 6D 6F 6E 53 63 53 65 74 74 69 6E 67 73 2F 53 6F 75 72 63 65 00 13 2F 53 63 72 69 70 74 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 16 41 74 74 61 63 68 6D 65 6E 74 4F 76 72 10 53 6F 63 6B 65 74 4E 0B 42 52 00 0C 42 79 74 65 50 72 6F 70 65 72 74 79 00 11 54 79 70 65 00 05 1E 1D 43 75 73 74 6F 6D 79 1B 13 00 24 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 00 17 72 3A 3A 42 6F 74 68 00 13 1D 3A 3A 00 0C 0F 50 65 72 6D 69 74 74 65 64 00 0C 04 4E 6F 6E 07 61 67 65 00 15 4D 6F 64 69 66 69 6C 75 65 70 72 69 6E 74 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 C1 D2 51 DE 50 91 63 34 69 91 25 B5 AB 7F 15 B9 12 9F 85 EC 55 83 07 43 7A 64 A7 15 45 8E E8 E3 EC 04 05 76 E4 1E C1 C9 CC 7D AB 3B 73 43 04 EE 91 1F 4E E8 67 39 BD 6C 73 13 02 D3 CD B3 4C E2 04 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A 08 6D 4B 9A BF 54 81 9D 68 6B D9 FC 1E 42 D2 E4 D5 10 24 47 94 81 8E B2 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 3A 77 22 D7 33 6B C6 D4 7E 9C 6B 66 96 76 3C A1 4C 67 97 74 97 39 A5 A7 74 99 E8 86 03 41 76 C6 B6 D2 55 B3 00 74 90 86 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 D0 79 CB 7A 95 F4 BB 67 F4 70 4F FF 64 4C DA A9 79 F1 D0 49 02 33 24 9A DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 4F 4E C3 25 20 6E B7 70 7E A2 42 63 10 83 7A 73 93 9F 1A E0 9A 04 84 BE 89 7D 34 70 A0 29 88 55 18 69 40 56 99 65 CF 69 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 EB 08 22 00 14 01 01 00 0D 09 2A 12 A2 B5 DD 4B C2 73 8B 94 0B 00 04 01 A4 7F E4 7F 78 3C 94 DA 01 02 01 02 02 03 0E 00 FD 05 07 04 04 03 03 03 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 7B 18 03 C5 42 02 02 02 02 02 05 D9 DB DB FC FD 7C FD CD C7 DC C7 DE D4 F0 3D FD D0 FD D4 FC CA FF FD D3 E3 E3 C4 DD D4 D0 FB 43 DF C6 D3 C7 DB 01 CB CB 03 C5 CC D1 CB DD EF D3 FD DB E1 CC D1 DC D8 CC 2D D0 FF F9 EC CA D0 C7 FA E7 DC FD DA EE D1 C7 E0 C7 D0 DC C9 CB C7 CB F3 D8 C9 D3 52 05 05 D5 D8 D8 D8 D8 95 D2 55 55 58 D8 58 D8 57 05 05 F9 DC E0 EB 93 C5 F9 C4 EF 44 20 01 78 00 45 49 40 08 88 F4 62 97 A4 9A C9 EF 36 81 B0 12 00 9A 35 03 CA 8C 12 8E 3C AC 2D 29 7E 3F F4 0B F8 AB 03 D2 11 6E 4B BB B4 0C 6E 4B F5 8A C9 77 3F 01 12 09 00 80 93 F1 AE 76 DA 31 D5 BA D3 29 F7 8A 06 FB 54 44 00 00 31 03 1F 12 06 4C 0D 10 00 02 3F 0F 2D 02 05 53 0E 01 07 01 06 01 04 06 0C 08 02 0F 10 04 0F 03 0E 04 08 0B 00 06 02 08 01 02 03 0F 03 FF 06 05 05 03 00 07 22 16 20 AC 3C A2 18 60 9F 82 05 1C 47 42 0C 32 C1 7E 59 95 02 24 8C D4 00 08 03 36 61 00 A6 73 2B 74 0F 31 13 75 AD 38 B4 44 88 02 42 0E 0A C0 6A 44";

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
                Settings.Default.InsigniaEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh added";
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[3], SwapPath[3], Backpack, Backpack1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.InsigniaEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh removed";
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
