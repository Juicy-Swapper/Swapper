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
    public partial class Floss : Form
    {
        bool enabled = Settings.Default.FlossEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Floss";

        public Floss()
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

        string Emote = "8C 0A 00 05 18 88 05 16 04 00 00 00 00 00 00 00 00 03 B1 00 20 04 80 EE 07 40 00 00 00 06 05 48 05 50 01 98 06 C0 06 08 07 20 07 48 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 42 6F 6F 67 69 5F 44 6F 77 6E 5F 5F 43 4D 46 00 5E 2E 48 4D 4D 32 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 00 44 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 46 2D 4C 00 63 2E 5F 00 13 2F 53 63 72 69 70 74 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 46 69 6C 72 2E 53 65 61 73 6F 2E 34 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 70 69 63 00 0E 11 43 6F 6F 6C 64 6F 77 53 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 73 00 11 4C 61 72 67 50 72 65 76 69 65 77 49 6D 67 65 00 04 4E 6F 6E 65 00 07 50 61 63 6B 0D 4C 65 6E 74 68 00 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 00 00 00 64 C1 00 00 00 00 45 3C 81 72 B9 7C 42 8A 0F 18 19 BD 0B 26 CB 6F 96 E2 1E D3 BB 8E 99 F2 6E 24 64 57 E2 DB 65 E7 03 88 EC 6D 66 BA 14 E3 BD 15 9D 4E 4D 44 0C 14 0F 1B 9D 7C 1E 0A 52 71 48 77 C2 D2 F3 68 0C 70 95 07 56 8D 9D C0 61 38 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 24 80 C8 BB 1E E6 DC CF DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 04 DD 5C 7C 6F F2 9D A8 75 5C F9 0E B3 5D 90 0F B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 4D C9 91 AA 4B B1 57 B8 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 EE 07 26 01 17 00 FF FF FF FF FF FF FF FF 84 FE 08 D0 06 DB 0B B7 0B 00 00 00 02 00 01 18 04 02 02 02 3C 02 0D 06 02 02 0A 05 03 00 01 98 41 80 3F 03 08 21 32 30 41 31 30 33 38 45 34 35 33 33 30 34 45 34 42 44 35 37 34 44 41 35 38 46 37 35 37 38 42 41 00 0C 00 00 00 20 39 45 46 32 34 31 38 41 37 44 36 42 32 35 30 44 41 37 30 39 33 39 30 31 46 31 46 37 00 06 34 38 34 44 31 44 39 43 41 30 42 43 38 39 44 45 33 30 45 34 41 43 45 41 38 31 37 30 43 1C 20 77 69 74 68 20 50 6F 70 75 6C 6F 74 75 73 2E 10 11 08 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 B7 C0 96 96 92 92 92 92 92 5A 87 87 32 8A 87 87 8E 35 59 7E F8 F8 F8 E0 79 B8 F9 F8 F8 F8 D8 79 F8 F8 F8 E8 F1 48 B9 87 87 87 87 3C 20 32 87 31 87 47 22 31 5B F9 F8 F8 F8 C0 7C F8 F8 F8 D0 79 F0 F9 F8 F8 F8 C0 78 E0 87 8A 87 46 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 49 30 2D 60 93 8F 87 7E D8 24 38 22 21 22 87 59 8A 7D 29 8F 89 87 87 8F 49 59 5A 87 5C 8F 87 8A 87 27 39 8B 3C 31 87 66 6E 2D 50 21 58 54 00 30 32 B2 87 41 40 40 87 42 5C 99 B9 8C 87 53 6A 92 4C 99 87 87 87 87 87 32 29 70 8B 8C 8B 87 8F 9E 28 78 97 87 87 89 8F 71 87 87 2A B9 39 59 4C 00 30 00 0F 00 13 00 12 00 4A 00 60 00 AA 00 60 00 39 00 38 00 34 00 98 00 97 00 0F 00 0E 00 46 00 48 00 65 00 63 00 15 00 85 00 16 00 93 00 23 02 0B 00 E7 01 D6 01 EB 01 34 00 FC 01 30 02 30 00 1B 00 61 00 B7 00 0D 00 BA 00 D0 00 DF 00 0D 00 7F 02 9A 00 0F 00 28 01 0D 00 16 00 0F 00 1D 00 BD 00 99 01 F7 00 59 00 EF 01 B1 00 41 00 10 00 0E 00 87 06 08 00 40 00 10 00 58 00 C8 06 0C 00 21 00 30 00 1A 00 49 03 4A 03 3F 00 7C 03 39 00 78 00 0E 01 08 00 EE 00 00 00 00 FF 0F 00 8C 0A";
        string Emote1 = "8C 06 00 04 FA 88 04 F8 04 00 00 00 00 00 00 00 00 03 C2 00 20 04 80 EE 07 40 00 00 00 06 05 48 05 50 01 98 06 C0 06 08 07 20 07 48 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 45 6D 6F 74 65 5F 46 6C 6F 73 73 44 61 6E 63 65 5F 4D 5E 2E 32 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 49 44 5F 42 6F 6F 67 69 65 44 6F 77 6E 00 44 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 49 63 6F 6E 73 2F 54 2D 2D 2D 45 2D 46 2D 4C 00 00 63 2E 00 00 00 00 00 5F 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 00 05 43 6C 61 73 73 00 19 54 79 70 65 2E 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 34 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 0B 44 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 45 70 69 63 00 0E 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 61 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 65 00 04 4E 6F 6E 65 00 07 50 61 63 6B 0D 4C 65 6E 67 74 68 00 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 00 00 00 64 C1 45 3C 81 72 B9 7C 42 8A 0F 18 19 BD 0B 26 CB 6F 96 E2 1E D3 BB 8E 99 F2 6E 24 64 57 E2 DB 65 E7 03 88 EC 6D 66 BA 14 E3 BD 15 9D 4E 4D 44 0C 14 0F 1B 9D 7C 1E 0A 52 71 48 77 C2 D2 F3 68 0C 70 95 07 56 8D 9D C0 61 38 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 24 80 C8 BB 1E E6 DC CF DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 04 DD 5C 7C 6F F2 9D A8 75 5C F9 0E B3 5D 90 0F B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 4D C9 91 AA 4B B1 57 B8 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 EE 07 00 26 01 17 00 FF FF FF FF FF FF FF FF 84 FE 08 D0 06 DB 0B B7 0B 00 00 00 00 02 01 18 04 02 02 01 02 3C 02 0D 06 0A 05 03 01 98 41 80 3F 03 08 21 00 32 30 41 31 30 33 38 45 34 35 33 33 30 34 45 34 42 44 35 37 34 44 41 35 38 46 37 35 37 38 42 41 00 0C 39 45 46 31 32 34 31 38 34 41 37 44 30 36 42 32 35 30 37 30 39 33 39 30 31 35 46 31 46 37 00 06 34 38 34 44 31 44 39 43 41 30 42 43 38 39 44 45 33 30 45 34 41 43 39 45 41 38 31 37 30 43 00 1C 53 77 61 70 70 65 64 20 42 79 20 4A 75 69 63 79 20 72 21 20 20 10 11 08 00 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 58 03 03 02 02 02 02 02 02 DC D3 DB D8 FD FD FC 15 CF 84 D3 D3 43 D7 CB D1 CF D0 11 FC 0A FF CD 38 D8 FF E5 38 4C DB 01 CB E0 C8 DF DE D3 CC C8 CB DF D0 CF E8 03 E3 38 CF C8 CB C9 CA E7 F7 CD DF E5 E6 EF CB D5 D7 D1 EB EF D3 DC D1 DC C9 DC CB CF D3 12 DB D8 D8 D7 DB D4 15 03 9F 40 6D 02 DF 01 07 E8 F0 83 47 CC F4 03 07 D3 CF 15 D5 15 05 00 00 4D 08 07 0A 00 02 05 02 17 0C 14 1C 07 06 1D 1C 0E 00 0E 08 0D 11 0D 0D 0E 06 2F 03 1F 1E 13 17 14 11 08 03 09 0F 06 02 08 07 05 17 02 07 10 05 13 07 05 05 11 0F 01 17 09 09 08 24 06 1B 22 00 08 08 00 08 01 00 04 21 07 24 01 09 16 00 00 00 37 03 03 0D 21 28 11 9C 13 0C 05 04 01 01 00 28 00 30 03 2E 13 02 07 0D 03 06 02 00 12 01 01 05 05 1E 08 1B 05 0A 03 02 02 FF 00 05 06 02 07 00 01 20 0F 0B 04 16 0E 01 23 4A 23 81 D1 40 E0 0C 5F 86 AF 6E 00 17 CE 31 64 00 40 B8 E0 0B 00 00 30 33 50 A3 00 68 A5 20 22 81 AD E4 B9 06 00 54 0E 02 34 0A 40 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
        
        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Scenario"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.FlossEnabled = true;
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
                Settings.Default.FlossEnabled = false;
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
