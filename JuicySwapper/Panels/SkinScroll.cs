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
    public partial class SkinScroll : UserControl
    {
        private static SkinScroll _instance;
        public static SkinScroll Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SkinScroll();
                return _instance;
            }
        }

        public SkinScroll()
        {
            InitializeComponent();
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
            //new Message(Resources.disabled).ShowDialog();
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
            //new Message(Resources.disabled).ShowDialog();
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
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Megumi().ShowDialog();
           //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton25_Click(object sender, EventArgs e)
        {
             new ReconSpecialist().ShowDialog(); 
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton18_Click_1(object sender, EventArgs e)
        {
            new RenegadeCOption().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new Chigusa().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new Yuki().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new Loserfruit().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new SparkleSpecialist().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
           new Isabelle().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new Chigusa().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new WildcatBlueOption().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
           new HarleyQuinnRebirth().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new Aloy().ShowDialog();
         //   new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            new AloyStyle().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton13_Click_1(object sender, EventArgs e)
        {
            new Eco().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new PrincessFish().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            new Grimey().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton15_Click_1(object sender, EventArgs e)
        {
          new ChunLi().ShowDialog();
          //  new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            new Echo().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton33_Click(object sender, EventArgs e)
        {
            //new Focus().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton34_Click(object sender, EventArgs e)
        {
            new VictoriaSaint().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton38_Click(object sender, EventArgs e)
        {
            //new Scourge().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton36_Click(object sender, EventArgs e)
        {
            //new ChaosAgent().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            //new AthleisureAssassin().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton27_Click_1(object sender, EventArgs e)
        {
            new TropicalZoey().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton32_Click(object sender, EventArgs e)
        {
            new TechLlama().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton29_Click_1(object sender, EventArgs e)
        {
            //new HarleyQuinn().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton35_Click(object sender, EventArgs e)
        {
            //new Hush().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new Catwomen().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            new StoneViper().ShowDialog();
        }

        private void bunifuImageButton37_Click(object sender, EventArgs e)
        {
            new Clip().ShowDialog();
        }

        private void bunifuImageButton30_Click(object sender, EventArgs e)
        {
            new Marius().ShowDialog();
        }

        private void bunifuImageButton30_Click_1(object sender, EventArgs e)
        {
            new GalaxyGirl().ShowDialog();
        }

        private void bunifuImageButton39_Click(object sender, EventArgs e)
        {
            new Dizzie().ShowDialog();
        }

        private void bunifuImageButton31_Click(object sender, EventArgs e)
        {
            //new SpartanAssassin().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton40_Click(object sender, EventArgs e)
        {
            new TheChampion().ShowDialog();
           
        }

        private void bunifuImageButton41_Click(object sender, EventArgs e)
        {
            new LokBot().ShowDialog();
        }
    }
}