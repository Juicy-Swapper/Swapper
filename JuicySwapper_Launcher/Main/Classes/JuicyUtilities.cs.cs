using DiscordRPC;
using DiscordRPC.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace JuicySwapper_Launcher.Main.Classes
{
	public class JuicyUtilities
    {
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
	}

	class JuicyUtilities_RPC
    {
		public static readonly DiscordRpcClient DiscordRPC = new DiscordRpcClient("854809091216900156"); //854809091216900156
		public static void SetRPCLocation(string Location)
		{
			DiscordRPC.RegisterUriScheme();
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				State = $"Browsing {Location} Page",
				Timestamps = Timestamps.Now,
				Buttons = new Button[] { new Button() { Label = "Discord", Url = "http://juicyswapper.xyz/discord" } },
				Assets = new Assets { LargeImageKey = "mainrpcimg", LargeImageText = $"🧃 • Powered By 0xkaede, Zylox and Tamely " }
			});
		}
	}
}
