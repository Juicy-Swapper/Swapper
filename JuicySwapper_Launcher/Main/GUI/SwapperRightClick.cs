using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JuicySwapper_Launcher.SatusAPI;

namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class SwapperRightClick : Form
    {
        public SwapperRightClick(int arg)
        {
            InitializeComponent();
            if(arg == 0)
            {
                var StatusAPI = new WebClient().DownloadString($"{API.HOST}/{API.Status}");
                Swapper StatusResponse = JsonConvert.DeserializeObject<Swapper>(StatusAPI);

                var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper.exe";

                Version.Text = GetFileVer(InstallFolder);
                APIversion.Text = StatusResponse.JuicySwapper.Version;

            }
        }

        public static string GetFileVer(string InstallFolder)
        {
            FileVersionInfo FileVersionInfo = null;
            try
            {
                FileVersionInfo = FileVersionInfo.GetVersionInfo(InstallFolder);
            }
            catch
            {
                MessageBox.Show("ERROR: Unknown");
            }
            return $"{FileVersionInfo.FileMajorPart}.{FileVersionInfo.FileMinorPart}.{FileVersionInfo.FileBuildPart}.{FileVersionInfo.FilePrivatePart}"; ;
        }

        private void SwapperRightClick_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void SwapperRightClick_Load(object sender, EventArgs e)
        {

        }
    }
}
