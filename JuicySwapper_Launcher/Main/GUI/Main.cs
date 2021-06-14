using JuicySwapper_Launcher.Main;
using JuicySwapper_Launcher.Main.Classes;
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

namespace JuicySwapper_Launcher
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            if (!Wrapper.Controls.Contains(SwappersTab.Instance))
            {
                Wrapper.Controls.Add(SwappersTab.Instance);
                SwappersTab.Instance.Dock = DockStyle.Fill;
                SwappersTab.Instance.BringToFront();
            }
            else
                SwappersTab.Instance.BringToFront();
            //var SwappersTab = 1;

            //if(test == 0)
            //    NormalLaunch.Text = "Install";
            //else if (test == 1)
            //    NormalLaunch.Text = "Launch";
            //else if (test == 2)
            //{
            //    NormalLaunch.Text = "Offline";
            //    NormalLaunch.Enabled = false;
            //}
            //else if (test == 3)
            //    NormalLaunch.Text = "Update";

            //Configuration = new Configuration();
            //Configuration.Open();

            //string[] JuicyAccount = args.Split(' ');

            //JuicyAccount[0] = Configuration.Username;
            //JuicyAccount[1] = Configuration.Password;

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

            //if(NormalLaunch.Text == "Launch")
            //{
                
            //    MessageBox.Show("Launching");

            //    var arguments = $"OppyxPn89INV4HVH5z1x {Configuration.Username} {Configuration.Password}";

            //    Swapper = new Process
            //    {
            //        StartInfo = new ProcessStartInfo($"{InstallFolder}\\JuicySwapper.exe", arguments)
            //        {
            //        }
            //    };

            //    Swapper.Start();

            //}
            //else if(NormalLaunch.Text == "Offline")
            //{
            //    MessageBox.Show("Offline");
            //}
            //else if (NormalLaunch.Text == "Update")
            //{
            //    MessageBox.Show("Updating");
            //}
        }

        public void SetShow()
        {
            if (base.InvokeRequired)
            {
                Home.SetShowDelegate method = new Home.SetShowDelegate(this.SetShow);
                base.Invoke(method);
                return;
            }
            base.Show();
        }

        // Token: 0x06000031 RID: 49 RVA: 0x00003B04 File Offset: 0x00001D04
        public void SetHide()
        {
            if (base.InvokeRequired)
            {
                Home.SetHideDelegate method = new Home.SetHideDelegate(this.SetHide);
                base.Invoke(method);
                return;
            }
            base.Hide();
        }

        private delegate void SetShowDelegate();

        private delegate void SetHideDelegate();

        public void startSwap()
        {
            timer1.Enabled = true;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if(Settings.Default.SwapperLaunched == true)
            {
                this.Hide();
                timer1.Enabled = false;
            }
            if (Settings.Default.SwapperLaunched == false)
            {
                this.Show();
                timer1.Enabled = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            Settings.Default.SwapperLaunched = false;
            Settings.Default.Save();
        }
    }
}
