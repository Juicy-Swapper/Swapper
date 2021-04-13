using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;
using System.ComponentModel;
using System.Globalization;

namespace JuicySwapper.Items.Emotes
{
    public partial class TakeTL : Form
    {
        bool enabled = Settings.Default.TAKEtLEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Take The L";

        public TakeTL()
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

        string Emote = "8C 0A 00 06 45 88 06 43 04 00 00 00 00 00 00 00 00 04 81 00 20 04 80 3C 0A 40 00 00 00 CB 06 10 07 A8 01 B8 08 F0 08 38 09 50 09 18 54 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 43 79 63 6C 6F 6E 65 5F 48 65 61 64 62 61 6E 67 2F 65 6D 6F 74 63 68 5F 43 4D 46 5F 4D 00 71 2E 4D 4D 4D 37 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 5F 42 00 53 65 72 69 43 72 65 61 74 6F 72 43 6F 6C 6C 61 62 00 32 43 61 74 61 6C 6F 67 2F 44 69 73 70 6C 61 79 41 73 73 65 74 73 2F 44 41 5F 49 2E 4A 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 49 63 2D 2D 45 2D 2D 4C 2D 4C 00 6F 2F 2E 6B 00 13 2F 53 63 72 69 70 74 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 2E 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 32 53 65 74 2E 50 6F 72 74 72 69 74 46 6F 6C 6B 19 6F 75 72 63 65 2E 53 68 6F 70 00 13 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 10 50 61 74 68 00 0B 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 70 69 63 00 13 11 43 6F 6F 6C 64 6F 77 53 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 74 18 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 65 00 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 0D 4C 65 6E 74 68 00 06 0C 53 74 72 75 63 74 00 06 10 53 68 6F 72 74 11 53 6D 61 6C 6C 0E 53 6F 66 74 12 0E 0C 54 65 78 64 C1 19 62 E3 A4 BA 14 1F 31 65 51 ED 01 43 9B 1F 01 C4 E4 2E 99 BC 7B D6 0D C1 7C EF 5F 07 A6 8C EE 6C 71 B4 76 AB 80 8E CA DA A0 CD 16 10 2F A1 C3 0E 70 81 72 41 D2 77 9B C1 C2 50 EC F3 86 43 CE 8A DB 3B 83 B9 D3 04 9A 78 01 E9 05 39 96 EF 21 C4 FB 90 AB 97 47 DB 5B EC 3F 01 F5 5C 25 76 C4 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 A2 F0 9F 7F D8 BE 95 89 C4 50 08 E7 B2 8A 26 DE 9F 34 7B 25 3E 97 A2 09 D2 85 94 71 4A 26 77 31 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE C5 DA 94 5B F5 D9 B2 20 F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 04 DD 5C 7C 6F F2 9D A8 DF 6A 99 F2 FA 6C C8 7D B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 75 5A 09 00 E1 6A D3 9B C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 4D C9 91 AA 4B B1 57 B8 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 99 CF 75 72 CD E3 48 34 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 F7 0F BF 1A 3E 49 34 AE 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E D4 C1 39 EA 6C B9 4C 8C FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 3C 0A 38 01 1E 00 13 25 57 EE E6 E4 6E BA 0B 00 00 00 02 00 01 01 1F D2 BC 72 EF 35 C4 09 01 19 04 02 02 02 3C 02 0D 06 02 02 0A 06 01 03 03 01 20 41 80 3F 03 21 44 38 44 46 35 43 38 31 34 31 44 41 30 39 43 38 36 41 33 32 41 31 42 35 33 45 33 38 32 34 37 00 0C 00 00 00 20 65 72 00 08 42 32 32 44 39 46 44 34 30 45 44 42 38 31 46 33 33 36 36 38 33 39 44 44 43 37 31 45 44 45 44 06 00 33 43 35 37 36 37 33 34 42 32 32 33 37 37 41 45 44 39 41 44 39 39 34 41 33 35 37 30 35 39 36 4F 70 65 6E 69 74 20 75 70 21 13 16 15 14 0A 07 00 00 00 00 00 00 00 00 00 00 00 FD FF FF FF 00 00 00 00 00 00 EC C0 96 96 92 92 92 92 92 92 41 87 87 32 87 8D 87 87 87 95 39 B9 87 79 F8 F8 F8 F8 C8 79 E8 78 F0 F0 F0 F0 E0 F9 F8 F8 F8 F8 D0 F9 E8 99 B9 87 87 87 87 3D 20 99 79 F8 9C 87 36 32 87 87 87 7C A8 79 F8 F8 A8 79 C0 B1 87 31 87 47 94 31 3B 49 F9 F8 F8 F8 F0 7D F8 F8 F8 F8 79 F8 A8 F9 F8 F8 F8 F0 78 F8 98 87 8A 87 46 91 25 48 28 20 4E 4A 87 87 32 28 20 2E 87 49 29 2D 52 93 8F 63 87 8A 8E D9 26 7E A8 87 7B D8 24 28 61 3E 21 22 87 59 8A 7D A8 29 8F 89 87 87 8F 49 21 20 30 60 58 5A 87 6C 87 87 87 2D 50 25 39 8B 3C 31 87 39 66 6E 2D 30 49 50 21 58 4C 38 22 00 30 32 B2 40 40 40 40 87 42 5C 99 99 99 87 5A 8C 87 DD 69 92 53 99 87 87 87 8E 87 22 21 6C 8C 87 87 87 8E 99 28 71 8E 87 87 87 AC 8C 2E 39 39 B9 B9 60 D9 60 00 30 00 0F 00 17 00 56 00 1D 00 C9 00 74 00 73 00 39 00 14 00 39 00 6D 00 34 00 4B 00 68 01 67 01 0E 00 4B 00 4C 00 4E 00 71 00 6F 00 15 00 91 00 16 00 9F 00 E9 01 17 03 0B 00 8F 02 B7 02 93 02 34 00 A4 02 AC 00 30 00 1B 00 1C 00 7B 00 01 03 AE 00 04 01 0D 00 F0 02 12 00 2F 01 3E 01 0D 00 07 03 FE 00 0F 00 57 00 D8 00 C5 00 AB 00 A6 01 0D 00 C9 01 16 02 74 00 1F 00 2D 00 EC 00 27 02 5F 01 40 01 71 00 6F 00 51 01 10 00 7F 00 59 00 10 00 0E 00 D1 06 08 00 E6 01 08 00 38 00 50 00 10 00 68 00 F8 08 0C 00 1C 00 46 00 1A 00 0A 04 0B 04 3F 00 3F 04 78 00 48 0A CA 00 08 00 44 01 00 00 00 FE 27 00 8C 0A 00 06 45";
        string Emote1 = "8C 06 00 06 2F 88 06 2D 04 00 00 00 00 00 00 00 00 04 8F 00 20 04 80 3C 0A 40 00 00 00 CB 06 10 07 A8 01 B8 08 F0 08 38 09 50 09 18 54 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 43 79 63 6C 6F 6E 65 5F 48 65 61 64 62 61 6E 67 2F 65 5F 63 68 5F 43 4D 46 5F 4D 00 71 4C 6F 73 65 72 5F 44 61 6E 63 65 5F 2E 00 4D 00 00 00 4D 4D 37 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 73 2F 45 49 44 5F 42 53 65 72 69 43 72 65 6F 72 43 6F 6C 6C 61 62 00 32 43 61 74 61 6C 6F 67 2F 44 69 73 70 6C 61 79 41 73 73 65 74 73 2F 44 41 5F 49 2E 4A 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 54 61 6B 65 54 68 65 4C 4C 2D 6F 2E 6B 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 00 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 31 32 53 65 74 2E 50 6F 72 74 72 61 69 74 46 6F 6C 6B 53 6F 75 72 63 65 2E 53 68 6F 70 00 13 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 10 50 61 74 68 00 0B 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 45 70 69 63 00 13 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 61 74 18 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 65 00 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 0D 4C 65 6E 67 74 68 00 06 0C 53 74 72 75 63 74 00 06 10 53 68 6F 72 74 11 53 6D 61 6C 6C 0E 53 6F 66 74 12 0E 0C 64 C1 19 62 E3 A4 BA 14 1F 31 65 51 ED 01 43 9B 1F 01 C4 E4 2E 99 BC 7B D6 0D C1 7C EF 5F 07 A6 8C EE 6C 71 B4 76 AB 80 8E CA DA A0 CD 16 10 2F A1 C3 0E 70 81 72 41 D2 77 9B C1 C2 50 EC F3 86 43 CE 8A DB 3B 83 B9 D3 04 9A 78 01 E9 05 39 96 EF 21 C4 FB 90 AB 97 47 DB 5B EC 3F 01 F5 5C 25 76 C4 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 A2 F0 9F 7F D8 BE 95 89 C4 50 08 E7 B2 8A 26 DE 9F 34 7B 25 3E 97 A2 09 D2 85 94 71 4A 26 77 31 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE C5 DA 94 5B F5 D9 B2 20 F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 04 DD 5C 7C 6F F2 9D A8 DF 6A 99 F2 FA 6C C8 7D B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 75 5A 09 00 E1 6A D3 9B C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 4D C9 91 AA 4B B1 57 B8 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 99 CF 75 72 CD E3 48 34 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 F7 0F BF 1A 3E 49 34 AE 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E D4 C1 39 EA 6C B9 4C 8C FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 3C 0A 38 01 1E 00 13 25 57 EE E6 E4 6E BA 0B 00 00 00 00 02 01 01 1F D2 BC 72 EF 35 C4 09 00 18 04 02 02 01 02 3C 02 0D 06 0A 06 01 03 03 00 00 20 41 80 3F 03 21 44 38 44 46 35 43 38 31 34 31 44 41 30 39 43 38 36 41 33 32 41 31 42 35 33 45 33 38 38 32 34 37 00 0C 00 20 74 68 65 20 4C 08 42 32 32 44 35 39 46 44 34 30 45 44 42 38 31 46 33 33 36 36 38 33 39 44 44 43 37 31 45 44 45 44 00 06 00 33 43 35 37 36 37 38 33 34 42 32 32 33 37 37 41 39 41 44 39 39 34 41 33 35 37 30 35 39 36 42 79 20 4A 75 69 63 79 21 20 20 00 04 13 00 16 15 14 0A 07 00 00 00 00 FD FF FF FF 00 00 00 00 00 00 A4 58 03 03 02 02 02 02 02 02 D9 D3 CB D6 15 FF D3 D0 D1 CC 55 38 D4 FD F8 38 01 D4 BF 15 38 01 38 15 CF D7 C8 05 F4 38 07 43 D3 92 CB 38 11 FC D5 38 11 D3 DB CA D1 DF FD E1 3D D9 38 E4 D8 FD FD 58 DB 01 CB E0 C8 C8 DF DE D3 CC C8 CB DF D0 CF E2 03 EB EB CB CB 38 E3 38 CF C8 E9 D7 C9 CA E7 CB 38 CD DF C9 CC CC E4 E5 E6 EF D3 DC CB D5 D7 D1 D7 EB EF D7 C8 E5 D8 D1 9C C9 DC D0 CA D3 52 12 D8 D8 D8 D8 D7 DB D4 05 05 D7 09 43 DF EA 80 02 A3 05 83 C9 03 ED 07 CC F1 83 4F 07 D1 D6 15 15 E8 25 55 00 00 6A 08 07 00 0F 0E 01 04 00 04 08 01 0B 0A 18 1B 1A 01 0C 05 0C 03 1F 15 07 06 16 04 06 0D 01 00 09 1C 0D 09 0E 06 15 2F 03 10 1F 14 1B 15 2A 08 03 04 0B 03 19 06 0C 03 18 0A 17 16 05 1F 06 07 0F 00 2E 11 1E 05 11 1E 0C 07 05 04 1F 28 18 09 07 19 08 07 01 2E 06 1E 00 1E 00 08 08 00 08 01 00 0B 02 00 21 07 27 00 0D 00 1C 00 00 3F 03 03 0D 21 05 16 08 1F 00 38 13 03 01 00 05 16 1B 05 0B 08 31 33 31 10 13 02 03 0D 03 06 02 00 08 0D 04 03 07 01 03 05 05 1E 08 17 02 05 05 03 03 02 FF 06 02 05 07 02 00 1F 03 1F 0D 0B 0A 21 40 4C 44 1B 22 C1 28 03 00 07 39 D2 17 AB 01 FC 34 A1 01 E5 58 8E 8F 1A 8C 0A 46 E0 46 00 8C 99 D4 00 81 01 28 B0 11 C5 58 5A E8 41 F8 FF 14 41 D3 10 01 CC 68 C0 15 40 C1 36 0C 40 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("Blow"))
            //    return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.TAKEtLEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote added";
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.TAKEtLEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote removed";
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
            if (enabled == false)
            {
                Message EmoteMsg = new Message(Resources.emote);
                EmoteMsg.ShowDialog();
                ConvertBytes.RunWorkerAsync();
            }
            else
                RevertBytes.RunWorkerAsync();
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
