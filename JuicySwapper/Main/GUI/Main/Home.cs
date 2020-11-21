using DiscordRPC;
using JuicySwapper.Main.GUI;
using JuicySwapper.Panels;
using JuicySwapper.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuicySwapper
{
    public partial class Home : Form
    {
        public static string Rpc;
        public static byte hold;
        public DiscordRpcClient discordRpcClient_0 = new DiscordRpcClient("704324460291031047");

        public static string GetPaksFolder
        {
            get { return Settings.Default.pakPath; }
        }

        public Home()
        {
            InitializeComponent();

            Settings.Default.pakPath = Settings.Default.InstallationPath + "\\FortniteGame\\Content\\Paks";
            Settings.Default.Save();

            label1.Text = "Welcome, " + Environment.UserName;

            JuicyUtilities.SetRPCAction("In Dashboard", "dashimg");

            Sidebar.Visible = false;
            Sidebar.Width = 68;
            SidebarWrapper.Width = 90;
            LineaSidebar.Width = 52;
            AnimacionSidebar.Show(Sidebar);
            hold = 0;
            Rpc = "InDashboard";
            if (!Wrapper.Controls.Contains(DashPanel.Instance))
            {
                Wrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }
        
        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) //Display DashPanel
        {
            JuicyUtilities.SetRPCLocation("In Dashboard", "dashimg");
            Rpc = "InDashboard";
            hold = 0;
            MoveToDash.Enabled = true;
            if (!Wrapper.Controls.Contains(DashPanel.Instance))
            {
                Wrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) //Display SkinsPanel
        {
            JuicyUtilities.SetRPCLocation("Skins", "skinimg");
            Rpc = "Skins";
            hold = 1;
            MoveToSkin.Enabled = true;
            if (!Wrapper.Controls.Contains(SkinsPanel.Instance))
            {
                Wrapper.Controls.Add(SkinsPanel.Instance);
                SkinsPanel.Instance.Dock = DockStyle.Fill;
                SkinsPanel.Instance.BringToFront();
            }
            else
                SkinsPanel.Instance.BringToFront();
        }  

        private void bunifuFlatButton3_Click(object sender, EventArgs e) //Display BackblingsPanel
        {
            JuicyUtilities.SetRPCLocation("Backblings", "backblingimg");
            Rpc = "Backblings";
            hold = 2;
            MoveToBack.Enabled = true;
            if (!Wrapper.Controls.Contains(BackblingsPanel.Instance))
            {
                Wrapper.Controls.Add(BackblingsPanel.Instance);
                BackblingsPanel.Instance.Dock = DockStyle.Fill;
                BackblingsPanel.Instance.BringToFront();
            }
            else
                BackblingsPanel.Instance.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e) //Display PickaxesPanel
        {
            JuicyUtilities.SetRPCLocation("Pickaxes", "pickaxeimg");
            Rpc = "Pickaxes";
            hold = 3;
            MoveToPick.Enabled = true;
            if (!Wrapper.Controls.Contains(PickaxesPanel.Instance))
            {
                Wrapper.Controls.Add(PickaxesPanel.Instance);
                PickaxesPanel.Instance.Dock = DockStyle.Fill;
                PickaxesPanel.Instance.BringToFront();
            }
            else
                PickaxesPanel.Instance.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e) //Display EmotesPanel
        {
            new EmoteWarning().ShowDialog();
            JuicyUtilities.SetRPCLocation("Emotes", "emoteimg");
            Rpc = "Emotes";
            hold = 4;
            MoveToEmote.Enabled = true;
            if (!Wrapper.Controls.Contains(EmotesPanel.Instance))
            {
                Wrapper.Controls.Add(EmotesPanel.Instance);
                EmotesPanel.Instance.Dock = DockStyle.Fill;
                EmotesPanel.Instance.BringToFront();
            }
            else
                EmotesPanel.Instance.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e) //Display WrapsPanel
        {
            JuicyUtilities.SetRPCLocation("Miscellaneous", "miscellaneousimg");
            Rpc = "Miscellaneous";
            hold = 4;
            MoveToWraps.Enabled = true;
            if (!Wrapper.Controls.Contains(MiscPanel.Instance))
            {
                Wrapper.Controls.Add(MiscPanel.Instance);
                MiscPanel.Instance.Dock = DockStyle.Fill;
                MiscPanel.Instance.BringToFront();
            }
            else
                MiscPanel.Instance.BringToFront();
        }

        private void displaySettings_Click(object sender, EventArgs e)
        {
            JuicyUtilities.SetRPCLocation("Settings", "settingsimg");
            new SettingsMenu().ShowDialog();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void MoveToDash_Tick(object sender, EventArgs e)
        {
            SkinButton.Enabled = false;
            BackblingButton.Enabled = false;
            PickaxeButton.Enabled = false;
            EmoteButton.Enabled = false;
            WrapsButton.Enabled = false;
            SettingsButton.Enabled = false;

            if (ControlBar.Location.Y > 91)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y - 2);
            }
            else
            {
                MoveToDash.Enabled = false;
                SkinButton.Enabled = true;
                BackblingButton.Enabled = true;
                PickaxeButton.Enabled = true;
                EmoteButton.Enabled = true;
                WrapsButton.Enabled = true;
                SettingsButton.Enabled = true;
            }
        }
        private void MoveToSkin_Tick(object sender, EventArgs e)
        {
            DashButton.Enabled = false;
            BackblingButton.Enabled = false;
            PickaxeButton.Enabled = false;
            EmoteButton.Enabled = false;
            WrapsButton.Enabled = false;
            SettingsButton.Enabled = false;

            if (ControlBar.Location.Y > 161)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y - 2);
            }
            else if (ControlBar.Location.Y < 161)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y + 2);
            }
            else
            {
                MoveToSkin.Enabled = false;
                DashButton.Enabled = true;
                BackblingButton.Enabled = true;
                PickaxeButton.Enabled = true;
                EmoteButton.Enabled = true;
                WrapsButton.Enabled = true;
                SettingsButton.Enabled = true;
            }
        }

        private void MoveToBack_Tick(object sender, EventArgs e)
        {
            DashButton.Enabled = false;
            SkinButton.Enabled = false;
            PickaxeButton.Enabled = false;
            EmoteButton.Enabled = false;
            WrapsButton.Enabled = false;
            SettingsButton.Enabled = false;

            if (ControlBar.Location.Y > 231)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y - 2);
            }
            else if (ControlBar.Location.Y < 231)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y + 2);
            }
            else
            {
                MoveToBack.Enabled = false;
                DashButton.Enabled = true;
                SkinButton.Enabled = true;
                PickaxeButton.Enabled = true;
                EmoteButton.Enabled = true;
                WrapsButton.Enabled = true;
                SettingsButton.Enabled = true;
            }
        }

        private void MoveToPick_Tick(object sender, EventArgs e)
        {
            DashButton.Enabled = false;
            BackblingButton.Enabled = false;
            SkinButton.Enabled = false;
            EmoteButton.Enabled = false;
            WrapsButton.Enabled = false;
            SettingsButton.Enabled = false;

            if (ControlBar.Location.Y > 301)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y - 2);
            }
            else if (ControlBar.Location.Y < 301)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y + 2);
            }
            else
            {
                MoveToPick.Enabled = false;
                DashButton.Enabled = true;
                BackblingButton.Enabled = true;
                SkinButton.Enabled = true;
                EmoteButton.Enabled = true;
                WrapsButton.Enabled = true;
                SettingsButton.Enabled = true;
            }
        }

        private void MoveToEmote_Tick(object sender, EventArgs e)
        {
            DashButton.Enabled = false;
            BackblingButton.Enabled = false;
            PickaxeButton.Enabled = false;
            SkinButton.Enabled = false;
            WrapsButton.Enabled = false;
            SettingsButton.Enabled = false;

            if (ControlBar.Location.Y > 371)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y - 2);
            }
            else if (ControlBar.Location.Y < 371)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y + 2);
            }
            else
            {
                MoveToEmote.Enabled = false;
                DashButton.Enabled = true;
                BackblingButton.Enabled = true;
                PickaxeButton.Enabled = true;
                SkinButton.Enabled = true;
                WrapsButton.Enabled = true;
                SettingsButton.Enabled = true;
            }
        }

        private void MoveToWraps_Tick(object sender, EventArgs e)
        {
            DashButton.Enabled = false;
            BackblingButton.Enabled = false;
            PickaxeButton.Enabled = false;
            EmoteButton.Enabled = false;
            SkinButton.Enabled = false;
            SettingsButton.Enabled = false;

            if (ControlBar.Location.Y > 441)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y - 2);
            }
            else if (ControlBar.Location.Y < 441)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y + 2);
            }
            else
            {
                MoveToWraps.Enabled = false;
                DashButton.Enabled = true;
                BackblingButton.Enabled = true;
                PickaxeButton.Enabled = true;
                EmoteButton.Enabled = true;
                SkinButton.Enabled = true;
                SettingsButton.Enabled = true;
            }
        }

        private void MoveToSettings_Tick(object sender, EventArgs e)
        {
            DashButton.Enabled = false;
            BackblingButton.Enabled = false;
            PickaxeButton.Enabled = false;
            EmoteButton.Enabled = false;
            WrapsButton.Enabled = false;
            SkinButton.Enabled = false;

            if (ControlBar.Location.Y > 511)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y - 2);
            }
            else if (ControlBar.Location.Y < 511)
            {
                ControlBar.Location = new Point(ControlBar.Location.X, ControlBar.Location.Y + 2);
            }
            else
            {
                MoveToSettings.Enabled = false;
                DashButton.Enabled = true;
                BackblingButton.Enabled = true;
                PickaxeButton.Enabled = true;
                EmoteButton.Enabled = true;
                WrapsButton.Enabled = true;
                SkinButton.Enabled = true;
            }
        }
    }
}
