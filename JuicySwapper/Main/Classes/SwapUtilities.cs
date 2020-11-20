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
			string Skin_Body_Path = Settings.Default.pakPath + "\\pakchunk10_s2-WindowsClient.ucas";
			string Skin_Head_Path = Settings.Default.pakPath + "\\pakchunk10_s2-WindowsClient.ucas";
			string Pickaxe_Mesh_Path = Settings.Default.pakPath + "\\pakchunk10_s2-WindowsClient.pak";
			string Pickaxe_Sound_Path = Settings.Default.pakPath + "\\pakchunk10_s2-WindowsClient.pak";
			string Backbling_Path = Settings.Default.pakPath + "\\pakchunk10_s3-WindowsClient.pak";
			string Emote_Path = Settings.Default.pakPath + "\\pakchunk10_s2-WindowsClient.pak";

			return new string[] { Skin_Body_Path, Skin_Head_Path, Pickaxe_Mesh_Path, Pickaxe_Sound_Path, Backbling_Path, Emote_Path };
		}

		public int[] GetSwapOffset()
		{
			int Offset_Skin_Body = Settings.Default.offset_skin_body;
			int Offset_Skin_Head = Settings.Default.offset_skin_head;
			int Offset_Pick_Mesh = Settings.Default.offset_pick_mesh;
			int Offset_Back_Mesh = Settings.Default.offset_back_mesh;
			int Offset_Emote_Mesh = Settings.Default.offset_emote_mesh;

			return new int[] { Offset_Skin_Body, Offset_Skin_Head, Offset_Pick_Mesh, Offset_Back_Mesh, Offset_Emote_Mesh };
		}

		public List<bool> AssaultTrooper = new List<bool>()
		{
			Settings.Default.SparkleSpecialistEnabled,
			Settings.Default.headhunterATEnabled
		};

		public List<bool> Dominator = new List<bool>()
		{
			Settings.Default.ReconExpertEnabled
		};

		public List<bool> Commando = new List<bool>()
		{
			Settings.Default.RamirezEnabled
		};

		public List<bool> ArcticAssassin = new List<bool>()
		{
			Settings.Default.RamirezAAEnabled
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
					if (Commando.All(a => a) || Commando.All(a => !a))
						return false;
					else

						SkinSwapped = "ArcticAssassin";
					if (Settings.Default.RamirezAAEnabled)
						SkinSwappedFor = "Ramirez";

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
				var OffsetsAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/offsets.json");

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
			   var PaksAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/json/paks.json");

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
