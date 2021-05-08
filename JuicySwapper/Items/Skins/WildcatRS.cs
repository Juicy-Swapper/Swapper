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
    public partial class WildcatRS : Form
    {
        bool enabled = Settings.Default.WildcatRSEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Loserfruit";

        public WildcatRS()
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

        string Body = "8C 0A 00 05 05 88 05 03 00 00 00 00 00 00 00 00 00 03 89 20 00 80 D3 09 40 00 00 00 57 06 98 06 70 01 08 08 30 08 C0 E8 04 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 52 61 69 64 65 72 53 69 6C 76 65 72 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 57 46 5F 4D 45 44 5F 50 69 6E 6B 00 69 2E 5E 5F 41 6E 69 6D 42 50 00 79 2E 5F 43 00 6E 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 00 87 2E 00 13 2F 53 63 72 69 70 74 2F 43 6F 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 1F 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 00 00 64 C1 9C 21 CF D9 39 E5 72 21 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 75 72 0A 0C C6 A4 2C 0C 64 9A FC 81 0D 94 AD A0 E6 A7 49 AB 13 F5 D1 76 96 30 B4 E0 C3 93 E9 32 BD F6 9F 8B 3B 2B 76 1A 21 C2 13 72 6A 56 3B 2F 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B CE 17 78 37 55 43 4B 42 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 D3 09 12 00 15 01 01 FF FF FF FF FF FF FF FF E5 4B 14 87 9C DF 6F 4C 25 FE B5 0B 04 00 01 00 03 06 00 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 00 00 00 04 02 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 AF C8 95 96 92 92 92 92 99 99 41 00 30 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 3D 35 78 A0 7A F8 F8 F8 F8 E0 79 98 F9 F8 F8 F8 F8 E0 87 82 01 79 C8 7C F8 F8 F8 98 36 87 7A 30 28 82 01 79 C8 87 8D 8D 44 91 25 87 87 24 87 87 8C 23 87 87 4E 87 8A 87 87 4D 49 24 32 79 F0 98 CF 20 20 28 79 20 32 20 40 87 29 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 31 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 5D 24 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 59 00 30 00 43 00 18 00 11 00 46 00 60 00 F4 00 E7 00 14 01 19 00 59 00 6B 00 60 00 19 00 7B 00 92 02 29 00 1E 00 CD 02 70 00 19 00 15 00 AD 00 3E 01 5B 00 22 00 26 00 20 01 51 00 71 00 16 04 2D 00 45 00 BA 00 1D 00 19 00 15 00 0C 00 51 01 35 00 5B 00 26 00 64 00 52 01 1A 00 24 01 15 00 02 02 1D 00 13 00 37 02 60 00 33 01 15 00 60 00 FE 01 40 00 A6 01 7F 01 C4 04 5F 03 1E 01 17 00 6C 02 6D 00 21 00 31 00 82 00 3D 00 10 00 5F 06 F7 07 08 00 10 00 48 00 10 00 37 08 48 00 08 00 28 00 88 00 10 00 88 00 B3 08 80 00 08 00 9C 00 23 00 10 00 00 00 00 04 03 13 FE 15 00 8C 0A 00 05 05";
        string Body1 = "8C 06 00 04 CC 88 04 CA 00 00 00 00 00 00 00 00 00 03 7C 20 00 80 D3 09 40 00 00 00 57 06 98 06 70 01 08 08 30 08 C0 E8 04 41 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 52 61 69 64 65 72 53 69 6C 76 65 72 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 2F 46 65 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 57 46 5F 4D 45 44 5F 50 69 6E 6B 00 69 57 69 6C 64 5F 43 61 74 2E 00 00 00 5E 5F 41 6E 69 6D 42 50 00 79 5F 43 00 00 6E 87 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 1F 1B 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 3A 3A 00 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 46 6C 61 67 49 6E 64 65 78 00 11 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 00 00 64 C1 9C 21 CF D9 39 E5 72 21 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 75 72 0A 0C C6 A4 2C 0C 64 9A FC 81 0D 94 AD A0 E6 A7 49 AB 13 F5 D1 76 96 30 B4 E0 C3 93 E9 32 BD F6 9F 8B 3B 2B 76 1A 21 C2 13 72 6A 56 3B 2F 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B CE 17 78 37 55 43 4B 42 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 D3 09 12 15 01 01 FF FF FF FF FF FF FF FF 00 E5 4B 14 FF 87 9C DF 6F 4C 25 FE B5 0B 00 04 00 00 03 06 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 00 02 80 05 01 08 00 00 00 01 00 00 00 00 00 00 00 00 00 7E 5C 03 03 02 02 02 02 05 05 D9 D3 83 83 D3 C9 FF E1 38 3D D0 D7 DB FC FE F3 D8 F1 D4 FF FF D4 F4 D4 DA FF D8 FC FD 5C 38 DB 01 CB CB CB DF DF DD CB D2 F9 38 1F C8 C8 CC F5 C8 D2 C8 46 CF EB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 EC DC E8 D8 CA D2 E0 DF D3 D2 FA C7 38 3B D3 DC D9 D8 EB F7 E7 CB D3 D5 05 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 E5 DC 1E 94 E7 D4 F5 1B 00 00 59 08 0B 00 09 0E 08 0C 0F 1C 01 01 0E 0E 07 12 0C 03 02 0A 0E 01 03 0E 00 08 0D 05 1F 29 0A 0E 2D 09 09 2E 05 0D 02 05 01 0D 04 0D 03 0E 0C 1A 08 1C 0D 2F 05 0B 2C 08 1B 08 0D 07 0B 1E 17 2C 25 16 0F 14 05 09 09 0A 05 08 1B 21 31 08 00 0F 00 00 08 08 08 00 04 32 02 08 00 00 30 02 03 41 0C 00 11 08 33 16 02 02 00 22 05 01 46 06 40 00 1C 29 5E 13 02 0F 13 11 1A 01 04 08 07 05 00 01 04 01 04 06 08 03 02 01 FF 05 06 0E 01 21 3E 02 82 B3 34 9A 8A 14 40 C4 08 48 16 81 49 D3 08 6C 2E 0B 80 C1 49 D0 68 00 13 07 40 93 3E 62 20 1D 02 C1 05 4C 15 C4 8A 31 31 00 0E 6A 81 A2 0B 46";

        string Head = "8C 0A 00 05 33 88 05 31 02 00 00 00 00 00 00 00 00 03 A7 00 20 00 80 FD 09 40 00 00 00 6C 06 B0 06 88 01 38 08 60 08 F0 18 09 04 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 4A 50 61 72 74 73 2F 46 65 6D 61 6C 2F 4D 65 64 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 52 61 69 64 65 72 53 69 6C 76 65 72 00 5C 50 6C 61 79 65 72 46 5F 4D 45 44 5F 49 63 65 51 75 65 65 6E 2F 4D 65 73 68 65 00 71 2E 68 5F 43 68 69 6C 64 5F 41 6E 69 6D 42 50 00 8B 2E 5F 43 00 77 53 6B 69 6E 73 2F 5F 2F 4D 61 74 65 72 69 61 6C 90 2E 00 13 2F 53 63 72 69 70 74 2F 43 6F 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 68 54 61 72 67 65 74 73 00 05 16 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 5F 63 61 70 48 61 74 00 0B 0F 48 61 69 74 12 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 BC 20 9C 5D 89 46 C1 C6 FF B6 04 4F F9 2D DE 05 10 AB 74 4A BC C8 88 90 C8 56 C4 AB 69 75 39 8B F2 CB 4A 30 4A 9D 15 C7 94 A0 1B 04 A7 F9 DB 91 D9 40 DE C1 55 9E 69 8D 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 59 69 FE 9A E2 BC 4B D8 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 FD 09 4C 00 14 06 01 FF FF FF FF FF FF FF FF 49 0A 37 00 12 7B 3D 9D D2 46 DB 14 9D 0B 00 00 04 00 01 01 03 06 01 05 01 1E 20 13 1F 06 00 04 09 02 04 02 04 02 05 03 02 02 01 04 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 B9 C0 96 96 92 92 92 92 99 92 41 87 87 53 87 89 87 36 7D F8 F8 E0 69 F9 D8 87 8C 8C 87 25 87 87 7B 90 7E B0 87 8A 2D 7E B8 82 01 79 B0 F9 F8 F8 F8 F8 B0 50 87 87 81 01 79 F8 90 7C F8 F8 F8 A8 36 31 87 42 68 30 81 01 79 C8 87 8D 8D 44 91 25 87 87 24 87 87 8C 87 87 95 4E 8F 87 33 79 C0 87 87 4F 20 28 79 20 32 20 40 87 29 87 7B C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 21 3C AD 38 64 20 69 29 70 4C 7A 7D 98 FF 57 2F 50 41 40 87 92 87 21 7E 55 30 22 00 30 32 99 99 39 40 87 C1 40 40 32 B2 B9 40 40 40 40 87 B3 99 59 59 99 59 7D 59 39 59 B9 79 87 9E 79 5C 00 30 00 0B 00 17 00 3B 00 48 00 09 00 4C 00 44 00 51 00 1C 00 5E 00 73 00 1B 00 6A 00 21 00 8D 00 1D 02 1E 02 33 00 1E 00 70 01 79 00 19 00 15 00 B6 00 50 01 22 00 49 00 7A 03 47 01 32 00 93 00 19 00 E2 03 15 00 0C 00 2A 01 35 00 57 00 22 00 60 00 27 01 1A 00 F9 00 15 00 E0 01 1D 00 13 00 15 02 10 00 4B 01 E1 04 0A 00 20 01 26 05 11 00 6F 01 2A 00 14 00 A1 01 2B 01 17 00 F0 01 60 02 65 00 2F 00 3F 00 F7 03 3D 00 10 00 71 06 08 00 B6 01 08 00 10 00 48 00 10 00 67 08 08 00 28 00 88 00 10 00 88 00 80 00 08 00 1C 00 20 00 30 09 0C 00 20 00 5D 00 58 00 00 00 00 01 0D 1C FE 1B 00 8C 0A 00 05 33 88 05";
        string Head1 = "8C 06 00 04 FD 88 04 FB 02 00 00 00 00 00 00 00 00 03 A1 00 20 00 80 FD 09 40 00 00 00 6C 06 B0 06 88 01 38 08 60 08 F0 18 09 04 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 4A 50 61 72 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 52 61 69 64 65 72 53 69 6C 76 00 5C 50 6C 61 79 65 72 46 5F 4D 45 44 5F 57 69 6C 64 5F 43 61 74 2F 4D 65 73 00 00 00 71 2E 00 68 49 63 65 5F 51 75 65 65 6E 49 63 65 5F 43 68 41 6E 69 6D 42 50 00 8B 5F 43 00 77 00 90 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 70 68 54 61 72 67 65 74 73 00 05 16 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 5F 63 61 70 48 61 74 00 0B 0F 00 0F 48 61 74 12 0B 49 6E 74 15 46 6C 61 67 73 49 6E 64 65 78 00 11 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 BC 20 9C 5D 89 46 C1 C6 FF B6 04 4F F9 2D DE 05 10 AB 74 4A BC C8 88 90 C8 56 C4 AB 69 75 39 8B F2 CB 4A 30 4A 9D 15 C7 94 A0 1B 04 A7 F9 DB 91 D9 40 DE C1 55 9E 69 8D 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 59 69 FE 9A E2 BC 4B D8 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 FD 09 4C 00 14 06 01 FF FF FF FF FF FF FF FF 00 49 0A 37 12 FF 7B 3D 9D D2 46 DB 14 9D 0B 00 04 00 00 01 03 06 01 05 01 00 1E 02 20 13 1F 06 00 00 04 09 02 04 02 04 02 05 03 02 02 01 00 80 05 01 08 01 00 00 00 00 00 00 00 00 00 88 58 03 03 02 02 02 02 05 02 D9 E3 D3 FF ED 21 38 CB 83 FE CF 38 CF CB C4 38 FF D1 38 FE C7 38 E3 CB FF D4 E0 38 FF D4 FD FD 5C 38 DB 01 CB CB DF D3 D5 38 DF C8 CC F5 C8 D2 C8 46 CF DB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 D2 E0 C9 D7 13 D0 DD D0 EF D1 EC DF F9 C3 38 3B E3 D3 DC D9 D8 03 CB F7 E7 CC CA D3 52 05 05 D5 D8 1B 58 D4 93 15 D5 94 D9 D8 58 D7 45 E5 55 D5 E5 17 15 15 45 55 55 C8 15 55 95 E7 D4 E7 00 00 57 08 03 0F 03 00 01 04 0C 08 06 03 06 0A 0B 0A 03 04 02 03 03 05 13 00 01 0D 0E 13 0A 01 22 24 0A 0B 01 2A 0D 04 0D 0F 0A 08 1F 04 01 0D 29 05 0B 2E 0B 13 29 02 18 2A 29 17 12 0C 19 13 0F 18 18 0E 07 07 2D 05 08 1B 00 20 08 00 0F 00 00 08 08 08 0C 04 08 38 00 0B 00 00 35 03 03 0E 13 02 28 1A 0A 00 03 0B 01 01 49 21 06 00 00 05 57 01 1B 33 67 13 02 0F 2B 0F 12 08 07 05 00 01 02 02 01 02 04 03 04 06 05 03 02 FF 05 00 06 02 0B 01 20 44 41 6C FE 80 06 A2 90 68 22 98 0A 84 07 CC 02 70 19 F1 84 00 71 46 0E 80 26 40 30 00 80 93 0A 89 94 A1 0B 88 3E 84 40 C8 11 7A 1C 2D AC 7C 60 40";

        string Hat = "8C 0A 00 04 A1 88 04 9F 00 00 00 00 00 00 00 00 00 03 3F 20 00 80 ED 09 40 00 00 00 8D 06 D0 06 50 01 20 08 48 08 D8 00 09 04 45 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 61 63 41 63 63 65 73 73 6F 72 69 65 73 2F 43 50 5F 46 5F 4D 45 44 5F 52 61 69 64 65 72 53 69 6C 76 65 72 00 65 50 6C 79 65 72 2F 46 65 6D 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 5F 50 69 6E 6B 2F 4D 73 68 65 73 2F 5F 5F 00 7F 2E 6C 5F 41 6E 69 6D 42 50 00 8F 2E 5F 43 00 72 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 5F 8F 2E 6E 48 61 69 72 00 87 2E 00 13 2F 53 63 72 69 70 74 2F 43 6F 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 74 00 0C 42 6F 6F 6C 0C 42 79 74 65 11 54 79 70 65 00 05 15 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 64 00 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 00 00 00 00 32 A8 2F 1A A0 54 79 5A A7 BB 32 DE 4D 75 85 38 E4 26 2F C2 ED B5 E7 FF D4 82 D7 F8 FA 34 00 63 02 26 0A 8C 97 15 D1 80 35 EA 37 9B 0C BB 56 EE 74 6D 33 C8 27 5C 2C 7D 85 17 79 0C BA DC 54 A8 F3 19 E8 52 A4 FE 64 45 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B C1 CA F1 15 D8 48 24 06 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 ED 09 12 00 14 02 01 FF FF FF FF FF FF FF FF FF 4E 13 F0 84 EA FF 76 B3 1F 90 0B 04 00 01 01 07 03 04 00 00 02 01 02 85 02 02 02 04 02 04 02 05 03 01 02 05 01 02 80 05 01 06 08 00 00 00 00 00 00 00 00 00 00 00 03 00 00 00 00 00 00 00 00 00 9E C8 95 96 92 92 92 92 99 92 41 87 87 53 87 8A 87 87 87 87 7F 90 8A 8F 87 26 60 8F 3D 79 39 82 01 79 D8 81 01 87 82 01 79 F8 90 7C F8 F8 F8 98 36 87 7A 30 28 21 81 01 79 F0 81 01 86 01 79 C8 87 8D 8D 44 91 25 87 87 24 87 87 87 87 8F 4F 4D 69 36 79 B8 CF 20 28 79 20 32 20 40 37 87 7B C8 79 70 22 30 87 79 90 32 5A 48 79 A0 22 32 8F 4E 7A 7D 98 FF 87 2B 50 41 40 87 87 25 7E 55 28 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 99 59 73 87 87 9D D9 20 64 28 53 00 30 00 0B 00 47 00 44 00 41 00 73 00 1F 00 85 00 67 00 81 00 81 00 6E 00 21 00 91 00 34 02 29 00 1E 00 7C 00 73 01 74 00 91 00 91 00 70 00 19 00 15 00 AD 00 43 02 1F 00 0E 00 9D 04 56 00 98 04 C5 01 91 00 19 00 50 00 15 00 0C 00 28 01 35 00 57 00 22 00 60 00 25 01 1A 00 13 00 D8 01 1B 00 EF 00 15 00 80 00 40 00 3B 01 D2 00 17 00 F7 01 57 00 21 00 31 00 87 04 3D 00 10 00 91 06 0F 08 08 00 10 00 48 00 10 00 4F 08 48 00 18 00 28 00 88 00 10 00 88 00 CB 08 80 00 08 00 1C 00 21 00 0C 00 34 00 25 00 00 00 00 0A 0A 11 17 0F 13 FC 0F 00 8C 0A 00 04 A1 88 04 9F 00";
        string Hat1 = "8C 06 00 04 07 88 04 05 00 00 00 00 00 00 00 00 00 02 E5 20 00 80 ED 09 40 8D 06 D0 06 50 01 20 08 48 08 D8 00 09 04 45 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 61 63 65 41 63 63 65 73 73 6F 72 69 65 50 5F 46 5F 4D 45 44 5F 52 61 69 64 65 72 53 69 6C 76 65 72 00 65 2F 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 57 69 6C 64 5F 43 61 74 73 68 7F 2E 6C 5F 41 6E 69 6D 42 50 8F 2E 5F 43 72 5F 50 69 6E 6B 2F 53 6B 69 6E 73 2F 2F 4D 61 69 61 6C 73 2F 5F 5F 5F 5F 5F 5F 5F 5F 00 8F 2E 6E 00 87 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 65 74 00 0C 11 05 15 17 1E 20 00 1C 45 43 75 73 74 6F 6D 47 65 6E 64 19 45 3A 3A 00 13 54 79 70 65 61 63 0F 50 65 72 6D 69 74 74 65 64 00 0B 15 04 4E 6F 6E 00 10 00 07 50 61 63 6B 61 67 65 12 64 C1 00 32 A8 2F 1A A0 54 79 5A A7 BB 32 DE 4D 75 85 38 E4 26 2F C2 ED B5 E7 FF D4 82 D7 F8 FA 34 00 63 02 26 0A 8C 97 15 D1 80 35 EA 37 9B 0C BB 56 EE 74 6D 33 C8 27 5C 2C 7D 85 17 79 0C BA DC 54 A8 F3 19 E8 52 A4 FE 64 45 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B C1 CA F1 15 D8 48 24 06 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 ED 09 12 00 14 02 01 FF FF FF FF FF FF FF FF FF 4E 13 00 F0 84 EA FF 76 B3 1F 90 0B 04 01 01 01 07 03 02 01 02 85 02 02 02 04 02 04 02 05 03 01 02 05 01 80 05 01 06 00 08 03 00 00 00 00 00 00 00 00 00 71 1C 03 C5 42 02 02 02 02 05 02 D9 A3 81 C7 FB 43 CB D0 C7 C6 CC F4 F4 FD FD E4 FD B7 FD FD FE 3D D0 D3 C7 FF FE FD 3D FE FD DB 01 CB CB EB F4 FD D1 FD FD FC 39 F4 3D 40 3A F0 C9 C7 FA D2 E6 C8 E7 E0 C4 82 D1 EB F9 F8 FC C7 B0 FA F7 39 80 F8 CC C7 D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 9D E0 05 15 48 DE 98 CB E8 84 A7 CC 25 00 00 46 03 08 07 0F 0C 09 05 0E 08 04 06 0F 0E 00 09 06 0E 07 10 1C 0A 00 0C 09 08 01 0D 05 14 0C 06 0D 0E 20 04 0D 08 07 1D 09 0B 10 03 2E 08 0D 0A 08 04 0B 0F 11 11 00 13 05 2B 00 29 08 00 29 00 00 25 00 36 0C 08 0D 00 00 2D 02 0E 0E 14 01 0F 05 46 0C 46 04 4D 04 09 22 09 00 0A 03 61 0C 5D 5D 08 13 02 0F 24 01 05 08 03 0D 07 01 08 0F 01 06 00 FF 05 06 0E 02 01 31 6D 67 09 1B 30 54 13 04 20 24 4E 0D 5A B6 A1 6C 70 56 00 01 80 31 00 89 C1 81 A5 E5 42 86 A6 88 20 DF A0 02 66 44";
        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Diva"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.WildcatRSEnabled = true;
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
                Settings.Default.WildcatRSEnabled = false;
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
