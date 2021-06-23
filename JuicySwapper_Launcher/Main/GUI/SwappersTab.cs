using JuicySwapper_Launcher.Main.Classes;
using JuicySwapper_Launcher.Main.GUI;
using JuicySwapper_Launcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Launcher.Main
{
    public partial class SwappersTab : UserControl
    {
        private static SwappersTab _instance;
        public static SwappersTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SwappersTab();
                return _instance;
            }
        }

        public SwappersTab()
        {
            InitializeComponent();

            SwapperConfiguration.GetEveryStatus();

            switch (Settings.Default.SwapperStatus_Default)
            {
                case 0:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapper_Default_Update_icon;
                    break;

                case 1:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapper_Default_Offline_icon;
                    SwapperLauncherDefault.Enabled = false;
                    break;

                case 3:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapper_Update_icon;
                    break;
            }

            switch (Settings.Default.SwapperStatus)
            {
                case 0:
                    SwapperLauncher.Image = Resources.LaunchSwapper_Update_icon;
                    break;

                case 1:
                    SwapperLauncher.Image = Resources.LaunchSwapper_OFFLINE_icon;
                    SwapperLauncher.Enabled = false;
                    break;

                case 3:
                    SwapperLauncher.Image = Resources.LaunchSwapper_Install_icon;
                    break;
            }
        }

        private void SwapperLauncher_MouseEnter(object sender, EventArgs e)
        {
            switch (Settings.Default.SwapperStatus)
            {
                case 0:
                    SwapperLauncher.Image = Resources.LaunchSwapper_icon;
                    break;

                case 2:
                    SwapperLauncher.Image = Resources.LaunchSwapper_Update_Popout_icon;
                    break;

                case 3:
                    SwapperLauncher.Image = Resources.LaunchSwapper_Install_PopOut_icon;
                    break;
            }
        }

        private void SwapperLauncher_MouseLeave(object sender, EventArgs e)
        {
            switch (Settings.Default.SwapperStatus)
            {
                case 3:
                    SwapperLauncher.Image = Resources.LaunchSwapper_Install_icon;
                    break;

                default:
                    SwapperLauncher.Image = Resources.LaunchSwapper_Update_icon;
                    break;
            }
        }

        private void SwapperLauncher_Click(object sender, EventArgs e)
        {

        }

        private void SwapperLauncherDefault_MouseEnter(object sender, EventArgs e)
        {
            switch (Settings.Default.SwapperStatus_Default)
            {
                case 0:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapperDefault_icon;
                    break;

                case 2:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapper_Default_Update_icon;
                    break;

                case 3:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapper_Default_Install_popout_icon;
                    break;
            }
        }

        private void SwapperLauncherDefault_MouseLeave(object sender, EventArgs e)
        {
            switch (Settings.Default.SwapperStatus_Default)
            {
                case 3:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapper_Default_Install_icon;
                    break;

                default:
                    SwapperLauncherDefault.Image = Resources.LaunchSwapperDefault_icon;
                    break;
            }
        }

        private void SwapperLauncher_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    //var RightClick = new SwapperRightClick(0);
                    //var x = Cursor.Position.X - 10;
                    //var y = Cursor.Position.Y - 10;
                    //RightClick.SetDesktopLocation(x, y);

                    //DialogResult dlgres = RightClick.ShowDialog();
                    break;

                case MouseButtons.Left:
                    switch (Settings.Default.SwapperStatus)
                    {
                        case 0:
                            var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper.exe";
                            Process Swapper;

                            var arguments = $"OppyxPn89INV4HVH5z1x {Settings.Default.username} {Settings.Default.Password} {Directory.GetCurrentDirectory()}";

                            Swapper = new Process
                            {
                                StartInfo = new ProcessStartInfo(InstallFolder, arguments)
                            };

                            Swapper.Start();

                            Environment.Exit(0);
                            break;

                        case 2:
                            Updater Updater = new Updater();
                            Updater.ShowDialog();

                            switch (Settings.Default.SwapperStatus)
                            {
                                case 0:
                                    SwapperLauncher.Image = Resources.LaunchSwapper_Update_icon;
                                    break;

                                case 1:
                                    SwapperLauncher.Image = Resources.LaunchSwapper_OFFLINE_icon;
                                    SwapperLauncher.Enabled = false;
                                    break;
                            }
                            break;

                        case 3:
                            Setup Setup = new Setup();
                            Setup.ShowDialog();

                            switch (Settings.Default.SwapperStatus)
                            {
                                case 0:
                                    SwapperLauncher.Image = Resources.LaunchSwapper_Update_icon;
                                    break;

                                case 1:
                                    SwapperLauncher.Image = Resources.LaunchSwapper_OFFLINE_icon;
                                    SwapperLauncher.Enabled = false;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
