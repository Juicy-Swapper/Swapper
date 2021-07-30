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
    public partial class BughaDance : Form
    {
        bool enabled = Settings.Default.BughaDanceEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Bring it a Round'";

        public BughaDance()
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

        string Emote = "8C 0A 00 06 32 88 06 30 04 00 00 00 00 00 00 00 00 04 76 00 20 04 80 31 0A 40 00 00 00 C0 06 00 07 A8 01 A8 08 E0 08 28 09 40 09 18 54 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 4B 69 74 63 68 65 6E 4E 61 76 69 67 61 74 6F 5F 4B 5F 43 4D 46 5F 4D 00 71 2E 4D 4D 4D 38 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 00 37 53 65 72 69 43 72 65 43 6F 6C 6C 61 62 00 33 43 61 74 61 6C 6F 67 2F 44 69 73 70 6C 61 79 41 73 73 65 74 73 2F 44 41 5F 4B 2E 4A 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 4C 2D 4C 00 6F 2F 2E 6B 00 13 2F 53 63 72 69 70 74 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 32 53 6F 75 72 63 65 2E 53 68 6F 70 00 13 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 10 50 61 74 68 00 0B 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 52 61 72 65 00 14 11 43 6F 6F 6C 64 6F 77 53 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 74 18 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0B 49 6E 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 65 00 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 0C 4C 6F 6F 70 73 00 06 0C 53 74 72 75 63 74 00 06 10 53 68 6F 72 74 11 53 6D 61 6C 6C 0E 53 6F 66 74 12 0E 0C 54 65 78 00 64 C1 A1 04 E8 FD B9 4F 36 44 71 81 81 88 DC 5B 98 4F BF 14 BF 9E 2D 2D 24 0A A2 AA 78 11 8D 92 57 92 AB 92 5E 1D DE F8 8F 36 DA A0 CD 16 10 2F A1 C3 80 76 F4 00 99 B0 ED CC 96 0E 98 CA EA 65 7B E3 13 48 38 6D FA 63 3C 37 21 23 B0 C6 C4 49 A6 74 DC 3E 0A 81 2E ED 1B 94 93 7E 6E 3F C3 8C BC 15 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 A2 F0 9F 7F D8 BE 95 89 9F 34 7B 25 3E 97 A2 09 D2 85 94 71 4A 26 77 31 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE C5 DA 94 5B F5 D9 B2 20 F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D DD FA 50 93 8B BD F2 7D B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 75 5A 09 00 E1 6A D3 9B C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 DB 6F A3 73 A1 40 EA 11 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 0A 60 9C 4E 14 47 BD 21 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 99 CF 75 72 CD E3 48 34 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 F7 0F BF 1A 3E 49 34 AE 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E D4 C1 39 EA 6C B9 4C 8C FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 31 0A 3A 01 1D 00 50 32 F7 B1 21 91 FA A4 0B 00 00 00 02 00 01 01 1F D2 BC 72 EF 35 C4 09 01 19 04 01 02 02 02 3D 02 0D 06 02 02 0A 06 01 03 03 00 80 3F 02 21 44 32 42 42 44 41 44 45 34 44 39 38 41 33 35 45 30 31 44 36 43 44 42 39 37 43 34 35 37 30 34 39 00 10 79 6E 61 6D 69 63 20 53 68 75 66 66 6C 65 00 08 43 45 30 36 31 31 35 36 34 38 41 36 35 44 37 46 34 38 41 42 36 39 45 44 39 43 34 38 42 45 34 06 00 33 38 43 39 39 46 34 31 34 37 30 44 33 44 35 44 45 30 37 35 39 32 46 33 37 38 41 46 33 00 12 49 20 6B 6E 6F 77 20 74 68 65 20 6D 6F 76 73 21 00 13 15 14 0A 07 00 00 00 00 00 00 00 00 00 00 00 FD FF FF FF 00 00 00 00 00 00 E4 C0 96 96 92 92 92 92 92 92 41 87 87 32 87 8D 87 87 3E 7A 87 79 F8 F8 F8 F8 C8 79 E8 78 F0 F0 F0 F0 E0 F9 F8 F8 F8 F8 D0 F9 E8 99 B9 87 87 87 87 7C 90 7A F0 9C 23 36 32 87 87 87 7C B0 79 F8 F8 B0 79 C8 B1 87 31 87 47 22 31 7B 90 F9 F8 F8 F8 F0 7D F8 F8 F8 F8 79 F8 A8 F9 F8 F8 F8 F0 78 F8 98 87 8A 87 46 91 25 48 28 20 4E 4A 87 87 32 28 20 2E 87 49 30 2D 52 93 8F 63 27 7E A8 87 7B D8 24 28 61 3E 21 22 87 59 87 79 B0 29 8F 89 87 87 8F 49 21 20 30 60 58 5A 87 6C 53 87 87 87 2D 50 25 39 3F 31 87 39 66 6E 2D 30 49 50 21 58 54 23 00 30 32 B2 40 40 40 40 87 42 5C 99 99 99 87 5A 87 87 7B 69 53 99 87 87 87 87 26 87 87 6A 87 8C 87 87 8E 99 28 71 87 89 8F 8E 87 9B 87 8F 23 B9 39 B9 60 D9 60 00 30 00 0F 00 18 00 17 00 56 00 1D 00 C9 00 40 00 3A 00 2D 00 14 00 39 00 6E 00 35 00 4D 00 6C 01 6B 01 0F 00 0E 00 4C 00 4E 00 71 00 6F 00 15 00 91 00 16 00 9F 00 EB 01 1B 03 0B 00 92 02 BB 02 96 02 34 00 A7 02 1C 03 30 00 1B 00 37 00 5F 00 E8 02 92 00 E8 00 0D 00 D6 02 12 00 13 01 22 01 0D 00 EC 02 E3 00 0F 00 58 00 D9 00 C6 00 AC 00 8B 01 0D 00 AE 01 58 00 08 02 29 00 1F 00 2D 00 F9 00 18 02 6C 01 4D 01 70 00 6E 00 5E 01 10 00 7E 00 59 00 10 00 0E 00 C7 06 A7 08 08 00 38 00 50 00 10 00 68 00 E8 08 0C 00 1C 00 38 00 78 09 1A 00 25 00 43 00 4A 04 7C 00 E2 00 08 00 46 01 00 00 00 FE 27 00 8C 0A 00 06 32 88 06 30";
        string Emote1 = "8C 06 00 05 D0 88 05 CE 04 00 00 00 00 00 00 00 00 04 3D 00 20 04 80 31 0A 40 C0 06 00 07 A8 01 A8 08 E0 08 28 09 40 09 18 54 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6D 6F 74 65 73 2F 43 65 6C 65 62 72 44 61 6E 63 65 5F 5F 43 4D 46 5F 4D 00 71 2E 4D 4D 00 38 74 68 65 6E 61 2F 49 74 65 6D 6F 73 6D 65 74 69 63 73 2F 73 49 44 5F 4B 69 74 63 4E 61 76 69 67 61 74 6F 72 00 37 53 65 72 69 43 72 65 43 6F 6C 6C 61 62 00 33 43 61 74 61 6C 6F 67 2F 44 69 73 70 41 73 73 65 74 41 5F 4B 2E 4A 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 49 63 6F 6E 73 54 2D 2D 2D 45 2D 00 4C 2D 4C 00 6F 2E 6B 00 13 2F 53 63 72 69 70 74 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 1A 46 69 6C 72 2E 53 65 61 73 6F 6E 2E 31 32 53 6F 75 72 53 68 6F 70 00 13 22 61 75 6C 74 5F 5F 0B 44 65 73 10 50 61 74 68 00 0B 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 0D 46 6C 6F 61 74 18 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0B 49 6E 11 4C 61 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 65 00 04 4E 6F 6E 65 00 0E 07 50 61 63 6B 0C 4C 6F 6F 70 73 00 06 0C 53 74 72 75 06 10 72 74 11 53 6C 0E 53 6F 66 74 12 0E 0C 00 64 C1 A1 04 E8 FD B9 4F 36 44 71 81 81 88 DC 5B 98 4F BF 14 BF 9E 2D 2D 24 0A A2 AA 78 11 8D 92 57 92 AB 92 5E 1D DE F8 8F 36 DA A0 CD 16 10 2F A1 C3 80 76 F4 00 99 B0 ED CC 96 0E 98 CA EA 65 7B E3 13 48 38 6D FA 63 3C 37 21 23 B0 C6 C4 49 A6 74 DC 3E 0A 81 2E ED 1B 94 93 7E 6E 3F C3 8C BC 15 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 A2 F0 9F 7F D8 BE 95 89 9F 34 7B 25 3E 97 A2 09 D2 85 94 71 4A 26 77 31 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE C5 DA 94 5B F5 D9 B2 20 F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D DD FA 50 93 8B BD F2 7D B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 75 5A 09 00 E1 6A D3 9B C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 DB 6F A3 73 A1 40 EA 11 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 FA 86 1E 80 92 B9 C6 D6 0A 60 9C 4E 14 47 BD 21 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 99 CF 75 72 CD E3 48 34 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 F7 0F BF 1A 3E 49 34 AE 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E D4 C1 39 EA 6C B9 4C 8C FF FF FF FF FF FF FF FF E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 31 0A 3A 01 1D 00 50 32 F7 B1 21 91 FA A4 0B 02 00 01 01 1F D2 BC 72 EF 35 C4 09 01 19 04 01 02 02 02 3D 02 0D 06 02 02 0A 06 01 03 03 04 80 3F 02 21 44 32 42 42 44 41 44 45 34 44 39 38 41 33 35 45 30 31 44 36 43 44 42 39 37 43 34 35 37 30 34 39 00 10 00 42 72 69 6E 67 20 69 74 20 52 00 00 08 43 45 30 36 31 31 35 36 34 38 41 38 36 35 44 37 46 42 36 39 45 44 39 43 34 38 42 45 34 00 06 00 33 38 43 39 39 46 34 31 34 34 37 30 44 33 44 35 30 44 45 30 37 35 39 39 32 46 33 37 46 33 00 12 79 20 4A 75 69 63 79 20 53 77 61 70 21 00 13 15 14 0A 07 FD FF FF FF 00 00 00 00 00 00 96 18 03 C5 42 02 02 02 02 02 02 D9 D3 CF D3 F9 FF FD FC 3D 39 74 56 C7 CF 41 C7 FF 07 CB D3 D2 C7 C7 FE FD FD 11 D3 C7 DB CA D1 FB FE FF FD 3D FC C7 DB 01 CB DC CC C8 DF DE D3 CC C8 CF DF D0 D3 E1 03 EB C7 C8 FF C5 FF CB CC E9 D7 C9 CA E7 C6 C4 FC CD C7 DF C9 C8 D0 E8 E4 E6 EF E3 CF E0 CB D5 D7 D1 C7 D5 C5 EA C6 ED CF D0 DD E0 C9 A4 C5 E0 CB D3 D2 12 D8 D8 D8 D8 DB C4 15 15 05 05 E7 27 E8 8D E3 05 83 CB EF C7 47 CC F1 83 4B C7 CA 15 15 D5 E8 25 E5 20 01 C8 00 59 48 90 02 0B 45 77 33 D7 34 FD 14 C9 32 F9 3E 81 82 18 00 4B 2A EA 48 BA 7A 8D ED CC 16 1D 5F 48 F0 07 51 1F 07 BD 80 FF DC E6 01 BA 51 CE C6 6D C6 55 97 F1 6C 15 C6 5D 0B 57 DE 77 11 41 80 A3 7B 00 0F 24 3F 0F F3 C2 19 D6 83 51 CB CE 36 A2 E6 D7 CB 52 2C D6 58 EC 01 00 00 4A 03 0D 15 02 05 43 0B 42 44 07 06 04 08 0C 01 00 03 09 02 04 22 07 05 03 02 00 39 01 3B 12 39 10 06 08 02 03 0D 03 05 02 00 08 01 03 03 03 09 01 03 05 04 15 03 08 00 17 02 04 01 02 00 FF 06 06 0E 00 1F 08 00 0E 0B 19 01 09 00 14 C2 30 D6 4A 01 A3 00 38 18 81 1E F4 00 04 3C 8B 68 54 07 E6 78 30 28 19 30 3C 22 6A 08 00 46 00 18 7D E0 0A 18 C1 0E 5C 31 62 A2 48 81 36 B4 00 C0 FD 4A 32 63 1C 24 4A 23 30 46 6C 24 2A 20 44";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (SwapUtilities.CheckIfCanSwap("TippyTap"))
              //  return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.BughaDanceEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote added";
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

            bool Swap1 = HexResearcher.Revert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.BughaDanceEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Emote removed";
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
