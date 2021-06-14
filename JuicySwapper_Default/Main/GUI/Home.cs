using JuicySwapper_Default.Main.GUI;
using JuicySwapper_Default.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Default
{
    public partial class Home : Form
    {
        public Home()
        {
            Settings.Default.InstallationPath = EpicGames.GetEpicInstallLocations().FirstOrDefault(x => x.AppName == "Fortnite")?.InstallLocation;

            Settings.Default.pakPath = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";
            Settings.Default.Save();

            WebClient ProgramClient = new WebClient();

            dynamic parsed = JObject.Parse(ProgramClient.DownloadString("https://juicyswapper.xyz/api/Defualt/Content.json"));

            var Ucas = $"{Settings.Default.pakPath}\\{parsed.Utilities.BodyNHeadPak}";

            if (!File.Exists(Ucas.Replace("4", "33")))
            {
                try
                {
                    File.Copy(Ucas, Ucas.Replace("4", "33"), true);
                    Thread.Sleep(1000);
                }
                catch (IOException)
                {
                    MessageBox.Show("There was a error trying to copy files please contact juicy support");
                }
            }

            InitializeComponent();
            if (!Wrapper.Controls.Contains(SkinPanel.Instance))
            {
                Wrapper.Controls.Add(SkinPanel.Instance);
                SkinPanel.Instance.Dock = DockStyle.Fill;
                SkinPanel.Instance.BringToFront();
            }
            else
                SkinPanel.Instance.BringToFront();
        }

        private void settingsMenuBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
