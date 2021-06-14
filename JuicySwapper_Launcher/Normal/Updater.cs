
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using static JuicySwapper_Launcher.SatusAPI;

namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class Updater : Form
    {
        static WebClient UpdaterClient = new WebClient();
        static int counter;
        public Updater()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            UpdaterBG.RunWorkerAsync();
        }

        private void UpdaterBG_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper.exe";

                if (File.Exists(InstallFolder))
                {
                    File.Delete(InstallFolder);
                }
                var StatusAPI = UpdaterClient.DownloadString("http://juicyswapper.xyz/api/status.json");
                Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
                UpdaterClient.Proxy = null;
                UpdaterClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                UpdaterClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                UpdaterClient.DownloadFileAsync(new Uri(StatusResponse.Swapperlink), InstallFolder);
                while (UpdaterClient.IsBusy)
                    Thread.Sleep(1000);
                if (File.Exists(InstallFolder))
                {
                    SwapperConfiguration.GetStatus();
                    Thread.Sleep(2000);
                    this.Close();
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
            InformationsLabel.Text = "Update completed.";
            ProgressBar.Value = 100;
        }

        private void Updater_Load(object sender, EventArgs e)
        {

        }
    }
}
