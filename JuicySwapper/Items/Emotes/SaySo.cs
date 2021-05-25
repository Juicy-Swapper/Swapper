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
    public partial class SaySo : Form
    {
        bool enabled = Settings.Default.SaySoEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Say So";

        public SaySo()
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

        string Emote = "8C 0A 00 06 91 88 06 8F 08 00 00 00 00 00 00 00 00 04 AE 00 20 04 80 69 0B 40 00 00 00 11 08 58 08 D0 01 28 0A 50 0A 98 B0 04 52 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 53 68 61 6F 6C 69 6E 53 69 70 55 70 5F 5F 43 4C 46 5F 4D 43 68 69 6C 64 00 71 2E 4D 4D 4D 4C 4D 46 00 65 2F 2E 4C 4D 4D 34 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 00 2F 43 61 74 61 6C 6F 67 2F 44 69 73 70 6C 61 79 41 73 73 65 74 73 2F 44 41 5F 43 2E 46 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 48 2D 4C 00 67 2E 54 63 00 13 2F 53 63 72 69 70 74 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 12 73 00 0D 41 72 72 79 50 72 6F 70 65 72 74 79 00 19 44 65 66 69 6E 69 08 42 6F 64 79 54 79 70 65 00 0C 42 79 74 65 05 43 6C 61 73 73 00 19 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 31 00 26 53 6F 75 72 63 65 57 69 6E 74 65 72 66 65 73 74 2E 68 61 6C 6C 65 6E 67 65 73 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 10 50 61 74 68 00 0B 4E 13 45 43 75 73 74 6F 6D 1A 3A 3A 4C 61 72 67 65 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 17 4D 10 11 43 6F 6F 6C 64 6F 77 53 65 63 73 00 0C 4D 6F 6E 74 61 67 65 00 0D 46 6C 6F 61 74 10 61 70 70 69 6E 67 0B 00 14 43 69 6E 65 72 00 0C 06 11 50 72 65 76 69 65 77 49 6D 04 4E 6F 6E 65 00 07 50 61 63 6B 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 0E 53 6F 66 74 12 0E 0C 54 65 78 00 64 C1 F0 BB F2 9A 46 7A 20 98 51 EA DE F9 51 C9 97 75 8A BE 62 63 E4 AB F5 71 DC 8E 2B 29 53 BC 82 AF 19 53 A4 8B B0 D1 72 83 FC 18 63 17 38 96 A6 8B A9 BF 67 5B 4B AA 91 60 EE 98 A1 E3 F3 F1 C9 C9 4E 15 80 60 03 13 57 0B 15 29 40 E2 75 EF B3 DA B2 F4 D6 D5 52 0B 77 3C 7F 1B 7F 21 8E EE A3 24 CE 3E 74 CE E5 D1 E7 FD EB 57 F3 0D A4 53 C8 E5 54 A6 B2 E2 93 86 F8 F1 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 47 67 A6 E0 0C BD A6 83 A8 E3 AA B3 3D 77 5A FD BD 42 3B E4 CB E2 F1 9F 61 E4 5D 59 DF 28 90 39 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 D5 C2 A9 DE 74 F6 43 98 37 54 0E 8B C9 71 99 99 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE C5 DA 94 5B F5 D9 B2 20 F0 34 0E 22 8B 92 6F 39 0D BA BC 12 62 E6 D7 95 49 56 90 B0 EB 0F DC 01 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 7C 78 FC 27 6F D5 A0 AD C4 E2 B7 4B A8 3B D0 53 B3 7D E9 93 04 5B 26 C2 71 23 C8 B8 5B A4 D5 2C D6 3C 55 A9 1E BB 6B 14 10 FE 22 10 01 6B D1 33 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 36 48 0B D0 13 0A 12 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 F7 0F BF 1A 3E 49 34 AE 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 69 0B 59 01 26 00 FF FF FF FF FF FF FF FF 2E F3 41 ED 27 A2 CC 90 0B 00 00 02 00 01 19 06 03 02 4A 06 02 02 0A 07 07 05 00 07 04 01 03 00 02 01 00 80 3F 21 00 45 33 45 39 42 41 45 39 34 38 37 30 34 41 37 33 39 32 31 46 42 33 42 39 34 35 45 44 34 39 36 41 00 0C 20 53 69 70 00 08 44 41 43 41 43 41 43 30 30 38 30 46 41 30 43 43 34 44 45 41 46 33 39 41 45 42 37 38 30 00 06 00 35 41 41 46 46 36 46 37 41 43 38 32 35 43 46 38 36 44 34 45 46 30 36 33 39 34 34 34 36 00 20 4D 69 6E 64 20 6F 76 65 72 20 62 6F 64 79 2C 20 62 75 74 20 66 69 72 73 74 2D 20 74 65 61 2E 00 1A 1B 1C 0E 0D 0A 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF C0 96 96 92 92 92 92 99 99 41 87 87 32 87 8D 87 87 33 61 8E 7F F8 F8 F8 F8 B8 79 F8 78 F8 F8 F8 F8 F1 F0 F0 F0 F0 E8 F9 F8 C9 F1 F0 F0 F8 F8 92 7B F8 F8 F8 F8 79 D0 F9 F8 F8 F8 E8 79 F8 F8 F8 F8 90 F1 70 B9 87 87 87 87 6C 32 87 87 87 7C 90 F9 F8 F8 90 79 A8 B1 87 31 87 47 22 31 6B F9 F8 F8 F8 D0 7C F8 F8 F8 E0 7A F8 F9 F8 F8 F8 D0 78 F0 87 8A 87 46 91 25 48 28 20 4E 4A 87 87 4A 40 8E 87 34 28 20 2E 87 87 49 87 49 30 20 29 52 93 8F 55 8E 87 8C 87 87 7E D8 24 28 61 3E 21 22 4E 79 A0 87 5A 87 79 90 32 7A A0 21 79 90 29 8F 2E 87 4F 21 30 8E 59 5A 21 6E 39 29 87 22 87 24 31 87 66 6E 2D 30 49 50 21 58 4C 40 23 00 30 32 B2 87 41 40 40 87 4A 5B 99 B9 87 5C 7A BC 31 E2 53 91 87 87 87 87 9F 38 76 8F 87 8D 87 9D 28 71 87 89 87 8E 8F 9B 87 87 87 87 24 B9 39 B9 59 59 66 00 30 00 0F 00 14 00 13 00 54 00 73 00 C7 00 4E 00 67 00 B5 00 67 00 3C 00 36 00 31 00 45 00 17 01 16 01 0F 00 0E 00 48 00 4A 00 69 00 67 00 15 00 89 00 16 00 97 00 CB 01 AE 02 0B 00 19 00 13 00 8E 02 7D 02 92 02 57 00 33 00 BB 02 F2 02 2A 00 48 00 1B 00 1C 00 A2 00 1B 01 0D 00 E9 02 12 00 46 01 55 01 D9 00 15 00 1C 00 13 00 73 01 1B 00 19 00 5B 03 2F 01 13 00 70 01 5A 00 21 00 0A 02 0D 00 42 00 2D 02 C1 00 DB 00 6D 00 0F 00 6C 02 66 01 42 00 C2 02 77 01 10 00 C4 00 51 00 10 00 0E 00 18 08 08 00 FE 01 08 00 40 00 10 00 58 00 40 02 0C 00 1E 00 3A 00 10 00 57 00 FE 03 3F 00 FB 03 78 00 EB 00 08 00 F5 00 0C 00 00 00 00 FE 2D 00 8C 0A 00 06 91 88 06 8F 08";
        string Emote1 = "8C 06 00 06 64 88 06 62 08 00 00 00 00 00 00 00 00 04 BD 00 20 04 80 69 0B 40 00 00 00 11 08 58 08 D0 01 28 0A 50 0A 98 B0 04 52 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 53 68 61 6F 6C 69 6E 53 69 70 55 70 5F 5F 43 4C 46 5F 4D 5F 43 68 69 6C 64 00 71 2E 52 4D 71 2E 4C 4D 46 00 65 48 50 69 6E 6B 2E 00 4D 4D 4D 34 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 00 2F 43 61 74 61 6C 6F 67 2F 44 69 73 70 6C 61 79 41 73 73 65 74 73 2F 44 41 5F 43 2E 46 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 48 2D 4C 00 67 2D 4C 2E 63 00 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 12 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 19 44 65 66 69 6E 69 00 08 42 6F 64 79 54 79 70 65 00 0C 42 79 74 65 05 43 6C 61 73 73 00 19 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 31 31 00 26 53 6F 75 72 63 65 2E 57 69 6E 74 65 72 66 65 73 74 2E 43 68 61 6C 6C 65 6E 67 65 73 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 10 50 61 74 68 00 0B 4E 13 45 43 75 73 74 6F 6D 1A 3A 3A 4C 61 72 67 65 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 17 4D 10 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 4D 6F 6E 74 61 67 65 00 0D 46 6C 6F 61 74 10 61 70 70 69 6E 67 00 0B 00 14 43 69 6E 65 72 00 0C 06 11 50 72 65 76 69 65 77 49 6D 04 4E 6F 6E 65 00 07 50 61 63 6B 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 0E 53 6F 66 74 12 0E 0C 00 64 C1 F0 BB F2 9A 46 7A 20 98 51 EA DE F9 51 C9 97 75 8A BE 62 63 E4 AB F5 71 DC 8E 2B 29 53 BC 82 AF 19 53 A4 8B B0 D1 72 83 FC 18 63 17 38 96 A6 8B A9 BF 67 5B 4B AA 91 60 EE 98 A1 E3 F3 F1 C9 C9 4E 15 80 60 03 13 57 0B 15 29 40 E2 75 EF B3 DA B2 F4 D6 D5 52 0B 77 3C 7F 1B 7F 21 8E EE A3 24 CE 3E 74 CE E5 D1 E7 FD EB 57 F3 0D A4 53 C8 E5 54 A6 B2 E2 93 86 F8 F1 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 47 67 A6 E0 0C BD A6 83 A8 E3 AA B3 3D 77 5A FD BD 42 3B E4 CB E2 F1 9F 61 E4 5D 59 DF 28 90 39 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 D5 C2 A9 DE 74 F6 43 98 37 54 0E 8B C9 71 99 99 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE C5 DA 94 5B F5 D9 B2 20 F0 34 0E 22 8B 92 6F 39 0D BA BC 12 62 E6 D7 95 49 56 90 B0 EB 0F DC 01 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 7C 78 FC 27 6F D5 A0 AD C4 E2 B7 4B A8 3B D0 53 B3 7D E9 93 04 5B 26 C2 71 23 C8 B8 5B A4 D5 2C D6 3C 55 A9 1E BB 6B 14 10 FE 22 10 01 6B D1 33 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 36 48 0B D0 13 0A 12 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 F7 0F BF 1A 3E 49 34 AE 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 69 0B 59 01 26 00 FF FF FF FF FF FF FF FF 2E F3 41 ED 27 A2 CC 90 00 00 02 01 19 06 03 02 4A 06 02 02 0A 07 07 00 05 07 04 01 03 00 07 04 02 00 80 3F 21 45 33 45 39 42 41 45 39 34 38 37 30 34 41 37 33 39 32 31 46 42 33 42 39 34 35 45 44 34 39 36 41 00 0C 00 00 00 53 61 79 20 53 6F 08 44 41 43 41 43 41 43 34 30 30 38 30 46 41 30 43 43 34 44 45 33 41 46 33 39 41 45 42 37 38 30 00 06 35 41 41 46 46 36 46 37 34 41 43 38 32 35 43 46 38 36 44 34 45 46 42 30 36 33 39 34 34 34 36 36 00 20 77 61 70 70 65 64 20 42 79 20 4A 75 69 63 79 20 72 21 20 20 20 20 20 20 00 1A 1B 1C 0E 00 0D 0A 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A6 58 03 03 02 02 02 02 05 05 D9 D3 D3 E9 FF F5 38 3D 5D 3D 75 38 3D 02 FE 81 D7 D4 D0 C5 38 D4 D9 FC 3D 05 38 01 38 15 EF D2 FF 3D C9 38 11 D3 DB CA D1 EF 11 FC FF D4 FB DC A4 FD D8 38 1E DB 01 CB E0 C8 C8 DF DE DF D8 D3 CC C8 CB DF DF D0 C8 CD E2 03 E3 E3 38 CF C8 E9 D7 C9 CA DF C5 38 E7 FF D2 C6 38 C9 FD CD CF DF C9 D0 E7 E6 C9 EF D5 CD CB CB D1 EB EF D3 CC E5 D8 D1 9C C9 DC D4 CB D3 52 12 DB D8 D8 D7 06 DD D0 15 D7 45 9D D4 17 09 DB CD 0E CC 05 93 F1 07 CC E4 C8 0B D3 CB 15 D5 15 15 05 15 88 00 00 6D 08 07 0C 0B 0C 0B 06 1F 06 0C 0C 12 00 0D 1E 0E 09 0D 20 1C 07 06 05 00 02 17 04 02 01 0F 0D 01 0E 06 14 27 03 01 0B 16 15 1A 16 0B 13 14 02 00 03 04 0A 13 07 22 0A 1E 1D 01 0D 04 0B 1B 03 01 23 17 0B 18 02 09 12 05 0A 15 09 03 05 07 14 1E 0A 1A 1F 08 0C 09 23 06 2C 00 16 08 08 00 07 02 00 0A 02 0A 00 0D 07 23 07 00 09 03 00 00 00 40 03 03 0D 1B 0B 41 38 41 37 16 01 39 32 1D 16 00 1E 05 0B 00 2F 01 29 00 30 13 02 03 0D 0F 03 0D 05 00 0A 24 01 03 03 06 05 00 00 0B 0B 05 03 06 08 0A 03 02 00 FF 05 05 08 01 00 28 1E 1F 0D 06 20 44 00 0E 91 41 09 4C 00 F0 0B BB 64 33 40 40 01 14 16 07 6D 63 35 A8 03 C0 C0 C0 F0 00 98 00 7E 0F 0C 40 0D 00 C1 2E D0 12 C2 88 30 D1 23 08 41 5F 30 8E 11 B0 A2 12 94 11 9D C3 0C 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("SideHustle"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SaySoEnabled = true;
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
                Settings.Default.SaySoEnabled = false;
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
