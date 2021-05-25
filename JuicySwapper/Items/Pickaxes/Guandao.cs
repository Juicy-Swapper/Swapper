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
    public partial class Guandao : Form
    {
        bool enabled = Settings.Default.GuandaoEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Guandao";

        public Guandao()
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

        string Pickaxe = "8C 0A 00 10 44 88 10 42 03 00 00 00 00 00 00 00 00 0B 29 00 20 04 80 18 1F 40 18 48 18 48 05 00 00 90 1D E8 1D 30 1E 1E 40 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 57 65 61 70 6F 6E 73 2F 41 62 69 6C 69 74 69 65 73 2F 47 41 42 5F 4D 65 6C 65 65 5F 49 6D 70 61 63 74 43 6F 6D 62 6F 5F 41 74 68 65 6E 61 00 60 2E 5F 43 00 2D 00 40 57 49 44 5F 48 72 76 65 73 74 5F 50 69 63 6B 61 78 65 5F 53 70 61 63 57 61 6E 64 65 72 65 72 4D 61 6C 65 00 5B 53 6F 75 6E 64 41 73 2F 2F 45 6E 65 6D 79 80 2E 55 52 65 61 64 74 53 77 69 6E 67 2E 50 49 41 6C 74 65 72 61 74 69 44 61 6D 61 67 65 54 79 70 65 42 61 73 00 65 2E 24 44 61 74 61 74 62 6C 65 73 2F 4C 6F 6F 74 4C 65 76 65 6C 00 33 46 6F 72 74 5F 50 6C 61 79 5F 2F 43 6F 6C 6C 65 63 5F 00 40 2E 29 55 49 48 55 44 2F 55 49 5F 52 61 64 61 72 5F 44 6F 74 5F 57 68 69 74 65 00 56 75 6E 64 2F 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 54 2D 2D 73 2D 00 58 2D 4C 00 80 2E 7C 2E 3C 46 4F 52 54 2F 42 6C 75 65 70 72 69 6E 74 73 2F 42 47 65 6E 65 72 69 63 00 57 2E 5F 43 00 27 4D 65 73 68 4B 00 2F 2E 53 5F 5F 4D 61 6C 5F 41 78 65 00 6B 2E 66 56 46 58 2F 4E 69 61 67 61 72 61 2F 73 2F 4E 53 5F 53 74 6F 6E 84 2E 65 57 6F 6F 64 00 82 2E 6C 44 65 66 61 75 74 00 90 2E 6A 4D 65 74 61 6C 00 8C 2E 67 4E 53 5F 5F 49 64 6C 65 00 8E 2E 68 00 90 2E 13 2F 53 63 72 69 70 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 47 61 6D 47 61 6D 65 70 6C 61 79 54 61 67 73 41 63 74 75 61 6C 41 6E 61 6C 79 74 69 63 46 4E 61 6D 65 0C 19 6E 69 6D 54 72 61 69 6C 73 46 69 72 73 74 53 6F 63 6B 65 74 4E 1A 53 65 63 6F 6E 64 0F 57 69 64 74 68 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 17 42 61 63 63 68 75 73 2E 2E 00 14 62 41 6C 6C 6F 77 4D 75 6C 74 69 70 6C 65 53 74 61 63 6B 73 00 0E 00 16 43 6F 73 6D 65 74 69 63 19 62 41 74 74 61 63 68 54 6F 00 1D 62 43 6E 42 65 44 65 70 6F 73 69 74 64 49 6E 53 74 6F 72 67 65 56 0D 72 6F 70 70 65 64 00 15 62 49 6E 76 65 6E 74 6F 72 79 53 69 7A 65 4C 69 6D 00 10 62 53 74 6C 65 6E 00 12 48 61 73 44 75 72 61 79 00 0F 62 4E 65 76 65 72 50 65 72 73 69 73 0C 42 6F 6F 6C 1F 62 53 6F 77 44 69 72 65 63 61 6C 41 72 72 6F 77 57 68 65 46 61 72 4F 66 66 00 0C 42 79 74 65 08 43 61 74 65 67 6F 72 79 00 05 43 6C 61 73 73 00 0A 43 6F 6C 75 6D 6E 09 54 00 17 48 61 6E 12 52 6F 77 26 5F 5F 44 65 66 69 6E 69 2A 44 69 73 61 73 73 65 6D 62 6C 65 44 65 67 72 61 64 4D 61 78 50 65 72 63 65 6E 74 72 69 6E 0B 72 6F 70 00 14 45 46 69 00 1F 3A 3A 49 6E 76 69 73 69 0D 74 65 6D 00 1C 3A 3A 00 0B 52 61 72 11 3A 3A 52 61 72 65 00 1D 65 6C 6F 61 64 46 58 53 74 61 74 65 3A 3A 45 6E 64 00 1D 45 4E 6F 72 6D 6C 00 16 54 72 69 67 67 65 72 21 3A 3A 41 75 74 6F 6D 61 74 69 63 00 0C 45 6E 75 6D 0E 4F 76 65 72 72 64 65 00 0D 46 6C 6F 61 74 1D 0D 46 58 5F 53 74 61 72 74 00 0B 46 58 5F 0D 1C 2E 53 6F 75 72 63 65 2E 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 22 47 72 61 6E 74 65 64 2E 45 71 75 69 2E 2E 07 1C 5F 54 30 31 00 11 45 66 66 65 63 74 00 10 46 58 26 50 68 79 73 69 63 61 6C 53 75 72 66 61 63 73 4D 61 70 00 1F 1E 0B 49 6E 74 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 0D 0B 4D 61 70 10 4D 69 6E 69 4D 61 42 72 75 73 68 00 17 56 69 65 77 44 69 73 74 63 65 00 08 4D 69 6E 00 0C 4E 61 6D 04 4E 0E 07 50 61 63 6B 12 75 70 53 6B 65 6C 00 19 65 72 12 50 72 69 6D 61 72 65 41 13 06 0F 0E 52 65 73 0B 52 6F 77 65 6E 74 73 00 07 52 6F 77 0C 53 74 72 75 63 74 00 0A 53 6C 61 74 65 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 31 00 0D 30 31 32 33 34 35 36 37 38 39 32 32 32 32 32 32 32 32 0C 33 34 35 36 37 38 39 00 13 12 30 54 61 67 3A 77 69 64 5F 68 70 73 77 6D 0C 54 65 78 09 32 44 00 0B 17 14 77 2E 6D 68 1B 57 4D 10 41 63 74 6F 72 12 73 68 25 64 C1 0B D1 54 AD B0 36 D6 B0 31 C6 07 E6 D6 98 1D 41 15 AE 8B 5D C4 AF 66 B7 E0 E1 9D 98 71 E1 56 66 F9 40 6C 0A A3 B9 91 47 6A 64 56 21 F6 B7 FB 88 1A D7 A1 08 65 C2 F5 C1 E7 ED 77 B5 A3 DD 95 F7 31 19 52 9F B5 E7 FC 96 34 EF 13 7A 41 BB 3A AE 97 12 57 94 1A 56 9C 5B 77 31 AE 43 97 F2 D2 4D C6 49 D5 95 6D EB 66 81 0A 77 E9 06 E7 BE A2 5E DF 46 D7 E7 82 7B 85 3E 69 24 A4 BF A9 0D 8E 46 FF A9 52 66 0B 0B 51 05 3E 4B 83 BD 6E 7D 91 72 3D 4F 6B 9D F0 3D 44 7B 94 02 11 D5 9C 0F 7F 22 D8 60 89 E8 47 C7 DA 65 DD CF D2 12 72 8E 7B 88 0E 93 5A 2D 39 33 53 DC DA D7 F8 9B B0 34 09 1C 6D C2 32 1F 6B B3 24 B3 4D D6 49 6F C7 47 B5 4A 45 CF C2 E9 1E C5 97 A3 2A 6D 9C A6 9F C6 BD 0E D1 6E 57 8E D2 E3 7D 89 90 7D 95 23 4C 6E EF 3E 9F 6E D0 A7 0B C2 84 2B 86 32 42 1D A5 5B 2D 5F 5A 5C ED 89 F4 0A BE 25 13 84 D0 66 2B A1 1F DC F0 0E 97 CE CB 0C 67 CF 52 61 4C FE E8 1B 53 D7 27 7F 31 94 48 47 17 20 52 49 56 73 93 01 18 5C 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 48 19 53 EC 0C 40 73 F8 AF B7 92 36 2D 68 5A A4 FF 9D BF 83 44 D8 AB BA D6 DF 3E 2D DB 1C 93 F5 9B C3 96 AB 63 DF 70 50 A8 E3 AA B3 3D 77 5A FD A0 20 73 C6 7C A3 4D 60 70 43 75 60 EC 4C 78 16 62 56 ED 6A 62 7F A3 64 76 29 07 38 53 1D 99 F3 C6 E0 08 33 EB 3D 3B CD E5 F1 8E 3B 3D C2 07 FA C9 3F C7 F6 28 38 8D 19 A2 44 42 19 0C 65 C8 36 85 42 31 66 36 5F 4A 81 55 39 E0 39 25 C8 BE 72 05 7A D2 09 00 D0 4F 72 8C 42 6E ED 60 B5 71 51 DE 72 84 89 5C 9A 9C B3 82 41 8D 74 2F BD D4 3F EE 28 C6 A7 41 C8 CC 73 5F F1 4F 17 98 E8 CF E5 AD 2B 3A 82 6E B6 DB 6B 32 55 D7 A3 91 04 09 AB 30 82 61 5F 9C 0A 20 71 FD 76 36 27 1D 07 CF 3B 40 26 15 6F 0D 82 0A EC 96 68 BA D1 CD 48 38 89 81 59 E1 AD 58 C4 11 82 5C B7 1B 1A EC 38 C4 FE F0 34 0E 22 8B 92 6F 39 69 A6 DD 0A AF FC 40 08 DF 48 95 A5 38 5B 65 33 6A 4D F9 A0 08 91 48 26 1D 33 27 6A 0A FF 98 D9 03 AA 02 AA C3 9D C8 B2 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 33 F5 AB 82 62 D3 37 BF 33 FA DE 60 E0 83 2C B5 21 CC FF 36 3F 64 F6 0E 6C 5B 34 36 C2 65 C1 19 49 A9 9A F8 07 86 51 53 81 EF 67 6F 2D FF B7 2E D6 3C 55 A9 1E BB 6B 14 C9 65 36 94 30 C1 46 43 84 EC 54 FB C1 E7 B8 DC B5 83 6E CC 56 50 A0 55 93 A5 A7 A5 38 D7 73 45 32 7A 8D 3F CF 98 83 9A C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 F5 61 D3 13 E3 AE 45 67 51 6A 6B A4 FC 3C 8C B9 13 EF E4 4D EC 00 34 91 66 C0 7C 9B 17 2E 9B 87 5B 69 1F 1D 12 55 26 5D C0 35 F0 CA 0B 23 C7 A4 67 B2 81 01 45 B1 5C 1B 3B EF E8 2F 13 C9 5D 75 DB 6F A3 73 A1 40 EA 11 32 50 77 C1 15 8A CC DD 39 01 5A 81 FE 31 FD 3B C2 EB B3 D9 30 59 00 D8 39 EF 4F A7 76 A4 62 F1 AD A2 3A C4 F4 A0 70 E1 C7 B9 E7 7B 86 0C 16 F3 2C 81 58 FF 04 7A 02 F6 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 6F C3 D4 37 FA 05 00 64 FD 3A 01 16 7B 9B 70 4E 5C F2 3B E6 12 F3 D7 48 78 C0 7E 96 90 03 5B 64 62 6D 93 AB 1A AE 7B 81 3C 4E 34 7F FF 33 3D EE B4 69 A9 78 E1 B4 8A A0 BC 73 EF 85 64 E9 0F 33 D9 4C 9B 5B E6 85 49 12 8C 86 10 8D A1 65 4C 44 33 9B 6F 71 90 95 97 78 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 50 3E ED 54 1E 2A 29 1F 17 93 19 0B 03 11 A3 4E BD 10 ED 87 4D 19 44 D2 A0 6A BA 78 E5 13 A9 90 FA 5D 74 F1 6F 69 0A 0C 26 B0 88 7A FC F8 4F FB C8 AC 71 36 39 86 87 21 2F 1A 3B 8C 87 D6 E7 D7 0C 3A 87 FE F5 B5 AE 69 DD 9A E9 69 B3 4D 26 FE 1B 5F 6B A9 F9 B2 F7 A1 33 C2 F2 92 F8 52 DC C7 74 7C 48 00 17 B5 C6 E5 C5 C8 83 BE 3E 2B 74 3E 7D 74 06 36 3C BB 64 26 A2 0F 39 26 E7 5C 52 40 AE B8 5F CA 47 BB CE 45 20 6F DD 36 8F 63 93 D3 25 3C DF 24 4E A2 AF D0 EA CE 9F 36 F1 F2 81 30 50 EC 69 F5 D1 93 BB 24 97 34 7A 18 D3 DB 6B D9 B6 60 ED 41 41 00 CA 6A 99 61 FB A7 19 16 64 02 72 83 FB 15 01 01 D9 10 DE 28 B5 8C AF E4 76 73 59 BF 58 F0 6D 5D AB 2F BD B2 D9 8B 36 15 A2 5A D2 18 04 72 D0 E2 B6 6E 6D 96 ED 9B D4 26 21 AB 65 B1 29 8A E4 43 6B BD AB 37 2F 90 F5 35 5D D9 45 CB 2F 95 B6 78 D9 36 AA 43 29 82 A8 B4 57 53 8B 0B 78 8B 6A 02 72 D6 A0 E5 46 23 43 BC A5 E9 A8 C1 B4 45 E3 CC C3 EE 6B D9 42 B9 46 36 32 22 C4 58 CB 6A 5D C9 6A 48 F5 BE 6A 02 4A 12 54 79 33 A4 13 A3 8C 1B 47 8A AB 86 89 D3 4C 77 CF 88 EB DE 92 B2 B4 3F 6B 74 FF FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 25 8E DB EE 36 40 10 95 18 1F 84 06 A7 00 80 D7 8E DF 67 54 0C 82 0B 00 00 00 02 00 01 4A 58 D3 32 1D 62 DD 4F 01 9C 26 68 43 F8 ED 5F 9E 44 22 02 70 C1 D2 0B E8 02 04 01 02 04 06 01 04 01 02 04 06 04 04 01 02 06 04 01 02 09 02 16 06 11 04 01 06 0A 04 01 02 0D 02 03 03 03 04 02 02 04 02 0A 05 23 58 25 5A 59 20 41 01 1B 00 9B 70 81 8C 94 95 96 97 98 99 9A 82 83 84 85 86 87 88 89 8A 8B 8D 8E 8F 90 91 92 93 00 1F 1D 1B 21 1F 1F 04 05 05 05 05 01 50 07 51 09 15 19 00 05 FE FF FF FF 61 00 70 01 01 A2 5F 02 9D 40 9C 45 03 03 F5 FF FF FF 07 FD FF FF FF 3F 60 00 17 0E CD CC CC 3D CD CC CC 3E 02 18 14 01 21 32 32 42 33 33 30 36 36 34 33 33 34 39 30 46 34 32 38 44 39 45 42 38 34 30 36 46 35 45 37 36 41 00 10 69 6E 67 20 54 6F 6F 6C A3 5B 31 13 12 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 95 C0 96 21 91 92 96 92 9A 91 41 00 78 F8 F8 F8 A8 79 E8 7C E0 30 28 38 7A E0 8D 87 87 8C 87 6F 55 20 91 7A 90 39 30 7D A0 81 01 79 F8 B8 F9 F8 F8 F8 90 7C A8 F9 F8 F8 F8 F8 78 78 78 F8 F8 F8 F8 FD F8 78 F8 F8 F8 F8 7A F8 A9 38 87 21 87 63 5B 38 30 7A F8 F8 F8 E8 79 E8 E1 8D 87 27 2A 40 25 2D 30 8F 21 7A F8 F8 B0 69 B1 32 87 2E 87 5C 2B 87 4F 38 22 39 72 38 7A F8 F8 F8 F8 D8 7C F8 F8 F8 F8 E8 79 F8 D0 F9 F8 F8 F8 F8 D8 79 F8 C0 A9 48 34 87 3E 48 87 7A F8 F8 F8 79 C8 7C D0 24 29 7A F8 C8 41 F9 D0 68 41 4C 78 A0 7E F8 F8 F8 F8 C0 79 C8 F9 F8 F8 C0 87 35 74 38 95 81 01 79 F8 81 01 86 01 79 F0 F9 F8 F8 F8 F8 F0 20 40 8D 83 01 79 F8 B0 81 01 87 01 79 F8 A0 F9 F8 F8 F8 A8 7B 78 87 01 79 F8 C8 81 01 28 82 01 79 F8 D0 27 87 44 87 39 28 5F 87 95 87 87 95 41 28 89 87 87 27 51 5E D1 87 87 87 79 A0 87 3A B9 87 87 87 73 22 87 59 87 51 32 8C 87 8B 8F 2B 39 87 87 87 24 23 28 8A 2D 2F 87 87 21 4D 8B 27 87 8B 87 4D 87 87 87 2B 21 21 4A 40 23 49 3B 39 22 30 28 20 2E 87 55 8E 23 7F F9 E2 99 20 38 2B 23 48 22 7A A8 87 21 31 23 6A 32 38 2A 23 59 87 31 87 37 56 28 38 8C 5B 2F 79 B8 87 87 4B 31 8D 87 4A 79 F8 2B 87 2C 20 41 30 41 31 3F 59 5A 87 6C 87 22 24 29 41 41 79 48 26 3E 22 5A 21 48 87 3F 36 78 D8 F9 B0 28 28 54 48 87 2F 71 4C 8F 20 3F 24 94 2F 55 22 29 50 25 21 26 20 22 3A 68 26 3B 51 30 20 39 31 50 2C 38 24 87 2A 31 87 36 6E 7D 21 58 31 28 63 71 F1 F1 F1 F1 F1 F1 F1 F1 69 E9 F1 F1 F1 F1 F1 F1 91 D9 69 E9 E9 E9 E9 E9 DB 48 29 70 3C 3E B9 21 B9 21 54 39 64 79 C8 2A 2A B9 32 A9 28 50 31 35 41 3A 48 20 38 79 F0 C0 38 22 00 F8 87 87 87 87 36 32 B2 40 40 40 40 87 42 5C 99 39 87 5A 87 61 87 E1 87 87 87 87 8F 99 21 93 5D 39 59 B9 C9 A3 91 BA 59 79 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 79 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 81 01 59 F9 A0 F9 A0 F9 A0 79 99 B9 79 A0 B9 D9 59 D9 B7 61 D9 61 99 59 B9 59 69 87 8A BE B2 59 59 87 21 64 99 87 87 87 87 9E 38 87 29 39 39 B9 59 30 01 14 00 30 00 43 00 1D 00 62 00 15 00 3D 00 13 00 2F 00 42 00 43 00 37 00 38 00 52 00 C5 00 5D 00 5D 00 82 00 57 00 D3 00 76 00 CD 00 57 00 76 00 B4 02 72 00 16 00 10 00 3D 03 2B 00 4B 00 67 00 14 00 26 00 47 01 11 00 15 00 31 00 0D 00 35 00 42 00 3E 00 1D 03 2B 00 EA 00 FF 01 ED 00 16 00 D2 01 CE 01 17 00 58 00 5A 00 82 00 5A 01 61 00 45 06 46 06 ED 05 3E 00 19 00 59 00 34 04 36 00 29 00 31 00 CA 06 2A 01 4D 00 1B 00 55 00 6D 00 7C 04 3E 05 95 04 68 00 86 00 86 00 67 00 84 00 29 00 6B 00 6E 00 92 00 92 00 6C 00 8E 00 8A 0B 37 04 69 00 90 00 90 00 27 0A 6A 00 92 00 7B 09 15 00 10 00 7C 09 16 00 10 00 24 00 55 00 1B 00 1C 00 42 0E 2B 0E 21 0B 10 00 18 00 92 00 73 00 60 04 1F 00 34 00 66 09 2A 00 12 00 8C 0F 37 00 10 01 B5 00 2F 00 7C 01 FD 0B 11 0C 0B 00 31 00 48 03 19 00 14 00 58 05 3C 02 23 01 A1 01 CE 00 51 01 E2 00 05 0C 2C 00 9C 02 C5 00 70 0C 90 00 7C 01 DC 01 16 00 FC 00 21 00 76 0D 0F 00 E0 00 6B 02 1E 00 AC 01 0D 00 13 00 0F 00 33 01 B5 00 22 00 1F 00 94 00 18 00 F8 01 E7 00 1F 00 B9 01 46 05 11 03 C2 00 0D 00 1C 00 29 04 72 0E 38 03 47 04 0D 00 6A 04 92 00 51 03 A4 00 83 01 09 00 2B 12 93 12 C2 00 69 05 13 00 7F 04 2E 07 21 00 3D 00 28 00 21 00 08 0F 20 00 96 03 6D 02 B3 0F 9C 0F 39 00 81 0D 12 00 A6 03 46 00 12 04 FD 0A 16 06 92 00 7E 00 4C 01 41 08 4A 0C D4 0F 9B 01 B0 01 56 03 C2 04 14 00 01 01 00 01 33 03 0C 03 19 01 34 02 A8 06 1E 02 A8 01 97 06 01 01 42 01 E1 00 3B 00 10 00 A2 01 69 11 0E 00 0F 00 A4 00 0E 00 A5 0B BD 08 B1 03 81 05 F1 03 07 09 A3 13 E6 01 EF 10 50 05 68 12 6D 00 72 04 16 00 EA 03 75 08 1D 00 64 07 5A 05 81 05 26 00 EF 05 46 07 ED 16 09 18 08 00 A6 05 08 00 40 00 78 00 10 00 70 00 F0 1D 0C 00 40 1E 1C 00 14 00 22 00 42 00 08 00 14 00 31 00 14 00 24 02 24 02 D4 01 58 00 1C 00 0C 00 C9 05 0C 00 19 00 18 00 95 00 2B 00 0C 00 73 06 8D 00 A2 0C 8C 06 4A 00 08 00 7D 00 00 00 00 04 00 0B 06 0A 11 0A 0F 0C 08 0D FD 0B 01 FC 17 00 8C 0A 00 10 44 88";
        string Pickaxe1 = "8C 06 00 0E 3C 88 0E 3A 03 00 00 00 00 00 00 00 40 29 0C 09 FA 48 08 08 39 79 D7 3E 4D 5B 6E F6 66 44 47 54 BE 4E 51 55 74 85 55 A2 F9 CC 83 15 41 E9 B5 85 59 92 49 87 57 75 B4 BB 6C DC 3E E7 D3 73 DC CB 56 2F 79 B3 DC A9 4F F3 C8 E5 16 F9 65 3B 88 8D 04 00 84 01 60 65 62 60 6D C8 44 81 55 0A 05 50 80 12 18 43 4B 53 A1 1A 95 EB 00 12 91 83 50 74 86 05 42 82 4A 85 1A C2 BE 20 03 81 59 28 E3 30 49 21 83 9A 4A 64 60 2A 83 A6 30 45 80 44 50 01 0E 66 24 23 06 04 2A 10 0C 68 19 35 11 11 21 CC 05 CB 54 5A DC 46 40 0A 4C A7 BF E4 5B 00 00 B0 D6 E4 AF B7 65 15 32 4A 0C 60 36 93 1E 25 4A F4 3C 42 8B A9 68 12 8E 37 60 66 29 4A C1 92 00 BD 9D AF C3 53 19 9C B1 78 CB AD 3A 33 90 CB 20 0D 09 D2 84 DA 80 BA 64 09 E6 03 FD 68 0A A4 41 88 C9 70 8D 83 A2 1C A8 91 91 43 57 14 58 B5 C9 A4 02 21 3E A7 15 14 2C 26 C6 60 71 34 88 CB F4 85 10 CD 4D B3 02 CA 34 59 4A 02 C2 1B 63 54 6A 2F FE 18 02 A3 C2 50 25 E6 AE 05 46 0C 05 B9 66 0C A7 F4 68 A8 DA 97 2A 72 70 65 74 80 7E 14 87 F0 F6 D3 E0 80 B2 42 B7 4C AE 3B E3 E9 EB 67 E4 79 09 67 C5 08 85 42 71 34 00 71 06 9B 55 C8 75 98 49 1A 00 C3 CD 23 47 DC B7 8C 5D 64 7C B4 D8 88 9F 2A 9C FC A1 07 B6 39 EE 45 ED 18 19 94 B6 E4 64 3B E4 5D 6A 6B E9 F3 B3 0F FA 56 4F 3D A0 CA E4 26 9C D9 90 FE 6A A9 EF E8 DF 9F FD 71 9D 5A 9B 27 FA A3 D1 A3 DD 72 4C 9D A4 7C DE 60 DD E1 9D F3 B8 76 CA 20 C1 9D 29 CB CF AB 3C BB 6A E6 DD 06 5E E6 27 CD 8A E4 49 D9 AC CC 74 AF F2 AA 81 CE 37 67 6D CB 83 00 9C D0 64 D7 67 13 A5 A8 C0 8C 32 34 24 75 18 4C 42 70 C4 C6 58 11 3E 48 54 A0 10 D1 17 6B 50 48 E1 F9 76 29 21 40 EC 7C 58 A2 21 D4 0C AA 40 B5 90 E6 A3 0C 4E 42 5C C5 E0 08 09 F9 6A 05 4A 11 25 8C 19 0A 8A 29 32 42 11 05 52 F8 73 32 65 10 4B 82 7A 3E D4 08 80 11 80 55 78 B5 59 83 41 9D DE DB 04 09 88 4A ED 52 1C 4B 93 5A 51 9A D2 58 00 CC 61 BC A8 0C 1B E3 87 9A F9 63 70 07 6E D3 E8 C1 38 3A 88 21 75 84 82 64 D4 0C 9A ED 65 D0 15 61 29 00 07 A8 BD 44 57 94 41 F3 48 1D 89 E9 49 55 7A C9 28 06 E0 B4 DD 23 20 33 DC 88 01 CC 6A 32 A0 18 50 85 62 5E 71 5C 2A 2E 84 54 29 29 5C 6B A2 E2 18 54 69 A5 54 5E 08 C5 07 24 0A 79 14 DF 0E 90 28 65 9A 09 55 65 D0 A8 1D 4D 05 5C 06 85 D0 0B B3 03 06 F0 48 90 61 83 38 C4 28 7F 6F 1A 68 EC 38 4E 7A 83 28 71 B4 50 28 14 49 62 91 48 CC EC F0 00 63 AC 3E 7E D3 00 E0 1E EA EE E8 96 AE 3B FC 70 4B 76 62 53 52 F6 C9 F1 A3 86 06 9A FE CD EC 13 2F 89 F3 1B 9F DF F2 A6 A3 DE E8 E8 FB AA 67 29 76 AE E6 00 D7 B5 7C 79 FC 76 05 7B 5B 58 E5 A5 7B 7E 4B EB 62 EF 0E 8B AD A1 53 BB 2F CD 6B BF F8 F9 B7 67 88 AE CA 7A 62 C7 BE 55 C2 BD C8 80 A7 BF 31 D4 FB EA F5 94 E0 E9 9B 02 D4 75 0B AB EE EC FF B3 B4 E2 16 FE 37 9A DC 0F 06 BD 68 C1 84 C7 60 34 B3 47 31 1F 40 E9 32 92 A2 7A CF A1 35 7E AF 5D 8D DA 67 FC 2C 44 84 57 B4 6E 12 53 CB E5 9A CD C7 5B 69 B1 3E BD 6C 95 2C 78 41 32 39 E9 A1 1D E3 55 D8 24 82 8A DB F4 DF 89 65 04 97 FE 71 A7 2F 1E C2 59 55 6E DB A7 85 ED FD 48 6A 8B 6D 36 1B A7 FE CD D6 A0 FA D6 BE F6 AE ED 6E F0 C1 B9 E7 FD 1F DB 93 85 CB 48 57 F5 12 56 9B 40 0C CA 60 FC 01 14 F3 42 07 3F 7F 18 AC DE 42 85 62 49 14 8A 89 86 8D 1A 51 E4 21 A3 A5 42 88 30 2D DB BA 0D 20 86 CE 65 0F B5 30 98 A4 48 9B 6D 23 1A F4 4B C2 7C A5 11 AF A4 42 7F 31 62 24 80 43 39 5C 09 91 72 42 1B A7 B3 CA DD 9C 60 C3 8E 89 0C 0D C0 1C 68 00 4D 87 10 4A B9 EA A6 88 40 53 04 40 73 F0 04 9E D3 92 6A 21 19 43 95 20 2B 35 0C 9A 28 A4 34 74 0A C9 11 D5 68 1A 12 C7 00 41 43 41 98 6D 0A 08 6D 52 84 80 D2 88 31 DA 4A 40 D3 D3 20 29 21 2A 80 0D A3 34 67 A3 18 E1 46 10 55 19 47 06 69 68 C3 18 82 02 1D 2A 28 08 D6 15 94 00 07 C3 40 CD 52 72 C0 86 29 D8 17 4F C9 58 88 8A 8E 96 BD 76 86 C9 87 32 56 95 44 CA CA CC 4F 1C 89 46 54 45 02 99 1D 50 2A 14 36 85 66 14 E3 E3 1F 03 4C CA F9 52 ED 40 69 01 44 03 1C 91 43 06 22 E4 EA 07 20 59 24 F5 5A 10 64 09 8E 29 36 39 AD A8 43 20 93 13 22 43 93 03 02 93 B8 01 BC E1 8D 66 67 79 F3 83 3B 43 9B 1F EC 3F 96 37 69 59 81 3D 45 57 D8 34 43 F3 76 54 FC D3 D9 EE 73 3F 0B 92 C1 D5 C6 79 B1 D3 A8 AE 1B D5 03 8B A9 85 C7 D6 9F 79 B9 AF F3 F5 96 A7 71 27 84 4D 1E 65 DB 16 4B DC 13 49 4F F3 B5 CA 47 17 16 8E BF 20 5E 17 7B 6F E4 C1 5E 98 3A 2A 7C BA D3 E5 E0 65 D9 FC C0 61 AD A8 2C FA FD C3 56 A7 01 97 B4 1D 70 D7 98 9C DD 07 2C 30 52 AE ED 6B ED DC B9 37 46 B9 7E 4B BB C5 79 89 A8 CE CB 1B F2 57 16 8E 9C 7A 02 8C 8D 8D 98 DF A2 57 53 4C AC 85 83 FE F6 A6 44 61 5B 27 EB D3 EC 63 0B 62 F7 E9 76 FF F3 A8 8F F7 85 93 6D AC 0C 9F 35 5A B0 B1 B3 62 63 F7 6D D7 8F E3 6C 6F FC 92 FF E7 A2 6B 5E 9A E6 7C 79 E0 F8 4F AB 47 A7 FC E5 E7 03 45 8B 1B 2E 7A 50 E9 65 AE 0D C1 09 13 43 83 7C CF AC 51 14 3E AD 65 B0 F0 25 E9 DF C5 4E 9E DD CD FB D4 B2 F5 D8 27 CB 51 D1 C6 BB CB 02 9E 96 CF 5C 2E 31 8C EE 4B 44 4E 4F 92 D4 CD 49 BB B1 E3 4D C6 D0 69 F1 AD DE 01 F0 CD 3E 43 39 CB A7 F5 C9 82 57 CD 47 25 79 9C 3F AD 8D 93 BF 7F 72 46 30 4B 59 DF 2B DF AF 29 66 EF 9C B2 B7 ED F1 4B 99 E4 42 61 E1 D9 79 25 FE C1 CD B7 AE DF 3F CE 38 9D 8F F7 0E 8F D8 8B AB 6E 4F 7B E9 13 0A 6A B4 DC 79 C2 7B DB E4 48 58 DB 33 96 1B CB 8D C5 F1 70 63 79 B1 39 6C 8E EB B4 49 8D D5 9B BF 29 AF A8 5C 5F 5B 17 1C EA 9A E1 01 D0 DD DB 95 43 1F 9D E0 5A 7C 27 9B 25 14 49 44 91 C2 D8 18 89 52 3A 89 CC 07 00 00 00 F4 C9 88 3D E7 7E EF 8E A8 3B AF CF 38 E8 D8 D9 91 2A EF 1F 37 B0 A2 28 E6 9B 87 2F AE D5 B4 5F 79 B7 5E C1 93 44 21 59 B1 67 97 00 8A 68 BD 5F B9 4D 2A 98 DB 71 19 09 B8 3E 93 B0 F4 70 22 91 49 45 21 B3 C7 96 6D BE 19 B3 20 B7 2C 38 E6 55 18 F9 ED E1 51 F5 F9 85 3B 93 45 9E BD EC ED FF BC 4D 0A B3 AD 6F BE 25 2A F8 A2 73 AE B7 18 AA 87 E7 0F 46 F0 B3 4E 5F D9 A4 EA 6F BB 4B 64 D4 ED A5 97 5C DF CA 7C D5 EB 93 14 76 D6 71 AB 65 FE 9E EA C1 FE 0D CB F8 F9 21 E1 B3 B8 7B 4A BF 9F 2D 58 44 EE F2 75 54 C5 96 7E 7C 11 F9 7B FA 9E 43 17 6C A7 2A DE E6 2E B9 3B 44 44 E4 DB A7 06 BD 5F D9 71 FE BD 81 D5 B8 F0 AF 9E 9F 6B 0D 75 2D 73 56 C4 63 8F 76 0E 3E EF CD 57 57 EC 52 90 F5 AB B0 AE 17 23 6E 4F 7C 33 B4 33 EA 5C D2 06 82 76 16 1F 58 44 F2 D6 0E 5F 96 AC 19 BF A6 67 4D EB 3D 2C 1C F9 6F D7 9B 4C 06 74 5C 4E 48 70 3B BD 3B 3C F3 87 24 E5 3D FD B4 A9 87 7F 7D 1D 89 D5 35 04 5A 0A A4 85 1F C6 51 63 7B 3F 3B 4C E7 2E 3A B3 6E 77 E0 0D 62 20 1C 56 59 A2 87 7A 05 C5 07 CB 72 B8 85 DD AA 9F F6 2B CF F7 AA C2 AE 5E 19 62 6B F7 54 57 55 3A 5E 1C B5 38 9D CE DC 2C 2F B1 ED EA 9F B6 3B 89 81 FB 7A 4C 65 AC 5B 3A 96 79 40 61 E3 72 38 1C 0E C7 8D 3D 8E E3 E9 E2 C2 66 7B E6 2E 08 2E AD DF 52 B6 7A ED BA AF 37 86 84 BA BA CE 0F FA C4 62 6F 73 71 77 16 78 77 76 3A C7 08 45 12 51 AC 58 21 8B 9C 25 F1 21 9B FC 00 00 00 00 00 00 00 0A 3C 5A 06 8A AC 52 8C 55 62 C5 22 CB 27 02 12 D7 9D 01 B9 CE 01 74 49 0D AB AC 7D D5 C7 32 74 21 B3 55 53 5A AE B6 1A 9B 6D 49 E4 A7 B1 61 C2 ED 8D D7 DB 16 6C 39 B1 66 CD 8B BB 3F FE 1F 0F 49 0D CE C7 80 F9 5B 77 A9 23 55 10 53 99 6A 9D B5 66 19 D3 A7 5C E3 76 B2 91 54 94 D4 4F D0 B9 28 BB 98 4A 72 D3 BC 7E 7F 2A 7A 8E B7 5F 1C 66 48 4F 57 45 DA E6 F2 19 E6 ED F3 62 75 17 6C 77 A0 AB 39 D1 75 7E EB 03 FB 10 68 2F E9 09 CE E4 BA 9C DF F6 94 96 FF BB 07 AD F5 F9 2B F2 FC B6 17 63 C2 73 30 CB 3C 5E B7 25 2F 87 DB 7F 81 F0 6A 79 EC 21 B8 BE EA 82 15 C5 87 C8 C8 F3 DA FF 7F F4 7E BB 52 7C 9B 70 07 9F 03 78 18 70 88 3A 47 C8 F1 6D 63 4A 7D 7A BA B8 D4 41 B4 55 C5 E3 A2 C5 4B E3 AD F3 9B C5 B7 EC DA 69 6E 20 D1 91 4F 13 95 82 CB 74 6D FE D7 53 77 79 CA 57 1D 2D 2F 3B 71 D7 A2 C1 82 F7 B5 45 E5 EF 63 19 DF F4 3B 95 D9 F8 32 A8 E9 72 FF 3F 59 A1 35 80 E7 F8 AA 7F 8E 65 93 63 E8 C7 C5 D7 B6 FE 24 B9 76 5E 5B 9C 23 D7 DA CE CF 28 7E 1F 55 B6 92 31 C4 CE 72 79 29 45 6B 68 3D BF 2E F2 59 3E 5F BB 9D D2 19 70 F4 AC B7 C5 1F CF 07 2D C2 90 86 DF F4 46 39 31 33 CC 46 F7 93 FF B2 7B E4 3D 2E 4C 7F FA BD C3 D7 E9 C7 E7 A8 CD 0D AC 9D D9 50 EC FE 9D 29 33 FB 73 19 6B 6A BF 98 2B 2E 91 EA EC BC 3E 94 93 2C BA 0E EC C5 2F EF F1 D7 EC D1 0E 90 F7 06 75 B3 8A 0A D9 37 48 FF 8E 3D B6 6C 68 4C 26 3F 15 DB 79 25 87 89 40 07 80 01 A2 44 8B A6 8D 12 37 C3 C5 6D 1A 29 0D 19 3D 02 90 25 41 A0 19 82 49 32 69 55 21 A2 D4 7F EF E4 4A BD 36 A5 2F F8 48 09 81 05 05 C6 01 F2 8C 2A 84 88 68 84 E0 91 F6 68 7D 1A DE 8A 80 B0 B1 00 00 3C 00 F7 06 C3 41 BE B5 17 03 CB CC 5F C6 AB F4 D1 3C D7 E3 0E A3 4F 5B CE 1B 19 43 D5 F3 7B 66 26 63 D0 04 DB FF 67 73 49 92 E4 FD E4 44 92 A1 56 8D 64 13 C8 39 E5 69 DA A1 FA AD 4C 0A E1 8B D7 87 6C 50 E7 9B EF FC 6C 46 96 89 70 8D C6 D6 3D 54 96 B1 B6 B3 86 79 C9 9B B2 3D AC FF 3E F0 F0 CF 91 34 09 21 86 AA 4C 65 20 1F 5B EA B3 7F 71 A0 52 CB 99 42 59 03 01 A5 64 0B 24 CA 87 5B 48 89 B4 6D 23 48 BD AB 0C 40 B2 50 EE 21 19 5C 9F 6A 8C 7C CC C8 FE 4B DB DC B7 18 F3 91 45 CB 9F A6 B4 7A ED 23 F3 76 F3 1E 54 FE 9B DD 61 C3 3B 39 00 B5 3C 0F AB 86 EC CC A0 52 EA 79 D4 86 91 74 45 A2 0D AE 9B 95 10 42 88 81 EF 17 CA BB 5B C4 59 3B B7 5C 56 55 F1 E4 95 8B 1D 00 00 00 C0 2D 00 4C 27 38 71 EB 5D 37 92 53 D2 E1 CF 6B CC 72 D3 5C A9 52 9A 44 87 CB 52 B7 2A C0 20 D3 42 08 5F 88 6F FE C3 CB D2 6B D9 33 F2 C4 3E DD AD AE 57 07 C5 DE 14 00 00 00 00 00 80 BD C9 52 BB B7 FB 2B 5B 9C 01 06 A4 9D E1 DF 0F 57 F3 EE C0 70 00 00 00 00 00 7D 1B CE 83 BA EA A6 F4 D6 AC DB 15 6A 86 D8 FD F1 31 0B 58 84 AE 29 BD 2C AA CC 99 11 E5 E0 9B 1A D1 A4 D3 84 BC E8 BF 41 71 59 40 05 80 01 17 48 5A 08 A8 8A A8 DC 90 CB BE BA BC CB C8 5A 22 4E 59 44 D7 62 EB F6 05 A0 79 00 00 28 00 64 9D B2 01 43 C2 51 E4 1D C8 30 6B 59 B2 90 9C 37 0E 80 C9 4C 7B 08 C4 81 59 77 C2 71 DE 1F FE D8 44 E0 C0 69 6F 94 04 0E 2D DA 0C A3 5C 87 64 26 18 4A 3F C4 C7 F5 DA 7B CF 7C 26 B5 F3 1D 75 9D 40 45 32 2A F8 B3 A1 99 90 2C 7D 49 C5 69 00 0A 74 23 52 21 47 49 53 C8 69 53 8B 83 02 8D 7B 0E 91 3D D1 61 18 9A 36 3C B4 C0 F0 01 13 8C 2C 98 7C 02 00 46 C0 1A 2A 00 CC 2A 64 11 26 0A FA B2 6E 38 6E 40 6F A4 D1 DC 2E DF C7 5B 7D 57 02 55 E1 9C 9A 66 FE 61 8F 6F FE AA F5 0F FA 5C 80 B3 DD 19 53 EB 28 A6 3B C2 AA 00 BC BF 59 33 1B 5E 6A 5C 06 98 0E 5A B3 2A FB BD 31 53 75 6E 7E 1F B6 F5 6B 73 3A EB 2B 51 2E 2A 26 FA 00 00 AC 19 C3 5D 99 82 AE C6 1B D4 25 0D F2 E2 EB 96 A9 DB 8A 3E 5D A2 BF E5 6F AD 0F C6 F6 B1 7D 59 F4 E7 ED C2 36 4A 27 15 59 56 20 03 30 00 92 48 80 02 08 0A AE 04 CC 28 E6 A7 64 F6 87 8F 5B E4 EB 7A 4D 49 BC D5 FA D4 5A D4 8B 4F 20 FD 20 26 00 FE 38 AC 6D 59 BD 4D 4A 64 B6 6B ED FC 2E C7 9F FF AF 6E 9B F9 42 6B 5C 48 99 23 72 8B 30 7C 5E 12 00 00 38 A2 04 57 76 56 0F F0 D2 06 AE 63 B7 B5 5B CB FE F1 FB BD 0F DB 94 65 74 49 A7 8A 54 F7 21 3C 24 B5 63 5D 02 00 00 10 0B 1C 00 00 01 D9 59 64 CC C1 3A B1 C2 B9 AC BC 0A 11 C8 79 F7 FE F4 F4 FB D5 CE BF 93 E5 CF 93 DC DF 85 61 DB 02 10 06 3C B0 66 0D 04 10 22 04 06 0B 9C 9B D4 B9 E6 7D 04 9C D0 1B 9B 11 09 C2 F0 44 47 90 0C 35 11 01 50 60 F4 08 7C 39 27 3C 59 E8 68 0E 6D 10 03 94 18 E6 E8 BB 80 04 B0 30 F0 87 19 58 01 1B 48 28 24 C0 09 1E C2 22 06 28 40 F0 24 B6 D5 0F 8C D2 12 91 53 87 47 8D 96 60 B2 19 44 18 18 05 F9 80 34 64 0B 06 02 34 A3 84 A6 C0 B8 3B 3C 2B 16 C0 06 13 98 60 B0 EB F2 73 CF 42 38 67 64 8B 3B 15 1A 0E F4 20 E0 10 F5 20 FC 26 89 7A 38 13 CC 19 18 05 1B 12 97 80 03 89 D6 94 EC B1 90 EB E8 8B D0 80 0B CA C2 3E 1C EB 8A B7 45 9A 60 00 CF A3 20 80 30 A5 08 93 0D CE 27 02 2C 38 81 77 0F 77 56 60 89 54 B8 BC AE 00 9E CB 08 87 01 25 60 4C 57 05 64 64 6A 64";
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
                Settings.Default.GuandaoEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh added";
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[2], SwapPath[2], Pickaxe, Pickaxe1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.GuandaoEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Mesh removed";
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
