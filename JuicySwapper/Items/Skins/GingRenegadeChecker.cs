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
    public partial class GingRenegadeChecker : Form
    {
        bool enabled = Settings.Default.GrenegadeCEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Renegade Raider";

        public GingRenegadeChecker()
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


        string Body = "8C 0A 00 05 1C 88 05 1A 00 00 00 00 00 00 00 00 00 03 90 20 00 80 08 0A 40 00 00 00 8C 06 D0 06 70 01 40 08 68 08 F8 20 09 04 48 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 5F 42 6F 64 79 5F 46 5F 52 65 6E 65 67 61 64 65 52 61 64 65 72 48 6F 6C 69 64 61 79 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 75 46 5F 4D 45 44 5F 5F 2F 4D 61 74 65 72 69 61 6C 73 2F 4D 5F 46 00 96 2E 55 65 64 5F 53 6F 6C 64 69 65 72 5F 30 31 46 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 26 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 1A 18 3F 92 84 53 EA 39 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 62 6A A0 2E D8 1F 3A 61 A6 EA 59 E7 60 56 80 DA A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 19 16 BF 66 26 F2 1D 27 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 08 0A 12 00 15 01 01 FF FF FF FF FF FF FF FF 1A 4B 14 B6 D0 8F E5 8C 91 33 B5 0B 04 00 01 00 03 08 00 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 00 00 00 06 02 80 05 01 04 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 BC C8 95 96 92 92 92 92 99 92 41 87 87 87 87 87 33 87 87 8C 87 35 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 4D 31 39 87 7F C8 28 82 01 79 F8 98 F9 F8 F8 98 87 46 79 7A F8 F8 F8 F8 D0 79 90 F9 F8 F8 F8 F8 D0 48 87 82 01 79 F8 90 87 87 8E 44 91 25 87 87 24 87 8A 87 25 8E 87 4E 87 8A 87 87 4D 49 24 32 79 F0 D0 CF 20 20 28 79 20 32 20 40 8F 28 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 31 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 55 30 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 5B 00 30 00 1F 00 4A 00 18 00 11 00 46 00 60 00 FB 00 F0 00 F1 00 F2 00 26 00 35 01 77 00 98 00 29 02 18 00 57 00 68 00 2E 02 67 00 21 00 15 00 AE 00 45 00 0B 02 22 00 26 00 21 01 51 00 71 00 44 04 2D 00 4C 00 C1 00 1D 00 19 00 15 00 0C 00 18 03 35 00 5B 00 26 00 64 00 59 01 1A 00 2B 01 15 00 0A 02 1D 00 13 00 3F 02 60 00 3A 01 15 00 60 00 B5 03 40 00 AD 01 86 01 3C 02 7D 02 1E 01 17 00 73 02 6D 00 21 00 31 00 82 00 3D 00 10 00 91 06 08 00 9E 01 08 00 10 00 48 00 10 00 6F 08 48 00 08 00 28 00 88 00 10 00 88 00 EB 08 80 00 08 00 9C 00 23 00 10 00 00 00 00 1A 0A FE 15 00 8C 0A 00 05 1C 88 05 1A 00 00 00 00 00 00";
        string Body1 = "8C 06 00 04 E6 88 04 E4 00 00 00 00 00 00 00 00 00 03 9A 20 00 80 08 0A 40 00 00 00 8C 06 D0 06 70 01 40 08 68 08 F8 20 09 04 48 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 5F 42 6F 64 79 5F 46 5F 52 65 6E 65 67 61 64 65 52 61 69 64 65 72 48 6F 6C 69 64 61 79 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 75 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 72 5F 30 31 2F 53 6B 69 6E 73 2F 54 56 5F 32 31 2F 4D 61 74 65 72 69 61 6C 45 44 5F 43 6F 6D 6D 61 6E 64 6F 54 56 32 31 00 00 00 96 2E 55 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 6F 6C 16 62 53 75 70 70 6F 72 74 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 26 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 3A 3A 00 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 46 6C 61 67 49 6E 64 65 78 00 11 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 1A 18 3F 92 84 53 EA 39 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 62 6A A0 2E D8 1F 3A 61 A6 EA 59 E7 60 56 80 DA A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 19 16 BF 66 26 F2 1D 27 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 08 0A 12 15 01 01 FF FF FF FF FF FF FF FF 00 1A 4B 14 FF B6 D0 8F E5 8C 91 33 B5 0B 00 04 00 00 03 08 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 06 02 80 05 01 04 00 00 00 01 00 00 00 00 00 00 00 00 00 7D 5C 03 03 02 02 02 02 05 02 D9 D3 D3 D3 C9 FF E1 38 3D D0 CF D3 D7 FF FD D8 FD D4 F8 FE FD 3D DC FF FC F8 DB 01 CB CB CB 43 DE DF DD CB D2 FD 1F C8 C8 CC F5 C8 D2 C8 D8 CF EB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 EC DC E8 D8 CA D2 E0 DF D3 D2 FA C7 38 3B D3 DC D9 D8 EB F7 E7 CC CA D3 15 45 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 E5 DC 1E 94 CB 99 D4 91 4C C8 1B 00 00 58 08 07 02 00 09 0E 08 03 0F 1F 1C 0F 08 00 00 11 1F 0F 00 16 0F 07 00 0D 06 05 19 0A 0E 24 09 09 2C 01 04 09 05 01 0D 04 28 0D 03 0E 0C 11 08 13 0D 2D 05 0B 2A 08 12 08 0D 07 0B 15 1E 14 2B 16 0F 1B 05 09 09 0A 05 08 2A 00 32 08 00 0F 00 00 08 08 08 00 04 02 02 08 00 00 2F 02 03 23 1C 27 08 33 16 22 08 01 01 5B 11 2D 44 00 44 06 54 00 16 02 0F 13 0D 1A 01 16 04 05 07 05 00 01 04 01 04 06 08 03 02 FF 05 06 0C 01 24 05 12 C4 85 96 2B 42 89 A0 81 0A A6 02 F8 C1 0E 48 31 1B 05 90 01 C4 DA 00 20 29 18 00 70 61 C3 54 27 05 9D 28 21 10 9B F6 04 43 4B 92 60 E1 27 42";

        string Hat = "8C 0A 00 04 B8 88 04 B6 00 00 00 00 00 00 00 00 00 03 5F 20 00 80 A8 09 40 00 00 00 3A 06 80 06 60 01 E0 07 08 08 98 08 C0 04 4C 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 48 61 74 73 2F 43 50 5F 48 61 74 5F 46 5F 43 6F 6D 6D 61 6E 64 6F 52 65 6E 65 67 61 64 65 52 61 69 64 72 48 6F 6C 69 64 61 79 00 78 50 6C 79 65 72 2F 46 65 6D 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 69 65 73 2F 46 5F 4D 45 44 5F 5F 2F 4D 61 74 65 72 69 61 6C 73 2F 4D 5F 46 5F 46 63 65 41 63 63 00 9C 2E 75 2F 65 73 68 65 73 2F 00 93 2E 7C 5F 41 6E 69 6D 42 50 00 A3 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 61 63 68 6F 63 6B 65 74 4E 0C 42 79 74 65 11 54 79 70 65 00 05 27 16 43 75 73 74 6F 6D 48 61 74 13 00 1E 4F 76 65 72 72 69 64 1F 44 65 66 61 75 6C 74 5F 5F 1C 0E 45 48 61 15 5F 48 65 6C 6D 65 00 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 18 3A 3A 48 61 74 00 04 00 0F 50 65 72 6D 69 74 74 65 64 00 07 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 9F B1 06 4D 01 50 70 57 4A F0 B5 87 38 A0 FE 00 CE 16 C0 08 0E DE 9C 6F A1 2E 17 2E DE 70 F3 E5 97 AF 12 EE 3E 51 0E DD 11 44 71 CF F7 9F 12 B9 39 E4 78 E8 26 76 94 62 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 28 5A DB 02 27 56 F4 80 E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 4E 08 CE B4 90 F6 5E 1A 79 E7 D0 07 5F 28 61 BD D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 03 14 EA 73 DA D3 FB B4 79 F1 D0 49 02 33 24 9A 50 A4 A4 0C EB 52 E3 58 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 A8 09 1D 00 11 01 01 FF FF FF FF FF FF FF FF C5 39 10 AB 87 68 48 20 D3 9C 8D 0B 04 00 01 04 03 02 1C 06 00 02 01 02 08 02 04 02 04 02 05 03 03 02 04 80 05 01 02 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 9F C8 95 96 92 92 92 92 92 99 41 87 87 53 87 87 87 8F 87 8D 87 7B 90 8A 8F 87 87 87 49 31 39 87 7F C8 8A 87 01 79 F8 B0 FA F8 F8 F8 F8 2E 78 F8 82 01 79 F8 81 01 87 82 01 79 F8 B0 87 87 8E 44 91 25 87 87 24 87 8A 87 8F 8B 26 4D 69 36 79 F0 D8 CF 2B 79 20 32 20 40 8F 28 87 7B C0 79 70 32 32 71 8E 23 30 87 79 90 87 59 48 79 A0 27 32 87 44 4C 7A 7D 98 FF 57 37 50 40 40 87 92 87 21 7E 55 40 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 49 50 49 BC 79 87 27 79 4F 00 30 00 0B 00 4E 00 4A 00 4B 00 4C 00 26 00 7A 00 9E 00 9E 01 2B 00 77 00 95 00 95 00 7E 00 25 00 15 00 C9 00 45 00 3C 00 20 00 F9 03 49 00 FF 03 95 00 18 00 61 00 15 00 0C 00 71 03 35 00 56 00 21 00 5F 00 16 00 CC 00 10 00 4F 01 1B 00 13 00 19 00 24 01 15 00 FE 03 43 00 92 00 7E 01 04 01 17 00 CD 01 3B 02 03 02 2F 00 3F 00 D5 02 3D 00 10 00 41 06 08 00 8E 01 08 00 10 00 48 00 10 00 CE 01 48 00 08 00 28 00 88 00 10 00 88 00 8B 08 80 00 08 00 98 00 29 00 2E 00 33 00 4B 00 00 00 00 1D 1A 1A 21 FE 11 00 8C 0A";
        string Hat1 = "8C 06 00 04 96 88 04 94 00 00 00 00 00 00 00 00 00 03 55 20 00 80 A8 09 40 00 00 00 3A 06 80 06 60 01 E0 07 08 08 98 08 C0 04 4C 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 48 61 74 73 2F 43 50 5F 5F 46 5F 43 6F 6D 6D 61 6E 64 6F 5F 52 65 6E 65 67 61 64 65 52 61 69 64 65 72 48 6F 6C 69 64 61 79 00 78 41 63 63 65 73 73 6F 72 69 65 4D 61 74 65 72 69 61 6C 73 2F 46 65 6C 65 30 37 00 9C 2E 75 50 6C 61 79 2F 4D 65 64 69 75 6D 2F 42 6F 64 46 5F 4D 45 44 5F 5F 2F 4D 65 73 68 65 73 2F 00 93 2E 7C 5F 41 6E 69 6D 42 50 00 A3 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 74 61 63 68 53 6F 63 6B 65 74 4E 0C 42 79 74 65 11 54 79 70 65 00 05 27 16 43 75 73 74 6F 6D 48 61 74 13 00 1E 4F 76 65 72 72 69 64 65 1F 44 65 66 61 75 6C 74 5F 5F 1C 0E 45 48 61 15 5F 48 65 6C 6D 65 74 00 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 18 3A 3A 48 61 74 00 04 46 61 63 65 00 0F 50 65 72 6D 69 74 74 65 64 00 07 0B 49 6E 74 15 46 6C 61 67 73 49 65 78 00 11 73 00 0C 04 4E 6F 6E 65 00 0E 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 9F B1 06 4D 01 50 70 57 4A F0 B5 87 38 A0 FE 00 CE 16 C0 08 0E DE 9C 6F A1 2E 17 2E DE 70 F3 E5 97 AF 12 EE 3E 51 0E DD 11 44 71 CF F7 9F 12 B9 39 E4 78 E8 26 76 94 62 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 28 5A DB 02 27 56 F4 80 E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 4E 08 CE B4 90 F6 5E 1A 79 E7 D0 07 5F 28 61 BD D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 03 14 EA 73 DA D3 FB B4 79 F1 D0 49 02 33 24 9A 50 A4 A4 0C EB 52 E3 58 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 A8 09 1D 00 11 01 01 FF FF FF FF FF FF FF FF 00 C5 39 10 FF AB 87 68 48 20 D3 9C 8D 0B 00 04 00 00 04 04 03 02 1C 00 06 00 00 02 01 02 08 02 04 02 04 02 05 03 03 02 01 00 80 05 01 02 01 00 00 00 00 00 00 00 00 00 79 5C 03 03 02 02 02 02 02 05 D9 E3 81 07 D3 D7 03 E2 D6 FD FD FD BC FD 43 D4 CB DF D1 D5 D3 EC 38 FE F1 38 3D FF F0 38 D4 DB 01 CB CB CB DF ED D3 FD 5F CF F5 C8 D2 C8 D8 CF D7 38 D9 38 CC D2 D2 F1 CB D0 FF E7 C8 CC C5 38 D3 DB DF F9 C3 38 81 7B CB DC D3 E0 D8 D8 03 CB F7 E7 D4 CA D3 52 05 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 E5 DC 13 92 59 E7 D4 E7 00 00 50 08 03 06 08 00 01 00 02 05 1E 0D 1B 1A 1B 1C 16 03 0F 0D 06 12 0B 0D 01 0D 04 08 21 01 27 0D 00 14 0D 04 27 0D 0E 09 07 0F 04 08 17 03 0B 01 0C 00 0D 0E 0A 16 0C 0F 1B 07 13 1B 07 07 27 05 08 25 00 16 08 00 0F 00 00 08 08 08 00 04 33 0B 0B 00 00 34 02 03 0E 08 20 07 09 2D 22 47 00 00 01 08 02 05 64 64 06 6B 16 02 0F 20 02 03 17 04 00 05 07 07 05 00 05 0A 08 01 02 01 00 04 06 05 03 02 FF 05 06 02 0D 01 24 40 88 29 4A 02 06 29 1B 02 12 01 15 43 82 3C CD D4 20 03 89 B0 00 80 4D 0A 06 00 54 32 D9 23 14 10 2E 8A 20 9E 67 38 CF 52 11 E5 70 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("GingerReneade"))
                return;

            ActionButton.Enabled = false;

            var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";
            int SwapOffsets = 254000000;
            string SwapPath = $"{Pathtopaks}\\pakchunk10_s22-WindowsClient.ucas";

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets, SwapPath, Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.GrenegadeCEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = HexResearcher.Convert(SwapOffsets, SwapPath, Hat, Hat1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Hat added";

            ActionButton.Image = Resources.RevertBtn;
            LogBox.Text += "\nConverted!";
        }

        private void RevertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            ActionButton.Enabled = false;

            var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";
            int SwapOffsets = 254000000;
            string SwapPath = $"{Pathtopaks}\\pakchunk10_s22-WindowsClient.ucas";

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Revert(SwapOffsets, SwapPath, Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.GrenegadeCEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = HexResearcher.Revert(SwapOffsets, SwapPath, Hat, Hat1, 0, 0, false, false);
            if (Swap2)
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
