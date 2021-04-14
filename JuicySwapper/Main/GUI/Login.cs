using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using System;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class Login : Form
    {
        bool _try, _hwidtry;

        [Obsolete]
        public Login()
        {
            JuicyUtilities.SetRPCSTAT($"Browsing Login Page");
            InitializeComponent();

            Username.Text = Settings.Default.username;
            password.Text = Settings.Default.Password;

            if (string.IsNullOrEmpty(Username.Text))
                Username.Text = "Enter a username...";

            if (string.IsNullOrEmpty(password.Text))
                password.Text = "Enter a password...";

            if (password.Text != "Enter a password...")
                password.isPassword = true;
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

        [Obsolete]
        private void Login_Click(object sender, EventArgs e)
        {
            MongoCRUD db = new MongoCRUD("JuicySwapper");
            string hwid = JuicyUtilities.GET_HARDWAREID;

            //epic
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

            try
            {
                _try = false;
                var Usercheck = db.LoadRecordByUsername<UserModel>("Juicy", Username.Text);
            }
            catch
            {
                _try = true;
            }

            if (_try == true)
            {
                Message Usernotfound = new Message(Resources.Usernotfound);
                Usernotfound.ShowDialog();
                return;
            }

            var onerec = db.LoadRecordByUsername<UserModel>("Juicy", Username.Text);
            if (JuicySwapper_Encryption.Auth.Accounts.Decrypt(onerec.password) != password.Text)
            {
                Message Passwordincorect = new Message(Resources.Passwordincorect);
                Passwordincorect.ShowDialog();
                return;
            }

            onerec = db.LoadRecordByUsername<UserModel>("Juicy", Username.Text);

            if (onerec.HWID == "Reset")
            {
                onerec.HWID = hwid;
                db.UpsertRecord("Juicy", onerec.username, onerec);
                Message hwidreset = new Message(Resources.hwidreset);
                hwidreset.ShowDialog();
                return;
            }

            if (onerec.HWID != hwid)
            {
                Message HWIDincorect = new Message(Resources.HWIDincorect);
                HWIDincorect.ShowDialog();
                return;
            }

            bool User = onerec.paid;
            if (User)
                Settings.Default.AccVerify = "Paid";
            else
                Settings.Default.AccVerify = "Free";

            Settings.Default.Name = Username.Text;
            Settings.Default.username = Username.Text;
            Settings.Default.Password = password.Text;
            Settings.Default.Save();

            Hide();
            var Home = new Home();
            if (User)
            {
                Message paidlogin = new Message(Resources.paidlogin);
                paidlogin.ShowDialog();
            }
            else
            {
                Message FreeLogin = new Message(Resources.freelogin);
                FreeLogin.ShowDialog();
            }
            Home.Closed += (s, args) => Close();
            Home.Show();
        }

        private void ExitSwapper_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotInfo_Click(object sender, EventArgs e)
        {
            var Open = new AccountInfo();
            Open.ShowDialog();
            
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Hide();
            var Open = new Signup();
            Open.Show();
        }
    }
}
