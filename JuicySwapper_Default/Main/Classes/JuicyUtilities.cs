using JuicySwapper_Default.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Default.Main.Classes
{
    class JuicyUtilities
    {

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
}
