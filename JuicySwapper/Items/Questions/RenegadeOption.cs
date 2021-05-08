using JuicySwapper.Items.Skins;
using JuicySwapper.Properties;
using System;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class RenegadeOption : Form
    {
        public RenegadeOption()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Redlinetorenegaderaider().ShowDialog();
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

            new Blazetorenegade().ShowDialog();
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

            new GingRenegade().ShowDialog();
            Close();
        }
    }
}
