using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Launcher
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PaidLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var Open = new SignUP();
            Open.Closed += (s, args) => Close();
            Open.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginFree_Click(object sender, EventArgs e)
        {
            Hide();
            var Open = new Main();
            Open.Closed += (s, args) => Close();
            Open.Show();
        }
    }
}
