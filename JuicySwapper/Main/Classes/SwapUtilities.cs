using JuicySwapper.Main.GUI;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using static JuicySwapper.Classes.Json_Api.OffsetsAPI;

namespace JuicySwapper.Main.Classes
{
    class SwapUtilities
    {
		public string[] GetSwapPath()
		{
			string Skin_Body_Path = Settings.Default.pakPath + "\\pakchunk10_s4-WindowsClient.ucas";
			string Skin_Head_Path = Settings.Default.pakPath + "\\pakchunk10_s5-WindowsClient.ucas";
			string Pickaxe_Mesh_Path = Settings.Default.pakPath + "\\pakchunk10_s4-WindowsClient.ucas";
			string Backbling_Path = Settings.Default.pakPath + "\\pakchunk10_s1-WindowsClient.ucas";
			string Emote_Path = Settings.Default.pakPath + "\\pakchunk10_s2-WindowsClient.pak";

			return new string[] { Skin_Body_Path, Skin_Head_Path, Pickaxe_Mesh_Path, Backbling_Path, Emote_Path };
		}

		public int[] GetSwapOffset()
		{
			int Offset_Skin_Body = Settings.Default.offset_skin_body;
			int Offset_Skin_Head = Settings.Default.offset_skin_head;
			int Offset_Pick_Mesh = Settings.Default.offset_pick_mesh;
			int Offset_Back_Mesh = Settings.Default.offset_back_mesh;
			int Offset_Emote_Mesh = Settings.Default.offset_emote_mesh;
			int Offset_Temp_gender = Settings.Default.offset_temp;

			return new int[] { Offset_Skin_Body, Offset_Skin_Head, Offset_Pick_Mesh, Offset_Back_Mesh, Offset_Emote_Mesh, Offset_Temp_gender };
		}

		public int[] GetSwapOffsetTemp()
		{
			int TempBackCapMat = 20000000;
			int TempBackfx = 2500000;
			int Offset_Pick_Mesh = 10000000;
			int Offset_Back_Mesh = Settings.Default.offset_back_mesh;
			int Offset_Emote_Mesh = Settings.Default.offset_emote_mesh;

			return new int[] { TempBackCapMat, TempBackfx, Offset_Pick_Mesh, Offset_Back_Mesh, Offset_Emote_Mesh };
		}

		public string[] GetSwapPathTemp()
		{
			string TempBackCapMat = Settings.Default.pakPath + "\\pakchunk10_s10-WindowsClient.ucas";
			string TempBackfx = Settings.Default.pakPath + "\\pakchunk10_s14-WindowsClient.ucas";
			string Pickaxe_Mesh_Path = Settings.Default.pakPath + "\\pakchunk10_s3-WindowsClient.ucas";
			string Backbling_Path = Settings.Default.pakPath + "\\pakchunk10_s1-WindowsClient.ucas";
			string Emote_Path = Settings.Default.pakPath + "\\pakchunk10_s2-WindowsClient.pak";

			return new string[] { TempBackCapMat, TempBackfx, Pickaxe_Mesh_Path, Backbling_Path, Emote_Path };
		}

		public string[] GetBackupPaths()
		{
			string Skin_Body_Path = "PakBackup/pakchunk10_s4-WindowsClient.ucas";
			string Skin_Head_Path = "PakBackup/pakchunk10_s5-WindowsClient.ucas";
			string Pickaxe_Mesh_Path = "PakBackup/pakchunk10_s4-WindowsClient.ucas";
			string Backbling_Path = "PakBackup/pakchunk10_s1-WindowsClient.ucas";
			string Emote_Path = "PakBackup/pakchunk10_s2-WindowsClient.pak";

			return new string[] { Skin_Body_Path, Skin_Head_Path, Pickaxe_Mesh_Path, Backbling_Path, Emote_Path };
		}

		public List<bool> AssaultTrooper = new List<bool>()
		{
			Settings.Default.SparkleSpecialistEnabled,
			Settings.Default.headhunterATEnabled,
			Settings.Default.RenegadeRaiderEnabled,
			Settings.Default.SurvivalSpecialistEnabled
		};

		public List<bool> Dominator = new List<bool>()
		{
			Settings.Default.ReconExpertEnabled,
			Settings.Default.BansheeEnabled
		};

		public List<bool> Commando = new List<bool>()
		{
			Settings.Default.RamirezEnabled
		};

		public List<bool> ArcticAssassin = new List<bool>()
		{
			Settings.Default.RamirezAAEnabled
		};

		public List<bool> Renegade = new List<bool>()
		{
			Settings.Default.BansheeRenEnabled
		};

		public List<bool> TacticsOfficer = new List<bool>()
		{
			Settings.Default.BansheeTOEnabled
		};

		public List<bool> Pathfinder = new List<bool>()
		{
			Settings.Default.WildcatEnabled
		};

		public List<bool> Shadowbird = new List<bool>()
		{
			Settings.Default.sunbirdEnabled
		};

		public List<bool> Scout = new List<bool>()
		{
			Settings.Default.SpitfireEnabled
		};

		public List<bool> Tracker = new List<bool>()
		{
			Settings.Default.HawkEnabled
		};

		public List<bool> Trooper = new List<bool>()
		{
			Settings.Default.RenegadeEnabled
		};

		public List<bool> RedShield = new List<bool>()
		{
			Settings.Default.BlackShieldEnabled
		};

		public static string SkinSwapped;
		public static string SkinSwappedFor;

		public bool CheckIfCanSwap(string s)
		{
			switch (s)
			{
				case "AssaultTrooper":
					if (AssaultTrooper.All(a => a) || AssaultTrooper.All(a => !a))
						return false;
					else
						SkinSwapped = "Assault Trooper";

					if (Settings.Default.SparkleSpecialistEnabled)
						SkinSwappedFor = "Sparkle Specialist";
					else if (Settings.Default.headhunterATEnabled)
						SkinSwappedFor = "Head Hunter";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Dominator":
					if (Dominator.All(a => a) || Dominator.All(a => !a))
						return false;
					else
						SkinSwapped = "Dominator";

					if (Settings.Default.ReconExpertEnabled)
						SkinSwappedFor = "Recon Expert";
					else if (Settings.Default.BansheeEnabled)
						SkinSwappedFor = "Banshee";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Commando":
					if (Commando.All(a => a) || Commando.All(a => !a))
						return false;
					else
						SkinSwapped = "Commando";

					if (Settings.Default.RamirezEnabled)
						SkinSwappedFor = "Ramirez";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "ArcticAssassin":
					if (ArcticAssassin.All(a => a) || ArcticAssassin.All(a => !a))
						return false;
					else
						SkinSwapped = "ArcticAssassin";

					if (Settings.Default.RamirezAAEnabled)
						SkinSwappedFor = "Ramirez";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Renegade":
					if (Renegade.All(a => a) || Renegade.All(a => !a))
						return false;
					else
						SkinSwapped = "Renegade";

					if (Settings.Default.BansheeRenEnabled)
						SkinSwappedFor = "Banshee";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "TacticsOfficer":
					if (TacticsOfficer.All(a => a) || TacticsOfficer.All(a => !a))
						return false;
					else
						SkinSwapped = "TacticsOfficer";

					if (Settings.Default.BansheeTOEnabled)
						SkinSwappedFor = "Banshee";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Pathfinder":
					if (Pathfinder.All(a => a) || Pathfinder.All(a => !a))
						return false;
					else
						SkinSwapped = "Pathfinder";

					if (Settings.Default.WildcatEnabled)
						SkinSwappedFor = "Wildcat";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Shadowbird":
					if (Shadowbird.All(a => a) || Shadowbird.All(a => !a))
						return false;
					else
						SkinSwapped = "Shadowbird";

					if (Settings.Default.sunbirdEnabled)
						SkinSwappedFor = "SunBird";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Scout":
					if (Scout.All(a => a) || Scout.All(a => !a))
						return false;
					else
						SkinSwapped = "Scout";

					if (Settings.Default.SpitfireEnabled)
						SkinSwappedFor = "Spitfire";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Tracker":
					if (Tracker.All(a => a) || Tracker.All(a => !a))
						return false;
					else
						SkinSwapped = "Tracker";

					if (Settings.Default.HawkEnabled)
						SkinSwappedFor = "Hawk";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "Trooper":
					if (Trooper.All(a => a) || Trooper.All(a => !a))
						return false;
					else
						SkinSwapped = "Trooper";

					if (Settings.Default.RenegadeEnabled)
						SkinSwappedFor = "Renegade";

					new CheckIfSwapMesg().ShowDialog();
					break;

				case "RedShield":
					if (RedShield.All(a => a) || RedShield.All(a => !a))
						return false;
					else
						SkinSwapped = "Red Shield";

					if (Settings.Default.BlackShieldEnabled)
						SkinSwappedFor = "Black Shild";

					new CheckIfSwapMesg().ShowDialog();
					break;

					
			}
			return true;
		}

		public static string Exp;
		//offsets
		public static void Requestoffsets()
		{
			try
			{
				//Downloads JSON from Juicy Swapper API.
				var OffsetsAPI = new WebClient().DownloadString($"{Api.HOST}/{Api.Offsets}");

				//Deserializes JSON from Juicy Swapper API.
				Offsets StatusResponse = JsonConvert.DeserializeObject<Offsets>(OffsetsAPI);

				//Sets Form Items from API Response.
				Settings.Default.offset_skin_body = int.Parse(StatusResponse.Body); //offset body
				Settings.Default.offset_skin_head = int.Parse(StatusResponse.Head); //offset head
				Settings.Default.offset_pick_mesh = int.Parse(StatusResponse.Pickaxe); //offset pickaxe
				Settings.Default.offset_back_mesh = int.Parse(StatusResponse.Backbling); //offset pickaxe
				Settings.Default.offset_emote_mesh = int.Parse(StatusResponse.Emotes); //offset pickaxe
				Settings.Default.Save();
			}
			catch
			{
				Exp = "Offsets";
				new ExceptionMess().ShowDialog();
			}
		}

		//paks || cba to use atm
		/*public static void RequestPaks()
	      {
		   try
		   {
			   //Downloads JSON from Juicy Swapper API.
			   var PaksAPI = new WebClient().DownloadString($"{Api.HOST}/{Api.Paks}");

			   //Deserializes JSON from Juicy Swapper API.
			   Paks StatusResponse = JsonConvert.DeserializeObject<Paks>(PaksAPI);

			   //Sets Form Items from API Response.
			   Settings.Default.Save();
		   }
		   catch
		   {
			   Exp = "Paks";
			   new ExceptionMess().ShowDialog();
		   }
	   } */
	}
}
