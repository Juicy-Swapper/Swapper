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
    public partial class Chicken : Form
    {
        bool enabled = Settings.Default.ChickenEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Chicken";

        public Chicken()
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

        string Emote = "8C 0A 00 05 34 88 05 32 04 00 00 00 00 00 00 00 00 03 C7 00 20 04 80 4B 08 40 00 00 00 63 05 A8 05 50 01 F8 06 20 07 68 07 80 07 4E 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 42 6C 6F 77 69 6E 67 42 75 62 62 6C 65 5F 5F 43 4D 46 5F 4D 00 68 2E 4E 4D 4D 36 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 73 00 48 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 4A 2D 4C 00 6B 2E 67 2E 00 13 2F 53 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 30 00 29 53 6F 75 72 63 65 31 30 2E 42 61 74 74 6C 65 50 61 73 73 2E 46 72 65 65 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 52 61 72 65 00 12 11 43 6F 6F 6C 64 6F 77 53 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 73 00 11 4C 61 72 67 50 72 65 76 69 65 77 49 6D 67 65 00 04 4E 6F 6E 65 00 07 50 61 63 6B 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 64 C1 78 11 90 2A 5F 60 23 7F 96 E4 78 2E 93 EA 48 F3 81 8C A9 E7 D1 37 17 E8 47 81 50 60 C5 88 E7 5E 0F 5B 51 3B 07 59 81 8E 4A A5 1F 51 B5 0B BF 83 8A DC 6A 30 A1 10 99 FA C2 3B 25 A2 6A C4 99 B7 25 6D C6 6F 8E E8 F7 64 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 27 92 74 FF AA 6A C3 EF AE 24 6F 9F 08 44 E5 F1 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 1B A9 7C F1 06 36 23 FB B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 4B 08 1C 01 18 00 FF FF FF FF FF FF FF FF 76 33 73 19 F1 41 50 A4 0B 00 00 00 02 00 01 18 04 04 02 3C 02 0D 06 02 02 0A 05 03 00 01 80 3F 02 21 39 33 30 39 36 37 35 37 34 32 44 32 45 32 37 46 34 38 34 46 37 45 38 45 46 30 30 36 32 36 35 00 10 00 00 00 20 08 33 31 35 34 39 44 38 31 34 31 33 34 37 33 46 32 45 33 34 34 38 42 33 38 43 42 35 30 44 44 45 06 00 35 31 32 34 46 39 30 34 39 33 41 35 35 41 30 41 43 35 34 42 34 42 42 45 46 46 33 42 34 37 34 00 0C 47 65 74 20 70 6F 70 70 69 6E 2E 00 10 12 11 08 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 BD C0 96 96 92 92 92 92 92 5A 87 87 32 87 8D 87 87 34 69 87 79 F8 F8 F8 F8 98 79 D8 F9 F8 F8 F8 F8 79 F0 F0 F0 F0 C0 F9 70 B9 87 87 87 87 74 33 87 31 87 47 22 31 7B F9 F8 F8 F8 E0 7C F8 F8 F8 F0 79 F8 98 F9 F8 F8 F8 E0 79 F8 8C 87 87 44 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 49 30 2D 52 93 8F 55 BE 87 87 87 87 79 D8 24 38 22 21 22 87 59 87 79 A0 29 8F 89 87 87 8F 49 59 5A 87 5C 8F 87 8A 87 27 39 31 87 66 6E 2D 50 21 58 4C 38 22 00 30 32 B2 87 41 40 40 87 42 5C 99 B9 87 56 6A 53 99 87 87 87 8E 87 3A 41 69 87 87 8B 87 8F 99 28 71 8D 87 87 87 9F 87 25 B9 39 B9 59 4C 00 30 00 0F 00 15 00 14 00 50 00 6A 00 BA 00 6A 00 3D 00 38 00 A6 00 A5 00 0F 00 0E 00 4A 00 4C 00 6D 00 1F 00 15 00 8D 00 16 00 9B 00 49 02 0B 00 03 02 F2 01 07 02 34 00 18 02 50 02 30 00 1B 00 1C 00 8D 00 E3 00 0D 00 E6 00 FC 00 0B 01 0D 00 C7 02 CA 00 0F 00 58 01 0D 00 16 00 0F 00 B2 00 BA 01 EC 00 4A 00 10 02 A2 00 41 00 10 00 0E 00 69 05 08 00 7E 01 08 00 40 00 10 00 58 00 28 07 0C 00 1F 00 2E 00 16 00 3B 03 3C 03 43 00 6E 03 7C 00 D8 00 08 00 E6 00 00 00 00 FE 0D 00 8C 0A 00 05 34 88";
        string Emote1 = "8C 06 00 05 16 88 05 14 04 00 00 00 00 00 00 00 00 03 DB 00 20 04 80 4B 08 40 00 00 00 63 05 A8 05 50 01 F8 06 20 07 68 07 80 4E 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 4E 6F 6F 64 6C 65 73 5F 5F 43 4D 46 5F 4D 68 2E 4D 4D 4D 36 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 49 44 5F 42 6C 6F 77 69 6E 67 42 75 62 62 6C 65 73 00 48 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 49 63 6F 6E 73 54 2D 2D 2D 45 2D 4A 2D 4C 00 00 6B 2E 67 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 00 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 31 30 00 29 53 6F 75 72 63 65 2E 42 61 74 74 6C 65 50 61 73 46 72 65 65 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 0B 44 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 52 61 72 65 00 12 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 61 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 65 00 04 4E 6F 6E 65 00 07 50 61 63 6B 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 64 C1 78 11 90 2A 5F 60 23 7F 96 E4 78 2E 93 EA 48 F3 81 8C A9 E7 D1 37 17 E8 47 81 50 60 C5 88 E7 5E 0F 5B 51 3B 07 59 81 8E 4A A5 1F 51 B5 0B BF 83 8A DC 6A 30 A1 10 99 FA C2 3B 25 A2 6A C4 99 B7 25 6D C6 6F 8E E8 F7 64 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 27 92 74 FF AA 6A C3 EF AE 24 6F 9F 08 44 E5 F1 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 1B A9 7C F1 06 36 23 FB B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 4B 08 1C 01 18 00 FF FF FF FF FF FF FF FF 76 33 73 19 F1 41 50 A4 0B 00 00 00 00 02 01 18 04 04 02 3C 02 0D 06 02 02 0A 05 03 01 80 3F 02 21 39 33 30 39 36 37 35 37 34 32 44 32 45 32 37 46 34 38 34 46 37 45 38 45 46 30 30 37 36 32 36 35 00 10 43 68 69 63 6B 65 6E 20 57 69 6E 67 20 49 74 00 08 33 31 35 34 39 44 38 31 34 31 33 34 37 33 46 32 45 38 33 34 34 38 42 33 38 43 42 35 30 44 44 45 00 06 00 35 31 32 34 46 37 39 30 34 39 33 41 35 35 41 30 41 43 35 34 42 34 42 42 45 46 46 33 42 34 37 34 00 0C 42 79 20 4A 75 69 63 79 20 20 20 00 10 12 11 00 00 00 00 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 79 58 03 03 02 02 02 02 02 05 DC D3 13 D5 DB CC FD F9 38 90 FC 3D 05 38 0D 38 15 CB D3 D3 43 DB CA D1 D7 D8 FD 12 FF D5 38 E0 D4 FD F5 38 54 DB 01 CB E0 C8 DF DE D3 CC C8 CB DF D0 CF E2 03 E3 17 40 03 E3 38 CF C8 CB C9 CA E7 C7 38 CD DF E5 E6 EF CB D5 D1 EB EF D3 DC D1 DC C9 DC D0 CA D3 52 12 DB D8 D8 D7 DB D4 15 A7 2D 0F CC 05 47 EF 07 CC F1 07 CB 15 15 0D D1 09 00 00 4D 08 07 06 03 00 08 0C 02 11 00 18 0D 07 06 19 0F 02 04 08 0E 00 05 13 0D 05 0E 06 2B 03 1B 1A 1F 1F 10 14 08 03 04 05 0B 02 0E 04 13 05 1F 02 07 10 05 13 07 0A 12 04 02 18 0A 09 08 2D 06 19 00 16 08 08 00 08 01 00 0E 0B 26 04 00 0C 00 00 33 03 03 0D 16 03 31 2F 3E 17 10 05 04 02 00 30 00 32 30 13 02 07 0D 03 06 02 00 0A 03 07 0C 01 01 05 05 1E 08 1B 0A 03 02 FF 05 06 02 0A 00 1F 0E 1F 1F 09 20 05 32 81 49 40 18 00 73 2A 31 3E 18 53 D7 40 C8 A1 C0 80 DE 16 00 68 03 A0 06 00 92 16 00 6C D0 1D 12 DF 23 00 AC E8 C0 67 89 40 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("Blow"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.ChickenEnabled = true;
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.ChickenEnabled = false;
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
    }
}