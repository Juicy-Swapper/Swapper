﻿using JuicySwapper.Api;
using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static JuicySwapper.Api.OffsetsAPI;
using static JuicySwapper.Api.PaksAPI;

namespace JuicySwapper.Main.Classes
{
    public class SwapUtilities
    {
		public string[] GetSwapPath()
		{
			var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";

			string Skin_Body_Path = $"{Pathtopaks}\\{Settings.Default.pak_skin_body}"; 
			string Skin_Head_Path = $"{Pathtopaks}\\{Settings.Default.pak_skin_head}";
			string Pickaxe_Mesh_Path = $"{Pathtopaks}\\{Settings.Default.pak_pick_mesh}";
			string Backbling_Path = $"{Pathtopaks}\\{Settings.Default.pak_back_mesh}";
			string Emote_Path = $"{Pathtopaks}\\{Settings.Default.pak_emote_mesh}";
			string pak_s17 = $"{Pathtopaks}\\pakchunk100_s17-WindowsClient.ucas";
			string Pickaxe_Mesh_Path_2 = $"{Pathtopaks}\\pakchunk100_s3-WindowsClient.ucas";
			string pak_s22 = $"{Pathtopaks}\\pakchunk100_s22-WindowsClient.ucas";

			return new string[] { Skin_Body_Path, Skin_Head_Path, Pickaxe_Mesh_Path, Backbling_Path, Emote_Path, pak_s17, Pickaxe_Mesh_Path_2, pak_s22 };
		}

		public int[] GetSwapOffset()
		{
			int Offset_Skin_Body = Settings.Default.offset_skin_body;
			int Offset_Skin_Head = Settings.Default.offset_skin_head;
			int Offset_Pick_Mesh = Settings.Default.offset_pick_mesh;
			int Offset_Back_Mesh = Settings.Default.offset_back_mesh;
			int Offset_Emote_Mesh = Settings.Default.offset_emote_mesh;
			int Offset_Blaze_Mesh = Settings.Default.offsetBlaze;
			int Jen_Temp = 130000000;
			int Pickaxe_Mesh_Path_2 = 1;
			int Emote_Path_2 = 1;
			int ShadowRuby = 244000000;

			return new int[] { Offset_Skin_Body, Offset_Skin_Head, Offset_Pick_Mesh, Offset_Back_Mesh, Offset_Emote_Mesh, Offset_Blaze_Mesh, Jen_Temp, Pickaxe_Mesh_Path_2, Emote_Path_2, ShadowRuby };
		}

		public string[] GetEACPath()
        {
			var PathtoEAC = $"{Settings.Default.InstallationPath}\\FortniteGame\\Binaries\\Win64\\EasyAntiCheat\\Launcher";
			string One = $"{PathtoEAC}\\SplashScreen.png";

			return new string[] { One };
		}

		public List<bool> NiteLite = new List<bool>()
		{
			Settings.Default.GhoulOGEnabled,
			Settings.Default.RednoseEnabled,
			Settings.Default.GalaxyEnabled,
			Settings.Default.TechLlamaEnabled,
			Settings.Default.GalaxyGirlEnabled
		};

		public List<bool> Blaze = new List<bool>()
		{
			Settings.Default.BrenegadeEnabled,
			Settings.Default.BrenegadeCEnabled,
			Settings.Default.WildcatBlazeEnabled,
			Settings.Default.WildcatBlueBlazeEnabled,
			Settings.Default.GrimeyBlazeEnabled,
			Settings.Default.CatwomenEnabled
		};

		public List<bool> Redline = new List<bool>()
		{
			Settings.Default.RrenegadeEnabled,
			Settings.Default.RrenegadeCEnabled,
			Settings.Default.AerialAssaultTrooperEnabled,
			Settings.Default.ReconSpecialistEnabled
		};

		public List<bool> GingerReneade = new List<bool>()
		{
			Settings.Default.RrenegadeEnabled,
			Settings.Default.GrenegadeCEnabled
		};

		public List<bool> Diva = new List<bool>()
		{
			Settings.Default.SirenEnabled,
			Settings.Default.TravisEnabled,
			Settings.Default.WildcatRSEnabled,
			Settings.Default.ScourgeEnabled,
			Settings.Default.ChaosAgentEnabled
		};

		public List<bool> DivaB = new List<bool>()
		{
			Settings.Default.SixStringEnabled,
			Settings.Default.InsigniaEnabled
		};

		public List<bool> BoogieDown = new List<bool>()
		{
			Settings.Default.ScenarioEnabled,
			Settings.Default.FlossEnabled
		};

		public List<bool> Neon = new List<bool>()
		{
			Settings.Default.LoserfruitEnabled,
			Settings.Default.WildcatBlueEnabled,
			Settings.Default.MeggEnabled,
			Settings.Default.IsabelleEnabled,
			Settings.Default.WildcatNeoEnabled,
			Settings.Default.AloyEnabled,
			Settings.Default.AloyStyleEnabled
		};

		public List<bool> RockAxe = new List<bool>()
		{
			Settings.Default.StarwandEnabled,
			Settings.Default.StuddedEnabled,
			Settings.Default.GuandaoEnabled
		};

		public List<bool> CaratCutter = new List<bool>()
		{
			Settings.Default.StarwandRSEnabled,
			Settings.Default.AxecaliburEnabled,
			Settings.Default.AloySpearEnabled
		};

		public List<bool> SideHustle = new List<bool>()
		{
			Settings.Default.SavageEnabled,
			Settings.Default.FreemixEnabled,
			Settings.Default.HitItEnabled,
			Settings.Default.BicycleEnabled,
			Settings.Default.SocksEnabled
		};
		public List<bool> BlowingBubbles = new List<bool>()
		{
			Settings.Default.ChickenEnabled,
			Settings.Default.LeaveTheDoorOpenEnabled,
			Settings.Default.CatComicEnabled,
		};
		public List<bool> TonyStark = new List<bool>()
		{
			Settings.Default.GrimeyEnabled,
			Settings.Default.EcoEnabled,
			Settings.Default.KelsierEnabled,
			Settings.Default.DeathStrokeEnabled,
			Settings.Default.SpireImmortalEnabled,
			Settings.Default.ThanosEnabled
		};

		public List<bool> FrozenAxe = new List<bool>()
		{
			Settings.Default.VisionEnabled,
			Settings.Default.GalaxyAxeEnabled
		};
		public List<bool> Turk = new List<bool>()
		{
			Settings.Default.IkonikEnabled
		};

		public List<bool> EAC = new List<bool>()
		{
			Settings.Default.JuicyEAC1Enabled
		};
		public List<bool> Jennifer2 = new List<bool>()
		{
			Settings.Default.FocusEnabled,
			Settings.Default.HarleyQuinnEnabled,
			Settings.Default.HushEnabled,
			Settings.Default.ManicEnabled,
			Settings.Default.TigeressEnabled,
			Settings.Default.StoneViperEnabled,
			Settings.Default.ClipEnabled,
			Settings.Default.DizzieEnabled,
			Settings.Default.CelesteEnabled
		};
		public List<bool> TippyTap = new List<bool>()
		{

		};
		public List<bool> ShadowRuby = new List<bool>()
		{
			Settings.Default.SpartanAssassinEnabled,
			Settings.Default.WildcatBlueSREnabled,
			Settings.Default.TheChampionEnabled,
			Settings.Default.LokBotEnabled,
			Settings.Default.SpaceCuddleEnabled,
			Settings.Default.SpaceCuddleBlueEnabled,
			Settings.Default.SpaceCuddleWhiteEnabled,
			Settings.Default.ChunLiEnabled

		};

		





		public bool CheckIfCanSwap(string s)
		{
			switch (s)
			{
				case "Nitelite":
					if (NiteLite.All(a => a) || NiteLite.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Nitelite is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Blaze":
					if (Blaze.All(a => a) || Blaze.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Blaze is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Redline":
					if (Redline.All(a => a) || Redline.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Redline is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "GingerReneade":
					if (GingerReneade.All(a => a) || GingerReneade.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using GingerReneade is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Diva":
					if (Diva.All(a => a) || Diva.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Diamond Diva is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break; 

				case "DivaB":
					if (DivaB.All(a => a) || DivaB.All(a => !a))
						return false;
					else
						MessageBox.Show("A Backbling using Diamond Diva back pack is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "BoogieDown":
					if (BoogieDown.All(a => a) || BoogieDown.All(a => !a))
						return false;
					else
						MessageBox.Show("A Emote using Boogie Down is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Neon":
					if (Neon.All(a => a) || Neon.All(a => !a))
						return false;
					else
						MessageBox.Show("A Skin using Neo Versa is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "RockAxe":
					if (RockAxe.All(a => a) || RockAxe.All(a => !a))
						return false;
					else
						MessageBox.Show("A Pickaxe using RockAxe is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "6CaratCutter":
					if (CaratCutter.All(a => a) || CaratCutter.All(a => !a))
						return false;
					else
						MessageBox.Show("A Pickaxe using 6-Carat Cutter is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;
				case "SideHustle":
					if (SideHustle.All(a => a) || SideHustle.All(a => !a))
						return false;
					else
						MessageBox.Show("A Emote using Side Hustle is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;
				case "BlowingBubbles":
					if (BlowingBubbles.All(a => a) || BlowingBubbles.All(a => !a))
						return false;
					else
						MessageBox.Show("A Emote using Blowing Bubbles is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");

					break;
				case "TonyStark":
					if (TonyStark.All(a => a) || TonyStark.All(a => !a))
						return false;
					else
						MessageBox.Show("A Skin using TonyStark is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");

					break;

				case "FrozenAxe":
					if (FrozenAxe.All(a => a) || FrozenAxe.All(a => !a))
						return false;
					else
						MessageBox.Show("A Pickaxe using Frozen Axe is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");

					break;
				case "Turk":
					if (Turk.All(a => a) || Turk.All(a => !a))
						return false;
					else
						MessageBox.Show("A Skin using Turk vs Riptide is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");

					break;
				case "Jennifer2":
					if (Jennifer2.All(a => a) || Jennifer2.All(a => !a))
						return false;
					else
						MessageBox.Show("A Skin using Jennifer Walters is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;
				case "ShadowRuby":
					if (ShadowRuby.All(a => a) || ShadowRuby.All(a => !a))
						return false;
					else
						MessageBox.Show("A Skin using Ruby Shadows is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

			}
			return true;
		}

		public static void Requestoffsets()
		{
			try
			{
				//Downloads JSON from Juicy Swapper API.
				var OffsetsAPI = new WebClient().DownloadString($"{API.HOST}/{API.Offsets}");

				//Deserializes JSON from Juicy Swapper API.
				Offsets StatusResponse = JsonConvert.DeserializeObject<Offsets>(OffsetsAPI);

				//Sets Form Items from API Response.
				Settings.Default.offset_skin_body = int.Parse(StatusResponse.Body); //offset body
				Settings.Default.offset_skin_head = int.Parse(StatusResponse.Head); //offset head
				Settings.Default.offset_pick_mesh = int.Parse(StatusResponse.Pickaxe); //offset pickaxe
				Settings.Default.offset_back_mesh = int.Parse(StatusResponse.Backbling); //offset pickaxe
				Settings.Default.offset_emote_mesh = int.Parse(StatusResponse.Emotes); //offset pickaxe
				Settings.Default.offsetBlaze = int.Parse(StatusResponse.Blaze); //offset pickaxe
				Settings.Default.Save();
			}
			catch
			{
				Message Exception = new Message(Resources.Exception);
				Exception.ShowDialog();
			}
		}

		public static void RequestPaks()
	    {
		   try
		   {
			   //Downloads JSON from Juicy Swapper API.
			   var PaksAPI = new WebClient().DownloadString($"{API.HOST}/{API.Paks}");

			   //Deserializes JSON from Juicy Swapper API.
			   Paks StatusResponse = JsonConvert.DeserializeObject<Paks>(PaksAPI);

				//Sets Form Items from API Response.
				Settings.Default.pak_skin_body = (StatusResponse.Body); //pak body
				Settings.Default.pak_skin_head = (StatusResponse.Head); //pak head
				Settings.Default.pak_pick_mesh = (StatusResponse.Pickaxe); //pak pickaxe
				Settings.Default.pak_back_mesh = (StatusResponse.Backbling); //pak pickaxe
				Settings.Default.pak_emote_mesh = (StatusResponse.Emotes); //pak pickaxe
		   }
		   catch
		   {
				Message Exception = new Message(Resources.Exception);
				Exception.ShowDialog();
		   }
	    }
	}
}
