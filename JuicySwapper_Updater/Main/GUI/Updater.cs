using DiscordRPC;
using JuicySwapper_Updater.Main.Classes;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using static JuicySwapper_Updater.Main.Classes.StatusAPI;

namespace JuicySwapper_Updater.Main.GUI
{
    public partial class Updater : Form
    {
        static WebClient UpdaterClient = new WebClient();
        public static DiscordRpcClient rpcClient;
        static int counter;
        public Updater()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Juicy.SetDiscordAction("Updater");
            GetFileVer();
        }

        private void GetFileVer()
        {
            if (File.Exists("JuicySwapper.exe"))
            {
                FileVersionInfo fileVersionInfo = null;
                try
                {
                    fileVersionInfo = FileVersionInfo.GetVersionInfo("JuicySwapper.exe");
                }
                catch
                {
                    InformationsLabel.Text = "ERROR: Unknown!";
                }
                string text = string.Format("{0}.{1}.{2}.{3}", new object[]
                {
                    fileVersionInfo.FileMajorPart,
                    fileVersionInfo.FileMinorPart,
                    fileVersionInfo.FileBuildPart,
                    fileVersionInfo.FilePrivatePart,
                });               
                CheckUpdate(text);
                return;
            }
            UpdaterBG.RunWorkerAsync();
        }
        void CheckUpdate(string fv)
        {
            foreach (Process process in Process.GetProcessesByName("JuicySwapper.exe"))
            {
                process.Kill();
            }

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    var StatusAPI = UpdaterClient.DownloadString("http://juicyswapper.xyz/api/status.json");
                    Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
                    webClient.Proxy = null;
                    string text = webClient.DownloadString(StatusResponse.version).ToString();                  
                    InformationsLabel.Text = "Newest version: " + text;
                    if (!text.Contains(fv))
                    {
                        InformationsLabel.Text = "Update available!";
                        UpdaterBG.RunWorkerAsync();
                    }
                    else
                    {
                        InformationsLabel.Text = "You are up to date!";
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    InformationsLabel.Text = "ERROR: Unknown!";
                }
            }
        }

        private void UpdaterBG_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (File.Exists("JuicySwapper.exe"))
                {
                    File.Delete("JuicySwapper.exe");
                }
                var StatusAPI = UpdaterClient.DownloadString("http://juicyswapper.xyz/api/status.json");
                Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
                UpdaterClient.Proxy = null;
                UpdaterClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                UpdaterClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                UpdaterClient.DownloadFileAsync(new Uri(StatusResponse.Swapperlink), "JuicySwapper.exe");
                while (UpdaterClient.IsBusy)
                    Thread.Sleep(1000);
                if (File.Exists("JuicySwapper.exe"))
                {                           
                    Thread.Sleep(3000);
                    Process.Start("JuicySwapper.exe");
                    Environment.Exit(0);
                }
                else
                {
                    InformationsLabel.Text = "ERROR: JuicySwapper not downloaded!";
                }
            }
            catch
            {
                InformationsLabel.Text = "ERROR: Unknown!";
            }
        }
        private void ProgressChanged(object obj, DownloadProgressChangedEventArgs e)
        {
            counter++;

            if (counter % 200 == 0)
            {
                InformationsLabel.Text = ("Downloaded "
                                  + ((e.BytesReceived / 1024f) / 1024f).ToString("#0.##") + "Mo"
                                  + " of "
                                  + ((e.TotalBytesToReceive / 1024f) / 1024f).ToString("#0.##") + "Mo"
                                  + "  (" + e.ProgressPercentage + "%)"
                );
                ProgressBar.Value = e.ProgressPercentage;
            }
        }
        private void Completed(object obj, AsyncCompletedEventArgs e)
        {
            InformationsLabel.Text = "Update completed. Launching JuicySwapper!";
            ProgressBar.Value = 100;
        }
    }
}
