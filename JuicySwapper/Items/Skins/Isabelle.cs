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

namespace JuicySwapper.Items.Skins
{
    public partial class Isabelle : Form
    {
        bool enabled = Settings.Default.IsabelleEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Isabelle";

        public Isabelle()
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

        string Body = "8C 0A 00 05 0B 88 05 09 00 00 00 00 00 00 00 00 00 03 8B 20 00 80 20 0A 40 00 00 00 A4 06 E8 06 70 01 58 08 80 08 10 09 38 09 04 47 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 5F 46 5F 4D 45 44 5F 00 75 2E 66 5F 41 6E 69 6D 42 50 00 85 2E 5F 43 00 77 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 00 97 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 25 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 AB AA 1F 92 BA 5A 62 00 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 42 3B B4 D1 23 0F 79 B6 C3 6B 24 65 50 F8 7E B8 82 C5 A8 4B 04 02 C0 95 4A 00 47 C8 05 F9 2E 7D BD CD 5A 4C 18 98 00 15 07 38 39 02 65 DF 05 59 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B E2 4A A6 AD 8D 27 9B 90 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 20 0A 12 00 15 01 01 FF FF FF FF FF FF FF FF 32 4B 14 8D 14 10 93 92 EC 2A A5 0B 04 00 01 00 03 06 00 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 00 00 00 04 02 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 AB C8 95 96 92 92 92 92 92 92 41 00 30 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 35 49 30 78 C0 82 01 79 B8 81 01 87 82 01 79 E8 7C F8 F8 F8 B8 26 87 7A C8 20 28 82 01 79 F8 90 89 87 87 46 91 25 87 87 24 87 87 8C 23 87 87 4E 87 8A 87 87 4D 49 24 32 79 F0 C8 CF 20 20 28 79 20 32 20 40 87 29 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 31 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 55 30 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 5C 00 30 00 49 00 18 00 11 00 46 00 60 00 FA 00 ED 00 EE 00 1E 01 1D 00 61 00 77 00 77 00 68 00 1D 00 87 00 BC 02 95 00 25 00 04 03 79 00 99 00 15 00 BD 00 57 01 5B 00 22 00 26 00 30 01 51 00 71 00 5D 04 33 00 4B 00 C0 00 1D 00 19 00 15 00 0C 00 65 01 35 00 5B 00 26 00 64 00 58 01 1A 00 2A 01 15 00 18 02 1D 00 13 00 4D 02 60 00 39 01 15 00 60 00 04 02 40 00 AC 01 85 01 0B 05 86 03 1E 01 17 00 72 02 6D 00 21 00 31 00 82 00 3D 00 10 00 A9 06 08 00 9E 01 08 00 10 00 48 00 10 00 87 08 48 00 08 00 28 00 88 00 10 00 88 00 03 09 80 00 08 00 9C 00 23 00 10 00 00 00 00 0A 04 04 0B 1C FE 15 00 8C 0A 00 05 0B 88 05 09 00 00 00 00 00 00 00";
        string Body1 = "8C 06 00 04 B3 88 04 B1 00 00 00 00 00 00 00 00 00 03 63 20 00 80 20 0A 40 A4 06 E8 06 70 01 58 08 80 08 10 09 38 09 04 47 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 64 69 75 6D 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 5F 46 5F 4D 45 44 5F 53 63 68 6F 6C 61 72 00 75 2E 66 5F 41 6E 69 6D 42 50 00 85 2E 5F 43 77 00 00 00 00 00 00 00 00 97 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 73 43 6F 6C 6F 72 53 77 61 74 63 79 74 65 11 50 61 72 74 00 05 25 1B 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 45 3A 3A 19 00 0F 0B 49 6E 74 14 4D 61 73 61 6C 00 15 46 6C 61 67 49 78 00 11 73 00 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 AB AA 1F 92 BA 5A 62 00 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 42 3B B4 D1 23 0F 79 B6 C3 6B 24 65 50 F8 7E B8 82 C5 A8 4B 04 02 C0 95 4A 00 47 C8 05 F9 2E 7D BD CD 5A 4C 18 98 00 15 07 38 39 02 65 DF 05 59 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B E2 4A A6 AD 8D 27 9B 90 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 20 0A 12 00 15 01 01 FF FF FF FF FF FF FF FF 32 4B 14 00 8D 14 10 93 92 EC 2A A5 0B 04 01 03 06 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 04 02 80 05 01 08 01 00 00 00 00 00 00 00 00 00 7B 1C 03 C5 42 02 02 02 02 02 02 D9 C7 D3 C7 03 D3 C9 FF FD 3D D0 D3 F4 F8 FE FD D8 FD BB FD FD FE 3D FF FD 7C DB 01 CB CB CB DF C7 C7 C4 1F DD CB D2 FD 1F C8 C8 CC ED D0 D2 C8 46 CF FF F9 EC CA D0 D8 FE D2 E6 FB D2 EC DC F9 8C C8 D2 E0 DF C7 D0 D2 FA FF C5 7B C7 CC E0 D9 D8 EB F7 E3 D0 CA D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 F9 DC E4 FA 47 65 C8 35 67 00 00 58 03 08 02 01 0C 00 09 0E 08 02 1E 0D 18 09 07 00 0F 00 0D 07 00 01 0D 05 17 20 0A 06 1D 0E 18 09 09 25 0B 03 08 05 0C 0D 04 0D 03 0E 0C 10 02 12 0D 10 05 0B 15 08 11 0D 02 08 14 1D 02 23 26 16 0F 02 1C 1A 05 09 09 0A 05 08 19 00 16 08 00 27 00 00 23 2B 00 04 0B 08 00 00 35 02 23 1E 15 01 06 08 33 09 16 0A 3E 0D 3E 05 45 03 08 1C 05 32 67 0F 13 02 0F 13 11 03 08 00 01 15 04 08 07 0B 02 06 01 01 01 02 00 03 08 03 02 FF 05 06 0D 01 00 40 50 1D 98 00 0C 2D 13 15 A8 2A 88 0D 06 CA B2 02 8C 47 D4 A1 41 22 D0 00 22 C4 0D 00 2E 6C 05 F0 0C 14 44 51 42 20 A8 A2 A8 67 CF 0D 0A 7E 82 44";

        string Head = "8C 0A 00 04 3E 88 04 3C 00 00 00 00 00 00 00 00 00 03 01 20 00 80 F1 08 40 00 00 00 AD 05 F0 05 30 01 20 07 48 07 D8 00 08 04 4C 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 43 79 62 72 53 63 61 76 65 6E 67 00 74 50 6C 61 79 65 72 46 5F 4D 45 44 5F 41 53 4E 5F 53 74 61 72 66 69 73 68 30 31 2F 4D 61 74 65 72 69 61 6C 5F 48 61 69 72 4E 6F 6E 65 00 98 2E 68 65 73 68 65 00 83 2E 75 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 9F 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 05 18 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 04 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 00 00 00 00 8A 7F 39 70 F9 11 74 41 B6 53 3F 10 FD A0 05 59 14 F6 E2 52 CE 4B 9C DF 5F DE E2 20 D5 C2 9F 6D 8B FE C7 62 25 96 84 DF A4 42 48 D2 80 09 EA 0B 37 80 64 53 C2 12 D2 16 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 2B 9D 6C 17 4C 05 E1 2A AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 F1 08 12 00 10 01 01 FF FF FF FF FF FF FF FF 03 09 37 00 0F 32 24 CC 31 50 B9 67 9B 0B 04 00 01 08 03 06 00 04 09 02 04 02 04 02 05 03 02 02 01 04 80 05 01 02 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 93 C8 95 96 92 92 92 92 99 92 41 87 87 53 87 87 87 87 21 8E 87 91 7A 90 7E B0 87 87 34 87 7C E8 87 84 01 79 F8 B0 F9 F8 F8 F8 E0 7C E8 82 01 79 E0 81 01 87 87 81 01 79 F8 C8 87 8F 87 43 91 25 87 87 24 87 87 8C 87 87 87 4E 31 79 D0 CF 20 28 79 20 32 20 40 87 29 87 7B C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 4C 7A 7D 98 FF 2C 29 50 41 40 87 87 25 7E 55 28 00 30 32 99 99 39 40 87 C1 40 40 32 B2 B9 40 40 40 40 87 5A 59 59 79 7B 87 9E 79 47 00 30 00 0B 00 09 00 4E 00 46 00 56 00 25 00 76 00 9A 00 22 00 6A 00 85 00 85 00 77 00 28 00 15 00 C5 00 4B 00 22 00 38 00 AF 03 26 00 76 00 19 00 0B 04 15 00 0C 00 2A 03 35 00 57 00 22 00 60 00 0A 01 1A 00 DC 00 15 00 D2 01 1D 00 13 00 07 02 10 00 2E 01 2D 01 D4 00 17 00 F2 03 DE 01 57 00 21 00 31 00 78 02 3D 00 10 00 B1 05 0F 07 08 00 10 00 48 00 10 00 4F 07 08 00 28 00 88 00 10 00 88 00 CB 07 80 00 08 00 9C 00 23 00 3E 00 00 00 00 19 0D 0D 1A FC 07 00 8C 0A 00 04 3E 88 04 3C 00 00 00 00";
        string Head1 = "8C 06 00 03 F6 88 03 F4 00 00 00 00 00 00 00 00 00 02 DA 20 00 80 F1 08 40 AD 05 F0 05 30 01 20 07 48 07 D8 00 08 04 4C 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 50 5F 5F 46 5F 43 79 62 65 72 53 63 61 76 65 6E 67 00 74 2F 50 6C 61 79 65 72 00 00 00 00 00 00 00 00 98 68 46 5F 4D 45 44 5F 43 41 55 5F 4A 61 6E 65 30 31 73 68 65 83 2E 75 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 9F 2E 5F 43 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 05 18 17 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 19 45 3A 3A 00 0F 0B 49 6E 74 15 46 6C 61 67 73 49 78 00 11 73 00 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 00 8A 7F 39 70 F9 11 74 41 B6 53 3F 10 FD A0 05 59 14 F6 E2 52 CE 4B 9C DF 5F DE E2 20 D5 C2 9F 6D 8B FE C7 62 25 96 84 DF A4 42 48 D2 80 09 EA 0B 37 80 64 53 C2 12 D2 16 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 2B 9D 6C 17 4C 05 E1 2A AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 F1 08 12 00 10 01 01 FF FF FF FF FF FF FF FF 03 09 37 0F 00 32 24 CC 31 50 B9 67 9B 0B 04 01 01 08 03 06 04 09 02 04 02 04 02 05 03 02 02 01 04 80 05 01 02 01 00 00 00 00 00 00 00 00 00 68 1C 03 C5 42 02 02 02 02 05 02 D9 A3 81 C7 CA 03 FA FF FF FD 7C FD D3 C6 FF DC 3D FD EC 3D DF 3D FD EE DB 01 CB CB DF D1 FD 1F C8 CC ED D0 D2 C8 46 CF FF F9 EC CA D0 D8 FE D2 E6 C7 FA D2 D2 E0 DF F9 FF C5 7B C7 CC E0 D9 D8 CB F7 E3 CC C7 D3 52 05 05 D5 D8 1B 58 D8 92 15 92 D8 D8 98 58 E7 45 9D E0 F5 FB 07 F5 E7 00 00 47 03 08 0B 01 06 0E 00 0E 02 1A 0C 06 02 0F 07 0F 0C 10 0D 0D 0F 0A 00 27 0E 0E 01 23 0D 04 0D 0F 0A 08 12 02 04 0D 1A 05 0B 0B 1F 08 16 15 0C 0F 0C 18 16 0F 09 09 14 05 08 14 00 22 08 00 22 00 00 2E 00 04 0B 06 0B 00 00 2E 02 0E 12 0C 04 04 05 30 64 13 1B 0B 00 07 4F 05 4F 0A 5C 12 13 02 0F 2B 08 04 08 07 07 02 01 01 02 01 00 03 10 03 02 00 FF 05 06 00 09 01 01 40 91 6E 10 43 11 02 10 6B 31 E2 C3 68 DC 00 0E 80 10 48 00 30 29 09 29 74 84 16 08 80 80 28 02 C8 94 D8 60 10 C5 06 44";

        string Hat = "8C 0A 00 04 73 88 04 71 00 00 00 00 00 00 00 00 00 03 26 20 00 80 30 09 40 00 00 00 DE 05 20 06 40 01 60 07 88 07 18 08 40 08 04 4B 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 61 63 41 63 63 65 73 6F 72 69 65 73 2F 43 50 5F 46 5F 4D 45 44 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 6D 50 6C 79 65 72 2F 46 65 6D 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 5F 2F 4D 65 73 68 65 73 2F 5F 00 8B 2E 74 5F 41 6E 69 6D 42 50 00 9B 2E 5F 43 00 7A 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 9D 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 74 00 0C 42 6F 6F 6C 0C 42 79 74 65 11 54 79 70 65 00 05 1B 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 64 00 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 00 00 00 64 C1 00 00 00 00 90 9F 52 7C D3 46 E5 78 0A A8 6C 6A 03 E7 A0 73 BC 5B A2 A5 B6 16 30 03 E7 20 C1 43 18 3A D3 F2 E1 82 2D 9C B1 A6 EF 5E A3 EB C6 B1 B9 8C 1C 2A 4A 8A 48 05 6D CB 82 54 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 4E 33 CB B8 4D 71 F7 CB 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 30 09 12 00 01 01 FF FF FF FF FF FF FF FF 42 3C 11 2B 67 92 7F F1 90 AF B9 0B 04 00 01 07 03 00 02 01 02 85 02 02 02 04 02 04 02 05 03 01 02 05 01 02 80 05 01 06 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 97 C8 95 96 92 92 92 92 92 92 41 87 87 53 87 8A 8D 87 87 87 87 7F 90 8A 8F 87 26 58 49 87 29 78 B8 39 82 01 79 F8 81 01 87 82 01 79 F8 B0 7C F8 F8 F8 B8 26 87 7A C8 20 48 81 01 79 F8 A8 89 87 87 46 91 25 87 87 24 87 87 87 87 8F 4F 4D 69 36 79 E8 CF 20 28 79 20 32 20 40 37 87 7B C8 79 70 22 30 87 79 90 32 5A 48 79 A0 22 32 8F 4E 7A 7D 98 FF 87 2B 50 41 40 87 87 25 7E 5D 00 30 52 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 22 E1 87 87 9B 79 4D 00 30 00 0B 00 4D 00 4A 00 47 00 48 00 7D 00 23 00 93 00 6F 00 8D 00 8D 00 76 00 25 00 9D 00 5E 02 A5 00 25 00 8F 01 7C 00 9F 00 15 00 C3 00 60 01 1F 00 0E 00 E8 03 56 00 E3 03 D1 00 97 00 19 00 56 00 15 00 0C 00 42 01 35 00 57 00 22 00 60 00 2B 01 1A 00 13 00 F4 01 1B 00 F5 00 15 00 80 00 40 00 41 01 D2 00 17 00 FD 01 57 00 21 00 31 00 B2 03 3D 00 10 00 4F 07 08 00 10 00 48 00 10 00 8F 07 48 00 08 00 28 00 88 00 10 00 88 00 0B 08 80 00 08 00 9C 00 2A 00 43 00 00 00 00 12 12 19 1F FF 0B 00 8C 0A 00 04 73 88 04";
        string Hat1 = "8C 06 00 04 28 88 04 26 00 00 00 00 00 00 00 00 00 03 08 20 00 80 30 09 40 DE 05 20 06 40 01 60 07 88 07 18 08 40 08 04 4B 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 61 63 65 41 63 63 65 73 73 6F 72 69 65 50 5F 46 5F 4D 45 44 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 6D 2F 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 53 63 68 6F 6C 61 72 73 68 8B 2E 74 5F 41 6E 69 6D 42 50 9B 2E 5F 43 7A 00 00 00 00 00 00 00 00 9D 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 65 74 00 0C 42 6F 6F 6C 0C 42 79 74 65 11 54 79 70 65 00 05 1B 17 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 76 65 72 72 69 64 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 45 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 0B 49 6E 74 15 46 6C 61 67 73 49 78 00 11 73 00 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 00 00 00 00 90 9F 52 7C D3 46 E5 78 0A A8 6C 6A 03 E7 A0 73 BC 5B A2 A5 B6 16 30 03 E7 20 C1 43 18 3A D3 F2 E1 82 2D 9C B1 A6 EF 5E A3 EB C6 B1 B9 8C 1C 2A 4A 8A 48 05 6D CB 82 54 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 4E 33 CB B8 4D 71 F7 CB 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 30 09 12 00 01 01 FF FF FF FF FF FF FF FF 42 3C 11 00 2B 67 92 7F F1 90 AF B9 0B 04 01 01 07 03 02 01 02 85 02 02 02 04 02 04 02 05 03 01 02 05 01 02 80 05 01 06 01 00 00 00 00 00 00 00 00 00 69 1C 03 C5 42 02 02 02 02 02 02 D9 A3 81 C7 FB 83 CB D0 C7 C6 CC F0 E8 EC FD FD B8 FD BF FD FD FE 3D FF FD 7C DB 01 CB CB DF DF ED D3 FD 1F C8 CC ED D0 D2 C8 46 D3 FF F9 EC CA D0 FB D2 E6 DC FD CA D2 DF F9 FF C5 7B C7 CC E0 D9 D8 CB F7 E3 C8 D3 E2 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 9D E0 F5 DE 98 87 F5 E7 00 00 49 03 08 07 05 02 0F 04 0D 0D 03 09 00 07 05 05 0E 0D 1B 00 04 0D 0B 10 07 06 20 0E 2B 27 0F 01 0E 0D 04 0D 0F 0A 08 13 02 0B 1C 03 0D 0D 08 08 19 0A 0F 0C 17 15 0F 09 09 22 05 08 12 20 00 08 00 20 00 00 2C 00 04 36 0B 0B 00 00 2E 02 0E 0E 1A 01 0F 04 44 15 44 04 08 4B 03 18 1C 05 35 6A 12 13 02 0F 28 02 03 0B 04 07 07 07 06 02 0B 02 01 00 03 10 03 02 FF 05 06 0E 01 01 41 6D 68 00 04 02 22 20 42 20 10 3C 37 89 60 68 23 00 40 14 C0 4C 56 42 60 47 A8 C1 38 77 51 04 84 8D 13 7B C0 0E 02 86 44";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Neon"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.IsabelleEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = HexResearcher.Convert(SwapOffsets[1], SwapPath[1], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head added";

            bool Swap3 = HexResearcher.Convert(SwapOffsets[1], SwapPath[1], Hat, Hat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat added";

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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.IsabelleEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = HexResearcher.Revert(SwapOffsets[1], SwapPath[1], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head removed";

            bool Swap3 = HexResearcher.Revert(SwapOffsets[1], SwapPath[1], Hat, Hat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat removed";

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
