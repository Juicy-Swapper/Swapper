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
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Security.Cryptography;
using System.Linq;

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

		//GetStatus
		public static void GetStatus()
		{
			try
			{
				new WebClient().DownloadString(Api.HOST);
			}
			catch
			{
				Message Exception = new Message(Resources.Exception);
				Exception.ShowDialog();
			}

			var StatusAPI = new WebClient().DownloadString($"{Api.HOST}/{Api.Status}");
			Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

			if (StatusResponse.IsOnline == false)
				new OfflineMode().ShowDialog();

			if (StatusResponse.Version != $"{Application.ProductVersion}")
			    new Update().ShowDialog();
		}

		//HWID.GET_HARDWAREID
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

		public static string Encrypt(string clearText)
		{
			string EncryptionKey = "abc123";
			byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cs.Write(clearBytes, 0, clearBytes.Length);
						cs.Close();
					}
					clearText = Convert.ToBase64String(ms.ToArray());
				}
			}
			return clearText;
		}

		public static string Decrypt(string cipherText)
		{
			string EncryptionKey = "abc123";
			cipherText = cipherText.Replace(" ", "+");
			byte[] cipherBytes = Convert.FromBase64String(cipherText);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cs.Write(cipherBytes, 0, cipherBytes.Length);
						cs.Close();
					}
					cipherText = Encoding.Unicode.GetString(ms.ToArray());
				}
			}
			return cipherText;
		}
	}

	public class InstallLocation
	{
		[JsonProperty("InstallationList")]
		public Installation[] InstallationList { get; set; }

		public class Installation
		{
			[JsonProperty("InstallLocation")]
			public string InstallLocation { get; set; }

			[JsonProperty("AppName")]
			public string AppName { get; set; }

			[JsonProperty("AppVersion")]
			public string AppVersion { get; set; }
		}
	}
}
