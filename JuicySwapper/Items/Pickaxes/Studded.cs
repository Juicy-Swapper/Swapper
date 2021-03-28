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
    public partial class Studded : Form
    {
        bool enabled = Settings.Default.StuddedEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Studded";

        public Studded()
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

        string Pickaxe = "8C 06 00 0F F2 88 0F F0 03 00 00 00 00 00 00 00 00 0B 3E 00 20 04 80 18 1F 40 00 00 00 03 18 48 18 48 05 90 1D E8 1D 30 1E 48 1E 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 57 65 61 70 6F 6E 41 62 69 6C 69 74 69 65 73 2F 47 41 42 5F 4D 65 6C 65 65 5F 49 6D 70 61 63 74 43 6F 6D 62 6F 5F 00 60 2E 5F 43 00 2D 00 40 57 49 44 5F 48 61 72 76 65 73 74 5F 50 69 63 6B 61 78 65 5F 53 70 61 63 61 6E 64 65 72 65 72 4D 61 6C 65 00 5B 53 6F 75 6E 64 41 73 2F 53 68 61 72 70 44 72 65 73 73 2F 50 41 5F 5F 43 75 65 80 2E 55 52 65 61 64 79 74 53 77 69 6E 67 49 41 6C 74 65 72 61 74 69 44 61 6D 61 67 65 54 79 70 65 42 61 73 00 65 2E 24 44 61 74 61 74 61 62 6C 65 73 2F 4C 6F 6F 74 4C 65 76 65 6C 00 33 46 6F 72 74 5F 50 6C 61 79 5F 2F 43 6F 6C 6C 65 63 74 5F 00 40 2E 00 29 55 49 48 55 44 2F 55 49 5F 52 61 64 61 72 5F 45 6E 65 6D 79 44 6F 74 5F 57 68 69 74 65 00 56 75 6E 64 2F 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 54 2D 2D 73 2D 00 00 00 58 2D 4C 00 00 00 80 2E 00 00 7C 3C 46 4F 52 54 2F 42 6C 75 65 70 72 69 6E 74 73 2F 42 47 65 6E 65 72 69 63 00 57 2E 5F 43 00 27 4D 65 73 68 4B 00 2F 2E 53 6B 2E 66 5F 5F 2F 56 46 58 2F 4E 69 61 67 61 72 73 2F 4E 53 5F 49 49 53 74 65 00 84 2E 65 57 6F 6F 64 00 82 6D 6C 44 65 66 61 75 6C 74 00 90 49 49 6A 4D 65 74 61 6C 00 8C 67 4E 53 5F 41 78 6C 65 00 8E 2E 68 53 53 69 6E 67 00 90 13 2F 53 63 72 69 70 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 70 6C 61 79 54 61 67 73 41 63 74 75 61 6C 41 6E 61 6C 79 74 69 63 46 4E 61 6D 65 0C 19 41 6E 69 6D 54 72 61 69 6C 73 46 69 72 73 74 53 6F 63 6B 65 74 00 1A 53 65 63 6F 6E 64 0F 57 69 64 74 68 00 0D 41 72 79 50 72 6F 70 65 72 74 79 00 12 17 42 61 63 63 68 75 73 2E 2E 00 14 62 41 6C 6C 6F 77 4D 75 6C 74 69 70 6C 65 53 74 61 63 6B 73 00 0E 00 16 43 6F 73 6D 65 74 69 63 19 62 41 74 63 68 54 6F 00 1D 62 43 61 6E 42 65 44 65 70 6F 73 69 74 65 64 49 6E 53 74 6F 72 61 67 65 56 0D 72 6F 70 70 65 64 00 15 62 49 6E 76 65 6E 74 6F 72 79 53 69 7A 65 4C 69 6D 00 10 62 53 74 6F 6C 65 6E 00 12 48 61 73 44 75 72 61 79 00 0F 62 4E 65 76 65 72 50 65 72 73 69 73 0C 42 6F 6F 6C 1F 62 53 68 6F 77 44 69 72 65 63 61 6C 41 72 72 6F 77 57 68 65 6E 46 61 72 4F 66 66 00 0C 42 79 74 65 08 43 61 74 65 67 6F 72 79 00 05 43 6C 61 73 73 00 0A 43 6F 6C 75 6D 6E 09 54 00 17 48 61 6E 64 6C 65 00 12 52 6F 77 26 5F 5F 44 65 66 69 00 2A 44 69 73 61 73 73 65 6D 62 6C 65 44 65 67 72 61 64 65 4D 61 78 50 65 72 63 65 6E 74 69 6E 0B 72 6F 70 00 14 45 46 69 00 1F 3A 3A 49 6E 76 69 73 69 0D 6D 00 1C 3A 3A 00 0B 52 61 72 11 3A 3A 52 61 72 65 00 1D 65 6C 6F 61 64 46 58 53 74 61 74 65 3A 3A 45 6E 64 4E 6F 72 6D 61 6C 00 16 54 72 69 67 67 65 72 21 3A 3A 41 75 74 6F 6D 61 74 69 63 00 0C 45 6E 75 6D 0E 4F 76 65 72 72 69 64 65 00 0D 46 6C 6F 61 74 1D 0D 46 58 5F 49 64 6C 65 5F 53 74 61 72 74 00 0B 46 58 5F 0D 1C 2E 53 6F 75 72 63 65 2E 00 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 22 47 72 61 6E 74 65 64 2E 45 71 75 69 70 70 00 07 1C 43 5F 54 30 31 00 11 45 66 66 65 63 74 00 10 46 58 26 50 68 79 73 69 63 61 6C 53 75 72 66 61 63 73 4D 61 70 00 1F 1E 0B 49 6E 08 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 0D 0B 4D 61 70 10 4D 69 6E 69 4D 61 70 42 72 75 73 68 00 17 56 69 65 77 44 69 73 74 61 6E 63 65 00 08 4D 69 6E 00 0C 04 4E 0E 07 50 61 63 6B 12 75 70 53 6B 65 6C 65 6C 00 19 65 72 12 50 72 69 6D 61 72 79 46 69 72 65 41 13 06 0F 0E 52 65 73 0B 52 6F 77 65 6E 74 73 00 07 52 6F 77 0C 53 74 72 75 63 74 00 0A 53 6C 61 74 65 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 31 00 0D 30 32 33 34 35 36 37 38 39 32 32 32 32 32 32 32 32 36 33 34 35 37 38 39 00 13 12 30 54 61 67 3A 77 69 64 5F 68 70 73 77 6D 0C 09 32 44 00 0B 17 14 77 2E 6D 68 1B 10 41 63 74 6F 72 12 73 68 25 64 C1 0B D1 54 AD B0 36 D6 B0 31 C6 07 E6 D6 98 1D 41 15 AE 8B 5D C4 AF 66 B7 E0 E1 9D 98 71 E1 56 66 F9 40 6C 0A A3 B9 91 47 6A 64 56 21 F6 B7 FB 88 1A D7 A1 08 65 C2 F5 C1 E7 ED 77 B5 A3 DD 95 F7 31 19 52 9F B5 E7 FC 96 34 EF 13 7A 41 BB 3A AE 97 12 57 94 1A 56 9C 5B 77 31 AE 43 97 F2 D2 4D C6 49 D5 95 6D EB 66 81 0A 77 E9 06 E7 BE A2 5E DF 46 D7 E7 82 7B 85 3E 69 24 A4 BF A9 0D 8E 46 FF A9 52 66 0B 0B 51 05 3E 4B 83 BD 6E 7D 91 72 3D 4F 6B 9D F0 3D 44 7B 94 02 11 D5 9C 0F 7F 22 D8 60 89 E8 47 C7 DA 65 DD CF D2 12 72 8E 7B 88 0E 93 5A 2D 39 33 53 DC DA D7 F8 9B B0 34 09 1C 6D C2 32 1F 6B B3 24 B3 4D D6 49 6F C7 47 B5 4A 45 CF C2 E9 1E C5 97 A3 2A 6D 9C A6 9F C6 BD 0E D1 6E 57 8E D2 E3 7D 89 90 7D 95 23 4C 6E EF 3E 9F 6E D0 A7 0B C2 84 2B 86 32 42 1D A5 5B 2D 5F 5A 5C ED 89 F4 0A BE 25 13 84 D0 66 2B A1 1F DC F0 0E 97 CE CB 0C 67 CF 52 61 4C FE E8 1B 53 D7 27 7F 31 94 48 47 17 20 52 49 56 73 93 01 18 5C 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 48 19 53 EC 0C 40 73 F8 AF B7 92 36 2D 68 5A A4 FF 9D BF 83 44 D8 AB BA D6 DF 3E 2D DB 1C 93 F5 9B C3 96 AB 63 DF 70 50 A8 E3 AA B3 3D 77 5A FD A0 20 73 C6 7C A3 4D 60 70 43 75 60 EC 4C 78 16 62 56 ED 6A 62 7F A3 64 76 29 07 38 53 1D 99 F3 C6 E0 08 33 EB 3D 3B CD E5 F1 8E 3B 3D C2 07 FA C9 3F C7 F6 28 38 8D 19 A2 44 42 19 0C 65 C8 36 85 42 31 66 36 5F 4A 81 55 39 E0 39 25 C8 BE 72 05 7A D2 09 00 D0 4F 72 8C 42 6E ED 60 B5 71 51 DE 72 84 89 5C 9A 9C B3 82 41 8D 74 2F BD D4 3F EE 28 C6 A7 41 C8 CC 73 5F F1 4F 17 98 E8 CF E5 AD 2B 3A 82 6E B6 DB 6B 32 55 D7 A3 91 04 09 AB 30 82 61 5F 9C 0A 20 71 FD 76 36 27 1D 07 CF 3B 40 26 15 6F 0D 82 0A EC 96 68 BA D1 CD 48 38 89 81 59 E1 AD 58 C4 11 82 5C B7 1B 1A EC 38 C4 FE F0 34 0E 22 8B 92 6F 39 69 A6 DD 0A AF FC 40 08 DF 48 95 A5 38 5B 65 33 6A 4D F9 A0 08 91 48 26 1D 33 27 6A 0A FF 98 D9 03 AA 02 AA C3 9D C8 B2 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 33 F5 AB 82 62 D3 37 BF 33 FA DE 60 E0 83 2C B5 21 CC FF 36 3F 64 F6 0E 6C 5B 34 36 C2 65 C1 19 49 A9 9A F8 07 86 51 53 81 EF 67 6F 2D FF B7 2E D6 3C 55 A9 1E BB 6B 14 C9 65 36 94 30 C1 46 43 84 EC 54 FB C1 E7 B8 DC B5 83 6E CC 56 50 A0 55 93 A5 A7 A5 38 D7 73 45 32 7A 8D 3F CF 98 83 9A C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 F5 61 D3 13 E3 AE 45 67 51 6A 6B A4 FC 3C 8C B9 13 EF E4 4D EC 00 34 91 66 C0 7C 9B 17 2E 9B 87 5B 69 1F 1D 12 55 26 5D C0 35 F0 CA 0B 23 C7 A4 67 B2 81 01 45 B1 5C 1B 3B EF E8 2F 13 C9 5D 75 DB 6F A3 73 A1 40 EA 11 32 50 77 C1 15 8A CC DD 39 01 5A 81 FE 31 FD 3B C2 EB B3 D9 30 59 00 D8 39 EF 4F A7 76 A4 62 F1 AD A2 3A C4 F4 A0 70 E1 C7 B9 E7 7B 86 0C 16 F3 2C 81 58 FF 04 7A 02 F6 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 6F C3 D4 37 FA 05 00 64 FD 3A 01 16 7B 9B 70 4E 5C F2 3B E6 12 F3 D7 48 78 C0 7E 96 90 03 5B 64 62 6D 93 AB 1A AE 7B 81 3C 4E 34 7F FF 33 3D EE B4 69 A9 78 E1 B4 8A A0 BC 73 EF 85 64 E9 0F 33 D9 4C 9B 5B E6 85 49 12 8C 86 10 8D A1 65 4C 44 33 9B 6F 71 90 95 97 78 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 50 3E ED 54 1E 2A 29 1F 17 93 19 0B 03 11 A3 4E BD 10 ED 87 4D 19 44 D2 A0 6A BA 78 E5 13 A9 90 FA 5D 74 F1 6F 69 0A 0C 26 B0 88 7A FC F8 4F FB C8 AC 71 36 39 86 87 21 2F 1A 3B 8C 87 D6 E7 D7 0C 3A 87 FE F5 B5 AE 69 DD 9A E9 69 B3 4D 26 FE 1B 5F 6B A9 F9 B2 F7 A1 33 C2 F2 92 F8 52 DC C7 74 7C 48 00 17 B5 C6 E5 C5 C8 83 BE 3E 2B 74 3E 7D 74 06 36 3C BB 64 26 A2 0F 39 26 E7 5C 52 40 AE B8 5F CA 47 BB CE 45 20 6F DD 36 8F 63 93 D3 25 3C DF 24 4E A2 AF D0 EA CE 9F 36 F1 F2 81 30 50 EC 69 F5 D1 93 BB 24 97 34 7A 18 D3 DB 6B D9 B6 60 ED 41 41 00 CA 6A 99 61 FB A7 19 16 64 02 72 83 FB 15 01 01 D9 10 DE 28 B5 8C AF E4 76 73 59 BF 58 F0 6D 5D AB 2F BD B2 D9 8B 36 15 A2 5A D2 18 04 72 D0 E2 B6 6E 6D 96 ED 9B D4 26 21 AB 65 B1 29 8A E4 43 6B BD AB 37 2F 90 F5 35 5D D9 45 CB 2F 95 B6 78 D9 36 AA 43 29 82 A8 B4 57 53 8B 0B 78 8B 6A 02 72 D6 A0 E5 46 23 43 BC A5 E9 A8 C1 B4 45 E3 CC C3 EE 6B D9 42 B9 46 36 32 22 C4 58 CB 6A 5D C9 6A 48 F5 BE 6A 02 4A 12 54 79 33 A4 13 A3 8C 1B 47 8A AB 86 89 D3 4C 77 CF 88 EB DE 92 B2 B4 3F 6B 74 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 25 8E DB EE 36 40 10 95 18 1F 84 06 A7 00 80 D7 8E DF 67 54 0C 82 0B 00 00 00 00 02 01 03 4A 58 D3 32 1D 62 DD 4F 01 00 9C 26 68 43 F8 ED 5F 9E 44 22 02 70 C1 D2 0B E8 02 04 01 02 04 06 01 04 01 02 04 06 04 04 01 02 05 04 01 02 09 02 15 06 10 06 0A 04 01 02 0D 02 03 02 03 03 04 04 02 02 01 02 04 02 0A 05 23 00 00 58 25 5A 59 20 41 01 1B 9B 70 81 8C 94 95 96 97 98 99 9A 82 83 84 85 86 87 88 89 8A 8B 8D 8E 8F 90 91 92 93 1F 1D 1B 21 1F 1F 04 05 05 05 50 07 51 09 15 19 05 FE FF FF FF 61 70 01 A2 5F 02 9D 40 9C 45 03 03 F5 FF FF FF 00 07 FD FF FF FF 3F 60 17 0E CD CC CC 3D CD CC CC 3E 02 17 14 01 00 21 32 32 42 33 33 30 36 36 34 33 33 34 39 30 46 34 32 38 44 39 45 42 38 34 30 36 46 35 45 37 36 41 00 10 00 00 00 69 6E 67 20 54 6F 6F 6C A3 00 5B 31 13 12 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 02 58 03 03 02 02 02 02 02 D2 CC 83 D3 FE E9 38 EB 38 CC CC D4 E6 38 83 EF E3 C8 01 03 EB D4 DB D8 FD FD A0 FD F7 FD FC C8 38 4C FC 3F DC 7C C8 38 4C 11 D0 CB EB E7 D4 D0 FE E9 38 29 CB D2 D4 CB D7 C8 CB FE 69 D2 D2 E7 CF E3 D0 CA D5 EA D4 FF FF FD CC FF 7C CC 11 D8 D3 D7 DC FF D9 38 DF 38 CB CD FE D9 1D 38 DC E8 F0 F8 98 FD F5 38 3D C8 D9 C9 83 D0 F3 CF 82 FF F1 38 3D FF 1D DC 38 CC 3D C8 D8 FF 29 FC D0 2D 3D FF EC 38 D0 3D D2 38 CC CB FF FD 3D FF FC D0 CB DB DB C8 CB E0 C8 43 03 D9 CC CB E2 E7 21 83 C7 38 D7 15 F3 CA E7 83 E2 D2 CF D5 CB CB CC CF CF CB DF CB DF CF C9 C9 DE D8 DF D7 D5 CA D0 CC C8 43 C9 E3 CB F7 38 2A 05 C8 D4 CF CB DC CA CA 38 CB D1 80 C9 EE D2 D4 CE CB E5 D3 D3 D7 D0 CC D4 E7 CF D1 38 DF D1 DF F1 38 CF C8 D9 D0 D9 D1 D3 E6 E6 EF CB 87 CC D8 DA 15 DC D4 CB D7 CA E6 D1 D4 D7 D3 A0 38 0D 38 D0 C8 E3 DD CF F1 DF CB D7 CB CF CA DC CA D1 DC CB C9 43 C9 CA D6 EC D7 E5 CC C8 D5 D1 E0 CF D4 CB CF D1 D3 EF F7 D1 DC D5 C8 EB F1 F4 31 31 31 31 31 31 31 ED 2D 31 31 31 31 31 31 EE ED 2D 2D F0 2D 2D 27 DC CD F0 D7 D7 15 C9 15 C9 C9 DC D5 EB D9 38 CE CE 15 D1 D4 D0 DC D1 D3 D9 DE D4 C8 D4 FD D0 CA 3B D3 52 12 D8 D8 D8 D8 D7 DB D4 05 05 D7 05 EB 2B 43 07 05 DF D7 15 88 55 15 40 4B 45 D5 95 88 55 E8 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 05 38 F8 05 38 05 38 05 38 05 38 05 38 3D E5 05 38 05 38 05 38 A8 D8 55 15 58 C8 15 25 95 88 55 8C 17 E8 25 E8 C9 19 84 D5 E5 D5 48 40 57 55 15 88 25 CB E7 06 D7 CF D1 56 D5 15 48 00 01 34 08 08 0D 0B 08 0A 0D 05 00 07 0A 1F 0F 08 11 13 00 05 00 0A 06 0F 00 09 05 0F 09 20 24 0E 08 1C 03 03 0F 0C 0E 22 09 0D 09 05 0D 0A 0B 03 1F 2A 17 0E 2E 1A 0D 00 02 00 08 0A 06 1D 2D 2E 25 06 0F 01 2F 0E 01 09 22 2A 07 07 0D 05 34 35 36 2B 3F 38 00 0E 0F 04 0C 1A 35 06 01 0A 04 04 06 32 25 15 01 08 02 03 0A 38 0D 08 34 0E 0E 06 08 0C 02 03 04 3A 33 39 08 00 0A 37 28 07 0C 32 02 0A 47 0F 18 3C 07 10 35 39 03 09 01 0C 22 14 1B 33 06 04 0A 3D 04 14 0D 3D 08 14 14 0E 04 09 39 07 08 13 06 14 05 0B 07 07 0B 0D 0A 07 0C 00 10 05 07 11 29 0A 05 04 21 31 04 2F 05 22 13 15 26 01 2E 3E 0A 37 0B 27 34 09 05 00 45 09 17 15 42 44 01 3B 0A 22 0E 20 0B 3B 2E 0E 06 14 3E 41 13 18 2A 0C 09 08 2B 24 11 1C 20 16 2E 2F 09 1A 09 03 09 1B 1E 06 07 06 0C 0F 06 00 3D 4F 29 29 29 37 44 4D 1E 4B 28 40 05 2A 0B 20 22 3D 05 3C 3B 29 0E 27 3E 45 40 00 2E 08 00 08 08 08 01 00 00 0C 08 00 0B 0C 1C 1C 2B 04 21 25 05 04 00 00 2B 0C 3A 24 01 00 00 00 A7 03 03 17 1D 30 01 15 0A 02 09 01 01 3B 19 31 02 3A 00 32 02 41 00 05 07 00 38 11 02 02 06 22 1A 00 0B 01 43 03 45 12 00 43 13 01 0A 06 2B 01 01 16 3B 11 08 01 00 00 55 50 03 4A 48 06 4E 00 54 04 59 30 00 01 56 16 52 04 57 12 04 08 05 01 05 10 13 03 06 08 06 15 05 01 18 16 00 05 04 0C 02 08 14 15 05 00 00 0A 07 04 00 00 05 00 05 0B 00 05 04 0E 0C 10 04 08 06 03 04 03 0B 03 00 0B 01 05 04 01 0A 02 04 0A 01 01 06 0A 03 02 00 00 01 03 01 02 15 FF 1F 06 02 06 05 05 16 07 08 00 00 FF 03 0D 05 01 22 05 12 57 B3 21 03 EE E3 10 04 A2 04 4C 64 A6 0A EF 9D C9 91 78 C8 20 40 A6 57 49 ED 07 B3 40 27 00 21 E4 10 A9 10 60 0A 78 0D C1 CD 2B 86 FE BD 10 04 18 78 80 09 28 50 E8 2C 0D 98 19 C4 4C 0C F0 7B 29 6F C2 0F 46 FE F1 C2 42 49 47 38 B6 46 73 84 00 83 10 A5 D8 04 C2 32 58 03 B5 94 09 4C 8C 03 DC 00 D0 60 00 00 02 03 7E EE 59 B0 60 96 4D 0C 4C FB 34 1A 0B 58 33 F0 28 81 07 05 41 E0 28 30 E7 04 3B 12 57 CE 09 D5 9A FA B1 EB 23 34 40 59 08 38 D9 FC CC D6 04 81 A6 9F 40 2E 36 11 9C 47 C0 82 EA D1 20 1F ED F9 19 3A 84 05 2E 52 93 A3 EB 6A F0 C8 00 10 40 16 10 32 BA 32 00 64 6A 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
        string Pickaxe1 = "8C 0A 00 10 44 88 10 42 03 00 00 00 00 00 00 00 00 0B 29 00 20 04 80 18 1F 40 18 48 18 48 05 00 00 90 1D E8 1D 30 1E 1E 40 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 57 65 61 70 6F 6E 73 2F 41 62 69 6C 69 74 69 65 73 2F 47 41 42 5F 4D 65 6C 65 65 5F 49 6D 70 61 63 74 43 6F 6D 62 6F 5F 41 74 68 65 6E 61 00 60 2E 5F 43 00 2D 00 40 57 49 44 5F 48 72 76 65 73 74 5F 50 69 63 6B 61 78 65 5F 53 70 61 63 57 61 6E 64 65 72 65 72 4D 61 6C 65 00 5B 53 6F 75 6E 64 41 73 2F 2F 45 6E 65 6D 79 80 2E 55 52 65 61 64 74 53 77 69 6E 67 2E 50 49 41 6C 74 65 72 61 74 69 44 61 6D 61 67 65 54 79 70 65 42 61 73 00 65 2E 24 44 61 74 61 74 62 6C 65 73 2F 4C 6F 6F 74 4C 65 76 65 6C 00 33 46 6F 72 74 5F 50 6C 61 79 5F 2F 43 6F 6C 6C 65 63 5F 00 40 2E 29 55 49 48 55 44 2F 55 49 5F 52 61 64 61 72 5F 44 6F 74 5F 57 68 69 74 65 00 56 75 6E 64 2F 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 54 2D 2D 73 2D 00 58 2D 4C 00 80 2E 7C 2E 3C 46 4F 52 54 2F 42 6C 75 65 70 72 69 6E 74 73 2F 42 47 65 6E 65 72 69 63 00 57 2E 5F 43 00 27 4D 65 73 68 4B 00 2F 2E 53 5F 5F 4D 61 6C 5F 41 78 65 00 6B 2E 66 56 46 58 2F 4E 69 61 67 61 72 61 2F 73 2F 4E 53 5F 53 74 6F 6E 84 2E 65 57 6F 6F 64 00 82 2E 6C 44 65 66 61 75 74 00 90 2E 6A 4D 65 74 61 6C 00 8C 2E 67 4E 53 5F 5F 49 64 6C 65 00 8E 2E 68 00 90 2E 13 2F 53 63 72 69 70 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 47 61 6D 47 61 6D 65 70 6C 61 79 54 61 67 73 41 63 74 75 61 6C 41 6E 61 6C 79 74 69 63 46 4E 61 6D 65 0C 19 6E 69 6D 54 72 61 69 6C 73 46 69 72 73 74 53 6F 63 6B 65 74 4E 1A 53 65 63 6F 6E 64 0F 57 69 64 74 68 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 17 42 61 63 63 68 75 73 2E 2E 00 14 62 41 6C 6C 6F 77 4D 75 6C 74 69 70 6C 65 53 74 61 63 6B 73 00 0E 00 16 43 6F 73 6D 65 74 69 63 19 62 41 74 74 61 63 68 54 6F 00 1D 62 43 6E 42 65 44 65 70 6F 73 69 74 64 49 6E 53 74 6F 72 67 65 56 0D 72 6F 70 70 65 64 00 15 62 49 6E 76 65 6E 74 6F 72 79 53 69 7A 65 4C 69 6D 00 10 62 53 74 6C 65 6E 00 12 48 61 73 44 75 72 61 79 00 0F 62 4E 65 76 65 72 50 65 72 73 69 73 0C 42 6F 6F 6C 1F 62 53 6F 77 44 69 72 65 63 61 6C 41 72 72 6F 77 57 68 65 46 61 72 4F 66 66 00 0C 42 79 74 65 08 43 61 74 65 67 6F 72 79 00 05 43 6C 61 73 73 00 0A 43 6F 6C 75 6D 6E 09 54 00 17 48 61 6E 12 52 6F 77 26 5F 5F 44 65 66 69 6E 69 2A 44 69 73 61 73 73 65 6D 62 6C 65 44 65 67 72 61 64 4D 61 78 50 65 72 63 65 6E 74 72 69 6E 0B 72 6F 70 00 14 45 46 69 00 1F 3A 3A 49 6E 76 69 73 69 0D 74 65 6D 00 1C 3A 3A 00 0B 52 61 72 11 3A 3A 52 61 72 65 00 1D 65 6C 6F 61 64 46 58 53 74 61 74 65 3A 3A 45 6E 64 00 1D 45 4E 6F 72 6D 6C 00 16 54 72 69 67 67 65 72 21 3A 3A 41 75 74 6F 6D 61 74 69 63 00 0C 45 6E 75 6D 0E 4F 76 65 72 72 64 65 00 0D 46 6C 6F 61 74 1D 0D 46 58 5F 53 74 61 72 74 00 0B 46 58 5F 0D 1C 2E 53 6F 75 72 63 65 2E 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 22 47 72 61 6E 74 65 64 2E 45 71 75 69 2E 2E 07 1C 5F 54 30 31 00 11 45 66 66 65 63 74 00 10 46 58 26 50 68 79 73 69 63 61 6C 53 75 72 66 61 63 73 4D 61 70 00 1F 1E 0B 49 6E 74 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 0D 0B 4D 61 70 10 4D 69 6E 69 4D 61 42 72 75 73 68 00 17 56 69 65 77 44 69 73 74 63 65 00 08 4D 69 6E 00 0C 4E 61 6D 04 4E 0E 07 50 61 63 6B 12 75 70 53 6B 65 6C 00 19 65 72 12 50 72 69 6D 61 72 65 41 13 06 0F 0E 52 65 73 0B 52 6F 77 65 6E 74 73 00 07 52 6F 77 0C 53 74 72 75 63 74 00 0A 53 6C 61 74 65 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 31 00 0D 30 31 32 33 34 35 36 37 38 39 32 32 32 32 32 32 32 32 0C 33 34 35 36 37 38 39 00 13 12 30 54 61 67 3A 77 69 64 5F 68 70 73 77 6D 0C 54 65 78 09 32 44 00 0B 17 14 77 2E 6D 68 1B 57 4D 10 41 63 74 6F 72 12 73 68 25 64 C1 0B D1 54 AD B0 36 D6 B0 31 C6 07 E6 D6 98 1D 41 15 AE 8B 5D C4 AF 66 B7 E0 E1 9D 98 71 E1 56 66 F9 40 6C 0A A3 B9 91 47 6A 64 56 21 F6 B7 FB 88 1A D7 A1 08 65 C2 F5 C1 E7 ED 77 B5 A3 DD 95 F7 31 19 52 9F B5 E7 FC 96 34 EF 13 7A 41 BB 3A AE 97 12 57 94 1A 56 9C 5B 77 31 AE 43 97 F2 D2 4D C6 49 D5 95 6D EB 66 81 0A 77 E9 06 E7 BE A2 5E DF 46 D7 E7 82 7B 85 3E 69 24 A4 BF A9 0D 8E 46 FF A9 52 66 0B 0B 51 05 3E 4B 83 BD 6E 7D 91 72 3D 4F 6B 9D F0 3D 44 7B 94 02 11 D5 9C 0F 7F 22 D8 60 89 E8 47 C7 DA 65 DD CF D2 12 72 8E 7B 88 0E 93 5A 2D 39 33 53 DC DA D7 F8 9B B0 34 09 1C 6D C2 32 1F 6B B3 24 B3 4D D6 49 6F C7 47 B5 4A 45 CF C2 E9 1E C5 97 A3 2A 6D 9C A6 9F C6 BD 0E D1 6E 57 8E D2 E3 7D 89 90 7D 95 23 4C 6E EF 3E 9F 6E D0 A7 0B C2 84 2B 86 32 42 1D A5 5B 2D 5F 5A 5C ED 89 F4 0A BE 25 13 84 D0 66 2B A1 1F DC F0 0E 97 CE CB 0C 67 CF 52 61 4C FE E8 1B 53 D7 27 7F 31 94 48 47 17 20 52 49 56 73 93 01 18 5C 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 48 19 53 EC 0C 40 73 F8 AF B7 92 36 2D 68 5A A4 FF 9D BF 83 44 D8 AB BA D6 DF 3E 2D DB 1C 93 F5 9B C3 96 AB 63 DF 70 50 A8 E3 AA B3 3D 77 5A FD A0 20 73 C6 7C A3 4D 60 70 43 75 60 EC 4C 78 16 62 56 ED 6A 62 7F A3 64 76 29 07 38 53 1D 99 F3 C6 E0 08 33 EB 3D 3B CD E5 F1 8E 3B 3D C2 07 FA C9 3F C7 F6 28 38 8D 19 A2 44 42 19 0C 65 C8 36 85 42 31 66 36 5F 4A 81 55 39 E0 39 25 C8 BE 72 05 7A D2 09 00 D0 4F 72 8C 42 6E ED 60 B5 71 51 DE 72 84 89 5C 9A 9C B3 82 41 8D 74 2F BD D4 3F EE 28 C6 A7 41 C8 CC 73 5F F1 4F 17 98 E8 CF E5 AD 2B 3A 82 6E B6 DB 6B 32 55 D7 A3 91 04 09 AB 30 82 61 5F 9C 0A 20 71 FD 76 36 27 1D 07 CF 3B 40 26 15 6F 0D 82 0A EC 96 68 BA D1 CD 48 38 89 81 59 E1 AD 58 C4 11 82 5C B7 1B 1A EC 38 C4 FE F0 34 0E 22 8B 92 6F 39 69 A6 DD 0A AF FC 40 08 DF 48 95 A5 38 5B 65 33 6A 4D F9 A0 08 91 48 26 1D 33 27 6A 0A FF 98 D9 03 AA 02 AA C3 9D C8 B2 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 33 F5 AB 82 62 D3 37 BF 33 FA DE 60 E0 83 2C B5 21 CC FF 36 3F 64 F6 0E 6C 5B 34 36 C2 65 C1 19 49 A9 9A F8 07 86 51 53 81 EF 67 6F 2D FF B7 2E D6 3C 55 A9 1E BB 6B 14 C9 65 36 94 30 C1 46 43 84 EC 54 FB C1 E7 B8 DC B5 83 6E CC 56 50 A0 55 93 A5 A7 A5 38 D7 73 45 32 7A 8D 3F CF 98 83 9A C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 F5 61 D3 13 E3 AE 45 67 51 6A 6B A4 FC 3C 8C B9 13 EF E4 4D EC 00 34 91 66 C0 7C 9B 17 2E 9B 87 5B 69 1F 1D 12 55 26 5D C0 35 F0 CA 0B 23 C7 A4 67 B2 81 01 45 B1 5C 1B 3B EF E8 2F 13 C9 5D 75 DB 6F A3 73 A1 40 EA 11 32 50 77 C1 15 8A CC DD 39 01 5A 81 FE 31 FD 3B C2 EB B3 D9 30 59 00 D8 39 EF 4F A7 76 A4 62 F1 AD A2 3A C4 F4 A0 70 E1 C7 B9 E7 7B 86 0C 16 F3 2C 81 58 FF 04 7A 02 F6 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 6F C3 D4 37 FA 05 00 64 FD 3A 01 16 7B 9B 70 4E 5C F2 3B E6 12 F3 D7 48 78 C0 7E 96 90 03 5B 64 62 6D 93 AB 1A AE 7B 81 3C 4E 34 7F FF 33 3D EE B4 69 A9 78 E1 B4 8A A0 BC 73 EF 85 64 E9 0F 33 D9 4C 9B 5B E6 85 49 12 8C 86 10 8D A1 65 4C 44 33 9B 6F 71 90 95 97 78 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 50 3E ED 54 1E 2A 29 1F 17 93 19 0B 03 11 A3 4E BD 10 ED 87 4D 19 44 D2 A0 6A BA 78 E5 13 A9 90 FA 5D 74 F1 6F 69 0A 0C 26 B0 88 7A FC F8 4F FB C8 AC 71 36 39 86 87 21 2F 1A 3B 8C 87 D6 E7 D7 0C 3A 87 FE F5 B5 AE 69 DD 9A E9 69 B3 4D 26 FE 1B 5F 6B A9 F9 B2 F7 A1 33 C2 F2 92 F8 52 DC C7 74 7C 48 00 17 B5 C6 E5 C5 C8 83 BE 3E 2B 74 3E 7D 74 06 36 3C BB 64 26 A2 0F 39 26 E7 5C 52 40 AE B8 5F CA 47 BB CE 45 20 6F DD 36 8F 63 93 D3 25 3C DF 24 4E A2 AF D0 EA CE 9F 36 F1 F2 81 30 50 EC 69 F5 D1 93 BB 24 97 34 7A 18 D3 DB 6B D9 B6 60 ED 41 41 00 CA 6A 99 61 FB A7 19 16 64 02 72 83 FB 15 01 01 D9 10 DE 28 B5 8C AF E4 76 73 59 BF 58 F0 6D 5D AB 2F BD B2 D9 8B 36 15 A2 5A D2 18 04 72 D0 E2 B6 6E 6D 96 ED 9B D4 26 21 AB 65 B1 29 8A E4 43 6B BD AB 37 2F 90 F5 35 5D D9 45 CB 2F 95 B6 78 D9 36 AA 43 29 82 A8 B4 57 53 8B 0B 78 8B 6A 02 72 D6 A0 E5 46 23 43 BC A5 E9 A8 C1 B4 45 E3 CC C3 EE 6B D9 42 B9 46 36 32 22 C4 58 CB 6A 5D C9 6A 48 F5 BE 6A 02 4A 12 54 79 33 A4 13 A3 8C 1B 47 8A AB 86 89 D3 4C 77 CF 88 EB DE 92 B2 B4 3F 6B 74 FF FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 25 8E DB EE 36 40 10 95 18 1F 84 06 A7 00 80 D7 8E DF 67 54 0C 82 0B 00 00 00 02 00 01 4A 58 D3 32 1D 62 DD 4F 01 9C 26 68 43 F8 ED 5F 9E 44 22 02 70 C1 D2 0B E8 02 04 01 02 04 06 01 04 01 02 04 06 04 04 01 02 05 04 01 02 09 02 15 06 10 04 01 06 0A 04 01 02 0D 02 03 03 03 04 02 02 04 02 0A 05 23 58 25 5A 59 20 41 01 1B 00 9B 70 81 8C 94 95 96 97 98 99 9A 82 83 84 85 86 87 88 89 8A 8B 8D 8E 8F 90 91 92 93 00 1F 1D 1B 21 1F 1F 04 05 05 05 05 01 50 07 51 09 15 19 00 05 FE FF FF FF 61 00 70 01 01 A2 5F 02 9D 40 9C 45 03 03 F5 FF FF FF 07 FD FF FF FF 3F 60 00 17 0E CD CC CC 3D CD CC CC 3E 02 17 14 01 21 32 32 42 33 33 30 36 36 34 33 33 34 39 30 46 34 32 38 44 39 45 42 38 34 30 36 46 35 45 37 36 41 00 10 69 6E 67 20 54 6F 6F 6C A3 5B 31 13 12 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 95 C0 96 21 91 92 96 92 9A 91 41 00 78 F8 F8 F8 A8 79 E8 7C E0 30 28 38 7A E0 8D 87 87 8C 87 6F 55 20 91 7A 90 39 30 7D A0 81 01 79 F8 B8 F9 F8 F8 F8 90 7C A8 F9 F8 F8 F8 F8 78 78 78 F8 F8 F8 F8 FD F8 78 F8 F8 F8 F8 7A F8 A9 38 87 21 87 63 5B 38 30 7A F8 F8 F8 E8 79 E8 E1 8D 87 27 2A 40 25 2D 30 8F 21 7A F8 F8 B0 69 B1 32 87 2E 87 5C 2B 87 4F 38 22 39 72 38 7A F8 F8 F8 F8 D8 7C F8 F8 F8 F8 E8 79 F8 D0 F9 F8 F8 F8 F8 D8 79 F8 C0 A9 48 34 87 3E 48 87 7A F8 F8 F8 79 C8 7C D0 24 29 7A F8 C8 41 F9 D0 68 41 4C 78 A0 7E F8 F8 F8 F8 C0 79 C8 F9 F8 F8 C0 87 35 74 38 95 81 01 79 F8 81 01 86 01 79 F0 F9 F8 F8 F8 F8 F0 20 40 8D 83 01 79 F8 B0 81 01 87 01 79 F8 A0 F9 F8 F8 F8 A8 7B 78 87 01 79 F8 C8 81 01 28 82 01 79 F8 D0 27 87 44 87 39 28 5F 87 95 87 87 95 41 28 89 87 87 27 51 5E D1 87 87 87 79 A0 87 3A B9 87 87 87 73 22 87 59 87 51 32 8C 87 8B 8F 2B 39 87 87 87 24 23 28 8A 2D 2F 87 87 21 4D 8B 27 87 8B 87 4D 87 87 87 2B 21 21 4A 40 23 49 3B 39 22 30 28 20 2E 87 55 8E 23 7F F9 E2 99 20 38 2B 23 48 22 7A A8 87 21 31 23 6A 32 38 2A 23 59 87 31 87 37 56 28 38 8C 5B 2F 79 B8 87 87 4B 31 8D 87 4A 79 F8 2B 87 2C 20 41 30 41 31 3F 59 5A 87 6C 87 22 24 29 41 41 79 48 26 3E 22 5A 21 48 87 3F 36 78 D8 F9 B0 28 28 54 48 87 2F 71 4C 8F 20 3F 24 94 2F 55 22 29 50 25 21 26 20 22 3A 68 26 3B 51 30 20 39 31 50 2C 38 24 87 2A 31 87 36 6E 7D 21 58 31 28 63 71 F1 F1 F1 F1 F1 F1 F1 F1 69 E9 F1 F1 F1 F1 F1 F1 91 D9 69 E9 E9 E9 E9 E9 DB 48 29 70 3C 3E B9 21 B9 21 54 39 64 79 C8 2A 2A B9 32 A9 28 50 31 35 41 3A 48 20 38 79 F0 C0 38 22 00 F8 87 87 87 87 36 32 B2 40 40 40 40 87 42 5C 99 39 87 5A 87 61 87 E1 87 87 87 87 8F 99 21 93 5D 39 59 B9 C9 A3 91 BA 59 79 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 79 F9 A0 F9 A0 F9 A0 F9 A0 F9 A0 81 01 59 F9 A0 F9 A0 F9 A0 79 99 B9 79 A0 B9 D9 59 D9 B7 61 D9 61 99 59 B9 59 69 87 8A BE B2 59 59 87 21 64 99 87 87 87 87 9E 38 87 29 39 39 B9 59 30 01 14 00 30 00 43 00 1D 00 62 00 15 00 3D 00 13 00 2F 00 42 00 43 00 37 00 38 00 52 00 C5 00 5D 00 5D 00 82 00 57 00 D3 00 76 00 CD 00 57 00 76 00 B4 02 72 00 16 00 10 00 3D 03 2B 00 4B 00 67 00 14 00 26 00 47 01 11 00 15 00 31 00 0D 00 35 00 42 00 3E 00 1D 03 2B 00 EA 00 FF 01 ED 00 16 00 D2 01 CE 01 17 00 58 00 5A 00 82 00 5A 01 61 00 45 06 46 06 ED 05 3E 00 19 00 59 00 34 04 36 00 29 00 31 00 CA 06 2A 01 4D 00 1B 00 55 00 6D 00 7C 04 3E 05 95 04 68 00 86 00 86 00 67 00 84 00 29 00 6B 00 6E 00 92 00 92 00 6C 00 8E 00 8A 0B 37 04 69 00 90 00 90 00 27 0A 6A 00 92 00 7B 09 15 00 10 00 7C 09 16 00 10 00 24 00 55 00 1B 00 1C 00 42 0E 2B 0E 21 0B 10 00 18 00 92 00 73 00 60 04 1F 00 34 00 66 09 2A 00 12 00 8C 0F 37 00 10 01 B5 00 2F 00 7C 01 FD 0B 11 0C 0B 00 31 00 48 03 19 00 14 00 58 05 3C 02 23 01 A1 01 CE 00 51 01 E2 00 05 0C 2C 00 9C 02 C5 00 70 0C 90 00 7C 01 DC 01 16 00 FC 00 21 00 76 0D 0F 00 E0 00 6B 02 1E 00 AC 01 0D 00 13 00 0F 00 33 01 B5 00 22 00 1F 00 94 00 18 00 F8 01 E7 00 1F 00 B9 01 46 05 11 03 C2 00 0D 00 1C 00 29 04 72 0E 38 03 47 04 0D 00 6A 04 92 00 51 03 A4 00 83 01 09 00 2B 12 93 12 C2 00 69 05 13 00 7F 04 2E 07 21 00 3D 00 28 00 21 00 08 0F 20 00 96 03 6D 02 B3 0F 9C 0F 39 00 81 0D 12 00 A6 03 46 00 12 04 FD 0A 16 06 92 00 7E 00 4C 01 41 08 4A 0C D4 0F 9B 01 B0 01 56 03 C2 04 14 00 01 01 00 01 33 03 0C 03 19 01 34 02 A8 06 1E 02 A8 01 97 06 01 01 42 01 E1 00 3B 00 10 00 A2 01 69 11 0E 00 0F 00 A4 00 0E 00 A5 0B BD 08 B1 03 81 05 F1 03 07 09 A3 13 E6 01 EF 10 50 05 68 12 6D 00 72 04 16 00 EA 03 75 08 1D 00 64 07 5A 05 81 05 26 00 EF 05 46 07 ED 16 09 18 08 00 A6 05 08 00 40 00 78 00 10 00 70 00 F0 1D 0C 00 40 1E 1C 00 14 00 22 00 42 00 08 00 14 00 31 00 14 00 24 02 24 02 D4 01 58 00 1C 00 0C 00 C9 05 0C 00 19 00 18 00 95 00 2B 00 0C 00 73 06 8D 00 A2 0C 8C 06 4A 00 08 00 7D 00 00 00 00 04 00 0B 06 0A 11 0A 0F 0C 08 0D FD 0B 01 FC 17 00 8C 0A 00 10 44 88";
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
                Settings.Default.StuddedEnabled = true;
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
                Settings.Default.StuddedEnabled = false;
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
