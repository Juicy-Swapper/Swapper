using JuicySwapper.Items.Skins;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Panels;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class SkinsPanel : UserControl
    {
        private static SkinsPanel _instance;      
        public static SkinsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SkinsPanel();
                return _instance;
            }
        }

        public SkinsPanel()
        {
            InitializeComponent();
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {
            if (!Sidebar.Controls.Contains(SidebarPanel.Instance))
            {
                Sidebar.Controls.Add(SidebarPanel.Instance);
                SidebarPanel.Instance.Dock = DockStyle.Fill;
                SidebarPanel.Instance.BringToFront();
            }
            else
                SidebarPanel.Instance.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //new SparkleSpecialist().ShowDialog();
            Home.Disabled = "Sparkle Specialist";
            new Disabled().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            //new ReconExpert().ShowDialog();
            Home.Disabled = "Recon Expert";
            new Disabled().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new headhunter().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new RamirezOption().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new Wildcat().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new BansheeOption().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new sunbird().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new Spitfire().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new Hawk().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new Renegade().ShowDialog();
        }
    }
}
