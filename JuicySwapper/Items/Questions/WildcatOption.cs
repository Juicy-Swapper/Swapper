using JuicySwapper.Properties;
using JuicySwapper.Items.Skins;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;


namespace JuicySwapper.Main.GUI
{
    public partial class WildcatOption : Form
    {
        public WildcatOption()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new WildcatRS().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new WildcatBlaze().ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

            new WildcatNeo().ShowDialog();
            //new Message(Resources.disabled).ShowDialog();
        }
    }
}
