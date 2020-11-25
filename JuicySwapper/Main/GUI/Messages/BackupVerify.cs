using JuicySwapper.Main.Classes;
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
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();
            if (File.Exists(SwapPath[0]) && File.Exists(SwapPath[1]))
            {
                backupWorker.RunWorkerAsync();
            }
            else
            {
                new PakError().ShowDialog();
            }
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            string[] BackPath = SwapUtilities.GetBackupPaths();
            if (File.Exists(BackPath[0]) && File.Exists(BackPath[1]))
            {
                backupWorker.RunWorkerAsync();
            }
            else
            {
                new PakError().ShowDialog();
            }
        }

        SwapUtilities SwapUtilities = new SwapUtilities();

        private void backupWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();
            string[] BackPath = SwapUtilities.GetBackupPaths();
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
                    Directory.Delete("PakBackup");
                }

                richTextBox1.Text += $"[{DateTime.Now}] Creating Pak Backup folder...\n";

                Directory.CreateDirectory("PakBackup");

                richTextBox1.Text += $"[{DateTime.Now}] Pak Backup folder created!\n";


                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 1/4\n";

                File.Copy(SwapPath[0], BackPath[0]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 1/4 game files!\n";

                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 2/4\n";

                File.Copy(SwapPath[1], BackPath[1]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 2/4 game files!\n";

                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 3/4\n";

                File.Copy(SwapPath[2], BackPath[2]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 3/4 game files!\n";

                richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 4/4\n";

                File.Copy(SwapPath[3], BackPath[3]);

                richTextBox1.Text += $"[{DateTime.Now}] Copied 3/4 game files!\n";


                richTextBox1.Text += $"[{DateTime.Now}] Successfully created backup of your game files!\n";
            }
            catch (Exception)
            {
                SwapUtilities.Exp = "backup";
                new ExceptionMess().ShowDialog();
            }
        }

        private void verifyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();
            string[] BackPath = SwapUtilities.GetBackupPaths();
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

                    richTextBox1.Text += $"[{ DateTime.Now}] Pak Backup folder detected!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Creating Pak Backup folder...\n";

                    Directory.CreateDirectory("PakBackup");

                    richTextBox1.Text += $"[{DateTime.Now}] Pak Backup folder created!\n";


                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 1/4\n";

                    File.Copy(BackPath[0], SwapPath[0]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 1/4 game files!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 2/4\n";

                    File.Copy(BackPath[1], SwapPath[1]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 2/4 game files!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 3/4\n";

                    File.Copy(BackPath[2], SwapPath[2]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 3/4 game files!\n";

                    richTextBox1.Text += $"[{DateTime.Now}] Copying game files... 4/4\n";

                    File.Copy(BackPath[3], SwapPath[3]);

                    richTextBox1.Text += $"[{DateTime.Now}] Copied 4/4 game files!\n";

                    File.Delete(BackPath[0]);
                    File.Delete(BackPath[1]);
                    File.Delete(BackPath[2]);
                    File.Delete(BackPath[3]);

                    Directory.Delete("PakBackup");
                }
                else
                {
                    MessageBox.Show($"[{DateTime.Now}] Pak Backup folder found, but no .pak files exist!", "Juicy Swapper - Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                SwapUtilities.Exp = "verify";
                new ExceptionMess().ShowDialog();
            }
        }
    }
}
