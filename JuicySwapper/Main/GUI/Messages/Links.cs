using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class Links : Form
    {
        public Links()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            JuicyUtilities.DiscordInvite();
        }

        private void Website_Click(object sender, EventArgs e)
        {
            JuicyUtilities.Website();
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            JuicyUtilities.Twitter();
        }
    }
}
