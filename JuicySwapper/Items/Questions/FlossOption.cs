﻿using JuicySwapper.Properties;
using JuicySwapper.Items.Emotes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;


namespace JuicySwapper.Main.GUI
{
    public partial class FlossOption : Form
    {
        public FlossOption()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Floss().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccVerify == "Guest")
            {
                Message a = new Message(Resources.Juicynoacc);
                a.ShowDialog();
                return;
            }

          //  new FlossArmWave().ShowDialog();
        }
    }
}
