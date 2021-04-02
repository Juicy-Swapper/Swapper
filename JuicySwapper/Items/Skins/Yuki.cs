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
    public partial class Yuki : Form
    {
        bool enabled = Settings.Default.YukiEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Yuki";

        public Yuki()
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

        string Body = "8C 0A 00 05 51 88 05 4F 00 00 00 00 00 00 00 00 00 03 B4 20 00 80 36 0B 40 00 00 00 62 07 A8 07 70 01 18 09 58 09 E8 10 0A 18 4C 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 48 69 67 68 74 6F 77 65 72 48 6F 6E 65 79 64 65 77 5F 53 77 6F 6C 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 6B 46 5F 4D 45 44 54 5F 43 43 50 4D 44 00 86 2E 5F 43 00 71 00 90 2E 46 78 5F 41 6E 69 6D 42 50 00 A0 2E 5F 43 00 62 53 6F 75 6E 64 73 2F 46 6F 72 74 5F 46 6F 6C 65 79 5F 4C 69 62 72 61 72 2F 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 17 42 6C 75 65 70 72 69 6E 74 47 65 65 72 61 74 65 64 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 73 43 6F 6C 6F 53 77 61 74 63 68 65 00 0C 42 79 74 65 11 50 61 72 74 00 05 2A 1B 43 75 73 74 6F 6D 13 00 24 44 65 66 61 75 6C 74 5F 5F 1C 2C 5F 43 00 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 23 0E 00 0F 14 4D 61 73 74 65 72 61 6C 00 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 67 65 00 15 4D 6F 64 69 66 69 65 72 00 0C 00 12 53 6F 66 74 4F 64 C1 6E F8 42 AC 74 A0 C6 EF DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 C6 7B 90 41 D4 07 C7 B5 29 D0 5A 33 11 5A 0C A8 19 6B 80 88 83 5D 60 BA 0B 13 C1 55 B1 97 72 78 88 1B AD 86 CD 0F C7 53 BD 70 AF 1F AB A1 EF D9 F5 B2 2E 3E B9 E8 F9 10 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 18 98 D0 9D 3A 83 54 F2 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 1E D8 32 3F 5E 43 7F FA 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 AD CD FD 96 91 A6 22 13 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 2B 5F BD 11 1A 4C C8 57 C6 F0 0D 14 35 AE 90 B7 79 F1 D0 49 02 33 24 9A 8B 36 D1 19 A0 B3 EC 0D C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 12 56 D5 F2 5D EC 7E B8 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 59 7A 01 D9 72 B9 91 80 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 36 0B 12 00 01 01 48 46 17 1A 6C 77 2E 08 6D CA B8 0B 04 00 01 01 BC E8 33 6A 1F 8F 18 36 03 08 00 06 07 04 04 04 81 02 05 03 01 02 02 04 06 02 00 00 00 00 01 00 00 00 FF FF FF FF 00 00 00 00 00 00 BA C8 95 96 92 92 92 92 99 92 41 00 30 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 2D A1 71 40 34 C1 28 82 01 79 C8 7C F8 F8 F8 F8 C0 78 F8 82 01 7A F8 81 01 87 82 01 79 F8 B8 34 87 87 3C 28 26 48 41 48 50 78 87 8E 87 42 87 39 28 24 87 87 24 87 87 87 87 8D 36 21 87 87 4E 87 8F 8F 4E 49 24 32 79 F0 F0 CF 20 20 28 79 20 87 7C E8 79 70 C9 78 F8 98 25 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 79 F8 B0 71 32 50 37 32 87 31 48 8D A4 87 49 62 6F 40 22 00 30 A2 30 99 39 40 40 40 40 40 39 B9 39 40 40 40 40 87 5A 59 59 99 D9 87 69 7A 87 8E 79 79 B9 63 00 30 00 4E 00 18 00 11 00 46 00 60 00 FF 00 F2 00 F3 00 2C 01 1B 00 36 01 6D 00 19 00 88 00 26 00 73 00 92 00 92 00 7A 00 26 00 A2 00 12 00 0D 00 A3 00 03 04 51 00 22 00 1F 04 8C 02 15 00 10 00 84 00 98 00 B9 00 28 00 0B 03 3B 00 26 00 C6 01 51 00 62 00 2C 05 38 00 50 00 DE 00 1D 00 19 00 3B 00 26 00 44 00 AE 01 84 01 48 00 3D 01 15 00 C1 02 1D 00 13 00 F6 02 60 00 4C 01 15 00 60 00 4D 05 B5 00 AA 02 75 00 F4 01 10 06 4E 03 95 02 EC 01 62 02 46 00 42 00 69 07 08 00 B6 01 30 09 10 00 58 00 38 00 58 00 10 00 F6 01 48 00 08 00 28 00 98 00 10 00 98 00 DB 09 80 00 08 00 2C 00 37 00 50 00 10 00 00 00 00 0F 10 16 16 1D FE 1B 00 8C 0A 00 05 51 88 05 4F 00";
        string Body1 = "8C 06 00 05 4A 88 05 48 00 00 00 00 00 00 00 00 00 03 CF 20 00 80 36 0B 40 00 00 00 62 07 A8 07 70 01 18 09 58 09 E8 10 0A 18 4C 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 48 69 67 68 74 6F 77 65 72 48 6F 6E 65 79 64 65 77 5F 53 77 6F 6C 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 6B 46 5F 4D 45 44 5F 53 61 69 6C 6F 72 5F 53 71 75 61 64 5F 52 65 62 65 6C 2F 4D 61 74 65 72 69 61 6C 73 2F 43 43 50 4D 46 45 00 00 00 86 54 5F 44 2E 5F 43 00 71 4C 65 61 64 65 72 00 00 00 90 2E 78 5F 41 6E 69 6D 42 50 A0 5F 43 62 53 6F 75 6E 64 73 2F 46 6F 72 74 5F 46 6F 6C 65 79 5F 6C 65 79 4C 69 62 72 61 72 2F 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 0E 45 6E 67 69 6E 65 00 14 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 17 42 6C 75 65 70 72 69 6E 74 47 65 6E 61 74 65 64 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 73 43 6F 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 2A 1B 43 75 73 74 6F 6D 13 00 24 44 65 66 61 75 6C 74 5F 5F 1C 2C 5F 43 00 13 45 00 1B 3A 3A 00 11 47 65 6E 19 3A 3A 3A 3A 00 23 0E 00 0F 14 4D 61 73 74 65 72 61 6C 00 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 61 67 65 00 15 4D 6F 64 69 66 69 65 72 00 0C 53 6F 66 74 64 C1 6E F8 42 AC 74 A0 C6 EF DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 C6 7B 90 41 D4 07 C7 B5 29 D0 5A 33 11 5A 0C A8 19 6B 80 88 83 5D 60 BA 0B 13 C1 55 B1 97 72 78 88 1B AD 86 CD 0F C7 53 BD 70 AF 1F AB A1 EF D9 F5 B2 2E 3E B9 E8 F9 10 52 10 8A 4F 34 DB 0D 04 A8 83 53 E2 8A 7B 81 ED 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 18 98 D0 9D 3A 83 54 F2 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 1E D8 32 3F 5E 43 7F FA 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 AD CD FD 96 91 A6 22 13 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 2B 5F BD 11 1A 4C C8 57 C6 F0 0D 14 35 AE 90 B7 79 F1 D0 49 02 33 24 9A 8B 36 D1 19 A0 B3 EC 0D C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 12 56 D5 F2 5D EC 7E B8 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 59 7A 01 D9 72 B9 91 80 FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 36 0B 12 00 18 01 01 00 48 46 17 1A 6C 77 2E 08 6D CA B8 0B 00 04 00 00 BC E8 33 6A 1F 8F 18 36 03 08 06 07 04 04 04 81 02 05 03 01 02 02 01 04 06 02 FF FF FF FF 00 00 00 00 00 00 95 5C 03 03 02 02 02 02 05 02 D9 D3 83 D3 C9 FF E1 38 3D D0 D7 CC D6 FF C8 09 F1 D8 CC CC 19 CC D9 38 FF DB C4 38 D0 D8 FF FD CC FD DF 80 FD E0 38 D4 1E D4 D1 DF CB DC D9 DC E0 F4 DB DB C8 CB CB 83 D3 C9 DF CB DF 5D CB D2 FD 1F C8 C8 CC F5 C8 EB 38 D9 38 CC 1D FC CB D0 D8 C6 38 D2 E6 CB FD D2 EC DC E8 D8 CA FE F1 D2 E0 D3 D2 D3 DC 0B DF EA 40 F7 D4 CA D3 52 05 05 D5 D8 D8 58 98 95 D5 15 D5 98 D8 58 58 57 05 E5 95 25 D8 EF 52 94 44 A7 C8 65 C8 35 00 00 65 08 06 00 09 0E 08 07 0A 09 16 05 17 18 11 08 03 1B 01 0D 0B 1E 09 00 0B 05 00 0A 00 02 1B 03 00 0A 0A 2F 2B 1C 0A 27 14 0D 08 0C 00 00 00 2C 03 25 0E 09 0A 24 00 08 06 05 01 03 0E 0C 16 1C 06 15 0D 23 05 29 0B 20 08 14 08 0D 07 0D 12 00 1C 28 2A 1D 14 1A 0E 0A 27 00 1E 08 00 00 00 00 00 08 00 04 00 08 00 00 31 02 03 4C 0C 16 08 33 16 24 01 22 01 2F 03 01 56 13 56 04 5D 0F 06 14 05 01 0F 1F 01 11 09 0A 01 1A 04 08 10 02 00 00 13 04 05 07 05 01 FF 06 05 0B 21 3F 16 2B 27 81 F1 0F 32 06 51 07 C0 4C 48 90 4C CE 3B 50 BC 81 51 B6 2A 60 06 0E 40 E8 60 20 A9 54 31 8E 73 FA A4 20 C0 54 44 4F C5 48 02 8E 07 00 1C 58 5C 44 2A 25 0A 48";

        string Head = "8C 0A 00 04 C9 88 04 C7 02 00 00 00 00 00 00 00 00 03 61 00 20 00 80 D2 09 40 00 00 00 6B 06 B0 06 58 01 08 08 30 08 C0 E8 04 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 55 50 61 72 74 73 2F 46 65 6D 61 6C 2F 4D 65 64 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 48 69 67 68 74 6F 77 65 72 48 6F 6E 65 79 64 65 77 5F 53 77 6F 6C 65 00 6C 50 6C 61 79 65 72 46 5F 4D 45 44 54 5F 30 31 2F 46 58 2F 43 43 50 4D 74 45 79 65 73 00 8B 2E 5F 43 00 74 4D 65 73 68 65 00 95 2E 7E 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 AB 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 68 54 61 72 67 65 74 73 00 05 21 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 20 44 65 66 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 5F 63 61 70 48 61 74 00 0B 0F 48 61 69 74 12 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 61 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 4F 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 00 AE 45 F7 B7 8C EA 78 9F F8 5F 95 07 4C 61 07 F5 92 84 5B DC 51 56 D6 14 14 A1 21 0E 98 96 B0 26 23 1A 5A 9E 92 EF 39 C8 2A 6B 3B 0D EA 2C 51 E8 B9 03 E3 4E 4E A6 9F 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 0B 09 99 5D FF 28 14 ED 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 D2 09 4C 00 14 06 01 FF FF FF FF FF FF FF FF 1E 0A 28 00 12 64 AC F8 67 67 F4 9C AD 0B 00 00 04 00 01 01 03 06 01 05 01 1D 1F 13 1E 08 00 04 08 04 04 03 02 02 04 06 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 AA C0 96 96 92 92 92 92 99 99 41 87 87 53 87 89 87 36 7D F8 F8 E0 69 F9 D8 87 8C 8C 87 25 87 87 87 7F 90 7E B0 2D A1 41 30 87 2B F1 86 01 79 E8 7C F8 F8 F8 F8 90 7D F8 A0 82 01 79 F8 98 81 01 87 87 01 79 F8 E0 87 87 8E 44 91 25 87 87 24 87 87 8C 87 87 87 4E 8F 87 33 79 F8 A0 87 87 4F 20 28 79 20 8D 7D C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 21 3C AD 38 64 20 69 29 70 54 37 48 87 23 87 87 87 26 6F 38 22 00 30 32 99 99 39 40 87 C1 40 40 32 B2 B9 40 40 40 40 87 B3 99 59 59 99 59 7D 59 39 59 B9 79 87 7A 51 00 30 00 0B 00 17 00 3B 00 48 00 09 00 57 00 4F 00 4B 00 4C 00 65 00 23 00 6E 00 1D 00 8D 00 28 00 76 00 97 00 97 00 80 00 2B 00 15 00 D1 00 4B 00 22 00 49 00 E7 03 6D 01 3D 00 9E 00 19 00 5A 04 37 00 22 00 40 00 12 01 1A 00 E4 00 15 00 E6 01 1D 00 13 00 1B 02 10 00 36 01 39 05 0A 00 00 01 7E 05 11 00 5A 01 2A 00 14 00 8D 01 FD 01 16 00 FB 00 A2 02 42 00 71 06 08 00 86 01 08 00 10 00 48 00 10 00 37 08 08 00 28 00 88 00 10 00 88 00 80 00 08 00 1C 00 20 00 00 09 0C 00 20 00 5D 00 50 00 00 00 00 11 19 17 23 FE 0F 00 8C";
        string Head1 = "8C 06 00 04 C5 88 04 C3 02 00 00 00 00 00 00 00 00 03 81 00 20 00 80 D2 09 40 00 00 00 6B 06 B0 06 58 01 08 08 30 08 C0 E8 04 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 55 50 61 72 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 48 69 67 68 74 6F 77 65 72 48 6F 6E 65 79 64 65 77 5F 53 77 6F 6C 65 00 6C 50 6C 61 79 65 72 42 6F 64 69 65 73 2F 46 5F 4D 45 44 5F 53 61 69 53 71 75 61 64 5F 52 65 62 65 6C 2F 4D 61 74 65 72 69 61 6C 73 2F 43 43 50 4D 46 45 00 00 00 00 8B 2E 5F 43 74 4C 65 61 64 65 72 2F 4D 65 73 68 65 95 2E 00 00 7E 5F 41 6E 69 6D 42 50 00 00 00 AB 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 70 68 54 61 72 67 65 74 73 00 05 21 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 5F 63 61 70 48 61 74 00 0B 0F 00 0F 48 61 74 12 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 61 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 00 AE 45 F7 B7 8C EA 78 9F F8 5F 95 07 4C 61 07 F5 92 84 5B DC 51 56 D6 14 14 A1 21 0E 98 96 B0 26 23 1A 5A 9E 92 EF 39 C8 2A 6B 3B 0D EA 2C 51 E8 B9 03 E3 4E 4E A6 9F 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 0B 09 99 5D FF 28 14 ED 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 D2 09 4C 00 14 06 01 FF FF FF FF FF FF FF FF 00 1E 0A 28 12 FF 64 AC F8 67 67 F4 9C AD 0B 00 04 00 00 01 03 06 01 05 01 00 1D 02 1F 13 1E 08 00 00 04 08 04 04 03 02 02 04 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 7C 58 03 03 02 02 02 02 05 05 D9 E3 D3 FF ED 21 38 CB FF F7 CB D7 CC D6 FF C1 38 1E E8 FD D0 C4 38 CF FB 38 CC FD FD FF CF FF F4 38 D4 F4 DB 01 CB CB DF D3 FD DF C8 CC F5 C8 DB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 D2 E0 C9 D7 13 D0 DD D0 EF D1 EC E3 D3 DC CB CB F7 D0 CA D3 52 05 05 D5 D8 1B 58 D4 93 15 D5 94 D9 D8 58 D7 45 E5 55 D5 E5 17 15 15 45 55 55 C8 15 55 95 67 D5 00 00 52 08 03 0F 03 00 01 0F 07 05 0A 09 1C 06 09 00 05 12 02 19 0E 01 0E 0D 0F 05 08 16 0E 1A 0D 09 09 0A 01 2F 2C 05 06 01 22 0F 0A 08 1A 04 0C 0D 26 05 0B 2B 0B 1E 21 02 08 22 21 12 12 0C 15 15 0E 03 29 0A 1B 00 1E 08 00 0F 00 00 08 08 08 0C 04 08 14 00 00 30 03 03 0E 13 02 28 1A 19 00 03 0D 17 02 51 15 03 03 5F 12 00 5F 04 01 66 13 02 0F 2B 0F 11 12 08 05 00 01 02 02 01 04 07 18 03 FF 05 00 06 02 06 20 44 D1 60 21 5E 1C 33 C1 34 C4 8C C0 59 10 4A 50 7F 98 00 C1 00 AE 00 00 88 03 A0 53 25 40 62 FD 31 C0 6A 10 55 6E 44 90 87 16 8F 37 82 60 40";

        string Hat = "8C 0A 00 03 EE 88 03 EC 00 00 00 00 00 00 00 00 00 02 C2 20 00 80 CA 08 40 00 00 00 A9 05 F0 05 08 01 F8 06 20 07 B0 07 D8 04 50 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 61 63 41 63 63 65 73 6F 72 69 65 73 2F 43 50 5F 46 5F 4D 45 44 5F 48 69 67 68 74 6F 77 65 72 48 6F 6E 65 79 64 65 77 5F 53 77 6F 6C 65 00 74 50 6C 79 65 72 2F 46 65 6D 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 54 5F 2F 4D 65 73 68 65 73 43 43 50 4D 44 5F 00 92 2E 5F 43 00 7F A6 2E 86 5F 41 6E 69 6D 42 50 00 B6 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 65 74 00 0C 42 6F 6F 6C 50 72 6F 70 65 72 74 79 00 0C 42 79 74 65 11 54 79 70 65 00 05 20 17 43 75 73 74 6F 6D 13 00 20 44 65 66 61 75 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 64 00 04 4E 6E 65 00 0E 07 50 61 63 6B 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 4F 64 C1 05 2F B6 A5 EB 80 BB B6 E3 ED AE 6D D9 50 98 40 9E 9D 0D 94 77 B4 02 7C A0 16 C0 36 51 81 C4 17 0C 74 1A 18 30 5F 40 68 01 0A E9 37 13 7B DE 81 28 84 AE 9B A7 8F 7B 19 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 4B F8 BC CC 99 D3 B0 90 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 CA 08 12 00 11 01 01 FF FF FF FF FF FF FF FF DC 2D 10 73 C6 B5 FA 36 76 E1 9B 0B 04 00 01 07 03 06 00 02 01 02 85 02 01 04 04 03 01 02 05 02 04 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 8E C8 95 96 92 92 92 92 92 99 41 87 87 53 87 8A 8D 87 87 87 87 87 7D 90 8A 8F 87 26 50 A1 71 8F 30 34 C1 39 82 01 79 E0 7C F0 F0 F0 F8 F8 78 F0 60 81 01 79 F8 C8 81 01 87 82 01 79 F8 F8 87 87 8E 44 91 25 87 87 24 87 87 87 87 87 4F 69 36 79 F0 A0 CF 20 28 79 20 8F 7B C8 79 70 22 30 87 79 90 32 5A 48 79 A0 22 32 8F 8C 34 48 8D A4 87 87 87 26 6F 48 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 7F 42 00 30 00 0B 00 52 00 4F 00 4C 00 4D 00 8B 00 21 00 9F 00 76 00 1C 00 94 00 2C 00 15 01 81 00 A8 00 A8 00 88 00 2E 00 15 00 DC 00 45 00 0E 00 27 04 47 00 22 04 D0 00 8D 00 19 00 5B 00 37 00 22 00 40 00 01 01 1A 00 13 00 E3 01 1B 00 DA 00 15 00 80 00 40 00 85 01 2F 01 36 02 42 00 E1 05 08 00 36 01 08 00 10 00 48 00 10 00 76 01 48 00 08 00 28 00 88 00 10 00 88 00 A3 07 80 00 08 00 9C 00 23 00 3B 00 00 00 00 19 24 24 2B EA 8C 0A 00 03 EE 88 03 EC 00 00 00 00";
        string Hat1 = "8C 06 00 03 EC 88 03 EA 00 00 00 00 00 00 00 00 00 02 D9 20 00 80 CA 08 40 00 00 00 A9 05 F0 05 08 01 F8 06 20 07 B0 07 D8 04 50 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 61 63 65 41 63 63 65 73 73 6F 72 69 65 73 2F 43 50 5F 46 5F 4D 45 44 5F 48 69 67 68 74 6F 77 65 72 48 6F 6E 65 79 64 65 77 5F 53 77 6F 6C 65 00 74 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 53 61 69 6C 6F 72 5F 53 71 75 61 64 5F 52 65 62 65 6C 2F 4D 61 74 65 72 69 61 6C 73 2F 43 43 50 4D 46 45 00 92 2E 5F 43 7F 4C 65 61 64 65 72 2F 4D 65 73 68 65 73 2F A6 2E 86 5F 41 6E 69 6D 42 50 B6 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 65 74 00 0C 42 6F 6F 6C 50 72 6F 70 65 72 74 79 00 0C 42 79 74 65 11 54 79 70 65 00 05 20 17 43 75 73 74 6F 6D 13 00 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 19 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 61 67 65 00 15 4D 6F 64 69 66 69 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 64 C1 05 2F B6 A5 EB 80 BB B6 E3 ED AE 6D D9 50 98 40 9E 9D 0D 94 77 B4 02 7C A0 16 C0 36 51 81 C4 17 0C 74 1A 18 30 5F 40 68 01 0A E9 37 13 7B DE 81 28 84 AE 9B A7 8F 7B 19 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 4B F8 BC CC 99 D3 B0 90 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 CA 08 12 11 01 01 FF FF FF FF FF FF FF FF 00 DC 2D 10 FF 73 C6 B5 FA 36 76 E1 9B 0B 00 04 00 00 07 03 06 02 01 02 85 02 01 04 04 03 01 02 05 02 01 00 00 00 00 00 00 00 00 00 00 00 6C 5C 03 03 02 02 02 02 02 05 D9 E3 81 FF 43 CB D0 D7 CC D6 E5 FD C1 38 3E A4 FD D7 C0 38 D0 DC E0 FD FD AC FD E3 9C FD E0 38 D4 F0 38 C8 DB 01 CB CB DF ED D3 FD 1F C8 CC F5 C8 DB 38 D9 38 CC CA D0 CB FD D2 E6 C8 CC C5 38 CA D2 D3 DC 0B CB F7 D8 0A D3 D5 05 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 E5 D8 1F 94 67 E2 00 00 45 08 03 0A 07 04 0A 09 04 00 0E 01 0C 18 19 0F 0F 00 09 03 00 07 00 1F 01 1D 06 0D 04 0C 06 2F 0F 2A 2B 05 01 1A 0F 0A 08 09 04 22 0B 26 03 07 02 0D 0F 0B 1D 17 24 0A 1E 1E 31 08 00 0F 00 00 08 08 08 00 04 3B 00 00 24 02 03 0E 32 00 01 0F 1E 51 00 2F 0B 5C 1B 5C 04 63 13 02 0F 27 03 10 04 08 00 00 0E 07 18 03 FF 05 06 00 0A 24 41 08 40 84 B8 AA 0A 8A 31 E1 F0 99 30 41 18 80 60 A4 66 80 88 03 20 81 73 8E 76 C0 8C 44 35 D0 A0 A8 67 02 6D 83 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap(""))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[6], SwapPath[5], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.YukiEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = HexResearcher.Convert(SwapOffsets[6], SwapPath[5], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head added";

            bool Swap3 = HexResearcher.Convert(SwapOffsets[6], SwapPath[5], Hat, Hat1, 0, 0, false, false);
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[6], SwapPath[5], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.YukiEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = HexResearcher.Revert(SwapOffsets[6], SwapPath[5], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head removed";

            bool Swap3 = HexResearcher.Revert(SwapOffsets[6], SwapPath[5], Hat, Hat1, 0, 0, false, false);
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
