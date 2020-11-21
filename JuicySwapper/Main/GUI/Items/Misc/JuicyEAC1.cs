using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Items.Misc
{
    public partial class JuicyEAC1 : Form
    {
        public JuicyEAC1()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            if (Settings.Default.JuicyEAC1Enabled == true)
                convertButton.Text = "Revert";
        
            else
                convertButton.Text = "Convert";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string filePath = Settings.Default.pakPath + "\\pakchunk10_s3-WindowsClient.pak";

            if (!File.Exists(filePath))
            {
                PakError a = new PakError(); a.ShowDialog();
                return;
            }

            else
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var Download = new WebClient();
            string Path = Settings.Default.InstallationPath + "\\FortniteGame\\Binaries\\Win64\\EasyAntiCheat\\Launcher";
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";
                File.Delete(Path + "\\SplashScreen.png");
                Download.DownloadFile("https://cdn.discordapp.com/attachments/729442108703899730/740299807280726036/JuicyEAC1.png", Path + "\\SplashScreen.png"); 
                RichTextBoxInfo.Text += "\n[LOG] Converted 1/1";
                Settings.Default.JuicyEAC1Enabled = true;
                convertButton.Text = "Revert";
                stopwatch.Stop();
                double numb = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + numb + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";
                File.Delete(Path + "\\SplashScreen.png");
                Download.DownloadFile("https://cdn.discordapp.com/attachments/729442108703899730/740300140983877783/SplashScreen.png", Path + "\\SplashScreen.png");
                RichTextBoxInfo.Text += "\n[LOG] Reverted 1/1";
                Settings.Default.JuicyEAC1Enabled = false;
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double numb = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + numb + " ms.");

            }
        }
    }
}
