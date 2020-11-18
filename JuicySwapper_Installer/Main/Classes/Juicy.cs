using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Installer.Main.Classes
{
    class Juicy
    {
        public static readonly DiscordRpcClient discordrpc = new DiscordRpcClient("704324460291031047");
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

    }
}
