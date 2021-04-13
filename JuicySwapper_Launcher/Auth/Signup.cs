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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void ExitSwapper_Click(object sender, EventArgs e)
        {
            Hide();
            var Open = new Login();
            Open.Closed += (s, args) => Close();
            Open.Show();
        }
    }
}
