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
    public partial class WakeUp : Form
    {
        bool enabled = Settings.Default.WakeUpEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Wake Up";

        public WakeUp()
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

        string Emote = "8C 0A 00 05 34 88 05 32 04 00 00 00 00 00 00 00 00 03 C7 00 20 04 80 4B 08 40 00 00 00 63 05 A8 05 50 01 F8 06 20 07 68 07 80 07 4E 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 42 6C 6F 77 69 6E 67 42 75 62 62 6C 65 5F 5F 43 4D 46 5F 4D 00 68 2E 4E 4D 4D 36 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 73 00 48 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 4A 2D 4C 00 6B 2E 67 2E 00 13 2F 53 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 30 00 29 53 6F 75 72 63 65 31 30 2E 42 61 74 74 6C 65 50 61 73 73 2E 46 72 65 65 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 52 61 72 65 00 12 11 43 6F 6F 6C 64 6F 77 53 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 73 00 11 4C 61 72 67 50 72 65 76 69 65 77 49 6D 67 65 00 04 4E 6F 6E 65 00 07 50 61 63 6B 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 64 C1 78 11 90 2A 5F 60 23 7F 96 E4 78 2E 93 EA 48 F3 81 8C A9 E7 D1 37 17 E8 47 81 50 60 C5 88 E7 5E 0F 5B 51 3B 07 59 81 8E 4A A5 1F 51 B5 0B BF 83 8A DC 6A 30 A1 10 99 FA C2 3B 25 A2 6A C4 99 B7 25 6D C6 6F 8E E8 F7 64 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 27 92 74 FF AA 6A C3 EF AE 24 6F 9F 08 44 E5 F1 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 1B A9 7C F1 06 36 23 FB B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 4B 08 1C 01 18 00 FF FF FF FF FF FF FF FF 76 33 73 19 F1 41 50 A4 0B 00 00 00 02 00 01 19 04 04 02 3C 02 0D 06 02 02 0A 05 03 00 01 80 3F 02 21 39 33 30 39 36 37 35 37 34 32 44 32 45 32 37 46 34 38 34 46 37 45 38 45 46 30 30 36 32 36 35 00 10 00 00 00 20 08 33 31 35 34 39 44 38 31 34 31 33 34 37 33 46 32 45 33 34 34 38 42 33 38 43 42 35 30 44 44 45 06 00 35 31 32 34 46 39 30 34 39 33 41 35 35 41 30 41 43 35 34 42 34 42 42 45 46 46 33 42 34 37 34 00 0C 47 65 74 20 70 6F 70 70 69 6E 2E 00 10 12 11 08 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 BD C0 96 96 92 92 92 92 92 5A 87 87 32 87 8D 87 87 34 69 87 79 F8 F8 F8 F8 98 79 D8 F9 F8 F8 F8 F8 79 F0 F0 F0 F0 C0 F9 70 B9 87 87 87 87 74 33 87 31 87 47 22 31 7B F9 F8 F8 F8 E0 7C F8 F8 F8 F0 79 F8 98 F9 F8 F8 F8 E0 79 F8 8C 87 87 44 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 49 30 2D 52 93 8F 55 BE 87 87 87 87 79 D8 24 38 22 21 22 87 59 87 79 A0 29 8F 89 87 87 8F 49 59 5A 87 5C 8F 87 8A 87 27 39 31 87 66 6E 2D 50 21 58 4C 38 22 00 30 32 B2 87 41 40 40 87 42 5C 99 B9 87 56 6A 53 99 87 87 87 8E 87 3A 41 69 87 87 8B 87 8F 99 28 71 8D 87 87 87 9F 87 25 B9 39 B9 59 4C 00 30 00 0F 00 15 00 14 00 50 00 6A 00 BA 00 6A 00 3D 00 38 00 A6 00 A5 00 0F 00 0E 00 4A 00 4C 00 6D 00 1F 00 15 00 8D 00 16 00 9B 00 49 02 0B 00 03 02 F2 01 07 02 34 00 18 02 50 02 30 00 1B 00 1C 00 8D 00 E3 00 0D 00 E6 00 FC 00 0B 01 0D 00 C7 02 CA 00 0F 00 58 01 0D 00 16 00 0F 00 B2 00 BA 01 EC 00 4A 00 10 02 A2 00 41 00 10 00 0E 00 69 05 08 00 7E 01 08 00 40 00 10 00 58 00 28 07 0C 00 1F 00 2E 00 16 00 3B 03 3C 03 43 00 6E 03 7C 00 D8 00 08 00 E6 00 00 00 00 FE 0D 00 8C 0A 00 05 34 88";
        string Emote1 = "8C 06 00 04 E6 88 04 E4 04 00 00 00 00 00 00 00 40 0F 78 03 C0 48 B0 0C 85 AE 6E 56 1E F2 BC 5C 8A 32 CC 84 E1 20 44 15 51 95 78 61 80 94 15 44 96 6E ED 98 21 2B 8A 46 0C 62 65 35 5C 4A 89 33 90 09 33 95 49 A6 21 2D E8 DA E4 26 C9 E6 D3 21 4C B4 EC 8A B1 BD 35 8D B6 26 33 F7 D9 5C 6B C6 DD FA A2 98 8A 67 9C 69 9F 8C FB 88 95 01 00 87 00 30 0A C0 01 68 76 01 F4 A3 94 D8 2C F2 61 09 29 22 EE 56 F9 78 38 6C AB C7 14 A6 54 A2 22 1C 8C CB 52 46 80 90 9C 18 51 38 D5 DA 9A 02 4A 21 72 6C 88 B0 7C 3A 97 2C 66 51 87 92 A8 1A E0 05 B5 1B 57 0B 51 D5 06 32 C7 90 08 8B 03 88 94 A8 ED 5D 3C 34 28 E5 72 42 E2 0C 19 05 E7 58 04 32 C2 06 84 31 16 71 3B 8E A4 A2 19 18 24 A2 20 97 7D FD 76 DF 9C ED F8 F4 CD AD C8 E4 81 C6 B1 A5 CB 6F 0C 19 57 DF 9F 07 DA A2 97 00 0A 23 00 FA 41 68 47 14 4F 24 5E C0 41 42 F1 2C F6 C7 07 C3 83 88 A8 32 E6 02 1C 15 10 78 A6 5F 8D B1 12 CE 84 24 AB B5 2D F9 14 97 F6 E3 7E AE 42 C2 08 41 A5 88 31 0F 58 F2 AB 55 69 E0 6D 48 B2 47 15 1B C1 2A B6 0C 08 71 AC 06 95 5C 03 02 BF 90 C5 20 45 D2 A4 54 2E F1 13 09 DA 92 0A 1F 4A 6A 25 3D 67 50 48 54 89 0A 51 92 30 C5 5F 1F B9 37 76 B7 72 6C ED 64 E7 AB AD 9D 5F FD BA F8 B0 EE 5B 02 1C 6F 9F 65 32 5D 3D CF EA F6 EE FA 5A 7B 2C 1F 67 37 6A E7 91 86 03 E5 42 6C A3 38 47 48 0C 81 16 70 C8 94 98 AF 12 15 20 40 56 51 41 AA 8E 59 26 C2 EA 62 20 97 C0 3C 4C E0 0A 40 48 C1 9B 3C 76 58 2A C6 CE 41 10 BE 01 C1 58 61 60 2A DD 08 84 0C 0E 94 A7 94 41 B5 68 35 B2 C1 37 4C A9 C7 C7 EC 9B 26 21 A9 25 3C 8B F4 48 52 26 10 B3 89 44 B3 56 4A 39 22 8C 90 96 0B 7D 00 66 74 01 17 85 00 13 E6 9B 00 9F 5F DF EA EA 28 9D F8 59 B8 87 EE 4F FE 7D ED E2 46 E3 9D 8F C7 6F 87 96 12 64 68 65 E1 8F C9 D5 A2 E4 5B F7 2D 32 D3 79 70 B7 FB D0 4E ED 69 ED EA 85 89 5B CB A9 F1 EF 73 2F AC 97 AE 6D 68 9E 34 BA 0F 3C 1C BD 2E 56 8F 19 31 35 1F 5E 2B 56 3A C6 0B DF 39 34 B7 7E 69 E2 E8 FE 33 C5 16 31 7D 65 A5 A9 CF 71 18 F2 F9 E1 AA 08 14 54 15 94 16 EC D3 B8 EA 3D 01 27 CD 7A ED F5 EE 97 71 DA E1 73 B8 5C 41 9A F1 DB 83 E0 F4 D0 CD CD 7E 86 61 69 C8 65 72 E6 72 00 00 00 E2 B9 C4 D4 ED CA 85 C3 DB 1E EE F2 88 26 D6 C0 DC 58 68 F8 AC DA F2 DE CC 47 DB 72 E0 F7 C5 4F 13 DB BF 95 CD FC F7 A0 C5 92 3E 7B AA FE 93 D9 63 CB FA 68 EC 8B D5 54 FE 3B 69 BA A7 C7 37 F6 D8 DA 9B 39 72 A5 FF D2 6B 13 8B 81 AE D9 37 F9 9F FE DA D3 6D 9A C4 77 6B 7E 9C 8A 0C 86 37 96 76 F7 32 23 53 EB 70 30 9F CF AB CD 25 A0 D1 16 14 14 BE E8 F3 B9 9D 41 96 0E B2 9E 7A 63 2A E6 A2 BD 0E 8F D3 E5 F5 BA 03 3A 07 6B 77 B9 9B 69 86 65 68 A6 95 33 1B 41 0F 00 00 00 00 00 09 80 D7 CC C1 8F 2E 83 A6 EE DB 9F 3E D3 70 01 31 76 97 AC D3 40 3B 91 73 20 27 76 82 7A F1 E9 DA 1E EC 6B 47 FB 74 9B 68 00 1F 3B 5D E7 CF 93 5A 4E E3 7D 3A 52 B1 2B D2 75 7D A3 FF 2D B1 CF F0 C2 6C A4 AB 56 3D EC 1A FE 76 DB 3E 99 5D 9A DC CC 4C F4 3F 56 38 F6 CD 5C B1 6C 62 FE 4E 41 52 3A 6C ED DA 1B D9 FD 1E EB 2D F7 8B 47 E7 09 F1 9F 46 57 37 2D 66 E7 68 B4 73 7F C9 9F 64 2E A5 2F 3C EE 6E 5F 53 EE 13 86 C3 A7 D3 57 BF C3 FB 5A 46 FF F2 75 00 00 6A 18 E7 D3 D3 DD DB FE FD CC FC 3D 39 90 74 15 D3 D3 43 DF C9 D1 9F D0 FD D2 3D FD E4 FD FC 1E DB 01 CB DC CC DF DE D3 CC C8 CF DF D0 CF E2 03 E3 17 40 03 FF CB D4 CA C9 CA E7 FF CD DF E5 E6 EF CB D5 D1 EB EF CF E0 C9 E4 C9 D8 D4 CA CB 05 52 12 DB D8 D8 93 02 05 A5 15 FB 5C 92 09 05 07 DF ED 07 CC F1 07 CB 15 15 E9 09 00 00 49 08 07 09 08 07 08 0E 0C 02 00 0E 0D 07 06 0A 02 04 04 13 05 03 0D 05 0E 03 11 03 1B 1A 1F 0C 10 10 08 03 04 05 0B 05 0E 04 13 05 1F 02 07 10 05 13 07 0A 12 04 02 18 0A 09 08 1A 06 19 00 34 08 08 00 08 0E 0B 26 04 00 0C 00 00 32 23 0D 18 03 35 04 3B 3E 2E 05 04 02 00 32 34 0A 32 09 13 02 07 0D 03 05 02 00 0A 03 07 0C 09 01 05 05 02 1E 08 1B 0A 03 02 FF 05 07 0A 1F 04 1F 1F 09 20 40 B9 07 41 B4 48 38 AA 30 1E 18 53 D7 40 F1 40 00 26 F0 AE D0 C6 D4 00 40 D2 02 80 0D BA 43 E2 7B 14 C0 82 20 A7 08 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("BlowingBubbles"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.WakeUpEnabled = true;
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
                Settings.Default.WakeUpEnabled = false;
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
