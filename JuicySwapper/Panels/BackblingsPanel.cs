using JuicySwapper.Main.Panels;
using System;
using System.Windows.Forms;
using JuicySwapper.Items.BackBlings;
using JuicySwapper.Main.GUI;
using JuicySwapper.Properties;

namespace JuicySwapper.Panels
{
    public partial class BackblingsPanel : UserControl
    {
        private static BackblingsPanel _instance;      
        public static BackblingsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BackblingsPanel();
                return _instance;
            }
        }

        public BackblingsPanel()
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Message Disabled = new Message(Resources.disabled);
            Disabled.ShowDialog();
            // new BlackShield().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Message Disabled = new Message(Resources.disabled);
            Disabled.ShowDialog();
            // new BattleShroud().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Message Disabled = new Message(Resources.disabled);
            Disabled.ShowDialog();
            // new IronCage().ShowDialog();
        }
    }
}
