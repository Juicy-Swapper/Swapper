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

namespace JuicySwapper.Items.Emotes
{
    public partial class Octane : Form
    {
        bool enabled = Settings.Default.OctaneEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Floss";

        public Octane()
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

        string Emote = "8C 0A 00 05 92 88 05 90 04 00 00 00 00 00 00 00 00 04 1F 00 20 04 80 54 08 40 00 00 00 5E 05 A0 05 60 01 00 07 28 07 70 88 07 46 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 43 75 73 74 6F 64 69 61 6C 5F 63 5F 43 4D 46 5F 4D 00 5C 2E 4D 4D 31 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 5F 00 43 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 45 2D 4C 00 61 2E 5D 00 13 2F 53 63 72 69 70 74 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 10 62 4D 6F 76 65 46 6F 72 77 61 72 64 4F 6E 6C 79 00 0C 69 6E 67 00 0C 42 6F 6F 6C 50 72 70 65 72 74 79 00 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 36 00 29 53 6F 75 72 63 65 31 36 2E 42 61 74 74 6C 65 50 61 73 73 2E 46 72 65 65 55 73 65 72 46 61 63 69 6E 67 46 6C 61 67 2E 54 72 61 76 65 72 73 61 6C 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0D 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0D 46 6C 6F 61 74 14 46 72 6F 6E 74 65 6E 64 50 72 65 76 69 65 77 53 63 61 6C 65 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 11 4C 61 72 67 65 49 6D 61 67 04 4E 6F 6E 00 07 50 61 63 6B 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 10 57 61 6C 6B 53 70 65 65 64 64 C1 00 00 00 00 77 62 E3 2D 51 85 41 AC 51 37 3D 1B B2 B4 8E 11 E3 74 4C 11 B7 3F 6B 1E 08 B2 98 59 FC 83 21 D9 17 F9 FE 2F 9C FE 30 7F 8E C9 40 AE 6D D9 6E 1F CD D1 05 1D CE 6C B5 88 6D 79 83 63 5D F2 9F E8 44 91 F8 50 2B 98 F8 6D 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F CE 80 53 49 06 22 AB 21 6D 6D 29 B9 A2 1E 30 CF DE 72 84 89 5C 9A 9C B3 AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 83 E6 4D 4D 51 4D 59 AB 9B 28 9E B7 C6 4E E4 0E B8 14 5D 32 AF A3 70 4B DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 BF 15 69 61 96 4A 52 5D B3 7D E9 93 04 5B 26 C2 D6 3C 55 A9 1E BB 6B 14 38 E3 B9 9D 86 14 08 13 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB DD CF 0B 7F 0B CA C2 D8 E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 54 08 33 01 1A 00 FF FF FF FF FF FF FF FF 2A C8 EA F1 87 8A CF 9C 0B 00 00 00 02 00 01 01 02 01 02 04 02 10 04 04 02 4A 06 02 05 05 01 01 00 00 34 42 03 00 01 80 3F 21 45 39 31 43 34 34 36 37 34 34 37 32 38 30 38 35 44 41 35 41 32 34 42 37 30 44 31 46 41 33 36 00 0C 00 00 00 43 6C 65 61 6E 20 53 77 65 65 70 00 08 46 42 45 43 37 39 31 45 31 38 44 39 34 41 43 45 41 37 30 41 38 44 33 32 39 31 36 44 33 00 06 42 38 30 30 39 36 32 31 31 46 39 42 43 46 34 42 42 43 39 32 41 43 39 38 46 35 35 00 10 54 69 64 79 20 61 73 20 79 6F 75 20 67 6F 2E 13 15 14 16 9A 99 19 3F 08 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C1 C0 96 96 92 92 92 92 99 5A 87 87 32 87 8D 87 37 42 87 79 F8 F8 F8 D0 79 B0 78 F0 F0 F0 E0 F9 F8 F8 F8 D8 F1 58 B9 87 87 87 87 4D 32 87 31 87 47 22 31 53 F9 F8 F8 F8 B8 7C F8 F8 F8 C8 79 E8 F9 F8 F8 F8 B8 78 D8 87 8A 87 46 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 87 25 2B 87 89 87 4F 30 2D 52 93 8F 55 BE 87 87 64 87 3F 87 87 7F D8 24 38 22 21 71 29 87 87 4D 87 87 87 5A 5A 87 6C 3E 94 8C 26 31 87 66 6E 2D 50 21 58 54 3D 25 00 30 32 B2 87 41 40 40 87 42 5C 99 B9 87 8E 91 87 51 6A 52 99 87 87 87 8D 87 87 87 6A 89 8E 87 87 8B 9F 30 70 92 8C 87 8E 8F 9B 87 87 29 39 39 B9 B9 5D 4D 00 30 00 0F 00 11 00 10 00 48 00 16 00 A6 00 5E 00 5F 00 33 00 95 00 94 00 0F 00 0E 00 45 00 47 00 63 00 61 00 15 00 83 00 16 00 91 00 1A 02 0B 00 E0 01 CF 01 E4 01 34 00 12 00 AD 00 23 02 57 02 5E 00 1B 00 1C 00 2B 00 72 00 E6 00 3C 01 0D 00 3F 01 55 01 DD 02 5E 00 03 01 94 01 0D 00 B7 01 44 00 0F 00 EE 01 C7 00 42 00 44 02 B0 00 41 00 10 00 0E 00 FE 01 61 05 EF 06 08 00 40 00 10 00 58 00 30 07 0C 00 2B 00 3A 00 15 00 3F 00 8A 04 78 00 43 08 C9 00 08 00 F1 00 00 00 00 FC 13 00 8C 0A 00 05 92 88 05 90";
        string Emote1 = "8C 06 00 05 75 88 05 73 04 00 00 00 00 00 00 00 00 04 25 00 20 04 80 54 08 40 00 00 00 5E 05 A0 05 60 01 00 07 28 07 70 88 46 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 43 75 73 74 6F 64 69 61 6C 5F 63 5F 43 4D 46 5F 4D 00 5C 52 68 79 6D 65 4C 6F 63 6B 2E 4D 4D 00 31 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 5F 00 43 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 49 63 6F 6E 73 54 2D 2D 2D 45 2D 45 2D 4C 00 61 2E 00 5D 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 00 10 62 4D 6F 76 65 46 6F 72 77 61 72 64 4F 6E 6C 79 00 0C 69 6E 67 00 0C 42 6F 6F 6C 50 72 6F 70 65 72 74 79 00 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 31 36 00 29 53 6F 75 72 63 65 2E 42 61 74 74 6C 65 50 61 73 46 72 65 65 55 73 65 72 46 61 63 69 6E 67 46 6C 61 67 2E 54 72 61 76 65 72 73 61 6C 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 0B 44 69 73 4E 0D 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0D 46 6C 6F 14 46 72 6F 6E 6E 64 50 72 65 76 69 65 77 53 63 61 6C 65 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 11 4C 61 72 67 65 49 6D 61 67 04 4E 6F 6E 65 00 07 50 61 63 6B 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 10 57 61 6C 6B 53 70 65 65 64 64 C1 77 62 E3 2D 51 85 41 AC 51 37 3D 1B B2 B4 8E 11 E3 74 4C 11 B7 3F 6B 1E 08 B2 98 59 FC 83 21 D9 17 F9 FE 2F 9C FE 30 7F 8E C9 40 AE 6D D9 6E 1F CD D1 05 1D CE 6C B5 88 6D 79 83 63 5D F2 9F E8 44 91 F8 50 2B 98 F8 6D 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F CE 80 53 49 06 22 AB 21 6D 6D 29 B9 A2 1E 30 CF DE 72 84 89 5C 9A 9C B3 AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 83 E6 4D 4D 51 4D 59 AB 9B 28 9E B7 C6 4E E4 0E B8 14 5D 32 AF A3 70 4B DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 BF 15 69 61 96 4A 52 5D B3 7D E9 93 04 5B 26 C2 D6 3C 55 A9 1E BB 6B 14 38 E3 B9 9D 86 14 08 13 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB DD CF 0B 7F 0B CA C2 D8 E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 54 08 33 01 1A 00 FF FF FF FF FF FF FF FF 2A C8 EA F1 87 8A CF 9C 0B 00 00 00 00 02 01 02 01 02 04 02 10 04 04 02 4A 06 02 02 05 02 04 05 01 01 34 42 03 01 80 3F 21 45 39 31 43 34 34 36 37 34 34 37 32 38 30 38 35 44 41 35 41 32 34 42 37 30 44 34 31 46 41 33 36 00 0C 00 00 00 4C 69 6C 27 20 4F 63 74 61 6E 65 00 08 46 39 42 45 43 37 39 31 34 45 31 38 44 39 34 41 43 45 41 37 30 41 38 44 33 32 34 36 44 33 00 06 42 38 30 30 39 36 34 32 31 31 46 39 42 43 46 34 42 42 43 39 42 32 41 43 39 38 46 35 33 35 00 10 42 79 20 4A 75 69 63 79 73 77 61 70 70 65 72 13 00 00 00 15 14 16 9A 99 19 3F 08 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 7E 58 03 03 02 02 02 02 05 05 DC D3 D3 DA FF 17 5C 50 CD 38 FC 3D 0D 38 44 56 DF D2 D3 43 DB CA D1 E3 3D FF DC 40 F9 E4 FE E0 38 DB 01 CB E0 C8 DF DE D3 CC C8 CB CB CF DF D0 CF E2 03 E3 17 40 03 EB D7 E3 38 CF C8 CB C9 F1 CD 83 DC 83 E7 E6 EF D7 03 CB D1 EB EF D3 DC D1 DC C9 DC D7 CB CA D3 D2 12 DB D8 D8 D7 DB D4 19 83 27 99 8C 0E CC 05 EF 43 47 D0 F0 02 07 CF 09 D7 15 15 D7 D1 00 00 50 08 07 09 08 00 0E 0E 15 0B 1B 1A 07 06 0D 0F 1E 00 04 0B 09 0D 0B 0E 06 1A 03 18 17 1C 11 0A 05 1B 1F 06 03 04 03 0A 0E 14 0B 17 1D 15 06 0B 1C 05 1F 0C 07 16 0F 0A 1C 08 09 08 23 06 16 2A 20 27 00 08 08 00 08 01 00 0D 07 22 00 3B 00 04 3E 00 00 3D 03 03 0D 18 05 16 06 34 36 1E 05 04 02 00 32 01 29 32 14 02 07 0D 03 11 00 14 02 00 0A 03 07 01 0B 12 01 01 0E 02 0D 08 03 01 08 0A 03 02 02 02 FF 05 06 02 10 00 2F 18 02 1B 0C 01 02 20 49 23 81 D2 80 55 AD 08 A8 B0 C7 DF 03 71 D0 04 BF 1A 80 30 4C 18 00 B8 C0 0D 08 80 F9 94 99 0B 0A 15 F1 96 A0 BA 18 C0 55 AC 81 43 00 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("BoogieDown"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[7], SwapPath[7], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.OctaneEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote added";
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[7], SwapPath[7], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.OctaneEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote removed";
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
            if (enabled == false)
            {
                Message EmoteMsg = new Message(Resources.emote);
                EmoteMsg.ShowDialog();
                ConvertBytes.RunWorkerAsync();
            }
            else
                RevertBytes.RunWorkerAsync();
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
