using JuicySwapper_Launcher.Main.Classes;
using JuicySwapper_Launcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class Signup : Form
    {
        bool _try, _hwidtry;
        public Signup()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var Open = new Login();
            Open.Closed += (s, args) => Close();
            Open.Show();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (Username.Text != "Enter a username...")
                return;

            Username.ResetText();
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.isPassword = true;
            if (password.Text != "Enter a password...")
                return;
            password.ResetText();
        }

        private void Cpassword_Enter(object sender, EventArgs e)
        {
            Cpassword.isPassword = true;
            if (Cpassword.Text != "Confirm password...")
                return;
            Cpassword.ResetText();
        }

        private void PaidLogin_Click(object sender, EventArgs e)
        {
            string hwid = JuicyUtilities.GET_HARDWAREID;

            string time = DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss");

            MongoCRUD db = new MongoCRUD("JuicySwapper");

            if (string.IsNullOrEmpty(Username.Text) || Username.Text.Length < 3 || Username.Text == "Enter a username...")
            {
                Message userinvalid = new Message(Resources.userinvalid);
                userinvalid.ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(password.Text) || password.Text.Length < 3 || password.Text == "Enter a password...")
            {
                Message Passwordinvalid = new Message(Resources.passwordinvalid);
                Passwordinvalid.ShowDialog();
                return;
            }
            if (password.Text != Cpassword.Text)
            {
                MessageBox.Show("Your passwords do not match");
                return;
            }

            try
            {
                _try = false;
                var Usercheck = db.LoadRecordByUsername<AccountInfo>("Users", Username.Text);
            }
            catch
            {
                _try = true;
            }

            try
            {
                _hwidtry = false;
                var onerec = db.LoadRecordByHwid<AccountInfo>("Users", hwid);
            }
            catch
            {
                _hwidtry = true;
            }

            if (_try == false)
            {
                Message Userfound = new Message(Resources.Userfound);
                Userfound.ShowDialog();
                return;
            }

            if (_hwidtry == false)
            {
                Message HWIDfound = new Message(Resources.HWIDfound);
                HWIDfound.ShowDialog();
                return;
            }

            db.InsertRecord("Users", new AccountInfo
            {
                username = Username.Text,
                password = JuicySwapper_Encryption.Auth.DataBase.Encrypt(password.Text, ""),
                CreatedAt = time,
                HWID = hwid,
                ProfilePicture = $"{API.HOST}/{API.DefaultPFP}"
            });

            Message Account_created = new Message(Resources.Account_created);
            Account_created.ShowDialog();

            Hide();
            var Open = new Login();
            Open.Closed += (s, args) => Close();
            Open.Show();
        }
    }
}
