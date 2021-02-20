using JuicySwapper.Api;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{ 
    public partial class OfflineMode : Form
    {
        public OfflineMode()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Backupverifybtn_Click(object sender, EventArgs e)
        {
            Process.Start($"{API.HOST}/{API.Discord}");
        }
    }
}
