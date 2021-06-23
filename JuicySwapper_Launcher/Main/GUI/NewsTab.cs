using Newtonsoft.Json.Linq;
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

namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class NewsTab : UserControl
    {
        private static NewsTab _instance;
        public static NewsTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewsTab();
                return _instance;
            }
        }

        public NewsTab()
        {
            InitializeComponent();
            FortniteNews.SizeMode = PictureBoxSizeMode.StretchImage;
            FortniteNews.ImageLocation = GetFortniteNews();
        }

        public static string GetFortniteNews()
        {
            WebClient ProgramClient = new WebClient();

            dynamic parsed = JObject.Parse(ProgramClient.DownloadString($"{FortniteAPI.HOST}/{FortniteAPI.News}"));

            var image = parsed.data.image;

            return image;
        }
    }
}
