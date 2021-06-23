using JuicySwapper_Launcher.Main.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class HomeTab : UserControl
    {
        private static HomeTab _instance;
        public static HomeTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomeTab();
                return _instance;
            }
        }

        public HomeTab()
        {
            InitializeComponent();
            MongoCRUD db = new MongoCRUD("JuicySwapper");

            UserInformationsLabel.Text = db.Accounts<AccountInfo>().ToString();

            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var recs = MongoCRUD.LoadRecords<AccountInfo>("Users");
            foreach (var rec in recs)
            {

                Bunifu.Framework.UI.BunifuFlatButton user = new Bunifu.Framework.UI.BunifuFlatButton();

                var request = WebRequest.Create(rec.ProfilePicture);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    user.Iconimage = Bitmap.FromStream(stream);
                }


                user.Size = new Size(165, 45);
                user.IconZoom = 100;
                user.Text = $"    {rec.username}";
                user.Activecolor = Color.Transparent;
                user.Normalcolor = Color.Transparent;
                user.OnHovercolor = Color.Transparent;

                flowLayoutPanel1.Controls.Add(user);
            }
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            vars.NAME = ((Bunifu.Framework.UI.BunifuImageButton)sender).Name;
            
        }
    }
}
