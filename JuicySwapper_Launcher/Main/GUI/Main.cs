using JuicySwapper_Launcher.Main;
using JuicySwapper_Launcher.Main.Classes;
using JuicySwapper_Launcher.Main.GUI;
using JuicySwapper_Launcher.Properties;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JuicySwapper_Launcher.SatusAPI;

namespace JuicySwapper_Launcher
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();

            pictureBox1.ImageLocation = vars.PFP;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //makes pfp round
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            //

            if (!Wrapper.Controls.Contains(HomeTab.Instance))
            {
                Wrapper.Controls.Add(HomeTab.Instance);
                HomeTab.Instance.Dock = DockStyle.Fill;
                HomeTab.Instance.BringToFront();
            }
            else
                HomeTab.Instance.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            MongoCRUD db = new MongoCRUD("JuicySwapper");

            var onerec = db.LoadRecordByUsername<AccountInfo>("Users", Settings.Default.Name);

            onerec = db.LoadRecordByUsername<AccountInfo>("Users", Settings.Default.Name);

            onerec.Online = false;
            db.UpsertRecord("Users", onerec.username, onerec);
        }

        private void HometabBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities_RPC.SetRPCLocation("Home");
            if (!Wrapper.Controls.Contains(HomeTab.Instance))
            {
                Wrapper.Controls.Add(HomeTab.Instance);
                HomeTab.Instance.Dock = DockStyle.Fill;
                HomeTab.Instance.BringToFront();
            }
            else
                HomeTab.Instance.BringToFront();
        }

        private void SwappertabBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities_RPC.SetRPCLocation("Swappers");
            if (!Wrapper.Controls.Contains(SwappersTab.Instance))
            {
                Wrapper.Controls.Add(SwappersTab.Instance);
                SwappersTab.Instance.Dock = DockStyle.Fill;
                SwappersTab.Instance.BringToFront();
            }
            else
                SwappersTab.Instance.BringToFront();
        }

        private void NewstabBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities_RPC.SetRPCLocation("News");
            if (!Wrapper.Controls.Contains(NewsTab.Instance))
            {
                Wrapper.Controls.Add(NewsTab.Instance);
                NewsTab.Instance.Dock = DockStyle.Fill;
                NewsTab.Instance.BringToFront();
            }
            else
                NewsTab.Instance.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
