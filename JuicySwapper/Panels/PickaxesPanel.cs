using JuicySwapper.Main.Panels;
using JuicySwapper.Main.GUI;
using System.Windows.Forms;
using JuicySwapper.Items.Pickaxes;
using JuicySwapper.Properties;

namespace JuicySwapper.Panels
{
    public partial class PickaxesPanel : UserControl
    {
        private static PickaxesPanel _instance;      
        public static PickaxesPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PickaxesPanel();
                return _instance;
            }
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

        public PickaxesPanel()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, System.EventArgs e)
        {
            //new FNCS().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, System.EventArgs e)
        {
            //new Studded().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, System.EventArgs e)
        {
            // new StarwandRS().ShowDialog();
           new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, System.EventArgs e)
        {
           //new RaidersRevenge().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, System.EventArgs e)
        {
            new Guandao().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, System.EventArgs e)
        {
             new Axecalibur().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, System.EventArgs e)
        {
            new HarleyHitter().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton1_Click_1(object sender, System.EventArgs e)
        {
           new GalaxyAxe().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton2_Click_1(object sender, System.EventArgs e)
        {
            new AloySpear().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton21_Click(object sender, System.EventArgs e)
        {
             new Vision().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton3_Click_1(object sender, System.EventArgs e)
        {
            //  new ACDC().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, System.EventArgs e)
        {
             new ReysQuarterstaff().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton4_Click_1(object sender, System.EventArgs e)
        {
              new CandyAxe().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }
    }
}
