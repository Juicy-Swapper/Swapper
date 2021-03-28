using DiscordRPC;
using System.Windows.Forms;

namespace JuicySwapper_Updater.Main.Classes
{
    class Juicy
    {
        public static readonly DiscordRpcClient DiscordRPC = new DiscordRpcClient("779410134244786206");
		public static void SetRPCLocation(string Location, string ImageKey)
		{
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				Timestamps = Timestamps.Now,
				Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Discord https://discord.gg/z6yqBdvBfH", SmallImageText = $"In {Location} Tab" }
			});
		}

		public static void SetRPCAction(string Action, string ImageKey)
		{
			DiscordRPC.SetPresence(new RichPresence
			{
				Details = "juicyswapper.xyz",
				Timestamps = Timestamps.Now,
				Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Discord https://discord.gg/z6yqBdvBfH", SmallImageText = $"{Action}" }
			});
		}
	}
}
