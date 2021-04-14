using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicyIndustries_Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimationSidebarReturn.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarFirst.Show(Sidebar);
            }
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
    }
}
