using JuicySwapper.Main.Panels;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Type = JuicySwapper.Api.ContentAPI.Type;
using JuicySwapper.Api;

namespace JuicySwapper.Panels
{
    public partial class DashPanel : UserControl
    {
        private static DashPanel _instance;      
        public static DashPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashPanel();
                return _instance;
            }
        }

        public DashPanel()
        {
            InitializeComponent();
            GetContent();
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {
            if (!Sidebar.Controls.Contains(SidebarPanel.Instance))
            {
                Sidebar.Controls.Add(SidebarPanel.Instance);
                SidebarPanel.Instance.Dock = DockStyle.Fill;
                SidebarPanel.Instance.BringToFront();
            }
            else
                SidebarPanel.Instance.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://juicyswapper.xyz");
        }

        public void GetContent()
        {
            //Downloads JSON from Juicy Swapper API.
            var ContentAPI = new WebClient().DownloadString($"{API.HOST}/{API.Content}");

            //Deserializes JSON from Juicy Swapper API.
            Type StatusResponse = JsonConvert.DeserializeObject<Type>(ContentAPI);

            //Sets Form Items from API Response.
            newsTitleLabel.Text = StatusResponse.News.NewsTitle;
            newsTextLabel.Text = StatusResponse.News.NewsText;
            newsImagePictureBox.ImageLocation = StatusResponse.News.NewsImage;
            changelogTextLabel.Text = StatusResponse.Patchnotes.PatchnotesText;
            currentVersionLabel.Text = $"Current Version: v{Application.ProductVersion}";
        }
    }
}
