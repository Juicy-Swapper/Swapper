using JuicySwapper.Items.Skins;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class RamirezOption : Form
    {
        public RamirezOption()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Ramirez().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new RamirezAA().ShowDialog();
        }
    }
}
