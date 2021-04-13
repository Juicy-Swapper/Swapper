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
    public partial class AloySpear : Form
    {
        bool enabled = Settings.Default.AloySpearEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Aloy's Spear";

        public AloySpear()
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

        string Pickaxe = "8C 0A 00 0F E1 88 0F DF 03 00 00 00 00 00 00 00 00 0A E6 00 20 04 80 AB 1D 40 00 00 00 B9 16 00 17 20 05 20 1C 78 1C C0 D8 40 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 57 65 61 70 6F 6E 73 2F 41 62 69 6C 69 74 69 65 73 2F 47 41 42 5F 4D 65 6C 65 65 5F 49 6D 70 61 63 74 43 6F 6D 62 6F 5F 41 74 68 65 6E 61 00 60 2E 5F 43 00 2D 57 49 44 5F 48 61 72 76 65 73 74 5F 50 69 63 6B 61 78 52 61 69 64 65 72 53 69 6C 76 65 72 46 65 6D 61 6C 65 00 58 53 6F 75 6E 64 41 73 2F 2F 50 41 5F 43 75 65 00 79 2E 57 52 65 61 64 79 77 2E 53 77 69 6E 67 49 41 6C 74 65 72 61 74 69 44 61 6D 61 67 65 54 79 70 65 42 61 73 00 65 2E 24 44 61 74 61 74 62 6C 65 73 2F 4C 6F 6F 74 4C 65 76 65 6C 00 33 46 6F 72 74 5F 50 6C 61 79 5F 2F 43 6F 6C 6C 65 63 5F 00 40 2E 29 55 49 48 55 44 2F 55 49 5F 52 61 64 61 72 5F 45 6E 65 6D 79 44 6F 74 5F 57 68 69 74 65 00 54 75 6E 64 2F 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 54 2D 2D 61 2D 00 56 2D 4C 00 7C 2E 78 2E 3C 46 4F 52 54 2F 42 6C 75 65 70 72 69 6E 74 73 2F 42 47 65 6E 65 72 69 63 00 57 2E 5F 43 00 27 4D 65 73 68 65 73 2F 53 4B 00 2F 2E 56 5F 5F 46 58 2F 4E 53 5F 49 64 6C 65 00 74 2E 61 50 5F 5F 41 6E 69 6D 54 72 61 69 6C 00 8A 2E 55 4D 65 74 61 6C 00 72 2E 59 5F 49 63 65 00 7A 2E 53 74 6F 6E 65 2E 54 57 6F 6F 64 00 70 2E 55 78 65 00 6E 2E 13 2F 53 63 72 69 70 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 47 61 6D 47 61 6D 65 70 6C 61 79 54 61 67 73 41 63 74 75 61 6C 41 6E 61 6C 79 74 69 63 46 4E 61 6D 65 0C 0A 73 00 0D 41 72 72 61 79 50 72 6F 65 72 74 79 00 12 09 62 5F 41 52 5F 52 17 42 61 63 63 68 75 73 2E 2E 00 14 62 41 6C 6C 6F 77 4D 75 6C 74 69 70 6C 65 53 74 61 63 6B 73 00 0E 00 16 43 6F 73 6D 65 74 69 63 19 62 41 74 74 61 63 68 54 6F 00 1D 62 43 61 6E 42 65 44 65 70 6F 73 69 74 65 64 49 6E 53 74 6F 72 61 67 65 56 61 75 6C 74 00 0D 72 6F 70 70 65 64 00 15 62 49 6E 76 65 6E 74 6F 72 79 53 69 7A 65 4C 69 6D 00 10 62 53 74 6C 65 6E 00 12 48 61 73 44 75 72 61 79 00 0F 62 4E 65 65 72 73 69 73 0C 42 6F 6F 6C 1F 62 53 6F 77 44 69 72 65 63 61 6C 41 72 72 6F 77 57 68 65 46 61 72 4F 66 66 00 0C 42 79 74 65 08 43 61 74 65 67 6F 72 79 00 05 43 6C 61 73 73 00 0A 43 6F 6C 75 6D 6E 4E 09 54 00 17 48 61 6E 12 52 6F 77 26 44 65 66 5F 5F 44 65 66 69 6E 69 2A 44 69 73 61 73 73 65 6D 62 6C 65 44 65 67 72 61 64 4D 61 78 50 65 72 63 65 6E 74 72 69 6E 0B 72 6F 70 00 14 45 46 69 00 1F 3A 3A 49 6E 76 69 73 69 0D 74 65 6D 00 1C 3A 3A 00 0B 52 61 72 11 3A 3A 52 61 72 65 00 1D 65 6C 6F 61 64 46 58 53 74 61 74 65 3A 3A 45 6E 64 00 1D 45 4E 6F 72 6D 6C 00 16 54 72 69 67 67 65 72 21 3A 3A 41 75 74 6F 6D 61 74 69 63 00 0C 45 6E 75 6D 0E 4F 76 65 72 72 64 65 00 0D 46 6C 6F 61 74 1D 1C 2E 53 6F 75 72 63 65 2E 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 22 47 72 61 6E 74 65 64 2E 45 71 75 69 2E 2E 07 1C 5F 54 30 31 00 11 45 66 66 65 63 74 4E 69 61 67 72 61 00 10 46 58 53 6F 6B 65 74 26 50 68 79 73 69 63 61 6C 53 75 72 66 61 63 73 4D 61 70 00 1F 1E 0B 49 6E 74 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 0D 0B 4D 61 70 10 4D 69 6E 69 4D 61 42 72 75 73 68 00 17 56 69 65 77 44 69 73 74 63 65 00 08 4D 69 6E 00 0C 4E 61 6D 04 4E 0E 07 50 61 63 6B 12 75 70 53 6B 65 6C 00 19 65 72 12 50 72 69 6D 61 72 65 41 13 06 0F 0E 52 65 73 0B 52 6F 77 65 6E 74 73 00 07 52 6F 77 0C 53 74 72 75 63 74 00 0A 53 6C 61 74 65 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 31 00 0D 30 31 32 33 34 35 36 37 38 39 32 32 32 32 32 32 32 32 0C 33 34 35 36 37 38 39 00 13 5F 00 31 54 61 67 3A 3A 77 69 64 5F 68 70 72 73 66 0C 54 65 78 09 32 44 00 0B 17 14 77 2E 6D 68 1B 57 4D 10 41 63 74 6F 72 12 73 68 00 64 C1 0B D1 54 AD B0 36 D6 B0 31 C6 07 E6 D6 98 1D 41 15 AE 8B 5D C4 AF 66 B7 69 42 09 F3 1F 5F 3B D5 83 53 40 CC 92 3E 7B 38 08 86 0B 87 2D B1 E4 23 E8 58 DF FA 04 30 1C 2C 74 9C 0E D4 61 C2 8E 4A 53 CF 64 94 B2 54 D4 56 B0 25 3E 16 E0 D5 DF 1E 97 12 57 94 1A 56 9C 5B 77 31 AE 43 97 F2 D2 4D C6 49 D5 95 6D EB 66 81 0A 77 E9 06 E7 BE A2 5E DF 46 D7 E7 82 7B 85 3E 69 24 A4 BF A9 0D 8E 46 41 38 23 75 65 FE 6B 17 9A 75 CA D8 EC 71 9A BD 2F 50 34 B3 6D F6 18 3B B1 7E 9A DE 6D E0 E0 EA D8 60 89 E8 47 C7 DA 65 DD CF D2 12 72 8E 7B 88 0E 93 5A 2D 39 33 53 DC DA D7 F8 9B B0 34 09 1C 50 F3 8D 73 53 79 D8 43 B0 ED D4 36 42 09 E0 77 C4 3C 72 F1 13 5B C8 43 D9 F9 63 86 BD EC 80 6E A0 91 6D 2D 17 1E 3A 0D D6 DA C0 5A 30 38 29 62 84 63 1B 3F 9C BF D3 9D D0 5A E1 1F 9D 2C 55 F0 32 B5 72 EC 74 1C 46 8B BE DC 40 FE 72 30 DD E8 82 66 5B 03 FC 35 5C 55 15 B6 16 1C 3F AE C7 8F E6 8C 75 C1 C5 3A CE 78 7E 7C 88 C8 03 B3 60 D7 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 48 19 53 EC 0C 40 73 F8 AF B7 92 36 2D 68 5A A4 81 D1 E0 4B 04 45 1A AD A8 E3 AA B3 3D 77 5A FD A0 20 73 C6 7C A3 4D 60 D3 D5 13 53 79 3E 60 E1 70 43 75 60 EC 4C 78 16 62 56 ED 6A 62 7F A3 64 76 29 07 38 53 1D 99 F3 C6 E0 08 33 EB 3D 3B CD E5 F1 8E 3B 3D C2 07 FA C9 3F C7 F6 28 38 8D 19 A2 44 42 19 0C 65 C8 36 85 42 31 66 36 5F 4A 81 55 39 E0 39 25 C8 BE 72 05 7A D2 09 00 D0 4F 72 8C 42 6E ED 60 B5 71 51 DE 72 84 89 5C 9A 9C B3 82 41 8D 74 2F BD D4 3F EE 28 C6 A7 41 C8 CC 73 5F F1 4F 17 98 E8 CF E5 AD 2B 3A 82 6E B6 DB 6B 32 55 D7 A3 91 04 09 AB 30 82 61 5F 9C 0A 20 71 FD 76 36 27 1D 07 CF 3B 40 26 15 6F 0D 82 0A EC 96 68 BA D1 CD 48 38 89 81 59 E1 AD 58 C4 11 82 5C B7 1B 1A EC 38 C4 FE F0 34 0E 22 8B 92 6F 39 69 A6 DD 0A AF FC 40 08 DF 48 95 A5 38 5B 65 33 6A 4D F9 A0 08 91 48 26 1D 33 27 6A 0A FF 98 D9 03 AA 02 AA C3 9D C8 B2 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 33 F5 AB 82 62 D3 37 BF 33 FA DE 60 E0 83 2C B5 21 CC FF 36 3F 64 F6 0E 6C 5B 34 36 C2 65 C1 19 49 A9 9A F8 07 86 51 53 81 EF 67 6F 2D FF B7 2E D6 3C 55 A9 1E BB 6B 14 C9 65 36 94 30 C1 46 43 32 7A 8D 3F CF 98 83 9A C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 F5 61 D3 13 E3 AE 45 67 51 6A 6B A4 FC 3C 8C B9 13 EF E4 4D EC 00 34 91 66 C0 7C 9B 17 2E 9B 87 5B 69 1F 1D 12 55 26 5D C0 35 F0 CA 0B 23 C7 A4 67 B2 81 01 45 B1 5C 1B 3B EF E8 2F 13 C9 5D 75 DB 6F A3 73 A1 40 EA 11 32 50 77 C1 15 8A CC DD 39 01 5A 81 FE 31 FD 3B C2 EB B3 D9 30 59 00 D8 39 EF 4F A7 76 A4 62 F1 AD A2 3A C4 F4 A0 70 E1 C7 B9 E7 7B 86 0C 16 F3 2C 81 58 FF 04 7A 02 F6 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 6F C3 D4 37 FA 05 00 64 FD 3A 01 16 7B 9B 70 4E 5C F2 3B E6 12 F3 D7 48 78 C0 7E 96 90 03 5B 64 62 6D 93 AB 1A AE 7B 81 3C 4E 34 7F FF 33 3D EE B4 69 A9 78 E1 B4 8A A0 BC 73 EF 85 64 E9 0F 33 D9 4C 9B 5B E6 85 49 12 8C 86 10 8D A1 65 4C 44 33 9B 6F 71 90 95 97 78 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 50 3E ED 54 1E 2A 29 1F 17 93 19 0B 03 11 A3 4E BD 10 ED 87 4D 19 44 D2 A0 6A BA 78 E5 13 A9 90 FA 5D 74 F1 6F 69 0A 0C 26 B0 88 7A FC F8 4F FB C8 AC 71 36 39 86 87 21 2F 1A 3B 8C 87 D6 E7 D7 0C 3A 87 FE F5 B5 AE 69 DD 9A E9 69 B3 4D 26 FE 1B 5F 6B A9 F9 B2 F7 A1 33 C2 F2 92 F8 52 DC C7 74 7C 48 00 17 B5 C6 E5 C5 C8 83 BE 3E 2B 74 3E 7D 74 06 36 3C BB 64 26 A2 0F 39 26 E7 5C 52 40 AE B8 5F CA 47 BB CE 45 20 6F DD 36 8F 63 93 D3 25 3C DF 24 4E A2 AF D0 EA CE 9F 36 F1 F2 81 30 50 EC 69 F5 D1 93 BB 24 97 34 7A 18 D3 DB 6B D9 B6 60 ED 41 41 00 CA 6A 99 61 FB A7 19 16 64 02 72 83 FB 15 01 01 D9 10 DE 28 B5 8C AF E4 76 73 59 BF 58 F0 6D 5D AB 2F DF EB 3F FF B5 E3 E3 9C 6D 96 ED 9B D4 26 21 AB 65 B1 29 8A E4 43 6B BD AB 37 2F 90 F5 35 5D D9 45 CB 2F 95 B6 78 D9 36 AA 43 29 82 A8 B4 57 53 8B 0B 78 8B 6A 02 72 D6 A0 E5 46 23 43 BC A5 E9 A8 C1 B4 45 E3 CC C3 EE 6B D9 42 B9 46 36 32 22 9B C6 8A 52 FC 27 C2 9C F5 BE 6A 02 4A 12 54 79 33 A4 13 A3 8C 1B 47 8A AB 86 89 D3 4C 77 CF 88 EB DE 92 B2 B4 3F 6B 74 FF FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 25 8E DB EE 36 40 10 95 AB 1D 6E 06 A2 00 D5 73 47 C9 45 52 CC 9C 0B 00 00 02 00 01 4A 58 D3 32 1D 62 DD 4F 01 9C 26 68 43 F8 ED 5F 9E 44 22 02 70 C1 D2 0B E8 02 04 03 02 06 04 01 02 04 06 04 04 01 02 05 04 01 02 09 02 16 06 11 04 01 06 0A 04 01 02 0D 02 03 02 03 03 04 02 02 04 02 0A 05 19 2F 1B 97 6C 7D 23 88 21 90 1D 91 6C 92 93 94 95 96 7E 7F 80 81 82 83 84 85 86 87 89 8A 8B 8C 8D 1F 8E 6C 8F 6C 6C 6C 6C 04 05 05 05 05 01 4F 07 50 09 15 25 00 05 FE FF FF FF 5D 00 6C 01 01 9D 5B 02 98 40 9C 45 03 03 F5 FF FF FF 07 FD FF FF FF 3E 5C 00 17 0E CD CC CC 3D CD CC CC 3E 02 17 14 01 21 32 32 42 33 33 30 36 36 34 33 33 34 39 30 46 34 32 38 44 39 45 42 38 34 30 36 46 35 45 37 36 41 00 10 69 6E 67 20 54 6F 6F 6C 9E 57 30 13 12 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 A2 C0 96 96 92 92 92 92 99 99 41 00 78 F8 F8 F8 A8 79 E8 7C E0 30 28 38 78 F0 87 87 94 87 87 EE 55 20 91 7A 98 7B 98 40 7E F8 F8 F8 F8 E8 79 F8 98 F9 F8 F8 F8 F8 98 2D F9 F8 F8 F8 F8 E0 79 F0 78 F8 F8 F8 F8 B8 F5 78 F8 F8 F8 F8 78 78 B8 A9 38 87 21 87 63 5B 38 30 7A F8 F8 F8 E8 79 E8 E1 8D 87 27 2A 40 25 2D 30 8F 21 7A F8 F8 B0 69 B1 32 87 87 87 87 59 2B 87 4F 38 22 21 99 E1 38 7A F8 F8 F8 F8 C8 7C F8 F8 F8 F8 D8 79 F8 C0 F9 F8 F8 F8 F8 C8 79 F8 B0 A9 48 34 87 3E 48 87 7A F8 F8 F8 79 C8 7C D0 87 2A 7A F8 C8 41 F9 D0 70 31 39 7E B8 7E F8 F8 F8 F8 D8 79 F8 F9 F8 F8 E0 7A E8 87 85 01 79 F8 D8 F9 F8 F8 F0 68 40 7F F8 F8 F8 F8 D0 79 F0 F9 F8 F8 F8 F8 D0 7E F8 F8 F8 F8 F0 79 F8 90 78 F0 F0 F0 F0 D8 FD 78 F8 F8 F8 E0 79 F0 F9 F8 F8 F8 F8 A8 7E F8 F8 F8 F8 C8 79 E8 F1 F0 F0 D8 40 78 B8 7C F8 F8 F8 F8 D0 79 D0 27 87 44 87 39 28 5F 87 95 87 87 95 41 28 49 87 8C 7E A0 27 87 3A B9 87 87 87 73 22 87 59 87 51 32 87 87 87 87 3D 87 87 87 24 23 28 8A 2D 2F 26 25 4D 8B 27 87 8B 87 4D 87 87 87 24 21 21 4A 40 23 49 3B 24 22 30 28 20 2E 87 55 8E 23 7F F9 E2 99 20 38 2B 23 48 22 7A A8 87 21 31 23 6A 32 38 2A 23 59 87 31 87 37 56 28 38 8C 5B 2F 79 B8 87 87 4B 31 8D 87 4A 79 F8 41 31 3F 59 5A 87 6C 87 22 24 29 41 41 79 48 26 87 8B 24 8C 2B 21 48 87 3F 36 78 D8 F9 B0 28 28 54 48 87 2F 71 4C 8F 20 3F 24 94 2F 55 22 29 50 25 21 26 20 22 3A 68 26 3B 51 30 20 39 31 50 2C 38 24 87 2A 31 87 36 6E 7D 21 58 31 28 63 71 F1 F1 F1 F1 F1 F1 F1 F1 69 E9 F1 F1 F1 F1 F1 F1 91 D9 69 E9 E9 E9 E9 E9 DB 39 B6 3E B9 29 29 31 54 39 64 79 C8 2A 2A B9 32 A9 28 50 31 35 41 3A 48 20 40 78 F0 C8 40 23 00 F8 87 87 87 87 36 32 B2 40 40 40 40 87 4A 5B 99 39 87 5A 87 61 87 E1 87 87 87 87 9F 21 93 5D 39 79 28 B9 59 39 59 B9 D9 B9 D9 B9 D9 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 B9 D9 B9 D9 F9 A0 78 F8 B0 F9 A0 F9 A0 81 01 F9 F8 F8 D0 59 F9 A0 F9 A0 F9 A0 79 99 B9 79 A0 B9 D9 59 D9 B7 61 D9 61 99 59 B9 59 69 87 8A BE B2 59 59 87 21 64 99 87 87 87 87 9E 38 87 29 39 39 B9 59 1E 01 30 00 43 00 1D 00 62 00 15 00 3D 00 13 00 D4 00 44 00 38 00 39 00 4F 00 D6 00 5A 00 7B 00 59 00 79 00 D2 00 59 00 D2 00 79 00 B5 02 75 00 16 00 10 00 ED 01 2B 00 4B 00 67 00 14 00 26 00 4A 01 11 00 15 00 31 00 0D 00 35 00 42 00 3E 00 2B 00 EA 00 02 02 ED 00 16 00 0F 02 15 00 56 00 58 00 7E 00 50 01 5D 00 3A 06 3B 06 E2 05 3E 00 19 00 59 00 36 00 29 00 31 00 BF 06 28 01 88 04 23 00 58 00 76 00 22 00 63 00 8C 00 1A 00 C7 07 57 00 74 00 5B 00 21 00 A2 01 57 00 74 00 56 00 72 00 40 05 92 03 57 00 70 00 9E 08 15 00 10 00 9F 08 16 00 10 00 24 00 7C 04 2A 0D 2A 09 1E 0D 13 0A 10 00 18 00 98 00 7E 00 1F 00 34 00 60 08 2A 00 12 00 7F 0E 45 08 37 00 1B 01 B5 00 2F 00 BC 01 EF 0A 03 0B 0B 00 31 00 06 07 19 00 14 00 F8 00 0B 02 23 01 AC 01 CE 00 51 01 E2 00 F7 0A 2C 00 6B 02 C5 00 62 0B 90 00 7C 01 DC 01 16 00 FC 00 21 00 68 0C 0F 00 E0 00 6B 02 1E 00 AC 01 0D 00 13 00 0F 00 33 01 B5 00 22 00 1F 00 94 00 18 00 F8 01 E7 00 1F 00 B9 01 CD 03 39 0D 0D 03 EB 03 0D 00 0E 04 67 00 26 03 79 00 58 01 09 00 F3 10 5B 11 9B 09 13 00 13 02 A3 05 21 00 3D 00 28 00 21 00 CF 0D 20 00 6B 03 42 02 7A 0E 63 0E 39 00 52 0C 12 00 7B 03 46 00 E7 03 56 07 BA 05 92 00 7E 00 4C 01 4E 08 28 06 9B 0E 9B 01 B0 01 2B 03 97 04 14 00 01 01 00 01 08 03 E1 02 19 01 34 02 4C 06 1E 02 A8 01 3B 06 01 01 42 01 E1 00 3B 00 10 00 A2 01 30 10 0E 00 0F 00 A4 00 0E 00 22 06 DD 03 93 08 92 08 D0 14 D3 01 AB 0F 12 05 1C 11 6E 00 5F 04 16 00 D7 03 37 08 1D 00 26 07 1C 05 43 05 26 00 B1 05 08 07 A2 15 C0 16 08 00 7E 05 08 00 40 00 78 00 10 00 70 00 C0 05 0C 00 D0 1C 1C 00 14 00 22 00 40 00 08 00 98 00 11 00 1D 00 08 00 14 00 24 02 24 02 D4 01 58 00 1C 00 0C 00 B3 05 0C 00 19 00 18 00 95 00 2B 00 0C 00 5D 06 8D 00 67 0C 76 06 4A 00 08 00 7D 00 00 00 00 04 06 FD 01 01 FC 13 00 8C 0A 00 0F E1 88 0F DF 03";
        string Pickaxe1 = "8C 06 00 0F A6 88 0F A4 03 00 00 00 00 00 00 00 00 0A EE 00 20 04 80 AB 1D 40 00 00 00 B9 16 00 17 20 05 20 1C 78 1C C0 D8 40 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 57 65 61 70 6F 6E 41 62 69 6C 69 74 69 65 73 2F 47 41 42 5F 4D 65 6C 65 65 5F 49 6D 70 61 63 74 43 6F 6D 62 6F 5F 00 60 2E 5F 43 00 2D 57 49 44 5F 48 61 72 76 65 73 74 5F 50 69 63 6B 61 78 52 61 69 64 65 72 53 69 6C 76 65 72 46 65 6D 61 6C 65 00 58 53 6F 75 6E 64 41 2F 50 41 5F 43 75 65 00 79 41 6C 63 68 65 6D 79 5F 5F 45 6E 65 6D 79 2E 00 57 52 65 61 64 79 77 53 77 69 6E 67 49 41 6C 74 65 72 61 74 69 44 61 6D 61 67 65 54 79 70 65 42 61 73 00 65 2E 24 44 61 74 61 74 61 62 6C 65 73 2F 4C 6F 6F 74 4C 65 76 65 6C 00 33 46 6F 72 74 5F 50 6C 61 79 5F 2F 43 6F 6C 6C 65 63 74 5F 00 40 2E 00 29 55 49 48 55 44 2F 55 49 5F 52 61 64 61 72 44 6F 74 5F 57 68 69 74 65 00 54 75 6E 64 2F 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 54 2D 2D 73 2D 00 56 2D 4C 00 7C 2D 4C 2E 78 00 00 3C 46 4F 52 54 2F 42 6C 75 65 70 72 69 6E 74 73 2F 42 47 65 6E 65 72 69 63 00 57 2E 5F 43 00 27 4D 65 73 68 65 73 2F 53 4B 00 2F 2E 56 5F 5F 2F 46 58 2F 4E 53 5F 49 64 6C 65 00 74 45 66 66 65 63 74 4E 53 48 6F 6C 6F 67 72 61 6D 2E 61 50 5F 5F 41 6E 69 6D 54 72 61 69 6C 00 8A 55 4D 65 74 61 6C 00 72 59 5F 49 63 65 00 7A 53 74 6F 6E 65 54 57 6F 6F 64 00 70 5F 41 78 65 00 6E 41 78 65 2E 13 2F 53 63 72 69 70 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 70 6C 61 79 54 61 67 73 41 63 74 75 61 6C 41 6E 61 6C 79 74 69 63 46 4E 61 6D 65 0C 0A 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 09 62 5F 41 52 5F 52 17 42 61 63 63 68 75 73 2E 2E 00 14 62 41 6C 6C 6F 77 4D 75 6C 74 69 70 6C 65 53 74 61 63 6B 73 00 0E 00 16 43 6F 73 6D 65 74 19 62 41 74 74 61 63 68 54 6F 00 1D 62 43 61 6E 42 65 44 65 70 6F 73 69 74 65 64 49 6E 53 74 6F 72 61 67 65 56 61 75 6C 74 00 0D 72 6F 70 70 65 64 00 15 62 49 6E 6E 74 6F 72 79 53 69 7A 65 4C 69 6D 00 10 62 53 74 6F 6C 65 6E 00 12 48 61 73 44 75 72 61 79 00 0F 62 4E 65 76 65 72 50 65 72 73 69 73 0C 42 6F 6F 6C 1F 62 53 68 6F 77 44 69 72 65 63 61 6C 41 72 72 6F 77 57 68 65 6E 46 61 72 4F 66 66 00 0C 42 79 74 65 08 43 61 74 65 67 6F 72 79 00 05 43 6C 61 73 73 00 0A 43 6F 6C 75 6D 6E 00 09 54 00 17 48 61 6E 12 52 6F 77 26 44 65 66 5F 5F 44 65 66 69 00 2A 44 69 73 61 73 73 65 6D 62 6C 65 44 65 67 72 61 64 65 4D 61 78 50 65 72 63 65 6E 74 69 6E 0B 72 6F 70 00 14 45 46 69 00 1F 3A 3A 49 6E 76 69 73 69 0D 6D 00 1C 3A 3A 00 0B 52 61 72 11 3A 3A 52 61 72 65 00 1D 65 6C 6F 61 64 46 58 53 74 61 74 65 3A 3A 45 6E 64 4E 6F 72 6D 61 6C 00 16 54 72 69 67 67 65 72 21 3A 3A 41 75 74 6F 6D 61 74 69 63 00 0C 45 6E 75 6D 0E 4F 76 65 72 72 69 64 65 00 0D 46 6C 6F 61 74 1D 1C 2E 53 6F 75 72 63 65 2E 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 22 47 72 61 6E 74 65 64 2E 45 71 75 69 70 70 00 07 1C 43 5F 54 30 31 00 11 4E 69 61 67 61 72 61 00 10 46 58 53 6F 63 6B 65 74 26 50 68 79 73 69 63 61 6C 53 75 72 66 61 63 73 4D 61 70 00 1F 1E 0B 49 6E 08 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 0D 0B 4D 61 70 10 4D 69 6E 69 4D 61 70 42 72 75 73 68 00 17 56 69 65 77 44 69 73 74 61 6E 63 65 00 08 4D 69 6E 00 0C 04 4E 0E 07 50 61 63 6B 12 75 70 53 6B 65 6C 65 6C 00 19 65 72 12 50 72 69 6D 61 72 79 46 69 72 65 41 13 06 0F 0E 52 65 73 0B 52 6F 77 65 6E 74 73 00 07 52 6F 77 0C 53 74 72 75 63 74 00 0A 53 6C 61 74 65 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 31 00 0D 30 32 33 34 35 36 37 38 39 32 32 32 32 32 32 32 32 36 33 34 35 37 38 39 00 13 5F 00 31 54 61 67 3A 3A 77 69 64 5F 68 70 72 73 66 0C 09 32 44 00 0B 17 14 77 2E 6D 68 1B 10 41 63 74 6F 72 12 73 68 64 C1 0B D1 54 AD B0 36 D6 B0 31 C6 07 E6 D6 98 1D 41 15 AE 8B 5D C4 AF 66 B7 69 42 09 F3 1F 5F 3B D5 83 53 40 CC 92 3E 7B 38 08 86 0B 87 2D B1 E4 23 E8 58 DF FA 04 30 1C 2C 74 9C 0E D4 61 C2 8E 4A 53 CF 64 94 B2 54 D4 56 B0 25 3E 16 E0 D5 DF 1E 97 12 57 94 1A 56 9C 5B 77 31 AE 43 97 F2 D2 4D C6 49 D5 95 6D EB 66 81 0A 77 E9 06 E7 BE A2 5E DF 46 D7 E7 82 7B 85 3E 69 24 A4 BF A9 0D 8E 46 41 38 23 75 65 FE 6B 17 9A 75 CA D8 EC 71 9A BD 2F 50 34 B3 6D F6 18 3B B1 7E 9A DE 6D E0 E0 EA D8 60 89 E8 47 C7 DA 65 DD CF D2 12 72 8E 7B 88 0E 93 5A 2D 39 33 53 DC DA D7 F8 9B B0 34 09 1C 50 F3 8D 73 53 79 D8 43 B0 ED D4 36 42 09 E0 77 C4 3C 72 F1 13 5B C8 43 D9 F9 63 86 BD EC 80 6E A0 91 6D 2D 17 1E 3A 0D D6 DA C0 5A 30 38 29 62 84 63 1B 3F 9C BF D3 9D D0 5A E1 1F 9D 2C 55 F0 32 B5 72 EC 74 1C 46 8B BE DC 40 FE 72 30 DD E8 82 66 5B 03 FC 35 5C 55 15 B6 16 1C 3F AE C7 8F E6 8C 75 C1 C5 3A CE 78 7E 7C 88 C8 03 B3 60 D7 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 48 19 53 EC 0C 40 73 F8 AF B7 92 36 2D 68 5A A4 81 D1 E0 4B 04 45 1A AD A8 E3 AA B3 3D 77 5A FD A0 20 73 C6 7C A3 4D 60 D3 D5 13 53 79 3E 60 E1 70 43 75 60 EC 4C 78 16 62 56 ED 6A 62 7F A3 64 76 29 07 38 53 1D 99 F3 C6 E0 08 33 EB 3D 3B CD E5 F1 8E 3B 3D C2 07 FA C9 3F C7 F6 28 38 8D 19 A2 44 42 19 0C 65 C8 36 85 42 31 66 36 5F 4A 81 55 39 E0 39 25 C8 BE 72 05 7A D2 09 00 D0 4F 72 8C 42 6E ED 60 B5 71 51 DE 72 84 89 5C 9A 9C B3 82 41 8D 74 2F BD D4 3F EE 28 C6 A7 41 C8 CC 73 5F F1 4F 17 98 E8 CF E5 AD 2B 3A 82 6E B6 DB 6B 32 55 D7 A3 91 04 09 AB 30 82 61 5F 9C 0A 20 71 FD 76 36 27 1D 07 CF 3B 40 26 15 6F 0D 82 0A EC 96 68 BA D1 CD 48 38 89 81 59 E1 AD 58 C4 11 82 5C B7 1B 1A EC 38 C4 FE F0 34 0E 22 8B 92 6F 39 69 A6 DD 0A AF FC 40 08 DF 48 95 A5 38 5B 65 33 6A 4D F9 A0 08 91 48 26 1D 33 27 6A 0A FF 98 D9 03 AA 02 AA C3 9D C8 B2 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 33 F5 AB 82 62 D3 37 BF 33 FA DE 60 E0 83 2C B5 21 CC FF 36 3F 64 F6 0E 6C 5B 34 36 C2 65 C1 19 49 A9 9A F8 07 86 51 53 81 EF 67 6F 2D FF B7 2E D6 3C 55 A9 1E BB 6B 14 C9 65 36 94 30 C1 46 43 32 7A 8D 3F CF 98 83 9A C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 F5 61 D3 13 E3 AE 45 67 51 6A 6B A4 FC 3C 8C B9 13 EF E4 4D EC 00 34 91 66 C0 7C 9B 17 2E 9B 87 5B 69 1F 1D 12 55 26 5D C0 35 F0 CA 0B 23 C7 A4 67 B2 81 01 45 B1 5C 1B 3B EF E8 2F 13 C9 5D 75 DB 6F A3 73 A1 40 EA 11 32 50 77 C1 15 8A CC DD 39 01 5A 81 FE 31 FD 3B C2 EB B3 D9 30 59 00 D8 39 EF 4F A7 76 A4 62 F1 AD A2 3A C4 F4 A0 70 E1 C7 B9 E7 7B 86 0C 16 F3 2C 81 58 FF 04 7A 02 F6 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 6F C3 D4 37 FA 05 00 64 FD 3A 01 16 7B 9B 70 4E 5C F2 3B E6 12 F3 D7 48 78 C0 7E 96 90 03 5B 64 62 6D 93 AB 1A AE 7B 81 3C 4E 34 7F FF 33 3D EE B4 69 A9 78 E1 B4 8A A0 BC 73 EF 85 64 E9 0F 33 D9 4C 9B 5B E6 85 49 12 8C 86 10 8D A1 65 4C 44 33 9B 6F 71 90 95 97 78 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 50 3E ED 54 1E 2A 29 1F 17 93 19 0B 03 11 A3 4E BD 10 ED 87 4D 19 44 D2 A0 6A BA 78 E5 13 A9 90 FA 5D 74 F1 6F 69 0A 0C 26 B0 88 7A FC F8 4F FB C8 AC 71 36 39 86 87 21 2F 1A 3B 8C 87 D6 E7 D7 0C 3A 87 FE F5 B5 AE 69 DD 9A E9 69 B3 4D 26 FE 1B 5F 6B A9 F9 B2 F7 A1 33 C2 F2 92 F8 52 DC C7 74 7C 48 00 17 B5 C6 E5 C5 C8 83 BE 3E 2B 74 3E 7D 74 06 36 3C BB 64 26 A2 0F 39 26 E7 5C 52 40 AE B8 5F CA 47 BB CE 45 20 6F DD 36 8F 63 93 D3 25 3C DF 24 4E A2 AF D0 EA CE 9F 36 F1 F2 81 30 50 EC 69 F5 D1 93 BB 24 97 34 7A 18 D3 DB 6B D9 B6 60 ED 41 41 00 CA 6A 99 61 FB A7 19 16 64 02 72 83 FB 15 01 01 D9 10 DE 28 B5 8C AF E4 76 73 59 BF 58 F0 6D 5D AB 2F DF EB 3F FF B5 E3 E3 9C 6D 96 ED 9B D4 26 21 AB 65 B1 29 8A E4 43 6B BD AB 37 2F 90 F5 35 5D D9 45 CB 2F 95 B6 78 D9 36 AA 43 29 82 A8 B4 57 53 8B 0B 78 8B 6A 02 72 D6 A0 E5 46 23 43 BC A5 E9 A8 C1 B4 45 E3 CC C3 EE 6B D9 42 B9 46 36 32 22 9B C6 8A 52 FC 27 C2 9C F5 BE 6A 02 4A 12 54 79 33 A4 13 A3 8C 1B 47 8A AB 86 89 D3 4C 77 CF 88 EB DE 92 B2 B4 3F 6B 74 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 25 8E DB EE 36 40 10 95 AB 1D 6E 06 A2 00 D5 73 47 C9 45 52 CC 9C 0B 00 00 00 00 02 01 03 4A 58 D3 32 1D 62 DD 4F 01 00 9C 26 68 43 F8 ED 5F 9E 44 22 02 70 C1 D2 0B E8 02 04 03 02 06 04 01 02 04 06 04 04 01 02 05 04 01 02 09 02 16 06 11 06 0A 04 01 02 0D 02 03 02 03 03 04 04 02 02 01 02 04 02 0A 05 19 2F 1B 01 97 7D 23 88 21 90 1D 91 92 6C 93 94 95 96 7E 7F 80 81 82 83 84 85 86 87 89 8A 8B 8C 8D 1F 8E 8F 6C 6C 6C 6C 04 05 05 05 4F 07 50 09 15 25 05 FE FF FF FF 5D 6C 01 9D 5B 02 98 40 9C 45 03 03 F5 FF FF FF 00 07 FD FF FF FF 3E 5C 17 0E CD CC CC 3D CD CC CC 3E 02 17 14 01 32 32 42 33 33 30 36 36 34 33 33 34 39 30 46 34 32 38 44 39 45 42 38 34 30 36 46 35 45 37 36 41 00 10 00 69 6E 67 20 54 6F 6F 6C 9E 57 30 00 13 12 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 03 58 03 03 02 02 02 02 05 05 D9 43 D3 FE E9 38 EB 38 CC CC D4 EC 38 03 2F E3 C8 01 80 C0 38 C7 38 D4 FF DB D5 E7 F9 38 D4 C9 FD CF 3D DC FC E0 DC 9C FC 3F DC 7C E0 54 38 11 D0 CB EB E7 D4 D0 FE E9 38 29 CB D2 D4 CB D7 C8 CB FE 69 D2 D2 D3 E7 CF E3 D0 CA D5 EA D4 FE FF D4 D4 FB F8 E4 FD F4 38 1E D1 D8 D3 D7 DC FF D9 38 DF 38 CF FE D9 1D 38 F0 D1 D1 D3 38 FF D8 83 DE 58 E7 38 D8 CC FD EA 38 FF DC C8 38 E0 64 CC 38 FD F4 D0 FF D0 C8 38 D0 F4 FD FF D8 FC 3F 3D FF FC D4 B0 D0 FF D4 D8 E7 70 60 38 CB DB DB C8 CB E0 C8 43 03 D9 CC DD C7 38 CB D7 15 F3 CA 83 E4 E3 D2 D7 83 CB CB CC CF CF CB DF CB DF CB CA C9 DE D8 CB DD D7 CB CA D0 CC C8 43 C9 E3 CB F7 38 2A 05 C8 D4 CF CB DC CA CA 38 CB D1 80 C9 EE D2 D4 CE CB E5 D3 D3 D7 D0 CC D4 E7 CF D1 38 DF D1 DF F1 38 D9 D1 D3 E6 E6 EF CB 87 CC D8 DA 15 DC D4 CB D0 CB CF D1 D4 D7 D3 A0 38 0D 38 D0 C8 E3 DD CF F1 DF CB D7 CB CF CA DC CA D1 DC CB C9 43 C9 CA D6 EC D7 E5 CC C8 D5 D1 E0 CF D4 CB CF D1 D3 EF F7 D1 DC D5 C8 EB F1 F4 31 31 31 31 31 31 31 ED 2D 31 31 31 31 31 31 EE ED 2D 2D F0 2D 2D 27 D5 13 D7 15 CD CD D1 C9 DC D5 EB D9 38 CE CE 15 D1 D4 D0 DC D1 D3 D9 DE D4 C8 D8 FC D8 CA 3B D3 52 12 D8 D8 D8 D8 D7 DB D4 05 05 D7 05 EB 2B 83 07 85 DF 80 15 15 88 D9 15 E8 15 25 49 84 59 44 49 44 59 44 C5 38 15 25 15 E8 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 15 25 45 38 05 38 FC 05 38 05 38 3D 3D E5 05 38 05 38 05 38 E8 D8 55 15 58 C8 15 25 95 88 55 4C 97 E8 25 E8 C9 19 84 D5 E5 D5 48 40 57 55 15 88 25 CB E7 CC 03 D5 CF 95 55 91 92 8C 00 01 39 08 0D 0B 08 0A 0D 05 00 0C 10 00 01 07 1E 02 03 08 07 09 1F 00 0D 0C 00 05 0A 0C 0A 00 0A 21 25 0E 08 11 03 03 0F 0C 0E 22 09 0D 09 05 0D 0A 0B 24 03 1F 2A 17 0E 2F 21 0D 0E 00 2A 01 07 09 12 06 04 02 11 22 23 2A 06 0F 01 0E 01 09 27 28 29 0B 00 2C 2F 04 12 00 06 08 01 07 02 04 00 07 1C 3B 0B 24 08 02 05 03 07 02 1A 02 1B 21 26 01 02 2F 04 3B 0D 08 37 0C 0E 06 08 0C 24 32 34 36 3B 08 00 00 2E 07 0C 34 02 0A 3A 0F 13 3E 07 19 37 3B 03 09 34 01 0C 00 13 1B 31 06 04 0A 3F 04 13 0D 3F 08 14 14 0E 04 09 3B 07 08 13 06 14 05 0B 07 07 0B 0D 0A 07 0C 00 10 05 07 11 25 38 09 23 05 26 18 1A 2B 01 3C 31 39 3E 0B 1B 3E 09 05 00 3C 09 1C 1A 39 3B 01 3F 0A 27 0E 02 0B 32 22 0E 06 14 2D 38 13 18 2F 0C 09 08 20 19 11 1C 24 16 10 23 09 1A 09 03 09 1B 1E 06 07 06 0C 0F 06 00 2A 25 3B 3A 48 41 1B 4F 2A 44 06 27 0C 2D 2F 3F 05 3E 2D 2B 0E 29 30 4A 31 00 26 08 00 08 08 08 01 00 00 0C 06 09 48 08 0C 1C 1C 0C 2D 04 2B 2F 05 04 00 00 25 0C 28 3F 2E 00 00 A3 03 03 17 1D 30 01 0F 11 02 00 03 14 04 03 3D 02 2C 00 43 02 32 00 05 07 00 38 11 02 02 06 22 09 08 00 0B 43 01 30 00 3E 01 0A 06 2B 01 06 16 04 03 10 03 06 28 09 33 2A 04 33 44 03 62 40 02 64 3F 03 60 26 03 18 01 04 08 05 01 05 10 0F 04 06 15 03 05 1E 08 09 00 05 04 0C 02 08 14 15 00 00 01 00 0A 07 04 00 00 05 00 05 0B 00 05 04 0E 0C 04 08 06 03 04 06 05 0B 03 00 0B 01 05 04 01 0A 02 04 0A 01 01 06 0A 03 02 00 00 03 03 01 02 16 FF 1F 06 02 06 05 05 14 07 08 13 FF 26 03 0D 05 01 1F 05 23 53 C3 45 01 0C CB 42 02 28 02 00 18 86 4A 60 B4 2E F9 DA 84 5D 8E E2 1C 8D C3 B2 1C DC 9B 00 38 12 03 8B 08 48 A8 02 5C 87 E4 3E 1C D2 B8 6F DA D1 00 41 87 89 84 11 2D 1B 00 20 7B C9 F4 C0 CE B7 C9 2C 78 01 D1 5F BC 70 90 C4 FA E3 20 67 30 7C 10 09 A7 76 01 34 F0 63 35 00 EB 36 C1 1F 80 98 56 35 00 33 20 12 00 08 0C A4 A9 63 40 62 55 21 1C 1C 9F 66 2C 60 CD 98 A3 EC 0F 8A 4F 80 E1 09 B5 3E 47 02 B6 78 20 21 27 BD 3E 42 03 94 85 80 83 B4 BE EC 40 38 80 4F C2 5E 04 08 98 29 03 C8 00 10 88 12 73 B7 82 6E 5E 5B ED BB D4 E4 E8 34 4B F4 C0 23 26 02 51 02 48 71 11 37 32 31 61 AF 64";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("6CaratCutter"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[2], SwapPath[2], Pickaxe, Pickaxe1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.AloySpearEnabled = true;
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
                Settings.Default.AloySpearEnabled = false;
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

        private void Axecalibur_Load(object sender, EventArgs e)
        {

        }
    }
}