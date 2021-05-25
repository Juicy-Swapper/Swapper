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
    public partial class Catwomen : Form
    {
        bool enabled = Settings.Default.CatwomenEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Renegade Raider";

        public Catwomen()
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

        string Body = "8C 0A 00 05 8C 88 05 8A 00 00 00 00 00 00 00 00 00 03 CF 20 00 80 2A 0B 40 00 00 00 99 07 E0 07 88 01 68 09 90 09 20 0A 48 0A 04 45 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 5F 42 6F 64 79 5F 46 5F 52 65 6E 65 67 61 64 65 52 61 69 64 65 72 46 69 72 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 74 46 5F 4D 45 44 5F 5F 2F 4D 61 74 65 72 69 61 6C 73 2F 4D 49 5F 00 97 2E 55 65 64 5F 53 6F 6C 64 69 65 72 5F 30 31 46 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 2E 5F 43 00 6C 45 66 66 65 63 74 73 2F 46 6F 72 74 5F 50 61 72 74 73 2F 43 43 50 4D 00 8C 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 6E 69 74 65 00 0E 41 64 64 69 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 00 05 23 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 15 6F 64 69 66 65 72 42 6C 75 65 70 72 69 6E 74 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 17 39 15 32 5F E2 6E 21 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 2F 01 57 CB 81 BB C4 ED 6A D9 92 CF 92 26 33 68 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 1A 08 75 51 67 72 D3 49 04 CF 1F 4E 52 87 DA 42 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 37 2A 55 A9 DC CA F8 E2 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 2A 0B 12 00 17 01 01 FF FF FF FF FF FF FF FF 3C 57 16 38 E1 D1 64 67 4C F1 95 0B 04 00 01 00 03 08 00 06 07 04 04 04 81 02 01 02 05 03 01 02 02 01 0A 06 02 80 05 01 04 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 CE C8 95 96 92 92 92 92 92 92 41 87 87 87 87 87 33 87 87 87 37 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 4D 31 21 87 7F D8 28 82 01 79 F8 A8 F9 F8 F8 98 87 46 79 7A F8 F8 F8 F8 D0 79 90 F9 F8 F8 F8 F8 D0 48 87 82 01 79 F8 90 34 87 3E 40 60 38 46 60 34 78 A0 82 01 79 F0 87 87 87 3C 28 24 8E 87 24 87 87 87 21 8E 87 4E 87 8A 87 87 4D 49 20 20 32 79 F0 B8 CF 20 20 28 79 20 32 20 40 87 29 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 31 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 2C 8C 87 66 7E 55 48 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 7B 79 F9 6A 00 30 00 1F 00 47 00 18 00 11 00 46 00 60 00 F8 00 ED 00 EE 00 EF 00 28 00 31 01 76 00 99 00 26 02 18 00 57 00 68 00 2E 02 67 00 21 00 8A 00 0D 00 15 00 A7 00 B5 03 06 02 50 02 22 03 1E 00 6E 00 1E 00 15 00 9D 00 B2 00 41 01 07 03 22 00 26 00 08 01 FF 00 51 00 71 00 3D 05 2A 00 49 00 BE 00 1D 00 19 00 15 00 0C 00 15 04 35 00 5B 00 26 00 64 00 56 01 1A 00 28 01 15 00 03 03 1D 00 13 00 38 03 60 00 37 01 15 00 60 00 AE 04 40 00 AA 01 83 01 35 03 76 03 1E 01 17 00 70 02 6D 00 21 00 31 00 94 01 99 00 54 00 10 00 D1 07 08 00 B6 01 08 00 10 00 48 00 10 00 F6 01 48 00 08 00 28 00 88 00 10 00 88 00 13 0A 80 00 08 00 9C 00 23 00 3E 00 10 00 00 00 00 19 0A 11 FE 1B 00 8C 0A 00 05 8C 88 05 8A 00 00 00 00 00 00";
        string Body1 = "8C 06 00 05 0A 88 05 08 00 00 00 00 00 00 00 00 00 03 83 20 00 80 2A 0B 40 99 07 E0 07 88 01 68 09 90 09 20 0A 48 0A 04 45 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 5F 79 5F 46 5F 52 65 6E 65 67 61 64 65 52 61 69 64 65 72 46 69 72 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 64 69 75 6D 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 74 45 66 66 65 63 74 73 2F 46 6F 72 74 5F 50 61 72 5F 2F 5F 5F 5F 5F 5F 5F 5F 5F 00 97 00 55 46 5F 4D 45 44 5F 43 61 76 65 72 6E 66 2E 65 5F 41 6E 69 6D 42 50 88 2E 5F 43 6C 00 8C 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 00 14 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 43 6F 6C 6F 72 53 77 61 74 63 79 74 65 11 00 05 23 1B 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 72 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 00 19 72 3A 3A 19 00 0F 0B 49 6E 74 14 4D 61 73 61 6C 00 15 46 6C 61 67 49 78 00 11 73 00 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 00 15 66 69 6C 75 65 70 72 69 6E 74 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 17 39 15 32 5F E2 6E 21 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 2F 01 57 CB 81 BB C4 ED 6A D9 92 CF 92 26 33 68 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 1A 08 75 51 67 72 D3 49 04 CF 1F 4E 52 87 DA 42 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 37 2A 55 A9 DC CA F8 E2 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 BE BB F3 B7 F1 2D 34 2A 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 2A 0B 12 00 17 01 01 FF FF FF FF FF FF FF FF 3C 57 16 00 38 E1 D1 64 67 4C F1 95 0B 04 01 03 08 06 07 04 04 04 81 02 01 02 05 03 01 02 02 01 0A 06 02 80 05 01 04 01 00 00 00 00 00 00 00 00 00 8E 1C 03 C5 42 02 02 02 02 02 02 D9 D3 C5 D3 C7 03 D3 C9 FF FD 11 DB D4 E8 D4 C7 F0 89 FF FE 7C FE D0 D3 F0 DC FD FD C8 FD FB 40 FD FD F6 F8 FD FE C7 D6 CC CB CB CB DF C7 C7 C4 1F DD C8 C8 D2 FD 1F C8 C8 CC ED D0 D2 C8 46 C7 C5 CC FF F9 EC CA D0 D8 FE D2 E6 43 FA D3 EC DC F9 8C C8 D2 E0 DF C7 D0 D2 FA FF C5 7B C7 CC E0 D9 D8 CF C4 C6 EB F7 E3 DC CA D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 F9 DC E4 FA F7 F5 35 A7 00 00 6D 03 08 07 09 0F 0A 00 09 0E 08 05 00 05 0E 00 0D 00 0E 17 1F 1A 0C 1B 0F 0C 00 00 29 0F 0C 02 00 11 1F 08 0D 05 0A 17 29 0A 0C 1B 0E 10 07 09 09 25 02 01 06 05 0A 0D 04 12 0B 0D 03 0E 0C 1E 02 10 0D 1B 05 0B 20 08 1F 0D 02 08 12 1B 02 23 22 16 0F 02 1A 18 05 09 09 1C 24 16 01 0C 08 2D 00 1E 08 00 1E 00 00 2F 25 00 04 0B 06 08 00 00 38 02 23 15 15 01 06 08 33 09 0A 00 06 0C 63 12 16 09 3C 04 3C 04 43 02 5B 7B 0F 01 0F 13 11 04 07 00 13 04 01 07 0B 02 01 00 01 01 01 02 00 03 08 07 03 02 FF 05 06 0D 01 01 31 30 71 03 46 EA CA F4 79 28 B0 09 1A 08 50 84 82 F8 28 19 EE 0A D8 50 64 39 48 59 48 83 A0 98 A0 D1 01 40 42 62 14 8E 55 26 86 80 A8 22 A8 15 FB 60 4E 41 03 10 40 F0 CC 1D 0A 08 44";

        string Head = "8C 0A 00 05 70 88 05 6E 02 00 00 00 00 00 00 00 00 03 C9 00 20 00 80 4B 0B 40 00 00 00 AC 07 F0 07 98 01 88 09 B0 09 40 0A 68 0A 04 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 50 50 61 72 74 73 2F 46 65 6D 61 6C 2F 4D 65 64 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 52 65 6E 67 61 64 65 52 61 69 64 72 46 69 72 65 00 74 50 6C 61 79 65 72 42 6F 64 69 65 73 2F 46 5F 4D 45 44 5F 5F 2F 4D 61 74 65 72 69 61 6C 73 2F 4D 49 5F 5F 00 97 2E 65 61 64 65 61 64 62 41 53 4E 5F 53 72 61 68 30 31 2F 4D 65 73 68 65 00 7A 2E 6F 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 96 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 68 54 61 72 67 65 74 73 00 05 1C 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 5F 63 61 70 48 61 74 00 0B 0F 48 61 69 74 12 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 4C 42 5B BB E1 FA 5F 26 D4 1C 86 4E 34 9F F5 CB 70 5E A7 06 54 71 B6 BE 9C 7C E5 94 89 5D AD EE 1E 55 53 FE 59 33 CB 9D C9 00 66 3A 43 B2 8E E3 17 D1 FD F7 EB B4 69 C9 79 16 85 6C 54 4E ED 9C C7 9C 53 A6 6A 6A 8E 65 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 38 06 06 4B 82 6F D8 B8 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 4B 0B 4C 00 16 06 01 FF FF FF FF FF FF FF FF 97 49 14 69 58 6E 8E 0E 04 FD 95 00 04 00 01 01 03 06 01 05 01 20 22 15 21 0A 00 04 09 02 04 02 04 02 05 03 02 02 08 80 05 01 06 05 01 00 00 00 00 00 00 00 00 03 00 00 00 00 00 00 00 00 00 BF C0 96 96 92 92 92 92 92 92 41 87 87 53 87 89 87 36 7D F8 F8 E0 69 F9 D8 87 8C 8C 87 25 8E 87 89 7F 90 7E 87 4D 31 21 87 7F D8 21 82 01 79 F8 A0 01 83 01 F3 F0 40 F9 F8 60 40 8D 33 87 79 D0 82 01 79 C8 81 01 87 87 81 01 79 F8 B0 87 87 87 44 91 25 87 87 24 87 87 8C 87 87 87 4E 8F 87 33 79 F0 87 87 4F 20 28 79 20 32 20 40 87 29 87 7B C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 21 3C AD 38 64 20 69 29 70 4C 7A 7D 98 FF 57 2F 50 41 40 87 92 87 21 7E 55 30 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 39 A1 59 59 99 59 7D 59 39 59 B9 79 87 25 B9 40 64 3A 65 00 30 00 0B 00 17 00 3B 00 48 00 09 00 52 00 4A 00 47 00 48 00 49 00 28 00 D0 00 76 00 23 00 0F 01 0F 01 99 00 68 02 98 00 75 02 1F 00 64 00 7C 00 7C 00 71 00 25 00 15 00 BC 00 4B 00 22 00 49 00 B4 04 53 01 38 00 99 00 19 00 22 05 15 00 0C 00 2D 03 35 00 57 00 22 00 60 00 2D 01 1A 00 FF 00 15 00 EC 01 1D 00 13 00 21 02 10 00 51 01 B8 04 0A 00 20 01 66 06 11 00 75 01 2A 00 14 00 A7 01 2B 01 17 00 F6 01 66 02 65 00 2F 00 3F 00 FA 02 3D 00 10 00 B1 07 08 00 C6 01 08 00 10 00 48 00 10 00 B7 09 48 00 08 00 28 00 88 00 10 00 88 00 3F 00 80 00 08 00 1C 00 20 00 80 0A 0C 00 20 00 5D 00 28 00 4C 00 2F 00 A9 00 00 00 00 19 18 18 07 07 14 FE 1F 00 8C 0A 00 05 70 88 05 6E 02 00";
        string Head1 = "8C 06 00 05 2E 88 05 2C 02 00 00 00 00 00 00 00 00 03 9C 00 20 00 80 4B 0B 40 AC 07 F0 07 98 01 88 09 B0 09 40 0A 68 0A 04 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 50 50 61 72 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 50 5F 5F 46 5F 52 65 6E 65 67 61 64 65 52 61 69 64 65 72 46 69 72 65 00 74 2F 50 6C 61 79 65 72 42 6F 64 69 65 73 2F 46 5F 4D 45 44 5F 5F 61 74 65 72 69 61 6C 73 2F 4D 49 5F 5F 00 97 2E 74 5F 5F 5F 5F 5F 5F 5F 5F 2E 62 43 61 76 65 72 6E 73 5F 7A 2E 6F 5F 41 6E 69 6D 42 50 96 2E 5F 43 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 70 68 54 61 72 67 65 74 73 00 05 1C 0C 43 75 72 6C 73 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 72 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 00 19 72 3A 3A 00 0F 08 5F 63 61 70 48 61 74 00 0B 0F 74 12 0B 49 6E 74 15 46 6C 61 67 73 49 78 00 11 73 00 0C 4E 61 6D 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 4C 42 5B BB E1 FA 5F 26 D4 1C 86 4E 34 9F F5 CB 70 5E A7 06 54 71 B6 BE 9C 7C E5 94 89 5D AD EE 1E 55 53 FE 59 33 CB 9D C9 00 66 3A 43 B2 8E E3 17 D1 FD F7 EB B4 69 C9 79 16 85 6C 54 4E ED 9C C7 9C 53 A6 6A 6A 8E 65 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 38 06 06 4B 82 6F D8 B8 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 4B 0B 4C 00 16 06 01 FF FF FF FF FF FF FF FF 97 49 14 00 69 58 6E 8E 0E 04 FD 95 0B 04 01 01 01 03 06 01 05 01 20 22 15 21 0A 04 09 02 04 02 04 02 05 03 02 02 01 08 02 80 05 01 06 04 03 00 00 00 00 00 00 00 00 00 95 18 03 C5 42 02 02 02 02 02 02 D9 A3 D3 FF ED 3D C7 CA FB F7 DF D1 C5 C4 FF C9 FE FD 3D FF FC FC FD 3D C8 D8 CF C4 C5 D4 11 E8 CC FD FD FD DB C4 FD FD DA D4 DB 01 CB CB C7 DF D3 FD C7 DF C8 CC ED D0 D2 C8 D8 C5 C5 CC FF F9 EC CA D0 D8 FE D2 E6 C7 FA D3 D2 E0 C9 D7 0B D8 C5 E8 C8 ED CD F0 DF F9 FF C5 7B E3 C7 CC E0 D9 D8 03 CB F7 E3 D0 CA D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 9D E0 05 0D 50 F7 E5 09 44 25 15 F9 07 65 05 EB CC E5 00 00 6D 03 08 0F 03 00 0B 01 0A 02 0F 00 01 01 00 08 0E 01 00 17 0E 01 10 00 1A 07 1D 05 09 2F 0C 06 04 29 00 09 09 0B 00 0D 04 0B 19 0A 01 2C 09 1B 00 01 01 2A 0D 04 25 16 05 0D 0F 0A 08 15 02 07 0D 16 05 0D 0B 1B 08 19 20 02 18 05 2E 09 1D 02 0C 1F 13 0F 03 1E 10 1E 0D 07 07 18 05 08 1D 00 1E 08 00 23 00 00 2F 00 08 38 05 07 01 09 00 00 3C 03 0E 13 02 28 09 15 15 03 09 09 09 63 12 41 05 09 43 11 12 15 03 4D 0B 4D 04 54 0F 13 02 0F 13 12 0F 0C 03 09 07 07 02 00 00 01 02 01 02 01 00 03 01 06 05 03 02 FF 05 06 02 09 01 00 40 44 2C 90 4C 89 08 E9 B4 02 0B 44 98 40 24 22 F4 EB 08 00 04 90 75 4B E0 00 EC 03 72 07 C0 B8 8A 50 68 F1 99 A2 29 C0 D4 61 03 08 88 A2 12 20 26 48 2F 04 5C 05 B7 D6 C0 84 86 62 44";

        string Hat = "8C 0A 00 04 BD 88 04 BB 00 00 00 00 00 00 00 00 00 03 64 20 00 80 A2 09 40 00 00 00 34 06 78 06 60 01 D8 07 00 08 90 08 B8 04 49 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 48 61 74 73 2F 43 50 5F 48 61 74 5F 46 5F 43 6F 6D 6D 61 6E 64 6F 52 65 6E 65 67 61 64 65 52 61 69 64 72 46 69 72 65 00 77 50 6C 79 65 72 2F 46 65 6D 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 69 65 73 2F 46 5F 4D 45 44 5F 5F 2F 4D 61 74 65 72 69 61 6C 73 2F 4D 49 5F 5F 46 63 65 41 63 63 00 9D 2E 75 48 6F 6C 69 64 61 79 2F 4D 65 73 68 65 00 93 2E 7C 5F 41 6E 69 6D 42 50 00 A3 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 61 63 68 6F 63 6B 65 74 4E 0C 42 79 74 65 11 54 79 70 65 00 05 24 16 43 75 73 74 6F 6D 48 61 74 13 00 1E 4F 76 65 72 72 69 64 65 1F 44 65 66 61 75 6C 74 5F 5F 1C 0E 45 48 61 15 5F 48 65 6C 6D 65 00 11 45 47 65 6E 64 65 72 00 17 3A 3A 42 6F 74 68 00 13 18 3A 3A 48 61 74 00 04 00 0F 50 65 72 6D 69 74 74 65 64 00 07 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 AD 65 39 CD C6 BB 14 39 CB 8E 08 08 18 97 26 A9 6B 81 06 C4 1B 77 12 B1 A1 2E 17 2E DE 70 F3 E5 97 AF 12 EE 3E 51 0E DD 11 44 71 CF F7 9F 12 B9 39 E4 78 E8 26 76 94 62 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 79 4B D3 C3 C0 3E 10 77 E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 4E 08 CE B4 90 F6 5E 1A 79 E7 D0 07 5F 28 61 BD D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 03 14 EA 73 DA D3 FB B4 79 F1 D0 49 02 33 24 9A 50 A4 A4 0C EB 52 E3 58 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 A2 09 1D 00 11 02 01 FF FF FF FF FF FF FF FF BF 39 10 24 B7 51 F6 79 F5 EA B9 0B 04 00 01 01 04 03 02 1C 06 00 02 01 02 08 02 04 02 04 02 05 03 03 02 04 80 05 01 02 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 A1 C8 95 96 92 92 92 92 92 99 41 87 87 53 87 87 87 8F 87 8D 7F 90 8A 8F 87 87 87 49 31 21 87 7F D8 8A 87 01 79 F8 C0 F9 F8 F8 F8 B8 87 96 28 78 F8 82 01 79 F8 81 01 87 82 01 79 F8 B0 87 87 8E 44 91 25 87 87 24 87 8A 87 8F 8B 26 4D 69 36 79 F0 C0 CF 2B 79 20 32 20 40 87 29 87 7B C0 79 70 32 32 71 8E 23 30 87 79 90 87 59 48 79 A0 27 32 87 44 4C 7A 7D 98 FF 57 37 50 40 40 87 92 87 21 7E 55 30 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 99 B1 38 BC 79 87 27 79 4E 00 30 00 0B 00 4B 00 47 00 48 00 49 00 28 00 79 00 9F 00 9B 01 2B 00 77 00 95 00 95 00 7E 00 25 00 15 00 C9 00 45 00 3C 00 20 00 F6 03 49 00 FC 03 92 00 18 00 5E 00 15 00 0C 00 72 03 35 00 56 00 21 00 5F 00 16 00 C9 00 10 00 4C 01 1B 00 13 00 19 00 21 01 15 00 FB 03 43 00 92 00 7B 01 04 01 17 00 CA 01 38 02 00 02 2F 00 3F 00 D2 02 3D 00 10 00 39 06 08 00 8E 01 08 00 10 00 48 00 10 00 07 08 48 00 08 00 28 00 88 00 10 00 88 00 83 08 80 00 08 00 29 00 2E 00 33 00 4B 00 00 00 00 1C 1A 1A 21 FE 11 00 8C 0A 00 04 BD 88 04 BB 00 00 00 00 00";
        string Hat1 = "8C 06 00 04 7F 88 04 7D 00 00 00 00 00 00 00 00 00 03 37 20 00 80 A2 09 40 34 06 78 06 60 01 D8 07 00 08 90 08 B8 04 49 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 48 61 74 50 5F 5F 46 5F 43 6F 6D 6D 61 6E 64 6F 5F 52 65 6E 65 67 61 64 65 52 61 69 64 65 72 46 69 72 65 00 77 2F 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 69 65 73 2F 46 5F 4D 45 44 5F 5F 2F 4D 61 69 61 6C 73 2F 2D 2D 2D 2D 2D 2D 2D 2D 00 9D 2D 75 43 61 76 65 72 6E 73 68 93 2E 00 7C 5F 41 6E 69 6D 42 50 A3 2E 5F 43 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 74 61 63 68 53 6F 63 6B 65 74 4E 0C 42 79 74 65 11 54 79 70 65 00 05 24 16 43 75 73 74 6F 6D 13 00 1E 4F 72 1F 44 65 66 61 75 6C 74 5F 5F 1C 0E 45 48 61 15 5F 48 65 6C 6D 65 74 00 11 45 47 65 6E 00 17 72 3A 3A 42 6F 74 68 00 13 18 3A 3A 00 04 46 61 63 65 00 0F 50 65 72 6D 69 74 74 65 64 00 07 0B 49 6E 74 15 46 6C 61 67 73 49 65 78 00 11 73 00 0C 04 4E 6F 6E 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 AD 65 39 CD C6 BB 14 39 CB 8E 08 08 18 97 26 A9 6B 81 06 C4 1B 77 12 B1 A1 2E 17 2E DE 70 F3 E5 97 AF 12 EE 3E 51 0E DD 11 44 71 CF F7 9F 12 B9 39 E4 78 E8 26 76 94 62 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 79 4B D3 C3 C0 3E 10 77 E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 4E 08 CE B4 90 F6 5E 1A 79 E7 D0 07 5F 28 61 BD D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 03 14 EA 73 DA D3 FB B4 79 F1 D0 49 02 33 24 9A 50 A4 A4 0C EB 52 E3 58 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 A2 09 1D 00 11 02 01 FF FF FF FF FF FF FF FF BF 39 10 00 24 B7 51 F6 79 F5 EA B9 0B 04 01 01 04 04 03 02 1C 00 06 02 01 02 08 02 04 02 04 02 05 03 03 02 01 80 05 01 02 01 00 00 00 00 00 00 00 00 00 77 1C 03 C5 42 02 02 02 02 02 05 D9 A3 81 C7 46 FB 43 DF D1 C9 C7 FF FE FD 3D C7 C6 C8 F0 E8 FC FD FD B9 FD BF FD FD FE DB 01 CB CB CB DF ED D3 FD 1F C4 CC ED D0 D2 C8 D8 C5 C5 CC FF F9 EC D2 D2 F1 CB D0 C7 FA E7 DC FD C6 D3 DB DF F9 FF 81 7B CB DC C7 D0 E0 D8 D8 03 CB F7 E3 D0 CA D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 F9 D4 E9 13 FA 0B F4 E7 00 00 55 03 08 0C 03 0F 00 01 06 00 01 07 03 0C 12 02 1D 00 0F 0C 0D 06 0C 1B 0D 01 00 04 08 2E 01 24 0A 0A 00 06 0D 04 2A 1F 06 0D 0E 09 07 0E 01 08 14 03 02 0B 01 19 0D 0E 0B 0A 13 0C 0F 18 07 12 10 18 07 07 1B 05 08 1F 00 16 08 00 2D 00 00 29 21 0C 04 06 03 0B 00 00 36 02 0E 03 1E 01 18 00 0A 0C 66 15 22 03 06 42 1E 42 04 12 49 02 23 13 02 0F 20 02 03 14 04 07 06 07 00 06 02 05 08 01 02 01 01 00 01 06 05 03 02 FF 05 06 02 0B 01 00 34 09 01 07 70 E1 9C 7C 28 08 84 00 40 2B 1E C8 BC CF 28 42 6C 08 18 00 28 3A B4 00 A0 CB 24 38 03 C1 84 8B C8 80 10 8A 03 40 73 28 6E 88 44";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Blaze"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[5], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.BrenegadeEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = HexResearcher.Convert(600000, SwapPath[1], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head added";

            bool Swap3 = HexResearcher.Convert(600000, SwapPath[1], Hat, Hat1, 0, 0, false, false);
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[5], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.CatwomenEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = HexResearcher.Revert(600000, SwapPath[1], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head removed";

            bool Swap3 = HexResearcher.Revert(600000, SwapPath[1], Hat, Hat1, 0, 0, false, false);
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
