using JuicySwapper.Main.GUI;
using DiscordRPC;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using System.Diagnostics;
using JuicySwapper.Main.Classes;
using static JuicySwapper.Classes.Json_Api.SatusAPI;
using static System.Environment;

namespace JuicySwapper
{
	public class JuicyUtilities
	{
		public static InstallLocation LauncherInstalled => GetLauncherInstalled();

		public static readonly DiscordRpcClient DiscordRPC = new DiscordRpcClient("779400510566039624");
		public static void SetRPCLocation(string Location, string ImageKey)
		{
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				Timestamps = Timestamps.Now,
				Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Version v{Application.ProductVersion}", SmallImageText = $"In {Location} Tab" }
			});
		}

		public static void SetRPCAction(string Action, string ImageKey)
		{
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				Timestamps = Timestamps.Now,
				Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Version v{Application.ProductVersion}", SmallImageText = $"{Action}" }
			});
		}

		public static void FindPaks()
		{
			foreach (InstallLocation.Installation installation in LauncherInstalled.InstallationList)
			{
				if (installation.AppName == "Fortnite")
					Settings.Default.InstallationPath = installation.InstallLocation; Settings.Default.Save();
			}
		}

		static InstallLocation GetLauncherInstalled()
		{
			var path = Path.Combine(GetFolderPath(SpecialFolder.CommonApplicationData),
				"Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");

			if (!File.Exists(path))
				return new InstallLocation();
			else
				return JsonConvert.DeserializeObject<InstallLocation>(File.ReadAllText(path));
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

		//discordinvite
		public static void DiscordInvite()
		{
			Process.Start("http://juicyswapper.xyz/discord");
		}

		//twitter
		public static void Twitter() { Process.Start("http://juicyswapper.xyz/twitter"); }

		//Website
		public static void Website() { Process.Start("http://juicyswapper.xyz"); }

		//GetStatus
		public static void GetStatus()
		{
			var StatusAPI = new WebClient().DownloadString("https://juicyswapper.xyz/api/status.json");
			Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

			if (StatusResponse.IsOnline == false)
				new DevMode().ShowDialog();

			//if (StatusResponse.Version != $"{Application.ProductVersion}")
			//new Update().ShowDialog();

			if (StatusResponse.Annoucement == true)
				new Annoucement().ShowDialog();
		}
	}
}
