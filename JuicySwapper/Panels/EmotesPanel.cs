using JuicySwapper.Main.Panels;
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

        private void bunifuFlatButton7_Click() => Environment.Exit(0);
    }
}
