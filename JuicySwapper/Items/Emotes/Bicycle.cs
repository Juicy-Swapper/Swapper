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
    public partial class Bicycle : Form
    {
        bool enabled = Settings.Default.BicycleEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Hang Loose Celebration";

        public Bicycle()
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

        string Emote = "8C 0A 00 05 89 88 05 87 04 00 00 00 00 00 00 00 00 04 06 00 20 04 80 A0 08 40 00 00 00 A3 05 E8 05 68 01 50 07 78 07 C0 D8 07 50 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 53 74 65 70 42 72 65 61 6B 64 61 6E 63 65 5F 5F 43 4D 46 5F 4D 00 6B 2E 4D 4D 36 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 73 2F 45 49 44 00 48 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 45 2D 4A 2D 4C 00 6B 2E 67 2E 00 13 2F 53 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 05 43 6C 61 73 73 00 19 54 79 70 65 2E 44 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 32 53 6F 75 72 63 65 2E 53 68 6F 70 00 29 43 31 32 2E 42 61 74 74 6C 65 50 61 73 73 2E 50 61 69 64 00 22 44 65 66 61 75 6C 74 5F 5F 0B 44 65 73 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 52 61 72 65 00 12 11 43 6F 6F 6C 64 6F 77 53 63 73 00 0C 45 6E 75 6D 50 72 6F 70 65 72 74 79 00 0D 46 6C 6F 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0B 49 6E 11 4C 72 67 65 50 72 65 76 69 65 77 49 6D 61 67 00 04 4E 6F 6E 65 00 07 50 61 63 6B 0C 4C 6F 6F 70 73 00 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 64 C1 93 0A 20 FB D4 AB 31 5F FD C7 1E 5B D7 26 1A EA 47 1F E5 49 1A B0 BB 17 C2 CC FD A3 2F E3 46 2C 07 0C 92 42 5A 77 D2 40 AF 4D 2F 53 C9 82 C1 1E 98 6B 88 45 DE 6B A1 99 31 BE C7 80 7F C3 12 1F D2 7C F0 03 4A 69 2E 42 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 A2 F0 9F 7F D8 BE 95 89 9F 34 7B 25 3E 97 A2 09 99 BD 2F 88 61 99 ED 15 DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D 1D F6 C4 BF B6 76 4A 68 B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 DB 6F A3 73 A1 40 EA 11 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 0A 60 9C 4E 14 47 BD 21 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 A0 08 3B 01 19 00 FF FF FF FF FF FF FF FF D4 EF 8A 23 42 AF B7 A3 0B 00 00 00 02 00 01 19 04 01 02 02 02 3C 02 0D 06 02 02 0A 05 03 00 80 3F 02 21 35 39 39 44 35 35 44 35 34 31 42 32 35 31 30 31 41 44 42 36 34 34 38 41 38 41 42 41 42 39 39 33 00 0C 00 00 00 53 69 64 65 20 48 75 73 74 6C 65 00 08 35 38 43 44 44 45 42 35 34 45 38 32 37 38 43 45 38 41 35 31 41 34 35 39 43 30 33 36 37 37 00 06 00 37 31 46 43 43 36 43 44 46 43 39 32 35 34 38 44 45 38 42 38 39 45 31 43 33 42 41 35 37 38 54 68 65 20 77 68 6F 6C 65 20 77 6F 72 6C 64 27 73 20 6F 6E 20 79 6F 75 72 20 73 69 64 65 2E 20 10 12 11 13 08 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C7 C0 96 96 92 92 92 92 99 5A 87 87 32 87 8D 87 87 35 71 87 79 F8 F8 F8 F8 A8 79 D8 78 F0 F0 F0 F0 C0 F9 F0 F0 F0 F0 D0 F9 78 B9 87 87 87 22 7D 32 87 31 87 47 22 31 7B F9 F8 F8 F8 E0 7C F8 F8 F8 F0 79 F8 98 F9 F8 F8 F8 E0 79 F8 8C 87 87 44 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 49 30 2E 51 93 8F 63 27 7F 38 87 87 87 87 79 D8 24 38 22 21 22 87 59 87 79 A0 29 8F 89 87 87 8F 49 59 5A 87 6C 53 8A 87 8F 87 25 39 3F 31 87 66 6E 2D 50 21 58 4C 38 22 00 30 32 B2 87 41 40 40 87 42 5C 99 B9 87 87 7A 68 53 99 87 87 87 87 87 87 87 71 8F 87 87 87 9C 28 71 87 89 87 8E 87 2A 87 87 87 87 2C 39 39 B9 B9 59 52 00 30 00 0F 00 16 00 15 00 52 00 1B 00 BF 00 6D 00 2A 00 3E 00 38 00 A9 00 A8 00 0F 00 0E 00 4A 00 4C 00 6D 00 1F 00 15 00 8D 00 16 00 9B 00 4C 02 0B 00 03 02 F2 01 07 02 34 00 18 02 51 02 A2 00 1B 00 37 00 5F 00 1B 00 37 00 A8 00 FE 00 0D 00 01 01 17 01 26 01 0D 00 E2 02 E5 00 0F 00 73 01 0D 00 96 01 3E 00 0F 00 1D 00 CD 00 F0 01 07 01 58 00 46 02 7F 00 41 00 10 00 0E 00 A9 05 08 00 96 01 08 00 40 00 10 00 58 00 80 07 0C 00 22 00 FA 07 1A 00 3F 00 A3 03 78 00 25 00 D5 00 E1 00 08 00 05 01 00 00 00 FE 13 00 8C";
        string Emote1 = "8C 06 00 05 2F 88 05 2D 04 00 00 00 00 00 00 00 40 10 7C 03 F9 48 B8 0E 4E FB 86 CC 30 92 54 92 31 44 9A 68 C1 61 82 20 A3 2E AF 08 4A 22 3C 96 1B A6 BE 0D F8 A0 44 80 91 41 3A 05 1A 2C 4A B3 39 02 4C A5 B4 69 9D BD 75 89 3A CF 64 B6 E6 CE 99 4E 76 EE 9A 63 85 2D 26 44 ED 7B 2C 48 CB 2E 87 E7 54 67 76 26 CE 29 3D 68 67 28 B1 AF 01 00 8C 00 30 04 30 0B A0 09 02 DC A3 92 EE 24 1F 10 91 9C C4 4C 06 B3 11 4B 20 8E 54 85 60 CE C3 51 1E 95 41 E0 27 D1 41 99 53 CC E6 8E D8 1E 4E 62 F1 61 AE 42 C4 08 41 65 12 63 1E B0 C8 2A 55 12 F0 16 24 DA 52 38 0E 36 24 20 04 38 15 F1 F0 C5 48 35 74 63 03 21 21 C5 9B 24 32 08 6A 85 C8 CB C5 06 39 38 90 46 40 00 21 20 8A 5E 56 43 72 48 08 A9 D1 A2 D5 48 4D 5D 9B FF C6 1D EA B5 F1 F4 D5 D0 CD C4 FD A9 E5 AF 57 72 2C 65 F6 5C B9 05 AD 00 79 71 00 DD 62 10 51 BC 2A F2 02 F6 AA 14 27 44 7C 89 80 2A FA 93 6C 92 A7 44 C5 1F 92 70 B4 C7 27 E2 94 5F 34 7B CD 16 08 F1 94 DC 85 41 55 85 B0 02 58 18 90 B1 87 CF 43 90 B1 F8 64 4C 68 C2 85 24 9A 51 83 C1 A8 07 A9 C5 4A 67 37 0F 4D 72 39 89 8A 9C 3E 25 E3 8C 0F 01 41 58 2F 22 8C 71 12 77 E2 60 02 77 48 F9 2A 57 46 0C A8 BC 5F 3F F1 84 5E FE 79 E3 B7 4F 97 66 7D FA DE 56 6A 78 D2 3B B3 70 7C EF 16 DF DD 55 32 02 25 5A D8 CC ED A3 F2 A1 E8 26 8C D7 DF 02 56 63 AE BB B9 5D 5B DE AB ED DB 9C 69 BD 29 02 93 57 10 52 84 09 E9 8B 8E A2 B9 63 FB CC 98 8E FE 08 AA B3 14 84 B5 25 06 20 C6 90 AC 04 26 99 CA F1 58 22 17 EA 6F 0A C5 45 8A F2 16 C9 09 62 90 85 AB 8C 25 05 E7 EA AD 1C 97 50 FA 15 89 94 BC 7D 55 DE 7A 4A B2 50 04 F6 E6 C2 4C 55 85 4A 80 71 39 60 8D EC 20 AA 8A 53 0A 62 34 00 81 22 E7 85 11 43 30 50 44 45 86 D7 41 06 E8 01 1E F2 01 0F C6 A5 00 77 FE 5E 90 8E 05 F4 6F 35 1C 9D 7F F8 D7 AB 62 E2 7C FA E2 F1 F7 ED 6F 14 52 53 BF CE 7C 1E DD BC 5F 3A FE EF 3F 6D 26 E9 CC 37 03 9F 4D D4 5D D6 85 7A 6E 2C 25 B2 CB E2 E9 DE DE 35 65 43 F3 B4 B9 E1 99 FF 87 BE 3D 54 51 3B 71 E5 F4 99 8E C9 45 D8 D9 55 AA C4 74 54 FF B8 EE 11 FB 24 67 BF F8 76 4F 89 5D BA FD 40 D2 64 B3 D9 4D 66 16 20 57 AB D5 E6 BD E9 B0 D2 0D 1E A7 BB C1 CA 78 F4 20 76 28 E0 69 64 DD 0C E3 F6 BA E9 7C 27 EB F0 D8 69 AB B3 91 B5 87 65 5E 94 14 39 2D 12 B9 BC 00 00 00 00 3F 09 1B 68 6B F4 CF C5 8F D7 9B 1F 7C 32 BC E6 BF 14 9D 5E 98 DE 7F 71 1E 3D FB E3 3E EE 6C A9 FD 94 4B 98 1C 2A CC F9 EF 5A FC F7 3E FF F6 C1 96 9A 0A F5 9D 5F CA DA 4C 0B E9 D9 56 D7 89 5D 73 5F AA E6 7A 51 E7 7C B2 FA 44 19 A6 A6 02 B7 0A E5 AE E1 BC 73 CF 9F 5D 9D 1B 79 A9 E8 54 A1 29 29 5D BF D2 72 88 6E 86 6C 76 75 DF 97 A0 AD D2 B6 E4 17 0D D5 D2 56 3B 63 B3 79 BD 36 16 00 19 89 D1 C3 FA 18 9F 93 75 38 6D E0 62 7D 3E 9A B6 D6 7B 5C EE 5A 6C 34 1A 71 CA 88 33 2F 97 ED D1 01 00 00 00 00 00 01 A3 29 8D C7 05 64 42 B1 C4 0C 5D EB BA 70 6B EE CD 97 07 6D 0C BC 3A 74 EE DE B3 81 70 46 20 70 AD 63 6D CD 9B 2E 32 34 71 96 8E 6D 12 DA 34 68 31 6A EC 76 6C D9 55 0A B6 38 35 27 7B 69 7E B0 3C 60 B1 87 F6 A0 FC 90 D0 FF 93 B1 FC AF C7 BC 4F 74 F1 99 19 1D CF 0E DA 17 BB F1 91 8E 47 D2 F4 BD 0C 66 4E B5 B9 2D 5F 5E 65 DF C3 13 97 BB 91 F9 D2 EE 58 FD AA FC 5F 87 6D CF 83 98 44 CB 72 76 20 A9 74 78 FA 35 37 39 1E 4E F7 5B 0B A6 D5 6B A6 E9 ED CC 4D 3D 35 06 2F B8 3A 6C 2F D3 00 00 6F 18 07 E6 D3 13 D5 DB D4 FD F9 38 FD 3D 39 78 68 15 CB D2 D3 43 DB CA D1 D7 D8 FD DA 3D FD D4 FD FC 2E DB 01 CB DC CC DF DE D3 CC C8 CF DF D0 CF E2 03 EB CB BB 94 43 FF CB D4 CA C9 CA E7 FF CD DF E5 E6 EF E3 D7 D7 D1 EB EF CF E0 C9 E4 C9 D8 D4 CA CB 05 52 12 DB D8 D8 93 02 05 A5 15 FB EC E3 05 EF 03 07 CC F1 07 CF D5 D5 15 15 15 05 00 00 4E 08 07 06 03 00 0A 0E 07 0C 00 01 00 07 06 0E 0A 02 04 0E 00 05 03 0D 05 0E 03 14 03 1B 1A 1F 0C 10 17 08 03 0F 07 00 06 05 09 1F 1E 05 1A 0D 07 1B 05 1E 06 05 05 18 0F 00 1E 07 09 08 10 06 1F 00 3C 08 08 00 0A 32 02 07 2B 00 0D 09 00 00 00 35 1E 0D 16 03 31 37 40 28 05 04 02 00 30 32 10 30 07 13 02 07 0D 03 05 02 00 08 04 03 09 0C 09 01 05 05 02 1E 08 00 20 04 0A 03 02 FF 05 07 0C 00 2F 13 07 1F 1D 20 05 0A 08 45 60 0A 3D F1 22 A0 00 69 90 2E 57 00 03 51 E6 FA C6 00 38 89 80 C2 E5 33 9F 07 A0 87 FF 8A 2A 0E 12 0D E8 40 67 89 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("SideHustle"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.BicycleEnabled = true;
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
                Settings.Default.BicycleEnabled = false;
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
