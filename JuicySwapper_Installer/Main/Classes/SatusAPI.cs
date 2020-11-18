using Newtonsoft.Json;

namespace JuicySwapper_Installer.Main.Classes
{
    class StatusAPI
    {
        public class Status
        {
            [JsonProperty("swapperlink")]
            public string Swapperlink { get; set; }

            [JsonProperty("updaterlink")]
            public string updaterlink { get; set; }
        }

    }
}
