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
    public partial class SpaceCuddle : Form
    {
        bool enabled = Settings.Default.SpaceCuddleEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Mecha Cuddle Master";

        public SpaceCuddle()
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

        string Body = "8C 0A 00 05 11 88 05 0F 00 00 00 00 00 00 00 00 00 03 92 20 00 80 4E 0A 40 00 00 00 D2 06 18 07 70 01 88 08 B0 08 40 09 68 09 04 49 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 53 74 72 65 65 74 46 61 73 68 69 6F 6E 45 63 6C 69 70 73 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 65 46 5F 4D 45 44 5F 5F 52 65 64 00 7E 2E 6C 5F 41 6E 69 6D 42 50 00 8E 2E 46 5F 43 00 7D 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 00 9D 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 27 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 34 FF E1 69 21 45 3C 72 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 E8 6D 15 A6 14 07 0C E1 DD 23 BC 6C B9 A0 7B 85 CE 1C 40 75 B3 B4 6D AF 41 A4 47 55 16 DF 7F 95 A6 8A FA 5F E9 AC 57 70 BE 23 75 7C B2 74 F4 3A 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 8F 2E F7 5D CD 32 BE 9D 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 4E 0A 12 00 15 01 01 FF FF FF FF FF FF FF FF 60 4B 14 85 38 FE 03 A0 D5 22 B3 0B 04 00 01 00 03 06 00 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 00 00 00 04 02 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 AA C8 95 96 92 92 92 92 92 92 41 00 30 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 3D 39 34 78 D8 82 01 79 D0 81 01 87 82 01 7A F8 7C F8 F8 F8 D0 3E 87 6A 78 28 82 01 79 F8 90 89 87 87 46 91 25 87 87 24 87 87 8C 23 87 87 4E 87 8A 87 87 4D 49 24 32 79 F0 D8 CF 20 20 28 79 20 32 20 40 87 29 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 28 31 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 55 40 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 5C 00 30 00 4B 00 18 00 11 00 46 00 60 00 FC 00 EF 00 F0 00 23 01 20 00 67 00 80 00 80 00 6E 00 20 00 90 00 E0 02 31 00 05 03 2A 03 7F 00 9F 00 15 00 C3 00 63 01 5B 00 22 00 26 00 36 01 51 00 71 00 89 04 35 00 4D 00 C2 00 1D 00 19 00 15 00 0C 00 67 01 35 00 5B 00 26 00 64 00 5A 01 1A 00 2C 01 15 00 20 02 1D 00 13 00 55 02 60 00 3B 01 15 00 60 00 06 02 40 00 AE 01 87 01 37 05 9A 03 1E 01 17 00 74 02 6D 00 21 00 31 00 82 00 3D 00 10 00 D9 06 08 00 9E 01 08 00 10 00 48 00 10 00 DE 01 48 00 08 00 28 00 88 00 10 00 88 00 33 09 80 00 08 00 9C 00 23 00 10 00 00 00 00 0C 0A 0A 11 22 FE 15 00 8C 0A 00 05 11 88 05 0F 00";
        string Body1 = "8C 06 00 04 BE 88 04 BC 00 00 00 00 00 00 00 00 00 03 67 20 00 80 4E 0A 40 D2 06 18 07 70 01 88 08 B0 08 40 09 68 09 04 49 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 53 74 72 65 65 74 46 61 73 68 69 6F 6E 45 63 6C 69 70 73 65 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 64 69 75 6D 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 65 46 5F 4D 45 44 5F 53 70 61 63 65 5F 43 75 64 64 6C 7E 2E 6C 5F 41 6E 69 6D 42 50 8E 2E 5F 43 7D 5A 79 6C 6F 78 00 00 00 00 00 00 00 00 9D 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 73 43 6F 6C 6F 72 53 77 61 74 63 79 74 65 11 50 61 72 74 00 05 27 1B 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 45 3A 3A 19 00 0F 0B 49 6E 74 14 4D 61 73 61 6C 00 15 46 6C 61 67 49 78 00 11 73 00 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 75 64 C1 34 FF E1 69 21 45 3C 72 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 E8 6D 15 A6 14 07 0C E1 DD 23 BC 6C B9 A0 7B 85 CE 1C 40 75 B3 B4 6D AF 41 A4 47 55 16 DF 7F 95 A6 8A FA 5F E9 AC 57 70 BE 23 75 7C B2 74 F4 3A 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 8F 2E F7 5D CD 32 BE 9D 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 4E 0A 12 00 15 01 01 FF FF FF FF FF FF FF FF 60 4B 14 00 85 38 FE 03 A0 D5 22 B3 0B 04 01 03 06 06 08 02 04 04 81 02 01 02 05 03 01 02 02 01 01 04 02 80 05 01 08 01 00 00 00 00 00 00 00 00 00 7E 1C 03 C5 42 02 02 02 02 02 02 D9 C7 D3 C7 03 D3 C9 FF FD 3D D0 DB FC E4 FD FD CC FD E7 3D FD FA 11 FF E5 FD BC DB 01 CB C7 CB CB DF C7 C7 C4 1F DD CB D2 FD 1F C8 C8 CC ED D0 D2 C8 46 CF FF F9 EC CA D0 D8 FE D2 E6 FB D2 EC DC F9 8C C8 D2 E0 DF C7 D0 D2 FA FF C5 7B C7 CC E0 D9 D8 EB F7 C5 E1 D8 CA D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 F9 DC E4 FA 47 65 C8 35 67 00 00 5B 03 08 02 03 0E 00 09 0E 08 04 16 03 10 0F 03 00 08 06 03 06 00 07 0D 0D 0B 2D 1A 2C 0A 06 1C 0E 1D 09 09 21 0D 05 0A 05 0E 0D 04 0D 03 0E 0C 12 02 14 0D 27 05 0B 2C 08 13 0D 02 08 16 1F 02 2F 27 16 0F 02 1E 1C 05 09 09 0A 05 1C 08 1D 00 16 08 00 16 00 00 27 2F 00 04 0B 08 00 00 34 02 23 20 15 01 06 08 33 09 16 0E 04 4A 0D 4A 04 51 09 0A 5A 67 09 13 02 04 05 13 11 03 08 00 01 17 04 08 07 0B 02 06 01 01 01 02 00 03 08 03 FF 05 06 0D 01 00 40 50 A1 DC 41 EC C2 E9 B1 5A 82 A8 80 8A 36 55 92 14 62 30 00 6C 42 20 D0 20 12 14 4A FD 5D D8 0A E2 19 28 10 44 09 81 20 8C A2 A2 06 EE 0D 2A 7E 82 44";

        string Hat = "8C 0A 00 04 82 88 04 80 00 00 00 00 00 00 00 00 00 03 2B 20 00 80 65 09 40 00 00 00 13 06 58 06 40 01 98 07 C0 07 50 08 78 08 04 55 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 61 63 41 63 63 65 73 73 6F 72 69 65 73 2F 43 50 5F 46 5F 4D 45 44 5F 5F 53 74 72 65 65 74 46 61 73 68 69 6F 6E 45 63 6C 69 70 73 65 00 73 50 6C 79 65 72 2F 46 65 6D 6C 65 2F 4D 65 64 69 75 6D 2F 42 6F 64 5F 5F 52 65 64 2F 4D 73 68 65 73 2F 00 94 2E 7A 5F 41 6E 69 6D 42 70 00 A4 2E 5F 43 00 7D 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 5F 48 61 69 72 00 9D 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 74 00 0C 42 6F 6F 6C 0C 42 79 74 65 11 54 79 70 65 00 05 25 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 64 00 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 4D 0C CF 22 39 84 9F 99 B1 F8 31 97 68 C1 F6 E0 EE 75 0C D7 B4 37 F7 78 EF B1 72 4A 2E D8 C2 1D C7 C0 85 91 47 2A 1C B9 10 00 14 A6 46 6C 27 CE 51 1F 72 AF 38 B0 B5 38 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 12 D4 30 5F 6F 9C F3 F6 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 65 09 12 00 01 01 FF FF FF FF FF FF FF FF 77 3C 11 D6 4D 77 39 74 66 DC 97 0B 04 00 01 07 03 00 02 01 02 85 02 02 02 04 02 04 02 05 03 01 02 05 01 02 80 05 01 06 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 9B C8 95 96 92 92 92 92 92 92 41 87 87 53 87 8A 87 87 3F 87 87 87 7A 90 8A 8F 87 26 28 38 39 8E 2D 78 D0 40 82 01 79 F8 98 81 01 87 82 01 79 F8 C8 7C F8 F8 F8 D0 3E 87 6A 78 87 01 79 F8 90 89 87 87 46 91 25 87 87 24 87 87 87 87 8F 4F 4D 69 36 79 F0 C8 CF 20 28 79 20 32 20 40 37 87 7B C8 79 70 22 30 87 79 90 32 5A 48 79 A0 22 32 8F 4E 7A 7D 98 FF 87 2B 50 41 40 87 87 25 7E 55 38 22 00 30 52 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 22 E1 87 87 9B 79 50 00 30 00 0B 00 19 00 57 00 54 00 51 00 49 00 4A 00 8A 00 26 00 8A 00 75 00 96 00 96 00 7C 00 28 00 A6 00 82 02 31 00 A7 02 7F 00 9F 00 15 00 C3 00 63 01 1F 00 0E 00 13 04 56 00 0E 04 2D 00 A1 00 19 00 60 00 15 00 0C 00 46 01 35 00 57 00 22 00 60 00 35 01 1A 00 13 00 FE 01 1B 00 FF 00 15 00 80 00 40 00 4B 01 D2 00 17 00 07 02 57 00 21 00 31 00 C5 03 3D 00 10 00 19 06 08 00 6E 01 08 00 10 00 48 00 10 00 C7 07 48 00 08 00 28 00 88 00 10 00 88 00 43 08 80 00 08 00 9C 00 2A 00 43 00 00 00 00 18 18 1F 22 FE 09 00 8C 0A 00 04 82 88 04 80";
        string Hat1 = "8C 06 00 04 38 88 04 36 00 00 00 00 00 00 00 00 00 03 09 20 00 80 65 09 40 13 06 58 06 40 01 98 07 C0 07 50 08 78 08 04 55 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 61 63 65 41 63 63 65 73 73 6F 72 69 65 50 5F 46 5F 4D 45 44 5F 5F 53 74 72 65 65 74 46 61 73 68 69 6F 6E 45 63 6C 69 70 73 65 00 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 4D 65 64 69 75 6D 2F 42 6F 64 53 70 5F 43 75 64 64 6C 65 73 65 94 2E 7A 5F 41 6E 69 6D 42 50 A4 2E 5F 43 7D 5A 79 6C 6F 78 00 00 00 00 00 00 00 00 9D 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 0F 62 41 74 74 61 63 68 54 6F 53 6F 63 6B 65 74 00 0C 42 6F 6F 6C 0C 42 79 74 65 11 54 79 70 65 00 05 25 17 43 75 73 74 6F 6D 13 00 1E 4D 61 69 61 6C 4F 76 65 72 72 69 64 20 44 65 66 61 75 6C 74 5F 5F 1C 11 45 47 65 6E 64 65 72 00 19 45 3A 3A 00 13 19 3A 3A 00 0F 50 65 72 6D 69 74 74 65 64 00 0B 49 6E 74 15 46 6C 61 67 73 49 78 00 11 73 00 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 75 64 C1 4D 0C CF 22 39 84 9F 99 B1 F8 31 97 68 C1 F6 E0 EE 75 0C D7 B4 37 F7 78 EF B1 72 4A 2E D8 C2 1D C7 C0 85 91 47 2A 1C B9 10 00 14 A6 46 6C 27 CE 51 1F 72 AF 38 B0 B5 38 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD FC 02 DD 56 A9 52 46 BB DE 72 84 89 5C 9A 9C B3 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 12 D4 30 5F 6F 9C F3 F6 9C 57 6E 1C 4A 94 58 A1 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 E1 E0 75 7E 10 87 5F 20 A7 90 03 3D EA 51 7A 64 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 96 F4 4B 43 32 EF 64 58 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C CC C5 25 56 69 31 65 68 7E A2 42 63 10 83 7A 73 75 F0 DA 76 DF 00 10 47 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 65 09 12 00 01 01 FF FF FF FF FF FF FF FF 77 3C 11 00 D6 4D 77 39 74 66 DC 97 0B 04 01 01 07 03 02 01 02 85 02 02 02 04 02 04 02 05 03 01 02 05 01 02 80 05 01 06 01 00 00 00 00 00 00 00 00 00 70 1C 03 C5 42 02 02 02 02 02 02 D9 A3 81 C7 D7 FB 43 CB D0 C6 C7 80 C5 C8 FC E8 D4 FD FD AC FD BF FD FD FE 11 FF E5 FD BC DB 01 CB C7 CB DF DF ED D3 FD 1F C8 CC ED D0 D2 C8 46 D3 FF F9 EC CA D0 FB D2 E6 DC FD CA D2 DF F9 FF C5 7B C7 CC E0 D9 D8 CB F7 C5 E1 D4 CA D3 62 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 9D E0 F5 DE 98 87 F5 E7 00 00 4E 03 08 07 01 0F 0C 09 0A 0A 0F 0D 09 0F 00 0D 01 0E 04 03 1A 00 07 0D 0D 0B 2F 1A 07 06 2B 0E 26 05 09 01 08 0D 04 0D 0F 0A 08 1D 02 0B 2B 03 07 0D 08 08 13 0A 0F 0C 11 1F 0F 09 09 22 05 1C 08 1F 00 16 08 00 2D 00 00 29 00 04 3E 0B 0B 00 00 2F 02 0E 0E 05 15 09 07 05 03 50 15 50 04 02 57 09 0F 0A 5A 67 09 13 02 04 05 28 02 03 15 04 07 07 07 06 02 0B 02 01 00 03 10 03 FF 05 06 0E 01 01 44 17 E6 81 07 B3 82 10 81 08 80 40 F0 DE 26 2A C6 42 5A 4D 40 60 02 18 01 C0 08 39 20 F7 41 14 41 25 04 C5 01 17 0E 21 84 28 44";

        string Head = "8C 0A 00 05 02 88 05 00 00 00 00 00 00 00 00 00 00 03 87 20 00 80 67 09 40 00 00 00 EB 05 30 06 70 01 A0 07 C8 07 58 08 80 08 04 52 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 61 72 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 53 74 72 65 74 46 61 73 68 69 6F 6E 45 63 6C 69 70 73 65 00 7D 50 6C 61 79 65 72 42 6F 64 69 65 73 2F 46 5F 4D 45 44 5F 5F 52 65 64 2F 53 6B 69 6E 73 2F 2F 4D 61 74 65 72 69 61 6C 00 9D 2E 5A 41 6E 67 65 6C 30 31 2F 4D 65 73 68 00 6E 2E 64 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 84 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 68 54 61 72 67 65 74 73 00 05 1E 43 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 48 61 69 72 5F 63 61 70 48 61 74 00 0B 0F 48 61 74 12 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 BC A9 26 C3 77 A1 2C B1 2C 2C 62 41 65 B6 08 55 3C 9A 5D E2 0E 58 44 39 CC 7D 7D 98 7A 70 64 5D E6 73 26 60 3A FA 9E F1 E2 98 F9 8C E8 9C 1D BB 60 1C 5D AA 42 BB CB 11 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 5F EE 5F C3 0D 6E 22 CE 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 67 09 40 00 12 06 01 FF FF FF FF FF FF FF FF A7 37 10 7F 85 93 AF 29 6E EC 9C 0B 04 00 01 01 04 01 05 1C 02 1E 11 1D 06 00 04 09 02 04 02 04 02 05 03 02 02 01 04 80 05 01 02 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 AF C8 95 96 92 92 92 92 92 92 41 87 87 53 87 87 87 87 21 8E 87 87 7C 90 7E 87 3D 39 87 3C 87 6A 78 28 82 01 79 F0 98 F9 F8 60 40 35 3F 78 7A F8 F8 F8 F8 F8 79 A8 F9 F8 F8 F8 F8 E8 87 87 01 79 F0 87 87 87 44 91 25 87 87 24 87 87 8C 87 87 87 4E 8F 87 33 7A F8 87 87 4F 20 28 79 20 32 20 40 87 29 87 7B C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 87 3A AD 38 6C 29 70 4C 7A 7D 98 FF 57 2F 50 41 40 87 92 87 21 7E 55 38 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 99 B1 30 A3 B9 99 39 59 39 79 87 9E 79 59 00 30 00 0B 00 09 00 54 00 4C 00 49 00 4A 00 55 00 31 00 7A 00 96 00 7F 00 9F 00 6A 01 6D 00 73 01 B9 00 1B 00 5C 00 70 00 66 00 1E 00 15 00 AA 00 4B 00 22 00 49 00 85 03 43 01 3A 00 9B 00 19 00 F5 03 15 00 0C 00 F8 02 35 00 57 00 22 00 60 00 2F 01 1A 00 01 01 15 00 DC 01 1D 00 13 00 11 02 10 00 53 01 0A 00 20 01 66 01 19 00 14 00 98 01 1A 01 17 00 E7 01 57 02 65 00 2F 00 3F 00 DD 02 3D 00 10 00 F1 05 08 00 9E 01 08 00 10 00 48 00 10 00 CF 07 48 00 08 00 28 00 88 00 10 00 88 00 4B 08 80 00 08 00 28 00 0C 00 34 00 0C 00 51 00 6C 00 00 00 00 22 09 FE 15 00 8C 0A 00 05 02 88 05 00";
        string Head1 = "8C 06 00 04 CD 88 04 CB 00 00 00 00 00 00 00 00 00 03 62 20 00 80 67 09 40 EB 05 30 06 70 01 A0 07 C8 07 58 08 80 08 04 52 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 50 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 50 5F 5F 46 5F 53 74 72 65 65 74 46 61 73 68 69 6F 6E 45 63 6C 69 70 73 65 00 7D 2F 50 6C 61 79 65 72 42 6F 64 69 65 5F 5F 53 6F 6C 65 72 5F 30 31 2F 53 6B 69 6E 73 2F 53 74 65 61 6C 74 68 5F 48 6F 6E 6F 72 2F 4D 61 69 61 6C 53 4D 4C 5F 41 53 4E 5F 5F 48 61 69 72 9D 2E 5A 45 44 5F 45 6D 70 74 79 30 31 73 68 00 6E 2E 64 61 6E 69 6D 42 50 84 2E 5F 43 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 61 6C 44 61 74 61 00 09 41 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 70 68 54 61 72 67 65 74 73 00 05 1E 0C 43 75 72 6C 73 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 1E 4F 76 65 72 72 69 64 65 20 00 1C 13 1B 45 3A 3A 00 11 47 65 6E 64 65 72 00 19 45 3A 3A 00 0F 08 5F 63 61 70 48 61 74 00 0B 0F 12 0B 49 6E 74 15 46 6C 61 67 73 49 78 00 11 73 00 0C 4E 61 6D 04 4E 6F 6E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 12 53 6F 66 74 0E 75 64 C1 BC A9 26 C3 77 A1 2C B1 2C 2C 62 41 65 B6 08 55 3C 9A 5D E2 0E 58 44 39 CC 7D 7D 98 7A 70 64 5D E6 73 26 60 3A FA 9E F1 E2 98 F9 8C E8 9C 1D BB 60 1C 5D AA 42 BB CB 11 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 5F EE 5F C3 0D 6E 22 CE 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 67 09 40 00 12 06 01 FF FF FF FF FF FF FF FF A7 37 10 00 7F 85 93 AF 29 6E EC 9C 0B 04 01 01 01 04 04 01 05 1C 02 1E 00 11 1D 06 04 09 02 04 02 04 02 05 03 02 02 01 04 80 05 01 02 01 00 00 00 00 00 00 00 00 00 8A 1C 03 C5 42 02 02 02 02 02 02 D9 A3 81 C7 CA FB F7 C7 C5 43 C7 CB D7 CC D7 FD FD E4 FD C8 CC D3 C6 DA F0 FE FD 3D 80 C8 D8 D7 3D FC FD EE DB 01 CB C7 C7 C7 DF D3 FD C7 DF C8 CC E9 D8 D1 C8 D8 CF 3A F8 FD 3D CA D0 D8 D2 E6 FB D2 D2 E0 C9 D7 0B D8 C5 EC CD F0 DF F9 FF C5 7B E3 C7 CC E0 D9 D8 03 CB F7 C5 E1 D4 CA D3 52 05 05 D5 D8 1B 58 D8 95 15 92 D8 D8 98 58 E7 45 9D E0 05 15 48 0B 15 45 92 15 C8 15 F9 07 F5 E7 00 00 5F 03 08 0B 01 0C 04 09 08 00 07 0A 09 0B 07 04 1A 07 12 06 1B 09 01 03 04 08 0D 09 1A 0E 00 22 0D 02 2A 09 1E 0A 01 2D 0B 1B 02 03 27 00 06 29 12 0D 00 06 1C 02 1E 14 05 0B 19 08 1B 2C 02 18 0A 1E 01 0C 10 12 0F 02 1F 11 1F 0D 07 07 15 05 10 08 1F 00 16 08 00 2D 00 00 29 00 08 09 04 0B 00 00 35 02 0E 12 17 03 02 01 19 00 05 02 66 0A 15 05 49 03 39 03 39 03 06 13 02 04 06 13 12 0F 0E 03 09 05 0C 03 06 01 02 01 02 01 00 03 01 06 05 03 FF 05 06 01 09 01 01 45 41 C1 99 11 65 51 69 04 71 C8 1E 42 ED 00 1C 25 00 C4 D4 CC 00 03 80 40 68 00 58 20 42 A9 C4 2E B4 41 0A 00 02 03 0C F8 32 4D D0 05 20 04 D4 1A 93 2E 04 08 44";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("ShadowRuby"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[9], SwapPath[7], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SpaceCuddleEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = HexResearcher.Convert(SwapOffsets[9], SwapPath[7], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head added";

            bool Swap3 = HexResearcher.Convert(SwapOffsets[9], SwapPath[7], Hat, Hat1, 0, 0, false, false);
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[9], SwapPath[7], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SpaceCuddleEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = HexResearcher.Revert(SwapOffsets[9], SwapPath[7], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head removed";

            bool Swap3 = HexResearcher.Revert(SwapOffsets[9], SwapPath[7], Hat, Hat1, 0, 0, false, false);
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
