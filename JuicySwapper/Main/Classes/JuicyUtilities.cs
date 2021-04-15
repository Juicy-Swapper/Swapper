using JuicySwapper.Main.GUI;
using DiscordRPC;
using DiscordRPC.Message;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using System.Diagnostics;
using JuicySwapper.Api;
using static JuicySwapper.Api.SatusAPI;
using static System.Environment;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Security.Cryptography;
using System.Media;
using System.Threading;
using System.Collections.Generic;

namespace JuicySwapper
{
	public class JuicyUtilities
	{
		public static readonly DiscordRpcClient DiscordRPC = new DiscordRpcClient("779400510566039624");
		public static void SetRPCLocation(string Location, string ImageKey)
		{
			DiscordRPC.RegisterUriScheme();
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				State = "Browsing Home Page",
				Timestamps = Timestamps.Now,
				Buttons = new DiscordRPC.Button[] { new DiscordRPC.Button() { Label = "Discord", Url = "http://juicyswapper.xyz/discord" } },
				Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Version v{Application.ProductVersion}", SmallImageText = $"In {Location} Tab" }
			});
		}

		public static void SetRPCAction(string Action, string ImageKey)
		{
			DiscordRPC.RegisterUriScheme();
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				State = "Browsing Home Page",
				Timestamps = Timestamps.Now,
				Buttons = new DiscordRPC.Button[] { new DiscordRPC.Button() { Label = "Discord", Url = "http://juicyswapper.xyz/discord" } },
				Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Version v{Application.ProductVersion}", SmallImageText = $"{Action}" }
			});
		}

		public static void SetRPCSTAT(string STAT)
		{
			DiscordRPC.RegisterUriScheme();
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				State = STAT,
				Timestamps = Timestamps.Now,
				Buttons = new DiscordRPC.Button[] { new DiscordRPC.Button() { Label = "Discord", Url = "http://juicyswapper.xyz/discord" } },
				Assets = new Assets { LargeImageKey = "mainrpcimg", LargeImageText = $"🧃 • Version v{Application.ProductVersion}", }
			});; 
		}

		public static void SetRPCSTAT2(string STAT)
		{
			DiscordRPC.RegisterUriScheme();
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				State = STAT,
				Buttons = new DiscordRPC.Button[] { new DiscordRPC.Button() { Label = "Discord", Url = "http://juicyswapper.xyz/discord" } },
				Assets = new Assets { LargeImageKey = "mainrpcimg", LargeImageText = $"🧃 • Version v{Application.ProductVersion}", }
			});
		}

		//killfortnite
		public static void CloseEpicProcesses()
		{
			Process[] processes = Process.GetProcesses();

			foreach (Process process in processes)
			{
				if (process.ProcessName.Contains("Fortnite") || process.ProcessName.Contains("EpicGamesLauncher"))
					process.Kill();
			}
		}

		//GetStatus
		public static void GetStatus()
		{
			WebClient ProgramClient = new WebClient();

			try
			{
				new WebClient().DownloadString(API.HOST);
			}
			catch
			{
				Message Exception = new Message(Resources.Exception);
				Exception.ShowDialog();
			}

			var StatusAPI = new WebClient().DownloadString($"{API.HOST}/{API.Status}");
			Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);


			if (StatusResponse.IsOnline == false)
				new OfflineMode().ShowDialog();

			if (StatusResponse.Version != $"{Application.ProductVersion}")
            {
				if (File.Exists("JuicySwapper_Updater.exe"))
                {
					File.Delete("JuicySwapper_Updater.exe");
				}
				ProgramClient.Proxy = null;
				ProgramClient.DownloadFileAsync(new Uri(StatusResponse.updaterlink), "JuicySwapper_Updater.exe");
				while (ProgramClient.IsBusy)
					Thread.Sleep(1000);
				if (File.Exists("JuicySwapper_Updater.exe"))
				{
					Process.Start("JuicySwapper_Updater.exe");
					Environment.Exit(0);
				}
				else
					MessageBox.Show("Updater did not downloaded!");
			}
		}

		public static string GET_HARDWAREID => ReturnHardwareID().Result;
		private static async Task<string> ReturnHardwareID()
		{
			byte[] bytes;
			StringBuilder sb = new StringBuilder();

			Task task = Task.Run(() =>
			{
				ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT * FROM Win32_bios");
				ManagementObjectCollection bios_Collection = bios.Get();
				foreach (ManagementObject obj in bios_Collection)
				{
					sb.Append(obj["Version"].ToString());
					break;
				}

				ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
				ManagementObjectCollection hdd_Collection = hdd.Get();
				foreach (ManagementObject obj in hdd_Collection)
				{
					sb.Append(obj["SerialNumber"].ToString());
					break;
				}
			});
			Task.WaitAny(task);
			bytes = Encoding.UTF8.GetBytes(sb.ToString());
			return await Task.FromResult(Convert.ToBase64String(bytes).Substring(12));
		}

		public static bool DownloadConvert(string FileName)
        {
			WebClient Download = new WebClient();
			string file = $"{Settings.Default.InstallationPath}\\FortniteGame\\Binaries\\Win64\\EasyAntiCheat\\Launcher\\SplashScreen.png";

			if (!File.Exists(file))
            {
				return false;
			}
			else
            {
				File.Delete(file);
				Download.DownloadFile($"{API.HOST}/{API.Images}/{FileName}.png", file);
				return true;
			}
		}

		public static bool DownloadRevert()
		{
			WebClient Download = new WebClient();
			string file = $"{Settings.Default.InstallationPath}\\FortniteGame\\Binaries\\Win64\\EasyAntiCheat\\Launcher\\SplashScreen.png";

			if (!File.Exists(file))
            {
				return false;
			}
			else
			{
				File.Delete(file);
				Download.DownloadFile($"{API.HOST}/{API.Images}/splashscreen.png", file);
				return true;
			}
		}

		public void MusicControl(string Activated)
		{
			Stream str = Resources.ReliefMusic;
			SoundPlayer snd = new SoundPlayer(str);
			if (Activated == "True")
				snd.PlayLooping();
			else
				snd.Stop();
		}
	}
}

static class EpicGames
{
	public static List<Installation> GetEpicInstallLocations()
	{
		var path = Path.Combine(GetFolderPath(SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");

		if (!Directory.Exists(Path.GetDirectoryName(path)) || !File.Exists(path))
			return null;

		return JsonConvert.DeserializeObject<EpicInstallLocations>(File.ReadAllText(path)).InstallationList;
	}

	public class EpicInstallLocations
	{
		[JsonProperty("InstallationList")]
		public List<Installation> InstallationList { get; set; }
	}

	public class Installation
	{
		[JsonProperty("InstallLocation")]
		public string InstallLocation { get; set; }

		[JsonProperty("AppName")]
		public string AppName { get; set; }
	}
}
