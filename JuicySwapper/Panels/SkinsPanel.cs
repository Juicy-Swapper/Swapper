using JuicySwapper.Items.Skins;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Panels;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using JuicySwapper.Properties;

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
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new SparkleSpecialist().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            new ReconExpert().ShowDialog();
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

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new Dazzle().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new RenegadeRaider().ShowDialog();
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            new SurvivalSpecialist().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new GingerbreadRaider().ShowDialog();
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new Fate().ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new EliteAgent().ShowDialog();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new RenegadeOption().ShowDialog();
        }

        private void bunifuImageButton11_Click_1(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new GhoulOG().ShowDialog();
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new RedReindeer().ShowDialog();
        }

        private void SkinsPanel_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            new WildcatOption().ShowDialog();
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            new Siren().ShowDialog();
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            new Travisscooter().ShowDialog();
        }

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            new RenegadeCOption().ShowDialog();
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            new Loserfruit().ShowDialog();
        }

        private void bunifuImageButton24_Click(object sender, EventArgs e)
        {
            new AerialAssaultTrooper().ShowDialog();
        }

        private void bunifuImageButton25_Click(object sender, EventArgs e)
        {
            new ReconSpecialist().ShowDialog();
        }
    }
}