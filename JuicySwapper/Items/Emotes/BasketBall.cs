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
    public partial class BasketBall : Form
    {
        bool enabled = Settings.Default.BasketBallEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Dribblin'";

        public BasketBall()
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

        string Emote = "8C 0A 00 06 46 88 06 44 06 00 00 00 00 00 00 00 00 04 93 00 20 04 80 45 0A 40 00 00 00 25 07 68 07 90 01 F8 08 20 09 68 09 80 04 5F 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73 2F 50 61 72 74 79 5F 4A 61 7A 7A 5F 54 77 69 6E 6B 6C 65 5F 54 6F 65 73 5F 5F 43 4D 46 5F 4D 00 80 2E 4D 4D 51 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 72 73 2F 43 49 44 5F 35 35 36 5F 5F 43 6F 6D 61 6E 64 6F 5F 46 5F 52 65 62 69 72 74 44 65 66 61 75 6C 74 41 00 7B 2E 3C 44 61 6E 63 49 44 00 4C 55 49 2F 46 6F 75 6E 64 54 65 78 74 75 72 65 73 2F 49 63 6F 6E 73 54 2D 2D 2D 4E 2F 2D 4C 00 73 2E 6F 2F 00 13 2F 53 63 72 69 70 74 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 70 6C 61 79 54 61 67 73 00 09 00 17 46 65 6D 61 6C 65 4F 76 65 72 72 69 64 65 00 19 44 65 66 69 6E 69 10 62 4D 6F 76 65 46 6F 72 77 61 72 64 4F 6E 6C 79 00 0C 69 6E 67 00 0C 42 6F 6F 6C 50 72 6F 70 65 72 74 79 00 05 43 6C 61 73 73 00 19 54 79 70 65 2E 00 1A 46 69 6C 72 2E 53 65 61 73 6F 2E 31 33 00 29 53 6F 75 72 63 65 31 33 2E 42 61 74 74 6C 65 50 61 73 73 2E 50 61 69 64 55 73 65 72 46 61 63 69 6E 67 46 6C 61 67 2E 54 72 61 76 65 72 73 61 6C 00 22 5F 5F 0B 44 65 73 69 73 4E 0B 45 52 61 72 69 74 79 00 11 3A 3A 52 61 72 65 00 18 11 43 6F 6F 6C 64 6F 77 6E 53 65 63 73 00 0C 45 6E 75 6D 0D 46 6C 6F 61 74 0B 00 14 43 6F 6E 74 61 69 6E 65 72 00 0C 0F 50 72 65 76 69 65 77 48 65 72 6F 00 11 4C 61 72 67 65 49 6D 61 67 65 00 04 4E 6F 6E 00 07 50 61 63 6B 06 0C 53 74 72 75 63 74 00 10 53 68 6F 72 74 11 53 6D 61 6C 6C 12 53 6F 66 74 0E 0C 54 65 78 10 57 61 6C 6B 53 70 65 65 64 64 C1 00 00 00 00 74 8F EA CA 58 10 1D E7 29 07 B5 5D 5C 49 CB EA 39 6A 6D 11 A5 57 3D 7F FA 20 D8 D0 23 6F B8 C5 FD 4A 66 04 60 44 B8 41 4A BD A9 21 1C 32 FB B6 98 9E E9 3A FB 26 E5 96 4A F7 27 19 E7 F9 4F CA 44 9C D0 67 47 89 DE 3C 99 34 F3 1D 48 50 C3 49 D4 5E 2F 85 36 72 D6 ED 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C BE EF EA 70 37 61 7D 63 F0 4D B5 88 0C 78 EC 4B 01 C0 35 55 A8 7C 3A E3 BD 42 3B E4 CB E2 F1 9F CE 80 53 49 06 22 AB 21 6D 6D 29 B9 A2 1E 30 CF DE 72 84 89 5C 9A 9C B3 AD 2B 3A 82 6E B6 DB 6B 1A 49 9A 22 A5 77 9C 64 DC 89 17 D7 37 5A D4 3A AC A6 19 D5 5D 2D B6 BC B8 14 5D 32 AF A3 70 4B DF 88 D1 A1 C2 23 B4 08 63 64 67 96 EF 89 0E DE F0 34 0E 22 8B 92 6F 39 F4 42 6C F3 51 98 47 18 80 22 F8 09 70 54 03 8D B3 70 92 03 9D 7A 8E 59 B3 7D E9 93 04 5B 26 C2 49 A9 9A F8 07 86 51 53 D6 3C 55 A9 1E BB 6B 14 C2 82 74 6B C8 5E FF 79 D9 C7 3D 10 6E D4 47 8C 0D 22 5A C5 BE 5A E3 77 9B 35 32 61 EC 52 A6 80 39 01 5A 81 FE 31 FD 3B C2 2D 35 A6 5B 0F 37 75 FA 86 1E 80 92 B9 C6 D6 62 6D 93 AB 1A AE 7B 81 8C 86 10 8D A1 65 4C 44 2F 98 52 99 C0 93 4D 00 84 C5 FC 69 09 FD D2 72 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 6D 96 ED 9B D4 26 21 AB DD CF 0B 7F 0B CA C2 D8 E8 CF 86 43 8A 24 FB 50 0A 03 68 8B 25 4D 09 6E E3 22 58 A5 6D 55 F8 70 0D FC B9 34 75 AE 70 78 3C CB 8A 60 E2 D4 31 70 45 0A 44 01 1E 00 FF FF FF FF FF FF FF FF D0 50 A8 F1 F2 DE 91 83 0B 00 00 00 02 00 01 01 02 01 02 04 02 10 04 04 02 2B 02 10 0D 06 02 02 0A 05 01 01 00 00 C8 42 03 00 01 80 3F 05 21 35 36 38 35 36 30 39 46 34 31 41 45 38 35 33 42 38 34 36 45 43 32 41 42 32 43 45 37 37 44 32 46 00 54 69 70 70 79 20 54 61 70 00 08 30 33 46 45 31 43 42 41 34 41 43 30 46 30 33 30 42 37 34 43 42 39 44 36 38 38 30 42 45 38 37 38 34 41 43 44 32 46 46 37 34 31 38 34 42 34 38 36 42 39 39 46 31 35 33 36 41 00 18 49 74 27 73 20 61 20 72 65 61 6C 20 74 6F 65 20 74 61 70 70 65 72 2E 15 17 16 18 0A 09 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 DC C0 96 96 92 92 92 92 92 99 41 87 87 32 87 8D 87 87 87 37 29 20 38 20 87 81 01 79 F8 90 01 81 01 F1 F0 40 B9 87 87 87 97 87 34 8C 87 8E 87 7B F8 F8 F8 F8 B0 79 F8 E0 F9 F0 24 7A B0 32 87 31 87 47 22 31 79 B0 FA F8 F8 F8 F8 7C F8 F8 F8 F8 98 79 F8 B8 FA F8 F8 F8 F8 78 F8 A8 87 8A 87 46 91 25 48 28 87 4B 4A 87 87 32 28 20 2E 87 87 25 2B 87 87 87 4A 30 2D 52 93 8F 55 BE 87 87 64 87 3F 87 3D 7A D8 24 38 22 21 22 87 59 87 79 D0 29 87 87 4C 4E 59 5A 87 6C 21 87 87 3C 87 8B 26 39 31 87 66 6E 2D 50 21 58 54 3D 2D 00 30 32 B2 87 41 40 40 87 42 5C 99 B9 87 8E 87 56 6A 7B 38 99 87 87 87 87 25 87 6C 87 8D 8D 87 2E 30 70 8C 8B 8C 8F 8E 9D 87 87 87 2A 39 39 B9 B9 59 5E 00 30 00 0F 00 1F 00 1E 00 1D 00 1C 00 1B 00 61 00 21 00 E3 00 E3 00 82 00 2A 00 53 00 7D 00 37 01 14 01 3E 00 94 01 93 01 0F 00 0E 00 4E 00 50 00 75 00 73 00 15 00 95 00 16 00 A3 00 4F 03 0B 00 21 02 10 02 25 02 34 00 12 00 B6 00 64 02 73 03 5E 00 1B 00 1C 00 2B 00 72 00 0E 03 E6 00 3C 01 0D 00 3F 01 55 01 64 01 0D 00 3E 03 89 00 2D 01 0F 00 B7 01 0D 00 DA 01 C5 00 12 00 0F 00 C9 00 2A 02 03 01 4A 00 80 02 B3 00 41 00 10 00 0E 00 3A 02 29 07 E7 08 08 00 40 00 10 00 58 00 28 09 0C 00 2D 00 3C 00 5A 00 22 00 D5 00 3D 00 2B 0A 04 05 76 00 50 0A CE 00 08 00 F2 00 00 00 00 04 03 05 FC 1F 00 8C 0A 00 06";
        string Emote1 = "8C 06 00 05 BB 88 05 B9 06 00 00 00 00 00 00 00 40 12 98 04 71 48 40 03 99 CE B2 58 4A 4A B3 B1 2A 24 FA D6 12 11 14 65 55 66 61 80 91 04 46 90 2C D3 4D 70 D8 49 7C 48 0A 31 3A 12 2A E3 47 21 85 24 38 98 99 96 36 F9 26 B9 6D 55 D9 1E D6 D6 67 68 AD 6D 65 D6 56 26 57 64 5C 6D 78 96 E6 71 3A AB 88 6B 59 D5 5E 54 4A AA 08 DC 01 00 9F 00 50 04 98 0A 60 18 03 A8 2A 52 72 50 16 23 0A 22 32 66 06 92 92 28 E1 48 A4 08 F3 30 85 29 4D D7 32 48 0B 7B 12 2A 52 13 49 1D E7 82 0E 84 43 09 D2 B9 42 94 54 08 AB A9 E5 44 D0 EC 76 E8 D2 D4 E7 85 2C 8B 93 42 9D 82 11 82 7A 9A 06 AC 24 97 A9 A8 BB 90 66 24 95 80 A4 C5 F1 44 29 A6 39 40 15 18 3D 1A 4D 61 A4 48 0E 44 A4 04 67 D6 42 A4 D0 86 80 95 F2 18 78 04 2A C2 96 AE 34 11 C3 69 93 52 29 A4 2B 74 C1 AA D6 3E D7 6F 05 B8 65 9D B1 E8 FC D2 7D AB 2F AB 4F 4D C7 4F 4E 3A 06 A6 EA 57 01 2A DF 03 A8 CA 40 02 51 A2 AE 88 12 0E E9 94 A6 4B 24 99 60 13 00 91 0C D2 35 15 0B 2C 21 6C C2 CB CA 29 1E 13 0E E9 2B 39 81 E2 50 61 45 7E 20 AE F5 F2 0A CE 85 15 7B 08 EC 00 10 13 29 D2 8D 41 D7 A5 B8 06 34 4D 73 A2 55 E5 F3 29 C9 62 51 09 2E B0 5A 63 16 44 07 52 5A 63 C4 A1 63 4D D4 78 91 4F 13 8C 6C 66 4D 34 23 BD B6 07 D7 AA 6A 4C AB 51 CD AC AE 40 2D 89 2E CB 23 50 01 21 88 E5 20 A3 83 3A FE 6B 78 77 FE 8D A3 E1 40 ED EC E6 29 67 FA B9 CE 96 C7 3B 6B A0 F0 49 73 BC 78 BA 3F AF C9 6F 0B 95 C9 B9 FA 05 3D 31 D0 8C 7A 21 6C 01 D1 C5 CF 19 63 18 40 4C 91 14 EB D2 45 82 29 4D 41 A4 6D 08 8F 6E 6E 60 48 34 CB E2 8D 21 12 F5 08 49 18 72 33 D2 AC 13 C1 C1 41 1C BD 59 A3 50 01 44 26 08 C5 FB 1B A6 9A 2A E9 0B 66 2F 3A A5 DE D5 D1 14 1C 38 2E 78 ED C6 AC 75 C5 CA 8B B8 C1 5C 51 D5 1C 2D 15 DA 09 7E 99 88 F4 49 59 09 3C E2 81 21 48 B2 B3 2C 25 74 44 70 78 27 12 5C 46 10 D5 4A 05 A2 8A 90 56 07 53 00 66 B8 C0 0C CA 80 21 CD BF 00 1F 3D DE 36 FD 7F 2E 3D EA 7E 2D 4C 91 9E EE 9A C1 9F A5 5B E8 DE FA DB A7 0F 5C 9B 75 F5 87 F0 21 F9 E3 0B EB 76 7E B6 F6 4A 78 5F AA BE EF D3 5F 8E D5 7D 3E E7 C7 29 C2 B6 F1 EE 8D 01 69 7B B1 AA 2C FB E1 1B 37 17 84 C7 E6 B5 37 D5 E9 8B 7F B3 76 D8 4E E5 5D 3D 81 35 4F ED 0B 72 4D 27 92 87 56 0E EE E5 7A B6 AE 13 7F FA E7 49 C5 F5 5A 79 57 CB 05 F3 E5 C1 97 AB 37 56 D9 E4 EC 89 C3 ED 4B 68 0E 4A A5 8B F7 DF 07 A3 C1 68 35 5A 2B AA 0D 67 8B 46 AF 97 0F 7A FC A1 20 EB E3 45 68 A5 83 2C EF F4 31 5E A7 DF 17 E4 78 B7 DF ED 0A 78 BC 0D CD 62 33 C2 60 82 17 AB 00 00 00 6D 7F FD 77 E3 DC C5 A1 1D 93 BF 59 EC BD B3 E1 4A FD 9E 49 77 7D C2 D1 E5 86 DE 36 E6 FC 9E 98 4D 3E E1 24 0B 8F B4 1D 9B 68 DB 3D E4 6B 6B B4 1F 77 65 D7 0F 8F 4B 0F DD B3 A9 CC BC 86 B1 F8 91 B2 77 56 99 86 77 0E 5E 3A 38 B0 F6 6C 61 F6 48 CD 99 6B 9E DB C5 3E 7A 78 BF 6F 70 CB A5 AD 87 37 6D EE DA 7E 1A 9E 3C D5 1A 95 7C CA 72 67 DA 1F AB 87 2F 6C 88 66 22 D7 F6 8D 3D C9 2D DF 30 02 4D A5 52 E9 C0 A8 19 0C 06 A3 C9 58 63 34 40 59 B9 C7 13 A0 FD 8C D7 E5 F2 B9 AA A7 3B 43 4C D0 DF EA 65 39 7F A8 C2 CD BA 7D 34 E3 0D D0 AD 50 C8 15 F2 59 00 A8 AF 06 00 00 00 00 00 06 85 E0 38 96 58 85 3A 64 17 DE 19 FB 71 EF 17 5E FC 06 7E 03 B8 C9 D3 B7 59 E3 8C A0 71 09 96 6E AD 43 BA 77 E2 D2 BC C0 E5 8D 1A 66 99 34 60 05 BC 1F 45 2A 54 A1 AC D5 FC F6 77 1A DE FC CA A9 B2 E3 EC DF DC F9 90 E4 6D B4 BC 1F E5 B5 EE 91 54 CE 44 76 A6 2B 1A E2 79 5B F1 51 E1 33 CB 36 78 6F DA 17 6F AF A9 B2 9D F4 A0 78 72 FD EB 19 58 3B 4E B6 47 15 96 F3 76 5B 0E C3 EF F2 DF 8E 8E EE A4 5F BD CF E4 FA 2D 5F 45 FE C8 EB FE FF CC EC 0C A9 9E ED 0E 8D 34 66 5A 2B 17 EF D7 93 CD E7 8E 65 88 AA EC A9 C1 FE FA 6D D5 92 FB 79 1D 18 7F 68 EE EF 76 36 75 A7 37 00 00 74 18 07 D9 D3 D3 F9 DB FF F9 38 FE 3D 39 78 6C 15 03 D3 FF FD 3D D3 D3 43 DB CA D1 FB FF FF FD FE FD DB 01 CB DC CC DF F7 D2 CC C8 CF CB 80 CD DF D0 CF E2 03 E3 17 40 03 EB D7 D7 FA E0 CB CC CB C9 CA E7 FF CD EF DF E5 E6 EF F9 D7 D1 EB 7A CF E0 F1 F4 F9 CC CB 05 D2 12 DB D8 D8 93 02 05 A5 15 FB 5C 27 E1 05 87 D0 EF 07 D0 F0 07 0B D7 D5 15 15 0D 90 00 00 50 08 07 01 00 07 09 07 0B 02 0B 05 06 1C 1B 07 06 15 06 08 0C 0D 1D 0D 0D 0E 0B 27 00 19 18 1D 0C 0A 0F 1C 24 06 03 04 03 0A 26 07 09 14 0B 17 1D 1C 05 26 01 0D 14 1F 05 12 0E 01 12 0B 18 0B 0C 08 0C 2B 34 00 08 08 00 06 0A 23 05 2C 0E 06 00 00 00 3F 22 0D 20 04 00 45 4B 4F 19 08 1A 40 19 0C 1E 05 04 02 00 01 3A 02 3C 14 3A 12 14 02 07 07 03 10 14 02 00 0A 03 07 01 0B 09 01 01 05 05 08 0B 03 08 20 0A 03 FF 05 07 18 00 1F 02 1F 1F 0D 06 21 57 27 40 19 18 00 48 C4 2A A2 DE 31 94 36 53 73 EB 65 00 29 9F C7 A0 00 B0 89 1A D0 C4 95 0B 03 81 F8 03 12 87 0A 84 44 61 04 68 A8 2B 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("TippyTap"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[4], SwapPath[4], Emote, Emote1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.BasketBallEnabled = true;
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
                Settings.Default.BasketBallEnabled = false;
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
