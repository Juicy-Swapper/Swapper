using JuicySwapper.Items.Skins;
using JuicySwapper.Properties;
using System;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class RenegadeCOption : Form
    {
        public RenegadeCOption()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Redlinetorenegaderaidercheckered().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new BlazetorenegadeCheckered().ShowDialog();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new GingRenegadeChecker().ShowDialog();
            Close();
        }
    }
}
