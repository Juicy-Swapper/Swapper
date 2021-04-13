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
    public partial class FlossArmWave : Form
    {
        bool enabled = Settings.Default.FlossArmWaveEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Floss";

        public FlossArmWave()
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

        string Emote = "8C 0A 00 05 47 88 05 45 06 00 00 00 00 00 00 00 00 03 D8 00 20 04 80 72 08 40 00 00 00 91 05 D8 05 48 01 20 07 07 90 A8 04 42 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 41 72 6D 57 61 76 65 5F 5F 43 4D 46 5F 4D 00 56 2E 4D 4D 4E 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 72 73 2F 43 49 44 5F 35 37 30 5F 5F 43 6F 6D 61 6E 64 6F 5F 4D 5F 53 6C 75 72 70 4D 6F 6E 73 74 65 72 00 75 2E 2F 44 61 6E 63 65 73 2F 45 49 44 00 41 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 43 2D 4C 00 5D 2E 59 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 31 00 29 53 6F 75 72 63 65 31 2E 42 61 74 74 6C 65 50 61 73 73 2E 50 61 69 64 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0B 11 43 6F 6F 6C 64 6F 77 53 65 63 73 00 0D 46 6C 6F 61 74 50 72 6F 70 65 72 74 79 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0F 50 72 65 76 69 65 77 48 65 72 6F 00 11 4C 61 72 67 65 49 6D 61 67 65 00 04 4E 6F 6E 00 07 50 61 63 6B 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 00 64 C1 73 92 58 CC B8 CD 2B EC D2 AB B0 21 75 BA 78 6B 5F A3 9E 75 FA D7 E2 4A A2 F2 36 48 42 88 9E DD C8 84 AB AD AA 86 B9 A0 4B 0F 00 0A 2A 6C 93 C1 86 96 5D 61 46 70 55 0A 1D 2A 82 74 32 56 2A B5 BC 29 81 C2 B4 50 B7 D3 5C 1C 37 26 FE 76 35 FF FB 75 B4 BD 11 8C CD 28 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 D5 C2 A9 DE 74 F6 43 98 61 FB 58 04 59 A9 E4 87 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 1B 5A A0 1A 39 33 3E 2E B3 7D E9 93 04 5B 26 C2 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 9B 35 32 61 EC 52 A6 80 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 72 08 26 01 18 00 FF FF FF FF FF FF FF FF 13 A2 E4 67 21 58 2F 80 0B 00 00 02 00 01 19 04 04 02 2B 02 1E 06 02 02 0A 05 03 00 01 80 3F 05 00 21 00 33 44 46 32 39 41 46 45 34 41 42 38 31 45 35 34 43 42 32 33 34 37 38 42 32 37 38 44 32 35 41 39 00 07 57 61 76 79 20 54 08 30 33 39 34 38 43 46 43 37 36 41 44 39 35 39 35 38 38 38 41 32 31 38 36 34 39 31 39 37 00 06 32 33 43 39 36 37 30 34 34 31 33 32 42 32 41 35 35 42 41 45 43 36 39 36 43 41 35 30 35 39 35 00 14 53 74 72 69 6B 65 20 61 20 77 70 6F 73 65 2E 00 12 14 13 00 00 0A 09 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C5 C0 96 96 92 92 9A 91 99 99 41 87 87 32 87 8D 87 B5 39 87 79 F8 F8 F8 B0 79 A0 78 F0 F0 F0 C0 F9 F8 F8 F8 B8 F1 48 B9 87 87 87 97 87 34 8C 87 87 7F F8 F8 F8 F8 98 79 F8 C8 F9 F0 87 43 32 87 31 87 47 22 31 43 F9 F8 F8 F8 A8 7C F8 F8 F8 B8 79 D8 F9 F8 F8 F8 A8 79 C8 89 87 87 46 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 49 30 2D 52 93 8F 55 BE 89 87 87 87 7E D8 24 38 22 21 61 29 8F 87 87 5F 5A 87 6C 21 87 87 3C 87 8B 26 31 87 66 6E 2D 50 21 58 4C 40 23 00 30 32 B2 87 41 40 40 87 4A 5B 99 B9 87 56 6A 7C A8 91 87 87 87 87 9F 8E 69 8A 8D 87 8D 87 9D 28 78 87 87 87 8D 9F 87 23 26 B9 B9 A9 DB 49 00 30 00 0F 00 0E 00 44 00 14 00 9C 00 58 00 2A 00 50 00 77 00 FE 00 31 00 54 01 53 01 0F 00 0E 00 43 00 45 00 5F 00 FF 00 15 00 7F 00 16 00 8D 00 CD 02 0B 00 D2 01 C1 01 D6 01 34 00 E7 01 E0 02 30 00 1B 00 1C 00 8D 00 E3 00 0D 00 E6 00 FC 00 76 02 A3 00 23 01 0D 00 46 01 8A 00 12 00 0F 00 8E 01 C0 00 42 00 E4 01 AB 00 41 00 10 00 0E 00 98 05 08 00 76 01 08 00 40 00 10 00 58 00 B8 01 0C 00 1F 00 2E 00 41 00 3A 00 65 03 73 00 7C 00 E2 00 00 00 00 FE 0B 00 8C 0A 00";
        string Emote1 = "8C 06 00 05 27 88 05 25 06 00 00 00 00 00 00 00 00 03 DD 00 20 04 80 72 08 40 00 00 00 91 05 D8 05 48 01 20 07 07 90 A8 04 42 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 41 72 6D 57 61 76 65 5F 5F 43 4D 46 5F 4D 00 56 46 6C 6F 73 73 44 61 6E 63 65 5F 4D 2E 4D 4E 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 74 69 63 73 2F 43 68 61 72 61 63 72 73 2F 43 49 44 5F 35 37 30 5F 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 53 6C 75 72 70 4D 6F 6E 73 74 65 72 00 75 2E 2F 73 2F 45 49 44 00 41 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 49 63 6F 6E 73 54 2D 2D 2D 45 2D 43 2D 4C 00 5D 2E 59 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 00 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 31 31 00 29 53 6F 75 72 63 65 2E 42 61 74 74 6C 65 50 61 73 50 61 69 64 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 0B 44 69 73 4E 0B 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0D 46 6C 6F 61 74 50 72 6F 70 65 72 74 79 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0F 50 72 65 76 69 65 77 48 65 72 6F 00 11 4C 61 72 67 65 49 6D 61 67 04 4E 6F 6E 65 00 07 50 61 63 6B 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 00 00 00 64 C1 73 92 58 CC B8 CD 2B EC D2 AB B0 21 75 BA 78 6B 5F A3 9E 75 FA D7 E2 4A A2 F2 36 48 42 88 9E DD C8 84 AB AD AA 86 B9 A0 4B 0F 00 0A 2A 6C 93 C1 86 96 5D 61 46 70 55 0A 1D 2A 82 74 32 56 2A B5 BC 29 81 C2 B4 50 B7 D3 5C 1C 37 26 FE 76 35 FF FB 75 B4 BD 11 8C CD 28 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 D5 C2 A9 DE 74 F6 43 98 61 FB 58 04 59 A9 E4 87 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 1B 5A A0 1A 39 33 3E 2E B3 7D E9 93 04 5B 26 C2 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 9B 35 32 61 EC 52 A6 80 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 72 08 26 01 18 00 FF FF FF FF FF FF FF FF 13 A2 E4 67 21 58 2F 80 0B 00 00 00 00 02 01 19 04 04 02 2B 02 1E 06 02 02 0A 05 03 01 80 3F 05 00 21 33 44 46 32 39 41 46 45 34 41 42 38 31 45 35 34 43 42 32 33 34 37 38 42 32 37 38 44 32 35 41 39 00 07 08 30 33 46 39 34 38 43 46 34 43 37 36 41 44 39 35 39 35 38 38 38 37 41 32 31 38 36 34 39 31 39 37 00 06 32 33 43 39 36 37 30 34 34 31 33 32 42 32 41 35 35 42 41 45 43 36 39 36 43 41 38 35 30 35 39 35 00 14 42 79 20 4A 75 69 63 79 20 53 77 61 70 70 65 72 2E 20 20 00 12 14 13 00 00 0A 09 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 7C 58 03 03 02 02 06 01 05 05 D9 D3 13 D5 FF D0 C3 38 D4 FC 3D 15 83 43 D3 FF FD 2D 38 CC DB D2 D3 43 DB CA D1 DB 3D FF CC 80 F9 D4 CC FD D0 38 CC DB 01 CB E0 C8 DF DE D3 CC C8 CB DF D0 CF E2 03 E3 17 40 03 E3 38 CF C8 CB C9 E9 CD E7 E6 EF C9 D7 83 CB D1 EB EF D3 DC D1 DC C9 DC CC CB D3 52 12 DB D8 D8 D7 DB D4 15 A7 2D 17 59 CC 05 87 CC 40 DD C8 07 CC F4 07 CB 15 15 0D 27 00 00 50 08 07 06 0C 04 0B 00 04 02 08 0F 1E 1A 09 1C 1B 07 06 0B 0D 19 08 00 15 07 05 03 0D 07 0E 06 25 03 10 19 15 15 16 2D 08 03 04 05 0B 02 0E 04 1E 0B 1B 05 1E 1F 0A 07 16 08 0A 1C 03 09 08 27 06 1C 00 1E 08 08 00 08 01 00 09 2F 03 02 2D 0B 0A 00 00 3A 03 03 0D 16 05 16 0A 33 4A 0C 08 08 17 3D 16 02 05 04 02 00 30 01 29 2E 13 02 07 0D 03 06 02 00 0A 03 07 0C 01 01 1A 08 0F 01 08 0A 03 02 02 FF 05 06 02 0A 00 1F 1F 1F 11 00 20 39 26 74 80 EE 2A AE 00 B5 0E 31 3F 20 00 B6 98 71 30 10 36 6C A8 80 2E 2A A0 06 00 74 10 8C 60 BB 43 74 7E 0A 40 DD 1C 90 92 28 61 40";
        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("Scenario"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.FlossArmWaveEnabled = true;
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
                Settings.Default.FlossArmWaveEnabled = false;
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
