using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
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

            label1.Text = Settings.Default.pakPath;
        }

        private void ConvertitemsBtn_Click(object sender, EventArgs e)
        {
            int num = 0;
            string text = "";

            if (Settings.Default.SparkleSpecialistEnabled == true)
            {
                num++;
                text += "Sparkle Specialist," + " ";
            }
            if (Settings.Default.headhunterEnabled == true)
            {
                num++;
                text += "Head Hunter (Assault Trooper)," + " ";
            }
            if (Settings.Default.ReconExpertEnabled == true)
            {
                num++;
                text += "Recon Expert," + " ";
            }
            if (Settings.Default.RamirezEnabled == true)
            {
                num++;
                text += "Ramirez (Commando)," + " ";
            }
            if (Settings.Default.RamirezAAEnabled == true)
            {
                num++;
                text += "Ramirez (Arctic Assassin)," + " ";
            }
            if (Settings.Default.BansheeRenEnabled == true)
            {
                num++;
                text += "WildCat (Renegade)," + " ";
            }
            if (Settings.Default.BansheeEnabled == true)
            {
                num++;
                text += "WildCat (Dominator)," + " ";
            }
            if (Settings.Default.BansheeTOEnabled == true)
            {
                num++;
                text += "WildCat (Tactics Officer)," + " ";
            }
            if (Settings.Default.WildcatEnabled == true)
            {
                num++;
                text += "Wildcat (Pathfinder)," + " ";
            }
            if (Settings.Default.sunbirdEnabled == true)
            {
                num++;
                text += "Shadowbird," + " ";
            }
            if (Settings.Default.SpitfireEnabled == true)
            {
                num++;
                text += "Spitfire," + " ";
            }
            if (Settings.Default.RenegadeEnabled == true)
            {
                num++;
                text += "Renegade," + " ";
            }
            if (Settings.Default.candyaxeEnabled == true)
            {
                num++;
                text += "Candy Axe," + " ";
            }
            if (Settings.Default.BlackShieldEnabled == true)
            {
                num++;
                text += "Black Shield," + " ";
            }
            if (Settings.Default.BattleShroudEnabled == true)
            {
                num++;
                text += "Battle Shroud," + " ";
            }
            if (Settings.Default.DazzleEnabled == true)
            {
                num++;
                text += "Dazzle," + " ";
            }
            if (Settings.Default.IronBeakEnabled == true)
            {
                num++;
                text += "Iron Beak," + " ";
            }
            if (Settings.Default.SkullySplitterEnabled == true)
            {
                num++;
                text += "Skully Splitter," + " ";
            }
            if (Settings.Default.TatAxeEnabled == true)
            {
                num++;
                text += "Tat Axe," + " ";
            }
            if (Settings.Default.IronCageEnabled == true)
            {
                num++;
                text += "Iron Cage," + " ";
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

        /*private void selectPakPathButton_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                Title = "Choose Pak File Directory",
                IsFolderPicker = true,
                InitialDirectory = "C:\\"
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists($"{dialog.FileName}\\pakchunk10-WindowsClient.pak"))
                {
                    label1.Text = dialog.FileName;
                    Settings.Default.pakPath = label1.Text;
                    Settings.Default.Save();
                    label1.Text = Settings.Default.pakPath;
                }
                else
                    MessageBox.Show("Please select the correct directory!", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

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
            new BackupVerify().ShowDialog();
        }

        private void MusicSwitch_Click(object sender, EventArgs e)
        {
            Music MusicController = new Music();
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
