using JuicySwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
            ActiveControl = label1;
            if (Settings.Default.MusicAct == true)
                MusicSwitch.Image = Resources.DesacMusic;
            else
                MusicSwitch.Image = Resources.ActivMusic;

            var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";

            label1.Text = Pathtopaks;
        }

        public static string swaptexts(string swap)
        {
            swap.ToLower();
            if (swap.Contains("renegade"))
            {
                return "Renegade Raider";
            }
            if (swap.Contains("ghoulog"))
            {
                return "Ghoul Trooper";
            }
            if (swap.Contains("wildcat"))
            {
                return "Wild Cat";
            }
            return "Nothing";
        }

        string AddSpaces(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) && text[i - 1] != ' ')
                    newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }

        private void ConvertitemsBtn_Click(object sender, EventArgs e)
        {
            if(Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            int num = 0;
            string text = "";

            //foreach (SettingsProperty currentProperty in Settings.Default.Properties)
            //{
            //    if (!currentProperty.Name.Contains("MusicAct"))
            //    {
            //        if (currentProperty.PropertyType == typeof(bool))
            //        {
            //            if((bool)Settings.Default[currentProperty.Name] == true)
            //            {
            //                var name = currentProperty.Name.Replace("Enabled", ",");
            //                var swaps = swaptexts(currentProperty.Name);
            //                if (swaps != "Nothing")
            //                {
            //                    num++;
            //                    text += $"{swaps} ";
            //                }
            //                else
            //                {
            //                    num++;
            //                    text += AddSpaces($"{name} ");

            //                }
            //            }
            //        }

            //    }
            //}

            //switch (num)
            //{
            //    case 0:
            //        MessageBox.Show("You don't have any converted items.", "Juicy Swapper - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;

            //    default:
            //        MessageBox.Show($"You currently have {num} item(s) converted: {text.Remove(text.Length - 1)}.", "Juicy Swapper - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //}

            //return;


            if (Settings.Default.BlackShieldEnabled == true)
            {
                num++;
                text += "Black Shield," + " ";
            }

            if (Settings.Default.BrenegadeEnabled == true)
            {
                num++;
                text += "Renegade Riader (BLAZE)," + " ";
            }
            if (Settings.Default.GhoulOGEnabled == true)
            {
                num++;
                text += "Pink ghoul," + " ";
            }
            if (Settings.Default.RrenegadeEnabled == true)
            {
                num++;
                text += "Renegade Raider (REDLINE)," + " ";
            }
            if (Settings.Default.GrenegadeEnabled == true)
            {
                num++;
                text += "Renegade Raider (GINGERBREAD)," + " ";
            }
            if (Settings.Default.WildcatBlueEnabled == true || Settings.Default.WildcatBlazeEnabled == true || Settings.Default.WildcatBlueBlazeEnabled || Settings.Default.WildcatNeoEnabled || Settings.Default.WildcatBlueSREnabled)
            {
                num++;
                text += "Wild Cat," + " ";
            }
            if (Settings.Default.SirenEnabled == true)
            {
                num++;
                text += "Siren," + " ";
            }
            if (Settings.Default.TravisEnabled == true)
            {
                num++;
                text += "Travis," + " ";
            }
            if (Settings.Default.BrenegadeCEnabled == true)
            {
                num++;
                text += "Renegade Raider (Checkered(BLAZE))," + " ";
            }
            if (Settings.Default.RrenegadeCEnabled == true)
            {
                num++;
                text += "Renegade Raider (Checkered(REDLINE))," + " ";
            }
            if (Settings.Default.FNCSEnabled == true)
            {
                num++;
                text += "FNCS," + " ";
            }
            if (Settings.Default.GrenegadeCEnabled == true)
            {
                num++;
                text += "Renegade Raider (Checkered(GINGERBREAD))," + " ";
            }
            if (Settings.Default.FreemixEnabled == true)
            {
                num++;
                text += "Free Mix," + " ";
            }
            if (Settings.Default.SixStringEnabled == true)
            {
                num++;
                text += "Six String," + " ";
            }
            if (Settings.Default.InsigniaEnabled == true)
            {
                num++;
                text += "Insignia," + " ";
            }
            if (Settings.Default.LoserfruitEnabled == true)
            {
                num++;
                text += "Loser fruit," + " ";
            }
            if (Settings.Default.StarwandEnabled == true || Settings.Default.StarwandRSEnabled == true)
            {
                num++;
                text += "Star wand," + " ";
            }
            if (Settings.Default.RaidersRevengeEnabled == true)
            {
                num++;
                text += "Raiders Revenge," + " ";
            }
            if (Settings.Default.GuandaoEnabled == true)
            {
                num++;
                text += "Guandao," + " ";
            }
            if (Settings.Default.AxecaliburEnabled == true)
            {
                num++;
                text += "Axe calibur," + " ";
            }
            if (Settings.Default.ChickenEnabled == true)
            {
                num++;
                text += "Chicken," + " ";
            }
            if (Settings.Default.TAKEtLEnabled == true)
            {
                num++;
                text += "Take The L," + " ";
            }
            if (Settings.Default.FlossEnabled == true || Settings.Default.FlossArmWaveEnabled)
            {
                num++;
                text += "Loserfruit," + " ";
            }
            if (Settings.Default.ScenarioEnabled == true)
            {
                num++;
                text += "Scenario," + " ";
            }
            if (Settings.Default.BlackShieldEnabled == true || Settings.Default.BlackShieldDSEnabled == true || Settings.Default.BlackShieldFSEnabled == true)
            {
                num++;
                text += "BlackShield," + " ";
            }
            if (Settings.Default.ReconSpecialistEnabled == true)
            {
                num++;
                text += "Recon Specialist," + " ";
            }
            if (Settings.Default.GalaxyEnabled == true)
            {
                num++;
                text += "Galaxy," + " ";
            }
            if (Settings.Default.SpectralSpineEnabled == true)
            {
                num++;
                text += " Spectral Spine," + " ";
            }
            if (Settings.Default.AerialAssaultTrooperEnabled == true)
            {
                num++;
                text += "Aerial Assault Trooper," + " ";
            }
            if (Settings.Default.HarleyHitterEnabled == true)
            {
                num++;
                text += "Harley Hitter," + " ";
            }
            if (Settings.Default.OctaneEnabled == true)
            {
                num++;
                text += "Lil' Octane," + " ";
            }
            if (Settings.Default.SaySoEnabled == true)
            {
                num++;
                text += " Say So," + " ";
            }
            if (Settings.Default.MegumiEnabled == true)
            {
                num++;
                text += "Megumi," + " ";
            }
            if (Settings.Default.YukiEnabled == true)
            {
                num++;
                text += "Yuki," + " ";
            }
            if (Settings.Default.ChigusaEnabled == true)
            {
                num++;
                text += "Chigusa," + " ";
            }
            if (Settings.Default.MeggEnabled == true)
            {
                num++;
                text += "Megg," + " ";
            }
            if (Settings.Default.IsabelleEnabled == true)
            {
                num++;
                text += "Isabelle," + " ";
            }
            if (Settings.Default.LeaveTheDoorOpenEnabled == true)
            {
                num++;
                text += "Leave The Door Open," + " ";
            }
            if (Settings.Default.RainbowCloverEnabled == true)
            {
                num++;
                text += "Rainbow Clover," + " ";
            }
            if (Settings.Default.HarleyQuinnRebirthEnabled == true)
            {
                num++;
                text += "Harley Quinn Rebirth," + " ";
            }
            if (Settings.Default.AloyEnabled == true || Settings.Default.AloyStyleEnabled)
            {
                num++;
                text += "Aloy," + " ";
            }
            if (Settings.Default.AloySpearEnabled == true)
            {
                num++;
                text += "Aloy's Spear," + " ";
            }
            if (Settings.Default.EcoEnabled == true)
            {
                num++;
                text += "Eco," + " ";
            }
            if (Settings.Default.GrimeyEnabled == true || Settings.Default.GrimeyBlazeEnabled)
            {
                num++;
                text += "Grimey," + " ";
            }
            if (Settings.Default.PrincessFishEnabled == true)
            {
                num++;
                text += "Princess Felicity Fish," + " ";
            }
            if (Settings.Default.SavageEnabled == true)
            {
                num++;
                text += "Savage," + " ";

            }
            if (Settings.Default.ChunLiEnabled == true)
            {
                num++;
                text += "Chun-Li," + " ";

            }
            if (Settings.Default.IkonikEnabled == true)
            {
                num++;
                text += "Ikonik," + " ";

            }
            if (Settings.Default.RueEnabled == true)
            {
                num++;
                text += "Rue," + " ";

            }
            if (Settings.Default.EchoEnabled == true)
            {
                num++;
                text += "Echo," + " ";

            }
            if (Settings.Default.FocusEnabled == true)
            {
                num++;
                text += "Focus," + " ";

            }
            if (Settings.Default.LaceEnabled == true)
            {
                num++;
                text += "Lace," + " ";

            }
            if (Settings.Default.ScourgeEnabled == true)
            {
                num++;
                text += "Lace," + " ";

            }
            if (Settings.Default.ChaosAgentEnabled == true)
            {
                num++;
                text += "Chaos Agent," + " ";

            }
            if (Settings.Default.AthleisureAssassinEnabled == true)
            {
                num++;
                text += "Athleisure Assassin," + " ";

            }
            if (Settings.Default.TropicalZoeyEnabled == true)
            {
                num++;
                text += "Tropical Punch Zoey," + " ";

            }
            if (Settings.Default.VictoriaSaintEnabled == true)
            {
                num++;
                text += "Victoria Saint," + " ";

            }
            if (Settings.Default.TechLlamaEnabled == true)
            {
                num++;
                text += "Brilliant Bomber," + " ";

            }
            if (Settings.Default.HushEnabled == true)
            {
                num++;
                text += "Hush," + " ";

            }
            if (Settings.Default.HarleyQuinnEnabled == true)
            {
                num++;
                text += "Harley Quinn," + " ";

            }
            if (Settings.Default.ManicEnabled == true)
            {
                num++;
                text += "Manic," + " ";

            }
            if (Settings.Default.ReysQuarterstaffEnabled == true)
            {
                num++;
                text += "Rey's Quarterstaff," + " ";

            }
            if (Settings.Default.CandyAxeEnabled == true)
            {
                num++;
                text += "Candy Axe," + " ";

            }
            if (Settings.Default.GalaxyAxeEnabled == true)
            {
                num++;
                text += "Stellar Axe," + " ";

            }
            if (Settings.Default.HitItEnabled == true)
            {
                num++;
                text += "Hit It," + " ";

            }
            if (Settings.Default.EliteAgentEnabled == true)
            {
                num++;
                text += "Elite Agent," + " ";

            }
            if (Settings.Default.TigeressEnabled == true)
            {
                num++;
                text += "Tigeress," + " ";

            }
            if (Settings.Default.PullUpEnabled == true)
            {
                num++;
                text += "Pull Up," + " ";

            }
            if (Settings.Default.CatComicEnabled == true)
            {
                num++;
                text += "Squash & Stretch," + " ";

            }
            if (Settings.Default.CatwomenEnabled == true)
            {
                num++;
                text += "Catwoman Zero," + " ";

            }
            if (Settings.Default.StoneViperEnabled == true)
            {
                num++;
                text += "Lyra," + " ";

            }
            if (Settings.Default.WakeUpEnabled == true)
            {
                num++;
                text += "Wake Up," + " ";

            }
            if (Settings.Default.WakeUpEnabled == true)
            {
                num++;
                text += "Wake Up," + " ";

            }
            if (Settings.Default.BicycleEnabled == true)
            {
                num++;
                text += "Hang Loose Celebration," + " ";

            }
            if (Settings.Default.ClipEnabled == true)
            {
                num++;
                text += "Clip," + " ";

            }
            if (Settings.Default.MariusEnabled == true)
            {
                num++;
                text += "Marius," + " ";

            }
            if (Settings.Default.BasketBallEnabled == true)
            {
                num++;
                text += "Dribblin'," + " ";

            }
            if (Settings.Default.DizzieEnabled == true)
            {
                num++;
                text += "Dizzie'," + " ";

            }
            if (Settings.Default.SpartanAssassinEnabled == true)
            {
                num++;
                text += "Spartan Assassin'," + " ";

            }
            if (Settings.Default.TheChampionEnabled == true)
            {
                num++;
                text += "The Champion'," + " ";

            }
            if (Settings.Default.LokBotEnabled == true)
            {
                num++;
                text += "Lok-Bot'," + " ";

            }
            if (Settings.Default.SocksEnabled == true)
            {
                num++;
                text += "Socks'," + " ";

            }
            if (Settings.Default.SpaceCuddleEnabled == true || Settings.Default.SpaceCuddleBlueEnabled || Settings.Default.SpaceCuddleWhiteEnabled)
            {
                num++;
                text += "Mecha Cuddle Master'," + " ";

            }
            if (Settings.Default.KelsierEnabled == true)
            {
                num++;
                text += "Kelsier'," + " ";

            }
            if (Settings.Default.DeathStrokeEnabled == true)
            {
                num++;
                text += "Deathstroke Zero'," + " ";

            }
            if (Settings.Default.SpireImmortalEnabled == true)
            {
                num++;
                text += "Spire Immortal'," + " ";

            }
            






































            switch (num)
            {
                case 0:
                    MessageBox.Show("You don't have any converted items.", "Juicy Swapper - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show($"You currently have {num} item(s) converted: {text.Remove(text.Length - 2)}.", "Juicy Swapper - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void selectPakPathButton_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                Title = "Choose Pak File Directory",
                IsFolderPicker = true,
                InitialDirectory = "C:\\"
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists($"{dialog.FileName}\\{Settings.Default.pak_skin_body}"))
                {
                    StringBuilder stringBuilder = new StringBuilder(Settings.Default.pakPath, 1000);
                    stringBuilder.Replace("\\FortniteGame\\Content\\Paks", "");
                    Settings.Default.InstallationPath = stringBuilder.ToString();
                    Settings.Default.Save();
                    var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";
                    label1.Text = Pathtopaks;
                }
                else
                    MessageBox.Show("Please select the correct directory!", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Home.Rpc == "Skins")
                JuicyUtilities.SetRPCLocation("Skins", "skinimg"); 

            else if (Home.Rpc == "Backblings")
                JuicyUtilities.SetRPCLocation("Backblings", "backblingimg");

            else if (Home.Rpc == "Pickaxes")
                JuicyUtilities.SetRPCLocation("Pickaxes", "pickaxeimg");

            else if (Home.Rpc == "Emotes")
                JuicyUtilities.SetRPCLocation("Emotes", "emoteimg");

            else if (Home.Rpc == "Miscellaneous")
                JuicyUtilities.SetRPCLocation("Miscellaneous", "miscellaneousimg");

            else if (Home.Rpc == "InDashboard")
                JuicyUtilities.SetRPCAction("In Dashboard", "dashimg");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetConfigBtn_Click(object sender, EventArgs e)
        {
            new ResetConfirm().ShowDialog();
        }

        private void Backupverifybtn_Click(object sender, EventArgs e)
        {

            String pakPath = Settings.Default.pakPath;

            //ucas
            File.Delete(pakPath + "\\pakchunk100_s3-WindowsClient.ucas");

            File.Delete(pakPath + "\\pakchunk100_s4-WindowsClient.ucas");

            File.Delete(pakPath + "\\pakchunk100_s5-WindowsClient.ucas");

            File.Delete(pakPath + "\\pakchunk100_s17-WindowsClient.ucas");

            File.Delete(pakPath + "\\pakchunk100_s22-WindowsClient.ucas");

            //utoc
            File.Delete(pakPath + "\\pakchunk100_s3-WindowsClient.utoc");

            File.Delete(pakPath + "\\pakchunk100_s4-WindowsClient.utoc");

            File.Delete(pakPath + "\\pakchunk100_s5-WindowsClient.utoc");

            File.Delete(pakPath + "\\pakchunk100_s17-WindowsClient.utoc");

            File.Delete(pakPath + "\\pakchunk100_s22-WindowsClient.utoc");

            //pak
            File.Delete(pakPath + "\\pakchunk100_s3-WindowsClient.pak");

            File.Delete(pakPath + "\\pakchunk100_s4-WindowsClient.pak");

            File.Delete(pakPath + "\\pakchunk100_s5-WindowsClient.pak");

            File.Delete(pakPath + "\\pakchunk100_s17-WindowsClient.pak");

            File.Delete(pakPath + "\\pakchunk100_s22-WindowsClient.pak");

            //sig
            File.Delete(pakPath + "\\pakchunk100_s3-WindowsClient.sig");

            File.Delete(pakPath + "\\pakchunk100_s4-WindowsClient.sig");

            File.Delete(pakPath + "\\pakchunk100_s5-WindowsClient.sig");

            File.Delete(pakPath + "\\pakchunk100_s17-WindowsClient.sig");

            File.Delete(pakPath + "\\pakchunk100_s22-WindowsClient.sig");

            foreach (SettingsProperty currentProperty in Settings.Default.Properties)
            {
                if (currentProperty.PropertyType == typeof(bool))
                    Settings.Default[currentProperty.Name] = false;

                Settings.Default.Save();
            }
            Close();

            DialogResult dialog = MessageBox.Show("Succesfull reverted all items.\nThis will restart the Swapper!", "Succesfull reverted all items.\nThis will restart the Swapper!", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    Application.Restart();
                }


                //new BackupVerify().ShowDialog();
            }

        private void MusicSwitch_Click(object sender, EventArgs e)
        {
            JuicyUtilities MusicController = new JuicyUtilities();
            if (Settings.Default.MusicAct != true)
            {
                MusicController.MusicControl(true);
                Settings.Default.MusicAct = true;
                Settings.Default.Save();
                MusicSwitch.Image = Resources.DesacMusic;
            }
            else
            {
                MusicController.MusicControl(false);
                Settings.Default.MusicAct = false;
                Settings.Default.Save();
                MusicSwitch.Image = Resources.ActivMusic;
            }
        }
    }
}
