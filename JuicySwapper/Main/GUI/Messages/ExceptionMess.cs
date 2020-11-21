using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;
using JuicySwapper.Main.Classes;

namespace JuicySwapper.Main.GUI
{
    public partial class ExceptionMess : Form
    {
        public ExceptionMess()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            label2.Text = "Looks like we couldnt get the Resources for our\napi too you.If you need help with this please\njoin our discord by clicking on the 'Discord' button";
            label3.Text = $"Help code: {SwapUtilities.Exp}";
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
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
