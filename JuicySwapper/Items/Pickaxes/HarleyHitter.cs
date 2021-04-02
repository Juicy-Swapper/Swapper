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

namespace JuicySwapper.Items.Pickaxes
{
    public partial class HarleyHitter : Form
    {
        bool enabled = Settings.Default.HarleyHitterEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "HarleyHitter";

        public HarleyHitter()
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

        string Pickaxe = "8C 0A 00 0E A9 88 0E A7 03 00 00 00 00 00 00 00 00 0A 3B 00 20 04 80 FE 18 40 00 00 00 6E 12 B0 12 B0 04 60 17 B8 17 00 18 18 18 40 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 57 65 61 70 6F 6E 73 2F 41 62 69 6C 69 74 69 65 73 2F 47 41 42 5F 4D 65 6C 65 65 5F 49 6D 70 61 63 74 43 6F 6D 62 6F 5F 41 74 68 65 6E 61 00 60 2E 5F 43 00 2D 57 49 44 5F 48 61 72 76 65 73 74 5F 50 69 63 6B 61 78 48 6F 6F 64 69 65 42 61 6E 64 69 74 46 65 6D 61 6C 65 00 62 53 6F 75 6E 64 41 73 2F 5F 45 6E 65 6D 79 5F 43 75 65 00 8D 2E 5C 71 75 69 70 81 2E 5C 53 77 69 6E 67 00 81 2E 3E 45 66 66 65 63 74 73 2F 46 6F 72 74 5F 2F 50 54 72 61 69 6C 5F 44 65 66 61 75 6C 74 00 54 2E 49 41 6C 74 65 72 61 74 69 44 61 6D 61 67 65 54 79 70 65 42 61 73 00 65 2E 24 44 61 74 61 74 62 6C 65 73 2F 4C 6F 6F 74 4C 65 76 65 6C 00 33 50 6C 61 79 5F 2F 43 6F 6C 6C 65 63 5F 00 40 2E 29 55 49 48 55 44 2F 55 49 5F 52 61 64 61 72 44 6F 74 5F 57 68 69 74 65 00 54 75 6E 64 2F 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 54 2D 2D 73 2D 00 56 2D 4C 00 7C 2E 78 2E 3C 46 4F 52 54 5F 42 6C 75 65 70 72 69 6E 74 73 2F 42 47 65 6E 65 72 69 63 00 57 2E 5F 43 00 27 4D 65 73 68 65 73 2F 53 4B 00 2F 2E 5F 5F 5F 44 65 6D 6F 5F 00 84 2E 13 2F 53 63 72 69 70 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 47 61 6D 47 61 6D 65 70 6C 61 79 54 61 67 73 41 63 74 75 61 6C 41 6E 61 6C 79 74 69 63 46 4E 61 6D 65 0C 0A 41 6E 69 6D 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 17 42 61 63 63 68 75 73 2E 2E 00 14 62 41 6C 6C 6F 77 4D 75 6C 74 69 70 6C 65 53 74 61 63 6B 73 00 0E 00 16 43 6F 73 6D 65 74 69 63 1D 62 43 61 6E 42 65 44 65 70 6F 73 69 74 65 64 49 6E 53 6F 72 61 67 65 56 0D 72 6F 70 70 65 64 00 15 62 49 6E 76 65 6E 74 6F 72 79 53 69 7A 65 4C 69 6D 00 10 62 53 74 6C 65 6E 00 12 48 61 73 44 75 72 61 79 00 0F 62 4E 65 76 65 72 50 65 72 73 69 73 0C 42 6F 6F 6C 1F 62 53 6F 77 44 69 72 65 63 61 6C 41 72 72 6F 77 57 68 6E 46 61 72 4F 66 66 00 0C 42 79 74 65 08 43 61 74 65 67 6F 72 79 00 05 43 6C 61 73 73 00 0A 43 6F 6C 75 6D 6E 4E 09 54 00 17 48 61 6E 64 6C 65 00 12 52 6F 77 26 5F 5F 44 65 66 69 6E 69 2A 44 69 73 61 73 73 65 6D 62 6C 65 44 65 67 72 61 64 4D 61 78 50 65 72 63 65 6E 74 72 69 6E 0B 72 6F 70 00 14 45 46 69 00 1F 3A 3A 49 6E 76 69 73 69 0D 74 65 6D 00 1C 3A 3A 00 0B 52 61 72 11 3A 3A 52 61 72 65 00 1D 65 6C 6F 61 64 46 58 53 74 61 74 65 3A 3A 45 6E 64 00 1D 45 4E 6F 72 6D 6C 00 16 54 72 69 67 67 65 72 21 3A 3A 41 75 74 6F 6D 61 74 69 63 00 0C 45 6E 75 6D 0E 4F 76 65 72 72 64 65 00 0D 46 6C 6F 61 74 1D 1C 2E 53 6F 75 72 63 65 2E 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 22 47 72 61 6E 74 65 64 2E 70 65 64 2E 2E 07 1C 5F 54 30 31 00 26 4E 69 61 67 61 72 61 50 68 79 73 69 63 61 6C 53 75 72 66 61 63 65 4D 61 70 00 1F 1E 0B 49 6E 74 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 0D 0B 4D 61 70 10 4D 69 6E 69 4D 61 42 72 75 73 68 00 17 56 69 65 77 44 69 73 74 63 65 00 08 4D 69 6E 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 12 50 69 63 6B 75 70 53 6B 65 6C 65 6C 00 19 65 72 12 50 72 69 6D 61 72 65 41 13 06 0F 0E 52 65 73 0B 52 6F 77 65 6E 74 73 00 07 52 6F 77 0C 53 74 72 75 63 74 00 0A 53 6C 61 74 65 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 31 00 0D 30 31 32 33 34 35 36 37 38 39 32 32 32 32 32 32 32 32 0C 33 34 35 36 37 38 39 00 13 31 54 61 67 3A 77 69 64 5F 68 70 68 62 66 0C 54 65 78 09 32 44 00 0B 17 14 77 2E 6D 68 1B 57 4D 10 41 63 74 6F 72 12 73 68 00 00 00 64 C1 00 00 00 00 0B D1 54 AD B0 36 D6 B0 31 C6 07 E6 D6 98 1D 41 15 AE 8B 5D C4 AF 66 B7 D8 ED CB D5 B0 DA D5 38 85 08 D6 7D 1E 2D 82 A6 36 C1 95 B1 27 FF 61 51 A6 F9 38 3E F3 17 F6 88 3E 64 F1 FD 70 1A 4C 0B 7C 4A DF C0 5E E3 B0 7C 7E 46 0B 0E FE 6B E1 9D 98 A6 74 0D 29 D4 7A ED E9 1E AB C4 EF C3 47 DF 97 12 57 94 1A 56 9C 5B 77 31 AE 43 97 F2 D2 4D C6 49 D5 95 6D EB 66 81 0A 77 E9 06 E7 BE A2 5E DF 46 D7 E7 82 7B 85 3E 69 24 A4 BF A9 0D 8E 46 87 D8 99 FE 59 0E D4 A4 BA 2A F8 31 AB F7 9F 8A 40 5C 28 1B 4D F3 AE C3 B6 CE 45 D0 50 88 2E E5 D8 60 89 E8 47 C7 DA 65 DD CF D2 12 72 8E 7B 88 0E 93 5A 2D 39 33 53 DC DA D7 F8 9B B0 34 09 1C DA 66 80 58 78 DD 5C 9A 75 B1 E4 C6 FF 76 69 E4 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 48 19 53 EC 0C 40 73 F8 AF B7 92 36 2D 68 5A A4 81 D1 E0 4B 04 45 1A AD A8 E3 AA B3 3D 77 5A FD A0 20 73 C6 7C A3 4D 60 70 43 75 60 EC 4C 78 16 62 56 ED 6A 62 7F A3 64 76 29 07 38 53 1D 99 F3 C6 E0 08 33 EB 3D 3B CD C9 3F C7 F6 28 38 8D 19 A2 44 42 19 0C 65 C8 36 85 42 31 66 36 5F 4A 81 55 39 E0 39 25 C8 BE 72 05 7A D2 09 00 D0 4F 72 8C 42 6E ED 60 B5 71 51 DE 72 84 89 5C 9A 9C B3 82 41 8D 74 2F BD D4 3F EE 28 C6 A7 41 C8 CC 73 5F F1 4F 17 98 E8 CF E5 AD 2B 3A 82 6E B6 DB 6B 32 55 D7 A3 91 04 09 AB 30 82 61 5F 9C 0A 20 71 FD 76 36 27 1D 07 CF 3B 40 26 15 6F 0D 82 0A EC 96 68 BA D1 CD 48 38 89 81 59 E1 AD 58 C4 11 82 5C B7 1B 1A EC 38 C4 FE F0 34 0E 22 8B 92 6F 39 69 A6 DD 0A AF FC 40 08 DF 48 95 A5 38 5B 65 33 6A 4D F9 A0 08 91 48 26 1D 33 27 6A 0A FF 98 D9 03 AA 02 AA C3 9D C8 B2 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 33 F5 AB 82 62 D3 37 BF 33 FA DE 60 E0 83 2C B5 21 CC FF 36 3F 64 F6 0E 6C 5B 34 36 C2 65 C1 19 49 A9 9A F8 07 86 51 53 81 EF 67 6F 2D FF B7 2E D6 3C 55 A9 1E BB 6B 14 C9 65 36 94 30 C1 46 43 32 7A 8D 3F CF 98 83 9A C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 F5 61 D3 13 E3 AE 45 67 51 6A 6B A4 FC 3C 8C B9 13 EF E4 4D EC 00 34 91 C0 35 F0 CA 0B 23 C7 A4 67 B2 81 01 45 B1 5C 1B 3B EF E8 2F 13 C9 5D 75 DB 6F A3 73 A1 40 EA 11 32 50 77 C1 15 8A CC DD 39 01 5A 81 FE 31 FD 3B C2 EB B3 D9 30 59 00 D8 39 EF 4F A7 76 A4 62 F1 AD A2 3A C4 F4 A0 70 E1 C7 B9 E7 7B 86 0C 16 F3 2C 81 58 FF 04 7A 02 F6 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 6F C3 D4 37 FA 05 00 64 FD 3A 01 16 7B 9B 70 4E 5C F2 3B E6 12 F3 D7 48 78 C0 7E 96 90 03 5B 64 62 6D 93 AB 1A AE 7B 81 3C 4E 34 7F FF 33 3D EE B4 69 A9 78 E1 B4 8A A0 BC 73 EF 85 64 E9 0F 33 D9 4C 9B 5B E6 85 49 12 8C 86 10 8D A1 65 4C 44 33 9B 6F 71 90 95 97 78 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 50 3E ED 54 1E 2A 29 1F 17 93 19 0B 03 11 A3 4E BD 10 ED 87 4D 19 44 D2 A0 6A BA 78 E5 13 A9 90 FA 5D 74 F1 6F 69 0A 0C 26 B0 88 7A FC F8 4F FB C8 AC 71 36 39 86 87 21 2F 1A 3B 8C 87 D6 E7 D7 0C 3A 87 FE F5 B5 AE 69 DD 9A E9 69 B3 4D 26 FE 1B 5F 6B A9 F9 B2 F7 A1 33 C2 F2 92 F8 52 DC C7 74 7C 48 00 17 B5 C6 E5 C5 C8 83 BE 3E 2B 74 3E 7D 74 06 36 3C BB 64 26 A2 0F 39 26 E7 5C 52 40 AE B8 5F CA 47 BB CE 45 20 6F DD 36 8F 63 93 D3 25 3C DF 24 4E A2 AF D0 EA CE 9F 36 F1 F2 81 30 50 EC 69 F5 D1 93 BB 24 97 34 7A 18 D3 DB 6B D9 B6 60 ED 41 41 00 CA 6A 99 61 FB A7 19 16 64 02 72 83 FB 15 01 01 D9 10 DE 28 B5 8C AF E4 76 73 59 BF 58 F0 6D 5D AB 2F 2D B0 B4 48 C3 6C 08 10 6D 96 ED 9B D4 26 21 AB 65 B1 29 8A E4 43 6B BD AB 37 2F 90 F5 35 5D D9 45 CB 2F 95 B6 78 D9 36 AA 43 29 82 A8 B4 57 53 8B 0B 78 8B 6A 02 72 D6 A0 E5 46 23 43 BC A5 E9 A8 C1 B4 45 E3 CC C3 EE 6B D9 42 B9 46 36 32 22 9B 3C 18 BD A2 C0 70 71 F5 BE 6A 02 4A 12 54 79 33 A4 13 A3 8C 1B 47 8A AB 86 89 D3 4C 77 CF 88 EB DE 92 B2 B4 3F 6B 74 FF FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 25 8E DB EE 36 40 10 95 FE 18 57 06 94 00 55 94 04 E0 D0 58 3B 9F 0B 00 00 00 02 00 01 4A 58 D3 32 1D 62 DD 4F 01 9C 26 68 43 F8 ED 5F 9E 44 22 02 70 C1 D2 0B E8 07 02 07 02 01 02 04 06 04 04 01 02 05 04 01 02 09 02 16 06 11 04 01 06 0A 04 01 02 0D 02 03 02 03 03 04 01 02 04 04 02 02 0A 05 0B 1B 89 5E 6F 7A 82 83 84 85 86 87 88 70 71 72 73 74 75 76 77 78 79 7B 7C 7D 7E 7F 80 81 5E 04 05 00 85 86 43 44 09 17 1B 05 FE FF FF FF 51 00 0D 01 01 8F 4F 02 8A 40 9C 45 03 03 F5 FF FF FF 07 FD FF FF FF 32 50 00 19 10 CD CC CC 3D CD CC CC 3E 02 17 14 01 21 32 32 42 33 33 30 36 36 34 33 33 34 39 30 46 34 32 38 44 39 45 42 38 34 30 36 46 35 45 37 36 41 69 6E 67 20 54 6F 6F 6C 90 4B 25 15 14 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 36 C0 96 96 92 92 92 92 92 92 41 00 78 F8 F8 F8 A8 79 E8 7C E0 30 28 38 78 F0 87 87 94 87 87 EE 55 20 91 7A 98 30 78 B0 36 86 01 79 F8 E8 F9 F8 F8 F8 F8 C8 2C 81 01 79 F8 B8 F1 F0 F0 F0 F0 E8 A5 82 01 79 F0 C0 B1 87 3E 48 28 3A 87 87 79 F8 F8 F8 90 79 B8 A9 38 87 21 87 63 5B 38 30 7A F8 F8 F8 E8 79 E8 E1 8D 87 27 2A 30 38 20 2D 30 8F 21 7A F8 F8 B0 69 B1 32 87 35 87 5C 2B 87 4F 38 22 39 62 38 7A F8 F8 F8 F8 C8 7C F8 F8 F8 F8 D8 79 F8 C0 F9 F8 F8 F8 F8 C8 79 F8 B0 A9 48 35 87 3D 48 87 7A F8 F8 F8 79 C8 7C D0 87 2A 7A F8 C8 41 F9 D0 70 31 39 34 78 D8 A1 82 01 79 F8 B8 27 87 44 87 39 28 5F 87 95 87 87 95 41 28 2D 87 87 7C A0 87 3A B9 87 87 87 73 22 87 59 87 87 8D 2E 39 87 87 87 24 23 28 8A 2D 2F 87 87 21 4D 8B 27 87 8A 87 4E 87 87 87 24 21 21 4A 40 87 49 3B 39 22 30 28 20 2E 87 55 8E 23 7F F9 E2 99 20 38 2B 23 48 22 7A A8 87 21 31 23 6A 32 38 2A 23 59 87 31 87 37 56 28 38 8C 5B 2F 79 B8 87 87 4B 31 8D 87 4A 79 F8 41 31 37 5A 5A 87 6C 87 22 28 2C 41 41 79 48 36 87 87 87 39 35 78 D8 F9 B0 28 28 54 48 87 2F 71 4C 8F 20 3F 24 94 2F 55 2F 50 25 87 95 21 22 3A 68 26 3B 51 30 20 39 31 50 2C 38 24 87 2A 31 87 36 6E 7D 21 58 31 28 63 71 F1 F1 F1 F1 F1 F1 F1 F1 69 E9 F1 F1 F1 F1 F1 F1 91 D9 69 E9 E9 E9 E9 E9 DB 48 3C 3E B9 29 29 31 54 39 64 79 C8 2A 2A B9 32 A9 28 50 31 35 41 3A 48 20 40 78 F8 C8 00 78 87 87 87 87 36 32 B2 40 40 40 40 87 42 5C 99 39 87 5A 87 61 87 E1 87 87 87 87 9D 27 7C 99 39 59 79 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 39 81 01 59 FA 78 F9 A0 F1 68 41 78 A0 B9 D9 59 61 B6 D2 68 61 99 59 B9 59 69 87 8A BE B2 59 59 87 21 64 99 87 87 87 87 2C 38 87 29 39 39 B9 59 0C 01 30 00 43 00 1D 00 62 00 15 00 3D 00 13 00 D4 00 44 00 38 00 39 00 1C 00 54 00 E0 00 64 00 8F 00 5E 00 5E 00 83 00 5E 00 83 00 0D 00 15 00 29 03 6E 03 40 00 56 00 87 03 15 01 16 00 10 00 10 04 2B 00 4B 00 67 00 14 00 26 00 EA 01 2D 01 11 00 15 00 31 00 0D 00 35 00 42 00 3E 00 D3 03 2B 00 EA 00 A2 02 ED 00 16 00 19 05 6F 02 15 00 56 00 58 00 7E 00 50 01 5D 00 66 03 0D 07 B4 06 3E 00 19 00 59 00 36 00 29 00 31 00 91 07 28 01 28 05 4C 00 25 00 61 00 86 00 CC 03 15 00 10 00 CD 03 16 00 10 00 24 00 80 05 2A 09 13 09 36 05 10 00 18 00 12 06 1F 00 34 00 68 03 2A 00 12 00 59 0A 37 00 F5 00 9A 00 2F 00 96 01 F7 05 0B 06 0B 00 31 00 19 00 14 00 0A 07 E5 01 7B 01 86 01 CE 00 36 01 E2 00 FF 05 2C 00 45 02 C5 00 6A 06 90 00 7C 01 C1 01 16 00 FC 00 21 00 70 07 0F 00 E0 00 50 02 1E 00 AC 01 0D 00 13 00 0F 00 33 01 B5 00 22 00 1F 00 94 00 18 00 F8 01 E7 00 1F 00 B9 01 A7 03 41 08 31 00 C5 03 0D 00 E8 03 67 00 BF 0A 79 00 58 01 09 00 CD 0C 35 0D D8 08 D3 09 28 00 21 00 B2 08 20 00 46 03 1D 02 5D 09 46 09 39 00 35 07 12 00 56 03 46 00 C2 03 6F 05 92 00 7E 00 A2 06 7E 09 76 01 8B 01 06 03 72 04 14 00 01 01 00 01 E3 02 BC 02 19 01 0F 02 01 06 F9 01 96 03 F0 05 01 01 42 01 E1 00 3B 00 10 00 A2 01 13 0B 0E 00 0F 00 A4 00 0E 00 07 0D 1D 05 B8 03 49 08 48 08 85 10 D3 01 8E 0A ED 04 FF 0B 6E 00 3A 04 16 00 D7 03 F7 07 1D 00 01 07 F7 04 1E 05 26 00 8C 05 E3 06 57 11 08 00 7F 17 08 00 40 00 78 00 10 00 70 00 C0 17 0C 00 10 18 1C 00 14 00 28 00 86 00 0C 00 18 00 14 00 08 00 24 02 D4 01 14 00 26 05 EE 04 1C 00 0C 00 31 00 CE 00 0C 00 19 00 18 00 95 00 2B 00 0C 00 46 06 8D 00 4D 00 DB 0B 5F 06 4A 00 08 00 7D 00 00 00 00 04 07 01 01 04 FE E7 00 FC 37 00 8C";
        string Pickaxe1 = "8C 06 00 0E 73 88 0E 71 03 00 00 00 00 00 00 00 00 0A 3D 00 20 04 80 FE 18 40 00 00 00 6E 12 B0 12 B0 04 60 17 B8 17 00 18 18 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 57 65 61 70 6F 6E 41 62 69 6C 69 74 69 65 73 2F 47 41 42 5F 4D 65 6C 65 65 5F 49 6D 70 61 63 74 43 6F 6D 62 6F 5F 00 60 2E 5F 43 00 2D 57 49 44 5F 48 61 72 76 65 73 74 5F 50 69 63 6B 61 78 48 6F 6F 64 69 65 42 61 6E 64 69 74 46 65 6D 61 6C 65 00 62 53 6F 75 6E 64 41 5F 45 6E 65 6D 79 5F 43 75 65 00 8D 4C 6F 6C 6C 69 70 6F 70 5F 54 72 69 63 6B 73 74 65 72 5F 2E 00 00 00 00 00 00 00 5C 71 75 69 70 81 52 64 79 53 77 69 6E 67 2E 00 3E 45 66 66 65 63 74 73 2F 46 6F 72 74 5F 2F 50 54 72 61 69 6C 5F 44 65 66 61 75 6C 74 00 54 2E 49 41 6C 74 65 72 61 74 69 44 61 6D 61 67 65 54 79 70 65 42 61 73 00 65 2E 24 44 61 74 61 74 61 62 6C 65 73 2F 4C 6F 6F 74 4C 65 76 65 6C 00 33 50 6C 61 79 5F 2F 43 6F 6C 6C 65 63 74 5F 00 40 2E 00 29 55 49 48 55 44 2F 55 49 5F 52 61 64 61 72 44 6F 74 5F 57 68 69 74 65 00 54 75 6E 64 2F 54 65 78 74 75 72 65 49 63 6F 6E 54 2D 2D 73 2D 00 56 2D 4C 00 7C 2E 2D 4C 00 78 00 3C 46 4F 52 54 2F 42 6C 75 65 70 72 69 6E 74 73 2F 42 47 65 6E 65 72 69 63 00 57 2E 5F 43 00 27 4D 65 73 68 65 73 2F 53 4B 00 2F 2E 5F 5F 5F 2F 44 65 6D 6F 5F 00 84 2E 00 00 13 2F 53 63 72 69 70 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 70 6C 61 79 54 61 67 73 41 63 74 75 61 6C 41 6E 61 6C 79 74 69 63 46 4E 61 6D 65 0C 0A 41 6E 69 6D 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 17 42 61 63 63 68 75 73 2E 2E 00 14 62 41 6C 6C 6F 77 4D 75 6C 74 69 70 6C 65 53 74 61 63 6B 73 00 0E 00 16 43 6F 73 6D 65 74 1D 62 43 61 6E 42 65 44 65 70 6F 73 69 74 65 64 49 6E 53 74 6F 72 61 67 65 56 0D 72 6F 70 70 65 64 00 15 62 49 6E 76 65 6E 74 6F 72 79 53 69 7A 65 4C 69 6D 00 10 62 53 74 6F 6C 65 6E 00 12 48 61 73 44 75 72 61 79 00 0F 62 4E 65 76 65 72 50 65 72 73 69 73 0C 42 6F 6F 6C 1F 62 53 68 6F 77 44 69 72 65 63 61 6C 41 72 72 6F 77 57 68 65 6E 46 61 72 4F 66 66 00 0C 42 79 74 65 08 43 61 74 65 67 6F 72 79 00 05 43 6C 61 73 73 00 0A 43 6F 6C 75 6D 6E 00 09 54 00 17 48 61 6E 64 6C 65 00 12 52 6F 77 26 5F 5F 44 65 66 69 00 2A 44 69 73 61 73 73 65 6D 62 6C 65 44 65 67 72 61 64 65 4D 61 78 50 65 72 63 65 6E 74 69 6E 0B 72 6F 70 00 14 45 46 69 00 1F 3A 3A 49 6E 76 69 73 69 0D 6D 00 1C 3A 3A 00 0B 52 61 72 11 3A 3A 52 61 72 65 00 1D 65 6C 6F 61 64 46 58 53 74 61 74 65 3A 3A 45 6E 64 4E 6F 72 6D 61 6C 00 16 54 72 69 67 67 65 72 21 3A 3A 41 75 74 6F 6D 61 74 69 63 00 0C 45 6E 75 6D 0E 4F 76 65 72 72 69 64 65 00 0D 46 6C 6F 61 74 1D 1C 2E 53 6F 75 72 63 65 2E 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 22 47 72 61 6E 74 65 64 2E 70 65 64 2E 00 07 1C 43 5F 54 30 31 00 26 4E 69 61 67 61 72 61 50 68 79 73 69 63 61 6C 53 75 72 66 61 63 65 4D 61 70 00 1F 1E 0B 49 6E 08 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 0D 0B 4D 61 70 10 4D 69 6E 69 4D 61 70 42 72 75 73 68 00 17 56 69 65 77 44 69 73 74 61 6E 63 65 00 08 4D 69 6E 00 0C 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 12 75 70 53 6B 65 6C 65 6C 00 19 65 72 12 50 72 69 6D 61 72 79 46 69 72 65 41 13 06 0F 0E 52 65 73 0B 52 6F 77 65 6E 74 73 00 07 52 6F 77 0C 53 74 72 75 63 74 00 0A 53 6C 61 74 65 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 31 00 0D 30 32 33 34 35 36 37 38 39 32 32 32 32 32 32 32 32 36 33 34 35 37 38 39 00 13 31 54 61 67 3A 77 69 64 5F 68 70 68 62 66 0C 09 32 44 00 0B 17 14 77 2E 6D 68 1B 10 41 63 74 6F 72 12 73 68 00 00 00 64 C1 0B D1 54 AD B0 36 D6 B0 31 C6 07 E6 D6 98 1D 41 15 AE 8B 5D C4 AF 66 B7 D8 ED CB D5 B0 DA D5 38 85 08 D6 7D 1E 2D 82 A6 36 C1 95 B1 27 FF 61 51 A6 F9 38 3E F3 17 F6 88 3E 64 F1 FD 70 1A 4C 0B 7C 4A DF C0 5E E3 B0 7C 7E 46 0B 0E FE 6B E1 9D 98 A6 74 0D 29 D4 7A ED E9 1E AB C4 EF C3 47 DF 97 12 57 94 1A 56 9C 5B 77 31 AE 43 97 F2 D2 4D C6 49 D5 95 6D EB 66 81 0A 77 E9 06 E7 BE A2 5E DF 46 D7 E7 82 7B 85 3E 69 24 A4 BF A9 0D 8E 46 87 D8 99 FE 59 0E D4 A4 BA 2A F8 31 AB F7 9F 8A 40 5C 28 1B 4D F3 AE C3 B6 CE 45 D0 50 88 2E E5 D8 60 89 E8 47 C7 DA 65 DD CF D2 12 72 8E 7B 88 0E 93 5A 2D 39 33 53 DC DA D7 F8 9B B0 34 09 1C DA 66 80 58 78 DD 5C 9A 75 B1 E4 C6 FF 76 69 E4 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 48 19 53 EC 0C 40 73 F8 AF B7 92 36 2D 68 5A A4 81 D1 E0 4B 04 45 1A AD A8 E3 AA B3 3D 77 5A FD A0 20 73 C6 7C A3 4D 60 70 43 75 60 EC 4C 78 16 62 56 ED 6A 62 7F A3 64 76 29 07 38 53 1D 99 F3 C6 E0 08 33 EB 3D 3B CD C9 3F C7 F6 28 38 8D 19 A2 44 42 19 0C 65 C8 36 85 42 31 66 36 5F 4A 81 55 39 E0 39 25 C8 BE 72 05 7A D2 09 00 D0 4F 72 8C 42 6E ED 60 B5 71 51 DE 72 84 89 5C 9A 9C B3 82 41 8D 74 2F BD D4 3F EE 28 C6 A7 41 C8 CC 73 5F F1 4F 17 98 E8 CF E5 AD 2B 3A 82 6E B6 DB 6B 32 55 D7 A3 91 04 09 AB 30 82 61 5F 9C 0A 20 71 FD 76 36 27 1D 07 CF 3B 40 26 15 6F 0D 82 0A EC 96 68 BA D1 CD 48 38 89 81 59 E1 AD 58 C4 11 82 5C B7 1B 1A EC 38 C4 FE F0 34 0E 22 8B 92 6F 39 69 A6 DD 0A AF FC 40 08 DF 48 95 A5 38 5B 65 33 6A 4D F9 A0 08 91 48 26 1D 33 27 6A 0A FF 98 D9 03 AA 02 AA C3 9D C8 B2 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 33 F5 AB 82 62 D3 37 BF 33 FA DE 60 E0 83 2C B5 21 CC FF 36 3F 64 F6 0E 6C 5B 34 36 C2 65 C1 19 49 A9 9A F8 07 86 51 53 81 EF 67 6F 2D FF B7 2E D6 3C 55 A9 1E BB 6B 14 C9 65 36 94 30 C1 46 43 32 7A 8D 3F CF 98 83 9A C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 F5 61 D3 13 E3 AE 45 67 51 6A 6B A4 FC 3C 8C B9 13 EF E4 4D EC 00 34 91 C0 35 F0 CA 0B 23 C7 A4 67 B2 81 01 45 B1 5C 1B 3B EF E8 2F 13 C9 5D 75 DB 6F A3 73 A1 40 EA 11 32 50 77 C1 15 8A CC DD 39 01 5A 81 FE 31 FD 3B C2 EB B3 D9 30 59 00 D8 39 EF 4F A7 76 A4 62 F1 AD A2 3A C4 F4 A0 70 E1 C7 B9 E7 7B 86 0C 16 F3 2C 81 58 FF 04 7A 02 F6 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 6F C3 D4 37 FA 05 00 64 FD 3A 01 16 7B 9B 70 4E 5C F2 3B E6 12 F3 D7 48 78 C0 7E 96 90 03 5B 64 62 6D 93 AB 1A AE 7B 81 3C 4E 34 7F FF 33 3D EE B4 69 A9 78 E1 B4 8A A0 BC 73 EF 85 64 E9 0F 33 D9 4C 9B 5B E6 85 49 12 8C 86 10 8D A1 65 4C 44 33 9B 6F 71 90 95 97 78 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 50 3E ED 54 1E 2A 29 1F 17 93 19 0B 03 11 A3 4E BD 10 ED 87 4D 19 44 D2 A0 6A BA 78 E5 13 A9 90 FA 5D 74 F1 6F 69 0A 0C 26 B0 88 7A FC F8 4F FB C8 AC 71 36 39 86 87 21 2F 1A 3B 8C 87 D6 E7 D7 0C 3A 87 FE F5 B5 AE 69 DD 9A E9 69 B3 4D 26 FE 1B 5F 6B A9 F9 B2 F7 A1 33 C2 F2 92 F8 52 DC C7 74 7C 48 00 17 B5 C6 E5 C5 C8 83 BE 3E 2B 74 3E 7D 74 06 36 3C BB 64 26 A2 0F 39 26 E7 5C 52 40 AE B8 5F CA 47 BB CE 45 20 6F DD 36 8F 63 93 D3 25 3C DF 24 4E A2 AF D0 EA CE 9F 36 F1 F2 81 30 50 EC 69 F5 D1 93 BB 24 97 34 7A 18 D3 DB 6B D9 B6 60 ED 41 41 00 CA 6A 99 61 FB A7 19 16 64 02 72 83 FB 15 01 01 D9 10 DE 28 B5 8C AF E4 76 73 59 BF 58 F0 6D 5D AB 2F 2D B0 B4 48 C3 6C 08 10 6D 96 ED 9B D4 26 21 AB 65 B1 29 8A E4 43 6B BD AB 37 2F 90 F5 35 5D D9 45 CB 2F 95 B6 78 D9 36 AA 43 29 82 A8 B4 57 53 8B 0B 78 8B 6A 02 72 D6 A0 E5 46 23 43 BC A5 E9 A8 C1 B4 45 E3 CC C3 EE 6B D9 42 B9 46 36 32 22 9B 3C 18 BD A2 C0 70 71 F5 BE 6A 02 4A 12 54 79 33 A4 13 A3 8C 1B 47 8A AB 86 89 D3 4C 77 CF 88 EB DE 92 B2 B4 3F 6B 74 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 25 8E DB EE 36 40 10 95 FE 18 57 06 94 00 55 94 04 E0 D0 58 3B 9F 0B 00 00 00 00 02 01 03 4A 58 D3 32 1D 62 DD 4F 01 00 9C 26 68 43 F8 ED 5F 9E 44 22 02 70 C1 D2 0B E8 07 02 07 02 01 02 04 06 04 04 01 02 05 04 01 02 09 02 16 06 11 06 0A 04 01 02 0D 02 03 02 03 03 04 04 02 02 0A 05 1B 89 5E 00 6F 7A 82 83 84 85 86 87 88 70 71 72 73 74 75 76 77 78 79 7B 7C 7D 7E 7F 80 81 04 05 05 05 43 07 44 09 17 1B 05 FE FF FF FF 51 0D 00 00 01 8F 00 4F 02 8A 00 40 9C 45 03 03 F5 FF FF FF 00 07 FD FF FF FF 32 50 19 10 00 CD CC CC 3D CD CC CC 3E 02 17 14 01 00 21 32 32 42 33 33 30 36 36 34 33 33 34 39 30 46 34 32 38 44 39 45 42 38 34 30 36 46 35 45 37 36 41 69 6E 67 20 54 6F 6F 6C 90 00 4B 25 15 14 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 CA 58 03 03 02 02 02 02 02 D5 CC 83 D3 FE E9 38 EB 38 CC CC D4 EC 38 03 2F E3 C8 01 80 C0 38 D8 C4 38 D3 FF 1F C0 38 E1 FD C8 FF CF 3D 81 FA 38 DC FC 3F DC BD 92 DB D8 CC D6 FF D1 38 11 D0 CB EB E7 D4 D0 FE E9 38 29 CB D2 D4 CC C8 D7 C8 CB FE 69 D2 D2 D3 E7 CF 83 E3 D0 CA D5 EA D4 FE FF FD FF FC D2 D8 D3 D7 DC FF D9 38 DF 38 CF FE D9 1D 38 F0 D1 D1 DB D8 38 09 FE C4 38 D4 D4 DC 38 DD 38 D0 DA CB DB DB C8 CB E0 C8 43 03 D9 CC CF C7 38 D7 15 F3 CA 83 E4 CF D5 CB CB CC CF CF CB DF CB DF CB CA C9 DE D8 DF D7 D5 CA D0 CC C8 43 C9 E3 CB F7 38 2A 05 C8 D4 CF CB DC CA CA 38 CB D1 80 C9 EE D2 D4 CE CB E5 D3 D3 D7 D0 CC D4 E7 CF D1 38 DF D1 DF F1 38 D9 D1 D3 E6 E6 EF CB CC CF D8 DA 15 DC D4 D3 D7 D3 E0 38 0D 38 D0 C8 E3 DD CF F1 DF CB D7 CB CF CA DC D3 DC CB C9 43 C9 CA D6 EC D7 E5 CC C8 D5 D1 E0 CF D4 CB CF D1 D3 EF F7 D1 DC D5 C8 EB F1 F4 31 31 31 31 31 31 31 ED 2D 31 31 31 31 31 31 EE ED 2D 2D F0 2D 2D 27 DC D7 D7 15 CD 0D D1 C9 DC D5 EB D9 38 CE CE 15 D1 D4 D0 DC D1 D3 D9 DE D4 C8 D8 FC CB FB D3 52 12 D8 D8 D8 D8 D7 DB D4 05 05 D7 05 EB 2B 83 07 85 CB EB C8 05 55 55 05 15 E8 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 FC E5 05 38 05 38 05 38 A8 D8 55 15 58 C8 15 25 95 88 55 8C 17 1F E8 E8 C9 19 80 16 E5 61 80 97 D5 15 88 22 CB E7 06 CF D4 CF D1 56 D5 15 48 00 01 19 08 08 0D 0B 08 0A 0D 05 00 0C 10 00 01 04 0C 18 0C 03 07 0E 1B 0B 05 04 0D 09 06 05 00 21 26 08 0E 23 27 0E 08 19 03 03 0F 0C 0E 24 15 09 0D 09 05 0D 0A 18 2A 03 1F 2C 17 0E 21 2B 0D 0E 00 0C 06 04 02 11 20 35 2C 06 0F 01 0E 01 09 39 3A 3B 0D 0D 09 2F 0E 05 09 02 3E 00 29 0D 08 25 02 0E 06 08 0C 28 32 3B 2E 08 00 20 07 0C 2C 02 0A 34 0F 0D 26 07 13 2F 23 03 09 01 0C 38 1D 20 29 06 04 0A 27 04 1D 0D 27 08 14 19 0E 04 09 33 07 08 18 06 14 05 0B 07 07 0B 0D 0A 07 0C 00 10 05 07 11 2F 30 09 2D 05 20 18 3A 1A 20 01 2F 29 37 3B 00 09 3F 09 17 15 3C 3E 01 3D 0A 22 0E 10 0B 27 0E 06 1F 26 3B 1E 13 2A 0C 09 08 1B 14 11 17 29 11 2E 28 09 1A 09 03 09 1B 1E 06 07 06 0C 0F 06 00 35 25 20 33 4D 34 1B 32 25 37 06 22 0C 28 2F 3F 05 29 28 26 0E 24 2B 4F 35 00 3D 08 00 08 08 08 01 00 00 0C 00 0A 00 0C 1C 20 2E 04 2E 28 05 00 00 2E 0C 05 33 27 01 00 00 00 8F 03 03 17 1D 30 01 0F 11 02 03 03 14 0F 14 05 43 01 42 44 02 48 13 0A 0C 2D 05 07 00 38 11 02 06 22 09 08 00 05 01 43 01 45 12 01 43 13 01 0A 06 2B 01 06 16 02 10 04 08 05 01 05 10 02 0F 06 15 03 17 16 00 05 04 0C 02 08 14 15 05 00 00 0A 07 04 00 00 05 00 05 0B 00 05 04 0E 0C 04 08 06 01 04 13 02 00 0B 01 05 04 01 0A 04 02 04 0A 01 01 06 0A 03 02 00 00 01 03 01 02 16 02 FF 1F 06 02 06 05 05 12 07 00 00 FF 03 00 0E 05 01 1D 05 12 57 B0 9A 2A BF 85 40 64 54 09 44 C0 06 A9 93 08 2B B8 9D 21 10 86 55 10 67 85 80 A2 88 45 80 27 CD 81 03 4D 9B E7 C9 C0 42 8A 01 A1 1F 59 A2 CE 86 54 08 C8 E8 95 98 19 80 55 20 3F 70 7D C3 35 80 B1 C3 1A 54 B9 E9 A8 3B F8 68 24 03 02 00 80 3C 65 1C D3 50 08 1C 58 A1 A6 01 74 61 04 09 B0 8B 87 FA D0 83 39 F3 D8 C5 52 86 84 E3 FD C8 1B FA 5B C6 3D B3 1F 82 51 9C 80 B1 20 23 48 12 0F 83 00 A2 17 BF 70 A5 D9 29 04 B8 E2 39 11 1B 40 27 00 03 10 3D 06 02 21 35 06 74 4C 0C 70 D2 44 20 02 E2 50 8D 00 ED 1E 31 62 78 6A 64";
        
        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("RockAxe"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[2], SwapPath[2], Pickaxe, Pickaxe1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.HarleyHitterEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh added";
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[2], SwapPath[2], Pickaxe, Pickaxe1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.HarleyHitterEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh removed";
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
