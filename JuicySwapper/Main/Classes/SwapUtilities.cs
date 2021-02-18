using JuicySwapper.Main.GUI;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
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
			int Offset_Temp_gender = 134101198;

			return new int[] { Offset_Skin_Body, Offset_Skin_Head, Offset_Pick_Mesh, Offset_Back_Mesh, Offset_Emote_Mesh, Offset_Temp_gender };
		}

		public int[] GetSwapOffsetTemp()
		{
			int TempBackCapMat = 20000000;
			int TempBackfx = 2500000;
			int Offset_Pick_Mesh = 10000000;
			int Offset_Back_Mesh = 146504298;
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

		//public List<bool> Commando = new List<bool>()
		//{
		//	Settings.Default.RamirezEnabled
		//};

		//public List<bool> ArcticAssassin = new List<bool>()
		//{
		//	Settings.Default.RamirezAAEnabled
		//};

		//public List<bool> Renegade = new List<bool>()
		//{
		//	Settings.Default.BansheeRenEnabled
		//};

		//public List<bool> TacticsOfficer = new List<bool>()
		//{
		//	Settings.Default.BansheeTOEnabled
		//};

		//public List<bool> Pathfinder = new List<bool>()
		//{
		//	Settings.Default.WildcatEnabled
		//};

		//public List<bool> Shadowbird = new List<bool>()
		//{
		//	Settings.Default.sunbirdEnabled
		//};

		//public List<bool> Scout = new List<bool>()
		//{
		//	Settings.Default.SpitfireEnabled
		//};

		//public List<bool> Tracker = new List<bool>()
		//{
		//	Settings.Default.HawkEnabled
		//};

		//public List<bool> Trooper = new List<bool>()
		//{
		//	Settings.Default.RenegadeEnabled
		//};

		//public List<bool> RedShield = new List<bool>()
		//{
		//	Settings.Default.BlackShieldEnabled
		//};

		public bool CheckIfCanSwap(string s)
		{
			switch (s)
			{
				case "AssaultTrooper":
					if (AssaultTrooper.All(a => a) || AssaultTrooper.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Dominator is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Dominator":
					if (Dominator.All(a => a) || Dominator.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Dominator is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;
			}
			return true;
		}

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
				Message Exception = new Message(Resources.Exception);
				Exception.ShowDialog();
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
