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

        string Body = "8C 0A 00 05 0B 88 05 09 00 00 00 00 00 00 00 00 00 03 8B 20 00 80 20 0A 40 00 00 00 A4 06 E8 06 70 01 58 08 80 08 10 09 38 09 04 47 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 5F 46 5F 4D 45 44 5F 00 75 2E 66 5F 41 6E 69 6D 42 50 00 85 2E 5F 43 00 77 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 00 97 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 25 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 AB AA 1F 92 BA 5A 62 00 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 42 3B B4 D1 23 0F 79 B6 C3 6B 24 65 50 F8 7E B8 82 C5 A8 4B 04 02 C0 95 4A 00 47 C8 05 F9 2E 7D BD CD 5A 4C 18 98 00 15 07 38 39 02 65 DF 05 59 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B E2 4A A6 AD 8D 27 9B 90 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 20 0A 12 00 15 01 01 FF FF FF FF FF FF FF FF 32 4B 14 8D 14 10 93 92 EC 2A A5 0B 04 00 01 00 03 06 00 06 08 02 04 04 81 02 01 02 04 03 01 02 02 01 01 00 00 00 04 02 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 AB C8 95 96 92 92 92 92 92 92 41 00 30 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 35 49 30 78 C0 82 01 79 B8 81 01 87 82 01 79 E8 7C F8 F8 F8 B8 26 87 7A C8 20 28 82 01 79 F8 90 89 87 87 46 91 25 87 87 24 87 87 8C 23 87 87 4E 87 8A 87 87 4D 49 24 32 79 F0 C8 CF 20 20 28 79 20 32 20 40 87 29 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 31 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 55 30 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 5C 00 30 00 49 00 18 00 11 00 46 00 60 00 FA 00 ED 00 EE 00 1E 01 1D 00 61 00 77 00 77 00 68 00 1D 00 87 00 BC 02 95 00 25 00 04 03 79 00 99 00 15 00 BD 00 57 01 5B 00 22 00 26 00 30 01 51 00 71 00 5D 04 33 00 4B 00 C0 00 1D 00 19 00 15 00 0C 00 65 01 35 00 5B 00 26 00 64 00 58 01 1A 00 2A 01 15 00 18 02 1D 00 13 00 4D 02 60 00 39 01 15 00 60 00 04 02 40 00 AC 01 85 01 0B 05 86 03 1E 01 17 00 72 02 6D 00 21 00 31 00 82 00 3D 00 10 00 A9 06 08 00 9E 01 08 00 10 00 48 00 10 00 87 08 48 00 08 00 28 00 88 00 10 00 88 00 03 09 80 00 08 00 9C 00 23 00 10 00 00 00 00 0A 04 04 0B 1C FE 15 00 8C 0A 00 05 0B 88 05 09";
        string Body1 = "8C 06 00 04 E8 88 04 E6 00 00 00 00 00 00 00 00 00 03 89 20 00 80 20 0A 40 00 00 00 A4 06 E8 06 70 01 58 08 80 08 10 09 38 09 04 47 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 5F 46 5F 4D 45 44 5F 00 75 53 63 68 6F 6C 61 2E 00 66 5F 41 6E 69 6D 42 50 00 85 5F 43 77 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 5F 00 97 2E 65 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 25 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 3A 3A 00 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 46 6C 61 67 49 6E 64 65 78 00 11 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 AB AA 1F 92 BA 5A 62 00 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 42 3B B4 D1 23 0F 79 B6 C3 6B 24 65 50 F8 7E B8 82 C5 A8 4B 04 02 C0 95 4A 00 47 C8 05 F9 2E 7D BD CD 5A 4C 18 98 00 15 07 38 39 02 65 DF 05 59 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B E2 4A A6 AD 8D 27 9B 90 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 20 0A 12 15 01 01 FF FF FF FF FF FF FF FF 00 32 4B 14 FF 8D 14 10 93 92 EC 2A A5 0B 00 04 00 00 03 06 06 08 02 04 04 81 02 01 02 04 03 01 02 02 01 01 00 02 80 05 01 08 00 00 00 01 00 00 00 00 00 00 00 00 00 85 5C 03 03 02 02 02 02 02 02 D9 D3 83 D3 C9 FF E1 38 3D D0 D3 DD D8 CC 38 FE F7 D4 D1 D4 D4 FD FD FF D4 F0 D4 7A DC FD CB D7 38 C9 CC FE F1 38 DB 01 CB CB CB DF DF DD CB D2 FD 1F C8 C8 CC F5 C8 D2 C8 D8 CF EB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 EC DC E8 D8 CA D2 E0 DF D3 D2 FA C7 38 3B D3 DC D9 D8 EB F7 E7 CC CA D3 15 45 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 E5 DC 1E 94 E7 D4 F5 1B 00 00 60 08 01 00 09 0E 08 02 05 06 16 05 09 01 0D 0F 06 1D 00 00 07 00 0E 0D 00 07 14 1A 0D 1C 01 01 0D 05 17 0C 0A 0E 2E 09 09 25 0B 03 08 05 01 0D 04 16 0D 03 0E 0C 10 08 12 0D 26 05 0B 23 08 11 08 0D 07 0B 14 1D 23 25 16 0F 1A 05 09 09 0A 05 08 2B 00 3A 08 00 0F 00 00 08 08 08 00 04 32 02 08 00 00 2D 02 03 47 0C 16 08 33 16 02 22 03 00 4E 06 3E 32 03 06 66 15 02 0F 13 11 1A 01 15 04 05 07 05 00 01 04 01 04 06 08 03 02 FF 05 06 0E 01 21 3F E1 55 56 A8 73 BF 37 C2 8A A0 83 55 4C 06 11 82 1D 60 62 33 8B A0 03 89 B4 00 00 A2 14 0C 00 B8 B0 C1 54 27 05 9F 28 21 10 2B 06 85 81 8B 0D DD 00 50 C1 0B 48";

        string Head = "8C 0A 00 04 3E 88 04 3C 00 00 00 00 00 00 00 00 00 03 01 20 00 80 F1 08 40 00 00 00 AD 05 F0 05 30 01 20 07 48 07 D8 00 08 04 4C 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 43 79 62 72 53 63 61 76 65 6E 67 00 74 50 6C 61 79 65 72 46 5F 4D 45 44 5F 41 53 4E 5F 53 74 61 72 66 69 73 68 30 31 2F 4D 61 74 65 72 69 61 6C 5F 48 61 69 72 4E 6F 6E 65 00 98 2E 68 65 73 68 65 00 83 2E 75 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 9F 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 05 18 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 04 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 00 00 00 00 8A 7F 39 70 F9 11 74 41 B6 53 3F 10 FD A0 05 59 14 F6 E2 52 CE 4B 9C DF 5F DE E2 20 D5 C2 9F 6D 8B FE C7 62 25 96 84 DF A4 42 48 D2 80 09 EA 0B 37 80 64 53 C2 12 D2 16 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 2B 9D 6C 17 4C 05 E1 2A AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 F1 08 12 00 10 01 01 FF FF FF FF FF FF FF FF 03 09 37 00 0F 32 24 CC 31 50 B9 67 9B 0B 04 00 01 08 03 06 00 04 09 02 04 02 04 02 04 03 02 02 01 04 80 05 01 02 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 93 C8 95 96 92 92 92 92 99 92 41 87 87 53 87 87 87 87 21 8E 87 91 7A 90 7E B0 87 87 34 87 7C E8 87 84 01 79 F8 B0 F9 F8 F8 F8 E0 7C E8 82 01 79 E0 81 01 87 87 81 01 79 F8 C8 87 8F 87 43 91 25 87 87 24 87 87 8C 87 87 87 4E 31 79 D0 CF 20 28 79 20 32 20 40 87 29 87 7B C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 4C 7A 7D 98 FF 2C 29 50 41 40 87 87 25 7E 55 28 00 30 32 99 99 39 40 87 C1 40 40 32 B2 B9 40 40 40 40 87 5A 59 59 79 7B 87 9E 79 47 00 30 00 0B 00 09 00 4E 00 46 00 56 00 25 00 76 00 9A 00 22 00 6A 00 85 00 85 00 77 00 28 00 15 00 C5 00 4B 00 22 00 38 00 AF 03 26 00 76 00 19 00 0B 04 15 00 0C 00 2A 03 35 00 57 00 22 00 60 00 0A 01 1A 00 DC 00 15 00 D2 01 1D 00 13 00 07 02 10 00 2E 01 2D 01 D4 00 17 00 F2 03 DE 01 57 00 21 00 31 00 78 02 3D 00 10 00 B1 05 0F 07 08 00 10 00 48 00 10 00 4F 07 08 00 28 00 88 00 10 00 88 00 CB 07 80 00 08 00 9C 00 23 00 3E 00 00 00 00 19 0D 0D 1A FC 07 00 8C 0A 00 04 3E 88 04 3C";
        string Head1 = "8C 06 00 04 2C 88 04 2A 00 00 00 00 00 00 00 00 00 02 FC 20 00 80 F1 08 40 00 00 00 AD 05 F0 05 30 01 20 07 48 07 D8 00 08 04 4C 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 43 79 62 65 72 53 63 61 76 65 6E 67 00 74 50 6C 61 79 46 5F 4D 45 44 5F 41 53 4E 5F 53 74 61 72 66 69 73 68 30 31 2F 4D 61 74 65 72 69 61 6C 5F 48 61 69 72 4E 6F 6E 65 00 98 2E 6E 00 68 65 73 68 65 00 83 43 41 55 5F 4A 61 6E 65 75 5F 41 6E 69 6D 42 50 5F 69 6C 64 00 9F 5F 43 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 05 18 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 0B 49 6E 74 15 46 6C 61 67 73 49 6E 64 65 78 00 11 73 00 04 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 4D 65 73 68 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 8A 7F 39 70 F9 11 74 41 B6 53 3F 10 FD A0 05 59 14 F6 E2 52 CE 4B 9C DF 5F DE E2 20 D5 C2 9F 6D 8B FE C7 62 25 96 84 DF A4 42 48 D2 80 09 EA 0B 37 80 64 53 C2 12 D2 16 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 AD 2B 3A 82 6E B6 DB 6B 2B 9D 6C 17 4C 05 E1 2A AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 F1 08 12 10 00 01 00 00 00 01 FF FF FF FF FF FF FF FF 00 03 09 37 0F FF 32 24 CC 31 50 B9 67 9B 0B 00 04 00 00 08 03 06 04 09 02 04 02 04 02 04 03 02 02 01 00 80 05 01 02 01 00 00 00 00 00 00 00 00 00 74 5C 03 03 02 02 02 02 05 02 D9 E3 81 CB 03 FE 83 CC 38 D3 EB 38 FF FD 3F EB 38 FE D3 38 F8 D4 F8 D4 D0 FD 03 FF EC D4 38 EC DE C8 DB 01 CB CB DF D1 DD 38 1F C8 CC F5 C8 D2 C8 D8 CF DB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 D2 E0 DF F9 C3 38 3B CF D1 DC D9 D8 F7 E7 C8 CA D3 15 01 D7 D8 1B 58 D4 93 15 D5 94 D9 D8 58 D7 45 E5 55 E5 D8 1F 94 E7 D4 E7 00 00 4D 08 03 01 06 0E 0E 0D 0E 02 15 02 0E 06 08 0F 1F 10 07 04 07 11 0C 1C 00 0D 0D 0F 0A 00 27 0E 0E 01 23 0D 04 28 0D 0F 0A 08 12 04 04 0D 20 05 0B 25 0B 16 15 0C 0F 24 16 0F 09 09 05 08 14 1A 32 08 00 0F 00 00 08 08 08 00 04 36 0E 0B 00 00 2C 02 03 0E 17 0C 00 01 0F 08 08 63 11 00 37 01 21 05 57 05 02 4F 13 02 0F 2B 04 05 07 05 00 01 02 04 00 1A 02 FF 03 05 00 06 00 0A 01 20 31 96 10 C7 80 00 86 22 04 A2 98 0A E2 C6 10 82 80 30 52 38 12 00 80 C4 01 10 81 4E 34 10 01 54 83 10 80 4C 89 85 30 9F 5E C0 88 40";

        string Hat = "8C 0A 00 04 73 88 04 71 00 00 00 00 00 00 00 00 00 03 26 20 00 80 30 09 40 00 00 00 DE 05 20 06 40 01 60 07 88 07 18 08 40 08 04 4B 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 61 63 41 63 63 65 73 6F 72 69 65 73 2F 43 50 5F 46 5F 4D 45 44 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 6D 50 6C 79 65 72 2F 46 65 6D 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 5F 2F 4D 65 73 68 65 73 2F 5F 00 8B 2E 74 5F 41 6E 69 6D 42 50 00 9B 2E 5F 43 00 7A 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 9D 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 74 00 0C 42 6F 6F 6C 0C 42 79 74 65 11 54 79 70 65 00 05 1B 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 64 00 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 00 00 00 64 C1 00 00 00 00 90 9F 52 7C D3 46 E5 78 0A A8 6C 6A 03 E7 A0 73 BC 5B A2 A5 B6 16 30 03 E7 20 C1 43 18 3A D3 F2 E1 82 2D 9C B1 A6 EF 5E A3 EB C6 B1 B9 8C 1C 2A 4A 8A 48 05 6D CB 82 54 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 4E 33 CB B8 4D 71 F7 CB 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 30 09 12 00 01 01 FF FF FF FF FF FF FF FF 42 3C 11 2B 67 92 7F F1 90 AF B9 0B 04 00 01 07 03 00 02 01 02 85 02 02 02 04 02 04 02 04 03 01 02 05 01 02 80 05 01 06 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 97 C8 95 96 92 92 92 92 92 92 41 87 87 53 87 8A 8D 87 87 87 87 7F 90 8A 8F 87 26 58 49 87 29 78 B8 39 82 01 79 F8 81 01 87 82 01 79 F8 B0 7C F8 F8 F8 B8 26 87 7A C8 20 48 81 01 79 F8 A8 89 87 87 46 91 25 87 87 24 87 87 87 87 8F 4F 4D 69 36 79 E8 CF 20 28 79 20 32 20 40 37 87 7B C8 79 70 22 30 87 79 90 32 5A 48 79 A0 22 32 8F 4E 7A 7D 98 FF 87 2B 50 41 40 87 87 25 7E 5D 00 30 52 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 22 E1 87 87 9B 79 4D 00 30 00 0B 00 4D 00 4A 00 47 00 48 00 7D 00 23 00 93 00 6F 00 8D 00 8D 00 76 00 25 00 9D 00 5E 02 A5 00 25 00 8F 01 7C 00 9F 00 15 00 C3 00 60 01 1F 00 0E 00 E8 03 56 00 E3 03 D1 00 97 00 19 00 56 00 15 00 0C 00 42 01 35 00 57 00 22 00 60 00 2B 01 1A 00 13 00 F4 01 1B 00 F5 00 15 00 80 00 40 00 41 01 D2 00 17 00 FD 01 57 00 21 00 31 00 B2 03 3D 00 10 00 4F 07 08 00 10 00 48 00 10 00 8F 07 48 00 08 00 28 00 88 00 10 00 88 00 0B 08 80 00 08 00 9C 00 2A 00 43 00 00 00 00 12 12 19 1F FF 0B 00 8C 0A 00 04 73 88 04";
        string Hat1 = "8C 06 00 04 5D 88 04 5B 00 00 00 00 00 00 00 00 00 03 21 20 00 80 30 09 40 00 00 00 DE 05 20 06 40 01 60 07 88 07 18 08 40 08 04 4B 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 61 63 65 41 63 63 65 73 73 6F 72 69 65 73 2F 43 50 5F 46 5F 4D 45 44 5F 43 79 62 65 72 53 63 61 76 65 6E 67 65 72 42 6C 75 65 00 6D 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 5F 2F 4D 65 73 68 65 73 2F 5F 00 8B 53 63 68 6F 6C 61 2E 00 74 5F 41 6E 69 6D 42 50 00 9B 5F 43 7A 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 9D 2E 65 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 65 74 00 0C 42 6F 6F 6C 0C 42 79 74 65 11 54 79 70 65 00 05 1B 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 0B 49 6E 74 15 46 6C 61 67 73 49 6E 64 65 78 00 11 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 90 9F 52 7C D3 46 E5 78 0A A8 6C 6A 03 E7 A0 73 BC 5B A2 A5 B6 16 30 03 E7 20 C1 43 18 3A D3 F2 E1 82 2D 9C B1 A6 EF 5E A3 EB C6 B1 B9 8C 1C 2A 4A 8A 48 05 6D CB 82 54 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 4E 33 CB B8 4D 71 F7 CB 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 30 09 12 00 01 01 FF FF FF FF FF FF FF FF 00 42 3C 11 FF 2B 67 92 7F F1 90 AF B9 0B 00 04 00 00 07 03 04 02 01 02 85 02 02 02 04 02 04 02 04 03 01 02 05 02 80 05 01 06 00 00 00 01 00 00 00 00 00 00 00 00 00 7B 5C 03 03 02 02 02 02 02 02 D9 E3 81 FF 43 CB E4 DD D7 C8 38 D5 FE CF 38 D4 ED D4 FD FD FF D4 F0 D4 7A 38 5C FD CB DB 38 C8 DC 3D F4 FC FD DB 01 CB CB DF DF ED D3 E9 38 1F C8 CC F5 C8 D2 C8 D8 D3 DB 38 D9 38 CC CA D0 FF D2 E6 C8 CC C5 38 CA D2 DF F9 C3 38 3B D3 DC D9 D8 CB F7 E7 84 0A D3 E2 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 E5 D8 1F 94 CB 95 48 C8 1B 00 00 51 08 03 05 02 0F 00 05 0B 0B 07 0F 03 06 1F 00 04 0B 06 12 0D 1B 16 1F 0D 14 09 04 07 0D 0B 10 07 06 20 0E 2B 18 0F 01 29 0D 04 16 0D 0F 0A 08 13 04 0B 27 03 07 0D 0D 0F 0B 19 0A 0F 15 0F 09 09 25 05 08 2B 00 08 00 0F 00 00 08 08 08 00 04 03 08 00 00 2C 02 03 0E 2D 00 01 0F 05 22 03 10 5C 06 44 32 03 06 22 27 10 15 02 0F 28 02 03 04 04 07 05 00 0B 02 04 06 10 03 02 FF 05 06 00 0D 01 24 37 85 00 F0 02 11 70 40 21 84 16 8A 6B 98 26 3C 5B 00 40 07 10 50 00 24 05 03 BC 11 82 C1 1E 20 42 60 C1 C6 89 4D 8A 0A F5 21 2C 88 40";

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
            LogBox.Text += "\nConverted!";
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
