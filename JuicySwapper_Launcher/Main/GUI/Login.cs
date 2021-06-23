using JuicySwapper_Launcher.Main.Classes;
using JuicySwapper_Launcher.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class Login : Form
    {
        bool _try, _hwidtry;


        [Obsolete]
        public Login()
        {
            JuicyUtilities_RPC.SetRPCLocation("Login");
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

        private void Login_Click(object sender, EventArgs e)
        {
            DataBaseinfo.Image = Resources.DataBaseInfoMesh;
            string hwid = JuicyUtilities.GET_HARDWAREID;
            MongoCRUD db = new MongoCRUD("JuicySwapper");

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
                var Usercheck = db.LoadRecordByUsername<UserControl>("Users", Username.Text);
            }
            catch
            {
                _try = true;
            }

            if(_try == false)
            {
                Message Usernotfound = new Message(Resources.Usernotfound);
                Usernotfound.ShowDialog();
                return;
            }

            var onerec = db.LoadRecordByUsername<AccountInfo>("Users", Username.Text);
            if (JuicySwapper_Encryption.Auth.DataBase.Decrypt(onerec.password, "") != password.Text)
            {
                Message Passwordincorect = new Message(Resources.Passwordincorect);
                Passwordincorect.ShowDialog();
                return;
            }

            onerec = db.LoadRecordByUsername<AccountInfo>("Users", Username.Text);

            if (onerec.HWID == "Reset")
            {
                onerec.HWID = hwid;
                db.UpsertRecord("Users", onerec.username, onerec);
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

            Settings.Default.Name = onerec.username;
            Settings.Default.username = Username.Text;
            Settings.Default.Password = password.Text;
            Settings.Default.Save();

            onerec.Online = true;
            db.UpsertRecord("Users", onerec.username, onerec);

            vars.PFP = onerec.ProfilePicture;

            if (KeppSignedIn.Checked == true)
            {
                Settings.Default.KeepSingedin = true;
                Settings.Default.Save();
            }
            else if (KeppSignedIn.Checked == false)
            {
                Settings.Default.KeepSingedin = false;
                Settings.Default.Save();
            }

            Hide();
            var Home = new Home();
            Message paidlogin = new Message(Resources.Juicylogin);
            paidlogin.ShowDialog();
            Home.Closed += (s, args) => Close();
            Home.Show();

        }

        private void ExitSwapper_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotInfo_Click(object sender, EventArgs e)
        {
            //var Open = new AccountInfo();
            //Open.ShowDialog();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void KeppSignedIn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Hide();
            var Open = new Signup();
            Open.Show();
        }
    }
}
