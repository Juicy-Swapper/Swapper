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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DiscordInviteBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities.DiscordInvite();
        }
    }
}
