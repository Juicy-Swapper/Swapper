using System;
using System.Windows.Forms;

namespace JuicySwapper.Main.Panels
{
    public partial class SidebarPanel : UserControl
    {
        private static SidebarPanel _instance;
        public static SidebarPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SidebarPanel();
                return _instance;
            }
        }

        public SidebarPanel()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
