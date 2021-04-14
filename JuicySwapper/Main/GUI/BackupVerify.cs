using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class BackupVerify : Form
    {
        public BackupVerify()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string[] GetSwapPath()
        {
            var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";

            string a = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";
            string b = $"{Pathtopaks}\\pakchunk10_s5-WindowsClient.ucas";
            string c = $"{Pathtopaks}\\pakchunk10_s17-WindowsClient.ucas";
            string d = $"{Pathtopaks}\\pakchunk10_s3-WindowsClient.ucas";
            string e = $"{Pathtopaks}\\pakchunk10_s22-WindowsClient.ucas";

            return new string[] { a, b, c, d, e };
        }

        public string[] GetBackupPaths()
        {
            string a = "PakBackup/pakchunk10_s4-WindowsClient.ucas";
            string b = "PakBackup/pakchunk10_s5-WindowsClient.ucas";
            string c = "PakBackup/pakchunk10_s17-WindowsClient.ucas";
            string d = "PakBackup/pakchunk10_s3-WindowsClient.ucas";
            string e = "PakBackup/pakchunk10_s22-WindowsClient.ucas";

            return new string[] { a, b, c, d, e };
        }

        private void backupWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] SwapPath = GetSwapPath();
            string[] BackPath = GetBackupPaths();
            try
            {
                if (Directory.Exists("PakBackup"))
                {
                    if (File.Exists(BackPath[0]))
                    {
                        File.Delete(BackPath[0]);
                    }
                    if (File.Exists(BackPath[1]))
                    {
                        File.Delete(BackPath[1]);
                    }
                    if (File.Exists(BackPath[2]))
                    {
                        File.Delete(BackPath[2]);
                    }
                    if (File.Exists(BackPath[3]))
                    {
                        File.Delete(BackPath[3]);
                    }
                    if (File.Exists(BackPath[4]))
                    {
                        File.Delete(BackPath[4]);
                    }
                    Directory.Delete("PakBackup");
                }

                richTextBox1.Text += $"[{DateTime.Now}] Creating Pak Backup folder...\n";

                Directory.CreateDirectory("PakBackup");

                richTextBox1.Text += $"[{DateTime.Now}] Pak Backup folder created!\n";


                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 1/4\n";

                File.Copy(SwapPath[0], BackPath[0]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 1/5 game files!\n";

                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 2/4\n";

                File.Copy(SwapPath[1], BackPath[1]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 2/5 game files!\n";

                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 3/4\n";

                File.Copy(SwapPath[2], BackPath[2]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 3/5 game files!\n";

                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 4/4\n";

                File.Copy(SwapPath[3], BackPath[3]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 4/5 game files!\n";

                File.Copy(SwapPath[4], BackPath[4]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 5/5 game files!\n";


                richTextBox1.Text += $"[{DateTime.Now}] Successfully created backup of your game files!\n";
            }
            catch (Exception EX)
            {
                richTextBox1.Text += $"[{DateTime.Now}] Error! Please contact the Juicy Swapper support team!";
            }
        }

        private void verifyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] SwapPath = GetSwapPath();
            string[] BackPath = GetBackupPaths();
            richTextBox1.Text = $"[{DateTime.Now}] Starting...\n";
            try
            {
                if (File.Exists(SwapPath[0]) && File.Exists(SwapPath[1]))
                {
                    if (File.Exists(SwapPath[0]))
                    {
                        File.Delete(SwapPath[0]);
                    }
                    if (File.Exists(SwapPath[1]))
                    {
                        File.Delete(SwapPath[1]);
                    }
                    if (File.Exists(SwapPath[2]))
                    {
                        File.Delete(SwapPath[2]);
                    }
                    if (File.Exists(SwapPath[3]))
                    {
                        File.Delete(SwapPath[3]);
                    }
                    if (File.Exists(SwapPath[4]))
                    {
                        File.Delete(SwapPath[4]);
                    }

                    richTextBox1.Text += $"[{ DateTime.Now}] Pak Backup folder detected!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Creating Pak Backup folder...\n";

                    Directory.CreateDirectory("PakBackup");

                    richTextBox1.Text += $"[{DateTime.Now}] Pak Backup folder created!\n";


                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 1/4\n";

                    File.Copy(BackPath[0], SwapPath[0]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 1/5 game files!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 2/4\n";

                    File.Copy(BackPath[1], SwapPath[1]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 2/5 game files!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 3/4\n";

                    File.Copy(BackPath[2], SwapPath[2]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 3/5 game files!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 4/4\n";

                    File.Copy(BackPath[3], SwapPath[3]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 4/5 game files!\n";

                    File.Copy(BackPath[4], SwapPath[4]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 5/5 game files!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Successfully verified your game files!\n";

                    File.Delete(BackPath[0]);
                    File.Delete(BackPath[1]);
                    File.Delete(BackPath[2]);
                    File.Delete(BackPath[3]);
                    File.Delete(BackPath[4]);

                    Directory.Delete("PakBackup");
                }
                else
                {
                    MessageBox.Show($"[{DateTime.Now}] Pak Backup folder found, but no .UCAS files exist!", "Juicy Swapper - Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                Message Exception = new Message(Resources.Exception);
                Exception.ShowDialog();
            }
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            string[] BackPath = GetBackupPaths();
            if (File.Exists(BackPath[0]) && File.Exists(BackPath[1]))
            {
                verifyWorker.RunWorkerAsync();
            }
            else
            {
                Message FortnitePathExp = new Message(Resources.pakfileerror);
                FortnitePathExp.ShowDialog();
            }
        }

        private void BackUpBtn_Click(object sender, EventArgs e)
        {
            string[] SwapPath = GetSwapPath();
            if (File.Exists(SwapPath[0]) && File.Exists(SwapPath[1]))
            {
                backupWorker.RunWorkerAsync();
            }
            else
            {
                Message FortnitePathExp = new Message(Resources.pakfileerror);
                FortnitePathExp.ShowDialog();
            }
        }

        private void BackupVerify_Load(object sender, EventArgs e)
        {

        }
    }
}
