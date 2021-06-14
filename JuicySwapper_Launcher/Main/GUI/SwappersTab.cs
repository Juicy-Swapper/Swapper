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

            SwapperConfiguration.GetStatus();

            if (Settings.Default.SwapperStatus == 1)
            {
                SwapperLauncher.Image = Resources.LaunchSwapperOFFLINE_icon;
                SwapperLauncher.Enabled = false;
            }
            else if(Settings.Default.SwapperStatus == 3)
                SwapperLauncher.Image = Resources.LaunchSwapperInstallDE_icon;
            else
               SwapperLauncher.Image = Resources.SwapperIConLaunch;
        }

        private void SwapperLauncher_MouseEnter(object sender, EventArgs e)
        {
            if (Settings.Default.SwapperStatus == 0)
                SwapperLauncher.Image = Resources.LaunchSwapper_icon;
            else if (Settings.Default.SwapperStatus == 2)
                SwapperLauncher.Image = Resources.LaunchSwapperUpdate_icon;

            else if (Settings.Default.SwapperStatus == 3)
                SwapperLauncher.Image = Resources.LaunchSwapperInstallNOW_icon;
        }

        private void SwapperLauncher_MouseLeave(object sender, EventArgs e)
        {
            if (Settings.Default.SwapperStatus == 3)
                SwapperLauncher.Image = Resources.LaunchSwapperInstallDE_icon;
            else
                SwapperLauncher.Image = Resources.SwapperIConLaunch;
        }

        private void SwapperLauncher_Click(object sender, EventArgs e)
        {
            if (Settings.Default.SwapperStatus == 0)
            {
                var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper.exe";
                Process Swapper;

                var arguments = $"OppyxPn89INV4HVH5z1x test test {Directory.GetCurrentDirectory()}";

                Swapper = new Process
                {
                    StartInfo = new ProcessStartInfo(InstallFolder, arguments )
                };

                Swapper.Start();

                Environment.Exit(0);
            }
            else if (Settings.Default.SwapperStatus == 2)
            {
                Updater Updater = new Updater();
                Updater.ShowDialog();
            }
            else if (Settings.Default.SwapperStatus == 3)
            {
                Setup Setup = new Setup();
                Setup.ShowDialog();
                if (Settings.Default.SwapperStatus == 1)
                {
                    SwapperLauncher.Image = Resources.LaunchSwapperOFFLINE_icon;
                    SwapperLauncher.Enabled = false;
                }
                else if (Settings.Default.SwapperStatus == 3)
                    SwapperLauncher.Image = Resources.LaunchSwapperInstallDE_icon;
                else
                    SwapperLauncher.Image = Resources.SwapperIConLaunch;
            }
        }
    }
}
