﻿using JuicySwapper.Main.Panels;
using System;
using System.Windows.Forms;
using JuicySwapper.Main.GUI;
using JuicySwapper.Properties;
using JuicySwapper.Items.BackBlings;

namespace JuicySwapper.Panels
{
    public partial class BackblingsPanel : UserControl
    {
        private static BackblingsPanel _instance;      
        public static BackblingsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BackblingsPanel();
                return _instance;
            }
        }

        public BackblingsPanel() => InitializeComponent();

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {
            if (!Sidebar.Controls.Contains(SidebarPanel.Instance))
            {
                Sidebar.Controls.Add(SidebarPanel.Instance);
                SidebarPanel.Instance.Dock = DockStyle.Fill;
                SidebarPanel.Instance.BringToFront();
            }
            else
                SidebarPanel.Instance.BringToFront();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //new Insignia().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new BlackShieldOption().ShowDialog();
           // new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //new SpectralSpine().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //new RainbowClover().ShowDialog();
            new Message(Resources.disabled).ShowDialog();
        }
    }
}
