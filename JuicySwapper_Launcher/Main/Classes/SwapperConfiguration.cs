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
		//GetStatus
		public static void GetStatus()
		{
			var StatusAPI = new WebClient().DownloadString($"{API.HOST}/{API.Status}");
			Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

            var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper.exe";

            if (!File.Exists(InstallFolder))
            {
                Settings.Default.SwapperStatus = 3;
                Settings.Default.Save();
                return;
            }

            if (!StatusResponse.IsOnline == false)
            {
                Settings.Default.SwapperStatus = 1;
                Settings.Default.Save();
                return;
            }

			if (StatusResponse.Version != GetFileVer())
            {
                Settings.Default.SwapperStatus = 2;
                Settings.Default.Save();
                return;
            }

            Settings.Default.SwapperStatus = 0;
            Settings.Default.Save();
        }

        public static void closefo()
        {
            Home Home = new Home();
            Home.Hide();
        }

        public static string GetFileVer()
        {
            FileVersionInfo fileVersionInfo = null;

            var InstallFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\JuicySwapper.exe";
            try
            {
                fileVersionInfo = FileVersionInfo.GetVersionInfo(InstallFolder);
            }
            catch
            {
                MessageBox.Show("ERROR: Unknown");
            }
            return $"{fileVersionInfo.FileMajorPart}.{fileVersionInfo.FileMinorPart}.{fileVersionInfo.FileBuildPart}.{fileVersionInfo.FilePrivatePart}"; ;
        }
        
    }

    class SatusAPI
    {
        public class Status
        {
            [JsonProperty("isOnline")]
            public bool IsOnline { get; set; }

            [JsonProperty("offlineMessage")]
            public string OfflineMessage { get; set; }

            [JsonProperty("database")]
            public string Database { get; set; }

            [JsonProperty("Encryption.dll")]
            public string Encryption { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("updaterlink")]
            public string updaterlink { get; set; }

            [JsonProperty("swapperlink")]
            public string Swapperlink { get; set; }
        }
    }

    class API
    {
        public static string HOST = "http://juicyswapper.xyz";
        public static string Content = "api/content.json";
        public static string Status = "api/status.json";
        public static string Offsets = "api/offsets.json";
        public static string Discord = "discord";
        public static string Images = "api/images";
        public static string Paks = "api/paks.json";
        public static string FortniteApiNews = "https://fortnite-api.com/v2/news";
    }
}
