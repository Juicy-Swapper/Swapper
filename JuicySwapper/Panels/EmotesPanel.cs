using JuicySwapper.Items.Emotes;
using JuicySwapper.Main.Panels;
using JuicySwapper.Main.GUI;
using System;
using System.Windows.Forms;
using JuicySwapper.Items.Skins;
using JuicySwapper.Properties;

namespace JuicySwapper.Panels
{
    public partial class EmotesPanel : UserControl
    {
        private static EmotesPanel _instance;      
        public static EmotesPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmotesPanel();
                return _instance;
            }
        }

        public EmotesPanel()
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

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new Floss().ShowDialog();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            new Scenario().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new BughaDance().ShowDialog();
        }
    }
}
