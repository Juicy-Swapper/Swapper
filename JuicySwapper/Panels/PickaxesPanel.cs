using JuicySwapper.Main.Panels;
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

            new candyaxe().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, System.EventArgs e)
        {
            new IronBeak().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, System.EventArgs e)
        {
            new SkullySplitter().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, System.EventArgs e)
        {
            new TatAxe().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, System.EventArgs e)
        {
            new FNCS().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, System.EventArgs e)
        {
            new Studded().ShowDialog();
        }
    }
}
