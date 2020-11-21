using JuicySwapper.Main.Panels;
using System.Windows.Forms;
using JuicySwapper.Items.Pickaxes;

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
            if (!Sidebar.Controls.Contains(SidebarPanel.Instance))
            {
                Sidebar.Controls.Add(SidebarPanel.Instance);
                SidebarPanel.Instance.Dock = DockStyle.Fill;
                SidebarPanel.Instance.BringToFront();
            }
            else
                SidebarPanel.Instance.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, System.EventArgs e)
        {
            new candyaxe().ShowDialog();
        }
    }
}
