using JuicySwapper_Default.Main.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Default
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if (!Wrapper.Controls.Contains(SkinPanel.Instance))
            {
                Wrapper.Controls.Add(SkinPanel.Instance);
                SkinPanel.Instance.Dock = DockStyle.Fill;
                SkinPanel.Instance.BringToFront();
            }
            else
                SkinPanel.Instance.BringToFront();
        }

        private void settingsMenuBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
