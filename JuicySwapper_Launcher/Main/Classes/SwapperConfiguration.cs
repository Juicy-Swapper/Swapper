using JuicySwapper_Launcher.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JuicySwapper_Launcher.SatusAPI;

namespace JuicySwapper_Launcher
{
    public class SwapperConfiguration
    {
        public static void GetEveryStatus()
        {
            GetStatus();
            GetDefaultStatus();
        }
		//GetStatus
		public static void GetStatus()
		{
			var StatusAPI = new WebClient().DownloadString($"{API.HOST}/{API.Status}");
			Swapper StatusResponse = JsonConvert.DeserializeObject<Swapper>(StatusAPI);

            var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper.exe";

            if (!File.Exists(InstallFolder))
            {
                Settings.Default.SwapperStatus = 3;
                Settings.Default.Save();
                return;
            }

            if (!StatusResponse.JuicySwapper.IsOnline == false)
            {
                Settings.Default.SwapperStatus = 1;
                Settings.Default.Save();
                return;
            }

			if (StatusResponse.JuicySwapper.Version == GetFileVer(InstallFolder))
            {
                Settings.Default.SwapperStatus = 2;
                Settings.Default.Save();
                return;
            }

            Settings.Default.SwapperStatus = 0;
            Settings.Default.Save();
        }

        public static void GetDefaultStatus()
        {
            var StatusAPI = new WebClient().DownloadString($"{API.HOST}/{API.Status}");
            Swapper StatusResponse = JsonConvert.DeserializeObject<Swapper>(StatusAPI);

            var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper_Default.exe";

            if (StatusResponse.JuicySwapper_Defualt.IsOnline == false)
            {
                Settings.Default.SwapperStatus_Default = 1;
                Settings.Default.Save();
                return;
            }

            if (!File.Exists(InstallFolder))
            {
                Settings.Default.SwapperStatus_Default = 3;
                Settings.Default.Save();
                return;
            }


            if (StatusResponse.JuicySwapper_Defualt.Version == GetFileVer(InstallFolder))
            {
                Settings.Default.SwapperStatus_Default = 2;
                Settings.Default.Save();
                return;
            }

            Settings.Default.SwapperStatus_Default = 0;
            Settings.Default.Save();
        }

        public static string GetFileVer(string InstallFolder)
        {
            FileVersionInfo FileVersionInfo = null;
            try
            {
                FileVersionInfo = FileVersionInfo.GetVersionInfo(InstallFolder);
            }
            catch
            {
                MessageBox.Show("ERROR: Unknown");
            }
            return $"{FileVersionInfo.FileMajorPart}.{FileVersionInfo.FileMinorPart}.{FileVersionInfo.FileBuildPart}.{FileVersionInfo.FilePrivatePart}"; ;
        }
        
    }

    class SatusAPI
    {
        public class Swapper
        {
            [JsonProperty("JuicySwapper")]
            public Status JuicySwapper { get; set; }

            [JsonProperty("JuicySwapper_Defualt")]
            public Status JuicySwapper_Defualt { get; set; }
        }

        public class Status
        {
            [JsonProperty("isOnline")]
            public bool IsOnline { get; set; }

            [JsonProperty("Encryption.dll")]
            public string Encryption { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("swapperlink")]
            public string Swapperlink { get; set; }
        }
    }

    class API
    {
        public static string HOST = "https://juicyswapper.netlify.app";
        public static string Content = "api/content.json";
        public static string Status = "api/status.json";
        public static string Offsets = "api/offsets.json";
        public static string Discord = "discord";
        public static string Images = "api/images";
        public static string Paks = "api/paks.json";
        public static string FortniteNews = "api/paks.json";
        public static string DefaultPFP = "Accounts/PFP.PNG";
    }

    class FortniteAPI
    {
        public static string HOST = "https://fortnite-api.com";
        public static string News = "v2/news/br";
    }
}
