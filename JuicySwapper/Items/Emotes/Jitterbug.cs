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
    public partial class Jitterbug : Form
    {
        bool enabled = Settings.Default.JitterbugEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Jitterbug";

        public Jitterbug()
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

        string Emote = "8C 0A 00 06 84 88 06 82 08 00 00 00 00 00 00 00 00 04 A3 00 20 04 80 33 0B 40 00 00 00 DB 07 20 08 D0 01 F0 09 18 0A 60 0A 78 04 4C 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 54 61 6B 65 5F 54 68 65 5F 45 6C 66 5F 5F 43 4D 46 5F 4D 00 65 2F 2E 52 2F 5F 43 68 69 6C 64 00 71 2E 4D 4D 4D 4D 4D 4D 32 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 54 68 65 45 6C 66 00 44 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 2D 2D 2D 45 2D 46 2D 4C 00 63 2E 5F 00 13 2F 53 63 72 69 70 74 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 12 73 00 0D 41 72 72 79 50 72 6F 70 65 72 74 79 00 19 44 65 66 69 6E 69 08 42 6F 64 79 54 79 70 65 00 0C 42 79 74 65 05 43 6C 61 73 73 00 19 2E 00 27 46 69 6C 72 2E 45 76 65 6E 74 2E 31 34 44 61 79 73 6F 66 00 19 53 65 61 73 6F 6E 2E 37 53 6F 75 72 63 65 4F 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 13 45 43 75 73 74 6F 6D 1A 3A 3A 4C 61 72 67 65 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 17 4D 0E 11 43 6F 6F 6C 64 6F 77 53 65 63 73 00 0C 4D 6F 6E 74 61 67 65 00 0D 46 6C 6F 61 74 10 61 70 70 69 6E 67 0B 00 14 43 69 6E 65 72 00 0C 06 11 50 72 65 76 69 65 77 49 6D 04 4E 6F 6E 65 00 07 50 61 63 6B 1B 50 68 6F 62 65 2E 2E 4D 69 6E 73 2E 5A 6F 6E 65 31 32 00 0D 4C 65 6E 74 68 00 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 64 C1 C5 AA AA 55 D3 65 88 A6 B5 9A B7 48 32 D1 06 51 68 4F 1E 23 56 FD A4 DF 9D C9 73 69 57 51 D4 47 CD 8E 78 3D 9B AA 4C 85 1E CE 0B D9 B3 EF 4F EA B6 57 BA 3E B5 F6 32 82 84 A1 77 27 2D FD 3E 7C D0 4C 11 BC 8C 27 83 B6 41 2C CF 0B 2E F6 FC 37 C9 6D F4 78 B6 37 97 64 3C 51 F3 10 3D AB A9 B7 9D FA 65 BD 9D DB 12 12 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 47 67 A6 E0 0C BD A6 83 A8 E3 AA B3 3D 77 5A FD BD 42 3B E4 CB E2 F1 9F 61 E4 5D 59 DF 28 90 39 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 DD 37 F8 77 2C 66 1E F7 B2 AE CF 81 B9 8E 80 19 87 5B 86 B4 FA D4 8B 0F DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 0D BA BC 12 62 E6 D7 95 49 56 90 B0 EB 0F DC 01 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 7C 78 FC 27 6F D5 A0 AD 1E 26 C8 72 2B 28 E9 E0 B3 7D E9 93 04 5B 26 C2 71 23 C8 B8 5B A4 D5 2C D6 3C 55 A9 1E BB 6B 14 10 FE 22 10 01 6B D1 33 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 36 48 0B D0 13 0A 12 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 C2 D5 A4 63 79 0A 9F CD E1 58 86 BE D5 0C 58 3C 4D C9 91 AA 4B B1 57 B8 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 33 0B 65 01 24 00 FF FF FF FF FF FF FF FF 99 36 77 23 04 55 FD A5 00 00 02 00 01 19 06 01 02 01 02 4A 06 02 02 0A 05 05 07 04 02 03 07 04 01 07 20 41 80 3F 08 21 46 32 43 42 39 30 38 33 34 36 34 34 42 34 33 30 30 39 38 43 44 43 39 35 32 46 33 45 34 37 31 44 00 0D 20 54 68 65 20 43 30 43 35 44 32 36 38 37 36 34 46 35 32 36 33 34 39 44 42 30 43 38 39 41 39 39 43 46 00 06 35 41 38 38 43 32 44 38 34 32 38 30 43 33 39 32 45 39 44 42 34 38 41 33 34 44 36 42 30 33 00 19 42 72 65 61 6B 20 6F 75 74 20 74 68 65 20 6D 69 73 74 6C 65 74 6F 65 2E 18 1B 31 30 1A 19 0C 0B 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF C0 96 96 92 92 92 92 92 99 41 87 87 32 87 8D 87 87 33 61 87 7A F8 F8 F8 F8 79 D0 FA F8 F8 F8 F8 87 79 F8 F8 F8 F8 B8 79 F8 78 F0 F0 F0 F0 A0 F9 F8 F8 F8 F8 90 F9 C8 F9 F8 F8 F8 F8 90 F9 F8 F8 F8 F8 C0 F9 F8 C9 B9 87 87 87 87 2C 87 31 87 31 87 4F 21 31 5B F9 F8 F8 F8 C0 7C F8 F8 F8 D0 79 F0 F9 F8 F8 F8 C0 78 E0 87 8A 87 46 91 25 48 28 87 4B 4A 87 87 4A 40 8E 87 34 28 20 2E 87 87 49 87 49 30 20 29 52 93 87 87 42 7A 90 87 61 EE D1 87 7B D8 24 38 22 21 22 4E 79 A0 87 5A 87 79 90 32 7A A0 21 79 29 8F 2E 87 4F 21 30 8E 59 5A 21 6E 39 29 87 22 87 24 8C 43 8C 7F E8 3B 8B 34 87 66 6E 2D 50 21 58 4C 38 22 00 30 32 B2 87 41 40 40 87 39 9A 59 99 B9 87 7E 68 64 6C 92 4B 99 87 87 87 87 9E 20 25 70 8A 8D 87 8B 87 9F 28 78 87 8D 87 8E 9F 87 87 87 2B 39 39 B9 B9 B9 B9 59 65 00 30 00 0F 00 14 00 13 00 4E 00 67 00 54 00 73 00 7C 01 42 00 34 00 AB 00 AA 00 0F 00 0E 00 46 00 48 00 65 00 63 00 15 00 85 00 16 00 93 00 36 02 0B 00 19 00 13 00 0A 02 F9 01 0E 02 57 00 33 00 37 02 74 02 2A 00 48 00 1B 00 DF 00 29 00 44 00 CB 00 44 01 0D 00 47 01 5D 01 49 00 F0 00 15 00 1C 00 13 00 8A 01 1B 00 19 00 64 03 44 01 13 00 85 01 58 00 21 00 1F 02 0D 00 42 00 42 02 BF 00 D9 00 6D 00 0F 00 93 01 1D 00 57 00 CA 02 9B 01 8B 00 20 03 FD 00 41 00 10 00 0E 00 E1 07 08 00 FE 01 08 00 40 00 10 00 58 00 3F 00 0C 00 20 00 3C 00 41 00 52 00 3D 00 39 04 3B 04 40 00 39 04 39 00 56 00 D7 00 08 00 0B 01 00 00 00 FE 2D 00 8C 0A 00 06 84 88";
        string Emote1 = "8C 06 00 06 59 88 06 57 08 00 00 00 00 00 00 00 00 04 AF 00 20 04 80 33 0B 40 00 00 00 DB 07 20 08 D0 01 F0 09 18 0A 60 0A 78 04 4C 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 54 61 6B 65 5F 54 68 65 5F 45 6C 66 5F 5F 43 4D 46 5F 4D 00 65 53 77 69 6E 67 44 61 6E 63 65 2E 52 5F 43 68 69 6C 64 00 71 2E 4C 4D 4D 4D 4D 4D 32 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 73 2F 45 49 44 45 6C 66 00 44 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 49 63 6F 6E 73 2D 2D 2D 45 2D 46 2D 4C 00 63 2E 00 5F 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 12 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 19 44 65 66 69 6E 69 00 08 42 6F 64 79 54 79 70 65 00 0C 42 79 74 65 05 43 6C 61 73 73 00 19 2E 00 27 46 69 6C 72 2E 45 76 65 6E 74 2E 31 34 44 61 79 73 6F 66 00 19 53 65 61 73 6F 6E 2E 37 53 6F 75 72 63 65 4F 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 0B 44 69 73 4E 13 45 43 75 73 74 6F 6D 1A 3A 3A 4C 61 72 67 65 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 17 4D 0E 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 4D 6F 6E 74 61 67 65 00 0D 46 6C 6F 61 74 10 61 70 70 69 6E 67 00 0B 00 14 43 69 6E 65 72 00 0C 06 11 50 72 65 76 69 65 77 49 6D 04 4E 6F 6E 65 00 07 50 61 63 6B 1B 50 68 6F 65 62 65 2E 2E 4D 69 6E 75 73 2E 5A 6F 6E 65 31 32 00 0D 4C 65 6E 67 74 68 00 0C 53 74 72 75 63 74 00 10 53 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 64 C1 C5 AA AA 55 D3 65 88 A6 B5 9A B7 48 32 D1 06 51 68 4F 1E 23 56 FD A4 DF 9D C9 73 69 57 51 D4 47 CD 8E 78 3D 9B AA 4C 85 1E CE 0B D9 B3 EF 4F EA B6 57 BA 3E B5 F6 32 82 84 A1 77 27 2D FD 3E 7C D0 4C 11 BC 8C 27 83 B6 41 2C CF 0B 2E F6 FC 37 C9 6D F4 78 B6 37 97 64 3C 51 F3 10 3D AB A9 B7 9D FA 65 BD 9D DB 12 12 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 47 67 A6 E0 0C BD A6 83 A8 E3 AA B3 3D 77 5A FD BD 42 3B E4 CB E2 F1 9F 61 E4 5D 59 DF 28 90 39 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 DD 37 F8 77 2C 66 1E F7 B2 AE CF 81 B9 8E 80 19 87 5B 86 B4 FA D4 8B 0F DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 0D BA BC 12 62 E6 D7 95 49 56 90 B0 EB 0F DC 01 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 7C 78 FC 27 6F D5 A0 AD 1E 26 C8 72 2B 28 E9 E0 B3 7D E9 93 04 5B 26 C2 71 23 C8 B8 5B A4 D5 2C D6 3C 55 A9 1E BB 6B 14 10 FE 22 10 01 6B D1 33 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 36 48 0B D0 13 0A 12 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 C2 D5 A4 63 79 0A 9F CD E1 58 86 BE D5 0C 58 3C 4D C9 91 AA 4B B1 57 B8 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 33 0B 65 01 24 00 FF FF FF FF FF FF FF FF 99 36 77 23 04 55 FD A5 00 00 02 01 19 06 01 02 01 02 4A 06 02 02 0A 05 05 07 04 02 03 00 07 04 01 07 20 41 80 3F 08 21 46 32 43 42 39 30 38 33 34 36 34 34 42 34 33 30 30 39 38 43 44 43 39 35 32 46 33 45 34 37 31 44 00 0D 4A 69 74 74 65 72 62 75 67 43 30 43 43 35 44 32 36 34 38 37 36 34 46 35 32 36 33 34 43 39 44 42 30 43 38 39 41 39 39 43 46 00 06 35 41 38 38 43 32 44 38 34 32 38 30 34 43 33 39 32 45 39 44 42 34 38 41 39 44 36 33 00 19 42 79 20 4A 75 69 63 79 20 53 77 61 70 70 65 72 21 20 20 20 20 20 20 20 18 00 1B 31 30 1A 19 0C 00 0B 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A4 58 03 03 02 02 02 02 02 05 D9 D3 D3 E9 FF D7 E0 D0 D1 38 D4 3D FF D9 38 D4 3D FD 11 38 3D 3D 31 38 60 15 CF CF 84 D3 D3 43 DF C9 D1 E7 3D FF E0 40 F9 E8 FE E4 38 DB 01 CB E0 C8 DF DE DF D8 D3 CC C8 CB DF DF D0 C8 CD E2 03 DB FE EB 2F 21 E3 38 CF C8 CB C9 CA DF C5 38 E7 FF D2 C6 38 C9 F5 CD CF DF 89 D0 E7 E6 C9 EF D5 CD CB CB DB EB 38 D7 D3 43 EA EF D3 DC D1 DC C9 DC D0 CA D3 52 12 DB D8 D8 D7 06 DD D0 15 D7 E8 DC 67 17 90 82 DF 05 07 CB F0 07 CC F4 83 03 47 CF C9 01 D5 15 15 15 15 15 05 00 00 6B 08 07 0C 0B 06 04 09 02 0F 0D 0C 10 0B 14 13 1E 0C 28 27 07 06 0E 00 26 03 05 0D 0B 0D 0D 0E 06 1E 03 01 0B 12 11 16 1A 0B 1F 1C 02 00 03 07 01 0C 03 1C 00 1F 15 01 08 0D 04 0B 12 03 01 2C 1C 0B 1D 09 17 05 0A 1A 07 01 05 07 1B 05 0F 12 13 03 28 05 09 08 25 06 28 00 16 08 08 00 07 02 00 0C 08 04 05 0E 08 21 01 0E 08 00 00 00 48 03 03 0D 1B 05 16 07 3B 05 41 38 38 42 42 13 02 02 05 04 02 00 33 01 29 33 14 02 07 0D 0F 03 0D 05 00 0D 00 05 03 07 01 01 03 06 05 00 0B 0B 05 03 06 08 05 09 00 05 06 03 02 FF 05 05 0A 01 02 00 1F 06 1F 15 00 00 15 20 40 04 6C 90 40 94 A0 12 18 40 AC 9A 63 1A 00 08 A0 21 3D 01 E4 78 00 1A 80 19 26 80 4C 00 68 66 02 06 9E 8A 4D 90 08 D9 4E 3C 23 50 78 69 96 10 D9 1E 00 5C 85 31 20 F4 23 94 08 40";

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
                Settings.Default.JitterbugEnabled = true;
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
                Settings.Default.JitterbugEnabled = false;
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
