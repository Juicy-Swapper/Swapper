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

        private void bunifuImageButton24_Click(object sender, EventArgs e)
        {
            new AerialAssaultTrooper().ShowDialog();
        }

        private void bunifuImageButton26_Click_1(object sender, EventArgs e)
        {
            new Galaxy().ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Megumi().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton25_Click(object sender, EventArgs e)
        {
            new ReconSpecialist().ShowDialog(); 
        }

        private void bunifuImageButton18_Click_1(object sender, EventArgs e)
        {
            new RenegadeCOption().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new Chigusa().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //new Yuki().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new Loserfruit().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new Megg().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new SparkleSpecialist().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new Isabelle().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new Chigusa().ShowDialog();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new WildcatBlueOption().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new HarleyQuinnRebirth().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new Aloy().ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            new AloyStyle().ShowDialog();
        }

        private void bunifuImageButton13_Click_1(object sender, EventArgs e)
        {
            new Eco().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new PrincessFish().ShowDialog();
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            new GrimeyOption().ShowDialog();
        }

        private void bunifuImageButton15_Click_1(object sender, EventArgs e)
        {
            new ChunLi().ShowDialog();
        }

        private void bunifuImageButton30_Click(object sender, EventArgs e)
        {
            new Ikonik().ShowDialog();
        }

        private void bunifuImageButton27_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton31_Click(object sender, EventArgs e)
        {
            new Rue().ShowDialog();
        }

        private void bunifuImageButton29_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            new Echo().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            new Surfwitch().ShowDialog();
        }

        private void bunifuImageButton33_Click(object sender, EventArgs e)
        {
            new Focus().ShowDialog();
        }

        private void bunifuImageButton34_Click(object sender, EventArgs e)
        {
            new VictoriaSaint().ShowDialog();
        }

        private void bunifuImageButton38_Click(object sender, EventArgs e)
        {
            new Scourge().ShowDialog();
        }

        private void bunifuImageButton36_Click(object sender, EventArgs e)
        {
            new ChaosAgent().ShowDialog();
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            new AthleisureAssassin().ShowDialog();
        }

        private void bunifuImageButton27_Click_1(object sender, EventArgs e)
        {
            new TropicalZoey().ShowDialog();
        }

        private void bunifuImageButton32_Click(object sender, EventArgs e)
        {
            new TechLlama().ShowDialog();
        }

        private void bunifuImageButton29_Click_1(object sender, EventArgs e)
        {
            new HarleyQuinn().ShowDialog();
        }

        private void bunifuImageButton35_Click(object sender, EventArgs e)
        {
            new Hush().ShowDialog();
        }

        private void bunifuImageButton37_Click(object sender, EventArgs e)
        {
            new Manic().ShowDialog();
        }
    }
}