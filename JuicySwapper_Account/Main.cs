using JuicySwapper_Account.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static JuicySwapper_Account.Classes.Mongodb;

namespace JuicySwapper_Account
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            var pink = Color.FromArgb(0xfe8299);
            LogLable.ForeColor = pink;
            LogLable.Text = "Juicy: Welcome please click (Get info from HWID)\nto get your account info!";
        }

        private void GetInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                LogLable.ForeColor = Color.Orange;
                LogLable.Text = "Mongodb: Looking through our database!";
                MongoCRUD db = new MongoCRUD("JuicySwapper");

                var GetHWID = JuicyUtilities.GET_HARDWAREID;

                var onerec = db.LoadRecordByHwid<UserModel>("Juicy", GetHWID);

                LogLable.ForeColor = Color.Green;
                LogLable.Text = "SUCCESS: We found your hwid in our database!";
                var Username = onerec.username;
                var Password = JuicyUtilities.Decrypt(onerec.password);
                var CreatedAt = onerec.CreatedAt;
                var HWID = onerec.HWID;
                var id = onerec.Id.ToString();

                username.Text = Username;
                Thread.Sleep(50);
                password.Text = Password;
                Thread.Sleep(50);
                CreatedAT.Text = CreatedAt;
                Thread.Sleep(50);
                hwid.Text = HWID;
                Thread.Sleep(50);
                ID.Text = id;
            }
            catch
            {
                LogLable.ForeColor = Color.Red;
                LogLable.Text = "ERROR: We couldn't find your hwid in our database!";
            }
        }

        private void GetInfoBtn_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            GetInfo.RunWorkerAsync();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
