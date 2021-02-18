using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuicySwapper
{
    public partial class Message : Form
    {
        public Message(Bitmap Message)
        {
            InitializeComponent();
            BackgroundImage = Message;
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            ClosingTimer.Enabled = true;
        }

        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            ClosingTimer.Enabled = false;
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ClosingTimer.Enabled = false;
            this.Close();
        }
    }
}
