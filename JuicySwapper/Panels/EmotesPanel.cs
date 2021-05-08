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

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new Freemix().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
              new Chicken().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
             new TakeTL().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new FlossOption().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Scenario().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new Jitterbug().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
             new Octane().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
             new Savage().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
              new SaySo().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new LeaveTheDoorOpen().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
           new HitIt().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
             new PullUp().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            new CatComic().ShowDialog();
        }
    }
}
