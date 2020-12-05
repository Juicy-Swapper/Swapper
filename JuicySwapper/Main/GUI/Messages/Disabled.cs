using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class Disabled : Form
    {
        public Disabled()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            label1.Text = $"{Home.Disabled} Disabled";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PakError_Load(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }
    }
}
