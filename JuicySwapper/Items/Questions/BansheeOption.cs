using JuicySwapper.Items.Skins;
using System;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class BansheeOption : Form
    {
        public BansheeOption()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Banshee().ShowDialog();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new BansheeRen().ShowDialog();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new BansheeTO().ShowDialog();
            Close();
        }
    }
}
