using JuicySwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
            ActiveControl = label1;
            if (Settings.Default.MusicAct == "True")
                MusicSwitch.Image = Resources.DesacMusic;
            else
                MusicSwitch.Image = Resources.ActivMusic;

            var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";

            label1.Text = Pathtopaks;
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
            if (Settings.Default.WildcatBlueEnabled == true || Settings.Default.WildcatBlazeEnabled == true || Settings.Default.WildcatBlueBlazeEnabled || Settings.Default.WildcatNeoEnabled)
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
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new BackupVerify().ShowDialog();
        }

        private void MusicSwitch_Click(object sender, EventArgs e)
        {
            JuicyUtilities MusicController = new JuicyUtilities();
            if (Settings.Default.MusicAct != "True")
            {
                MusicController.MusicControl("True");
                Settings.Default.MusicAct = "True";
                Settings.Default.Save();
                MusicSwitch.Image = Resources.DesacMusic;
            }
            else
            {
                MusicController.MusicControl("False");
                Settings.Default.MusicAct = "False";
                Settings.Default.Save();
                MusicSwitch.Image = Resources.ActivMusic;
            }
        }
    }
}
