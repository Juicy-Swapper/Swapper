using Type = JuicySwapper_Default.Main.Classes.ContentAPI.Type;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using JuicySwapper_Launcher.Main;
//using ContentAPI = JuicySwapper_Default.Main.Classes.ContentAPI;

namespace JuicySwapper_Default.Main.GUI
{
    public partial class SkinPanel : UserControl
    {
        private static SkinPanel _instance;
        public static SkinPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SkinPanel();
                return _instance;
            }
        }

        public SkinPanel()
        {
            InitializeComponent();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            vars.item = ((Bunifu.Framework.UI.BunifuImageButton)sender).Name;
            new SkinSwapper().Show();
        }

        private void SkinPanel_Load(object sender, EventArgs e)
        {
            WebClient ProgramClient = new WebClient();

            dynamic parsed = JObject.Parse(ProgramClient.DownloadString("https://juicyswapper.xyz/api/Defualt/Content.json"));

            foreach (var Cosmetic in parsed.name)
            {
                //PictureBox newPic = new PictureBox();
                Bunifu.Framework.UI.BunifuImageButton newPic = new Bunifu.Framework.UI.BunifuImageButton();
                newPic.ImageLocation = Cosmetic.Icon;
                newPic.Name = Cosmetic.Name;
                Cursor = Cursors.Hand;
                newPic.SizeMode = PictureBoxSizeMode.Zoom;
                newPic.Size = new Size(71, 71);
                newPic.ImageActive = null;
                newPic.BackColor = Color.Transparent;
                newPic.Click += buttonOn_Click;
                flowLayoutPanel1.Controls.Add(newPic);
            }

        }
    }
}
