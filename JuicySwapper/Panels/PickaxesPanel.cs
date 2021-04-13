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
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

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
            new FNCS().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, System.EventArgs e)
        {
            new Studded().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, System.EventArgs e)
        {
            new StarwandRS().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, System.EventArgs e)
        {
            new RaidersRevenge().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, System.EventArgs e)
        {
           new Guandao().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, System.EventArgs e)
        {
            new Axecalibur().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, System.EventArgs e)
        {
            new HarleyHitter().ShowDialog();
        }

        private void bunifuImageButton1_Click_1(object sender, System.EventArgs e)
        {
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton2_Click_1(object sender, System.EventArgs e)
        {
            new AloySpear().ShowDialog();
        }
    }
}
