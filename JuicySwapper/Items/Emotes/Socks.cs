﻿using JuicySwapper.Properties;
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
    public partial class Socks : Form
    {
        bool enabled = Settings.Default.SocksEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Socks";

        public Socks()
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

        string Emote = "8C 0A 00 05 89 88 05 87 04 00 00 00 00 00 00 00 00 04 06 00 20 04 80 A0 08 40 00 00 00 A3 05 E8 05 68 01 50 07 78 07 C0 D8 07 50 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 53 74 65 70 42 72 65 61 6B 64 61 6E 63 65 5F 5F 43 4D 46 5F 4D 00 6B 2E 4D 4D 36 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 73 2F 45 49 44 00 48 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 4A 2D 4C 00 6B 2E 67 2E 00 13 2F 53 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 44 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 32 53 6F 75 72 63 65 2E 53 68 6F 70 00 29 43 31 32 2E 42 61 74 74 6C 65 50 61 73 73 2E 50 61 69 64 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 52 61 72 65 00 12 11 43 6F 6F 6C 64 6F 77 53 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0B 49 6E 11 4C 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 00 04 4E 6F 6E 65 00 07 50 61 63 6B 0C 4C 6F 6F 70 73 00 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 64 C1 93 0A 20 FB D4 AB 31 5F FD C7 1E 5B D7 26 1A EA 47 1F E5 49 1A B0 BB 17 C2 CC FD A3 2F E3 46 2C 07 0C 92 42 5A 77 D2 40 AF 4D 2F 53 C9 82 C1 1E 98 6B 88 45 DE 6B A1 99 31 BE C7 80 7F C3 12 1F D2 7C F0 03 4A 69 2E 42 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 A2 F0 9F 7F D8 BE 95 89 9F 34 7B 25 3E 97 A2 09 99 BD 2F 88 61 99 ED 15 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 1D F6 C4 BF B6 76 4A 68 B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 DB 6F A3 73 A1 40 EA 11 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 0A 60 9C 4E 14 47 BD 21 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 A0 08 3B 01 19 00 FF FF FF FF FF FF FF FF D4 EF 8A 23 42 AF B7 A3 0B 00 00 00 02 00 01 19 04 01 02 02 02 3C 02 0D 06 02 02 0A 05 03 00 80 3F 02 21 35 39 39 44 35 35 44 35 34 31 42 32 35 31 30 31 41 44 42 36 34 34 38 41 38 41 42 41 42 39 39 33 00 0C 00 00 00 53 69 64 65 20 48 75 73 74 6C 65 00 08 35 38 43 44 44 45 42 35 34 45 38 32 37 38 43 45 38 41 35 31 41 34 35 39 43 30 33 36 37 37 00 06 00 37 31 46 43 43 36 43 44 46 43 39 32 35 34 38 44 45 38 42 38 39 45 31 43 33 42 41 35 37 38 54 68 65 20 77 68 6F 6C 65 20 77 6F 72 6C 64 27 73 20 6F 6E 20 79 6F 75 72 20 73 69 64 65 2E 20 10 12 11 13 08 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C7 C0 96 96 92 92 92 92 99 5A 87 87 32 87 8D 87 87 35 71 87 79 F8 F8 F8 F8 A8 79 D8 78 F0 F0 F0 F0 C0 F9 F0 F0 F0 F0 D0 F9 78 B9 87 87 87 22 7D 32 87 31 87 47 22 31 7B F9 F8 F8 F8 E0 7C F8 F8 F8 F0 79 F8 98 F9 F8 F8 F8 E0 79 F8 8C 87 87 44 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 49 30 2E 51 93 8F 63 27 7F 38 87 87 87 87 79 D8 24 38 22 21 22 87 59 87 79 A0 29 8F 89 87 87 8F 49 59 5A 87 6C 53 8A 87 8F 87 25 39 3F 31 87 66 6E 2D 50 21 58 4C 38 22 00 30 32 B2 87 41 40 40 87 42 5C 99 B9 87 87 7A 68 53 99 87 87 87 87 87 87 87 71 8F 87 87 87 9C 28 71 87 89 87 8E 87 2A 87 87 87 87 2C 39 39 B9 B9 59 52 00 30 00 0F 00 16 00 15 00 52 00 1B 00 BF 00 6D 00 2A 00 3E 00 38 00 A9 00 A8 00 0F 00 0E 00 4A 00 4C 00 6D 00 1F 00 15 00 8D 00 16 00 9B 00 4C 02 0B 00 03 02 F2 01 07 02 34 00 18 02 51 02 A2 00 1B 00 37 00 5F 00 1B 00 37 00 A8 00 FE 00 0D 00 01 01 17 01 26 01 0D 00 E2 02 E5 00 0F 00 73 01 0D 00 96 01 3E 00 0F 00 1D 00 CD 00 F0 01 07 01 58 00 46 02 7F 00 41 00 10 00 0E 00 A9 05 08 00 96 01 08 00 40 00 10 00 58 00 80 07 0C 00 22 00 FA 07 1A 00 3F 00 A3 03 78 00 25 00 D5 00 E1 00 08 00 05 01 00 00 00 FE 13 00 8C";
        string Emote1 = "8C 06 00 05 3E 88 05 3C 04 00 00 00 00 00 00 00 00 03 DC 00 20 04 80 A0 08 40 A3 05 E8 05 68 01 50 07 78 07 C0 D8 07 50 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 53 74 65 70 42 72 65 61 6B 64 61 6E 63 65 5F 5F 43 4D 46 5F 4D 00 6B 6F 63 6B 73 2E 45 00 00 00 00 00 00 00 00 00 00 00 00 4D 4D 36 74 68 65 6E 61 2F 49 74 65 6D 43 6F 73 6D 65 74 69 63 73 2F 44 49 44 00 48 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 49 63 6F 6E 73 54 2D 2D 2D 45 2D 4A 2D 4C 2D 4C 2E 67 13 2F 53 63 72 69 70 74 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 31 32 53 6F 75 72 63 65 2E 53 68 6F 70 00 29 31 32 2E 42 61 74 74 6C 65 50 61 73 50 61 69 64 00 22 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 65 00 12 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 0D 46 6C 6F 61 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0B 49 6E 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 65 00 04 4E 6F 6E 65 00 07 50 61 63 6B 0C 4C 6F 6F 70 73 00 06 0C 53 74 72 75 10 72 74 11 53 6C 12 53 6F 66 74 0E 0C 64 C1 93 0A 20 FB D4 AB 31 5F FD C7 1E 5B D7 26 1A EA 47 1F E5 49 1A B0 BB 17 C2 CC FD A3 2F E3 46 2C 07 0C 92 42 5A 77 D2 40 AF 4D 2F 53 C9 82 C1 1E 98 6B 88 45 DE 6B A1 99 31 BE C7 80 7F C3 12 1F D2 7C F0 03 4A 69 2E 42 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 A2 F0 9F 7F D8 BE 95 89 9F 34 7B 25 3E 97 A2 09 99 BD 2F 88 61 99 ED 15 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 1D F6 C4 BF B6 76 4A 68 B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 DB 6F A3 73 A1 40 EA 11 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 0A 60 9C 4E 14 47 BD 21 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 A0 08 3B 01 19 00 FF FF FF FF FF FF FF FF D4 EF 8A 23 42 AF B7 A3 0B 02 01 00 04 01 02 02 02 3C 02 0D 06 02 02 0A 05 03 80 3F 02 21 35 39 39 44 35 35 44 35 34 31 42 32 35 31 30 31 41 44 42 36 34 34 38 41 38 41 42 41 42 39 39 33 00 0C 08 35 38 43 44 44 45 42 34 35 34 45 38 32 37 38 43 45 38 41 35 31 41 34 35 39 43 30 33 36 37 37 00 06 00 37 31 46 43 43 36 43 44 34 46 43 39 32 35 34 38 44 42 38 39 38 45 31 43 33 42 41 35 37 38 50 75 74 20 69 6E 20 77 6F 72 6B 2E 20 42 79 20 4A 75 69 63 79 20 53 77 61 70 10 12 11 13 08 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 84 18 03 C5 42 02 02 02 02 05 E6 D3 D3 F1 FF D7 CC D0 FA D8 FF 3D 39 80 7C 15 83 CB C4 B6 D2 D3 43 DB CA D1 F7 3D D2 FC C8 FF 58 E4 FD FC FC C7 DB 01 CB DC CC C5 DF DE D3 CC C8 CF DF D0 CF E2 03 EB CB BB 94 43 C7 FF CB D4 CA C9 CA E7 C6 FF CD C7 DF E5 E6 EF E3 CB D5 D7 D1 C7 C5 EA C6 ED CF E0 C9 E4 C5 DC D4 CA D3 52 12 DB D8 D8 E7 F5 D6 FB EC E3 05 C7 E8 F1 07 CC F1 83 CF C7 C4 CC D5 D5 15 15 E5 20 01 94 00 4F 49 80 08 C5 1A 9C F4 C9 BF FB 59 23 2A 35 7A 55 03 10 14 00 B4 84 5C 43 8A 08 7C F6 A2 92 06 C0 72 55 D7 A1 4F B6 B7 05 92 55 20 3B C8 88 46 AF 98 D9 7A E2 81 39 39 CA 24 66 06 1F 8B DF 3E 85 65 DB E7 13 7B 29 2B 68 E5 B7 8B A6 0A 91 6A 00 00 3D 03 0D 1D 05 17 01 09 45 2E 0D 07 08 05 04 02 00 37 26 00 06 2E 05 02 05 08 02 03 0D 03 05 02 00 08 04 03 09 03 03 09 01 05 00 02 15 03 08 00 1B 04 01 02 FF 05 06 0B 00 1F 1E 0E 0A 17 00 04 3A 83 A0 18 81 93 13 47 BE 24 51 FE 10 D0 03 17 11 B3 3E 5D 00 AA 0F 13 7F 60 32 00 9F 9B 48 BC 08 AB 06 00 AE 1E 32 20 43 1D 00 68 45 15 07 12 C0 2C 88 40 6B 01 08 44";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("SideHustle"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SocksEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote added";
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SocksEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote removed";
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
