using JuicySwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
            ActiveControl = label1;
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            new Links().ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
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
                if (File.Exists($"{dialog.FileName}\\pakchunk10-WindowsClient.pak"))
                {
                    pakPathTextbox.Text = dialog.FileName;
                    Settings.Default.pakPath = pakPathTextbox.Text;
                    Settings.Default.Save();
                    pakPathTextbox.Text = Settings.Default.pakPath;
                }
                else
                    MessageBox.Show("Please select the correct directory!", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            pakPathTextbox.Text = Settings.Default.pakPath;
        }

        private void resetConfigButton_Click(object sender, EventArgs e)
        {
            new ResetConfirm().ShowDialog();
        }

        private void convertedItemsButton_Click(object sender, EventArgs e)
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

        private void updateCheckButton_Click(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.Proxy = null;
                    string text = webClient.DownloadString("https://juicyswapper.xyz/api/version").ToString();
                    if (text != Application.ProductVersion)
                        MessageBox.Show("You are using an outdated version of Juicy Swapper! " + ("The most recent version of Juicy Swapper is v" + text) + " and you are currently using v" + Application.ProductVersion + ". Please close the swapper and launch 'Juicy Updater.exe'");

                    else
                        MessageBox.Show("You are up to date, and you are currently using v" + Application.ProductVersion + ".");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: SERVER_ERROR");
                }
            }
        }

        private void advancedButton_Click(object sender, EventArgs e)
        {
            new AdvancedSettings().ShowDialog();
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
    }
}
