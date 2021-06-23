using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static JuicySwapper_Launcher.SatusAPI;


namespace JuicySwapper_Launcher.Main.GUI
{
    public partial class Setup : Form
    {
        static WebClient SetupClient = new WebClient();
        static int counter;

        [ComImport]
        [Guid("00021401-0000-0000-C000-000000000046")]
        internal class ShellLink
        {
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("000214F9-0000-0000-C000-000000000046")]
        internal interface IShellLink
        {
            void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
            void GetIDList(out IntPtr ppidl);
            void SetIDList(IntPtr pidl);
            void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
            void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
            void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
            void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
            void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
            void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
            void GetHotkey(out short pwHotkey);
            void SetHotkey(short wHotkey);
            void GetShowCmd(out int piShowCmd);
            void SetShowCmd(int iShowCmd);
            void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
            void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
            void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
            void Resolve(IntPtr hwnd, int fFlags);
            void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
        }

        public Setup()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            SetupDL();       
        }
        public void SetupDL()
        {
            string AppdataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            foreach (Process process in Process.GetProcessesByName("JuicySwapper.exe"))
            {
                process.Kill();
            }

            try
            {
                if (Directory.Exists(AppdataFolder + "\\Juicy Industries"))
                {
                    DeleteDirectory(AppdataFolder + "\\Juicy Industries");
                    Thread.Sleep(100);
                    Directory.CreateDirectory(AppdataFolder + "\\Juicy Industries");
                }
                else
                    Directory.CreateDirectory(AppdataFolder + "\\Juicy Industries");
            }
            catch
            {
                InformationsLabel.Text = "ERROR: Cannot create installation folder!";
                return;
            }
            Downloader.RunWorkerAsync();
        }

        private void Downloader_DoWork(object sender, DoWorkEventArgs e)
        {
            string InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries";
            try
            {
                var StatusAPI = SetupClient.DownloadString("http://juicyswapper.xyz/api/status.json");
                Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
                SetupClient.Proxy = null;
                SetupClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                SetupClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                SetupClient.DownloadFileAsync(new Uri(StatusResponse.Swapperlink), InstallFolder + "\\JuicySwapper.exe");
                while (SetupClient.IsBusy)
                    Thread.Sleep(1000);
                if (File.Exists(InstallFolder + "\\JuicySwapper.exe"))
                {
                    SwapperConfiguration.GetStatus();
                    Thread.Sleep(2000);
                    Close();
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

        public static void DeleteDirectory(string DirectoryToDelete)
        {
            string[] files = Directory.GetFiles(DirectoryToDelete);
            string[] dirs = Directory.GetDirectories(DirectoryToDelete);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(DirectoryToDelete, false);
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
            InformationsLabel.Text = "Installation completed.";
            ProgressBar.Value = 100;
        }
    }
}
