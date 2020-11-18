using JuicySwapper.Main.GUI;
using DiscordRPC;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using JuicySwapper.Main.Classes;
using static JuicySwapper.Classes.Json_Api.SatusAPI;
using static System.Environment;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JuicySwapper
{
	public class Juicy
	{
		public static InstallLocation LauncherInstalled => GetLauncherInstalled();
		//
		//RPC
		//
		public static readonly DiscordRpcClient discordrpc = new DiscordRpcClient("760881751849173033");
		public static void SetDiscordLocation(string Location)
		{
			discordrpc.SetPresence(new RichPresence
			{
				Details = $"🧃 • In {Location} Tab",
				State = "🧃 • juicyswapper.xyz",
				Assets = new Assets { LargeImageKey = "discordsmall2", LargeImageText = $"🧃 • Version v{Application.ProductVersion}" }
			});
		}

		public static void SetDiscordAction(string Action)
		{
			discordrpc.SetPresence(new RichPresence
			{
				Details = $"🧃 • {Action}",
				State = "🧃 • juicyswapper.xyz",
				Assets = new Assets { LargeImageKey = "discordsmall2", LargeImageText = $"🧃 • Version v{Application.ProductVersion}" }
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
