using JuicySwapper_Launcher.Main;
using JuicySwapper_Launcher.Main.Classes;
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

namespace JuicySwapper_Launcher
{
    public partial class Home : Form
    {
        Configuration Configuration;

        public Home(string args)
        {
            InitializeComponent();
            var test = 1;

            if(test == 0)
                NormalLaunch.Text = "Install";
            else if (test == 1)
                NormalLaunch.Text = "Launch";
            else if (test == 2)
            {
                NormalLaunch.Text = "Offline";
                NormalLaunch.Enabled = false;
            }
            else if (test == 3)
                NormalLaunch.Text = "Update";

            Configuration = new Configuration();
            Configuration.Open();

            string[] JuicyAccount = args.Split(' ');

            JuicyAccount[0] = Configuration.Username;
            JuicyAccount[1] = Configuration.Password;

        }

        void create()
        {
            MongoCRUD db = new MongoCRUD("JuicySwapper");

            db.InsertRecord("Users", new AccountInfo
            {
                username = "Test",
                password = "Test",
                HWID = "Test",
                
                
            });
        }

        private void NormalLaunch_Click(object sender, EventArgs e)
        {
            var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries";
            Process Swapper;

            if(NormalLaunch.Text == "Launch")
            {
                
                MessageBox.Show("Launching");

                var arguments = $"OppyxPn89INV4HVH5z1x {Configuration.Username} {Configuration.Password}";

                Swapper = new Process
                {
                    StartInfo = new ProcessStartInfo($"{InstallFolder}\\JuicySwapper.exe", arguments)
                    {
                    }
                };

                Swapper.Start();

            }
            else if(NormalLaunch.Text == "Offline")
            {
                MessageBox.Show("Offline");
            }
            else if (NormalLaunch.Text == "Update")
            {
                MessageBox.Show("Updating");
            }
        }
    }
}
