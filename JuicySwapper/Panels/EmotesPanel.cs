using JuicySwapper.Items.Emotes;
using JuicySwapper.Main.Panels;
using JuicySwapper.Main.GUI;
using System;
using System.Windows.Forms;

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

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new Freemix().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new Chicken().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new TakeTL().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new FlossOption().ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Scenario().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new Jitterbug().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new Octane().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new Savage().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new SaySo().ShowDialog();
        }
    }
}
