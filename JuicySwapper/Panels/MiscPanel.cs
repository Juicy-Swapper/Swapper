using JuicySwapper.Main.Panels;
using System;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class MiscPanel : UserControl
    {
        private static MiscPanel _instance;
        public static MiscPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MiscPanel();
                return _instance;
            }
        }

        public MiscPanel()
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

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }
    }
}
