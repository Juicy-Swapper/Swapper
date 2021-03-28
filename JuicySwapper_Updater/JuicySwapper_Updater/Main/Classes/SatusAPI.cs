using Newtonsoft.Json;

namespace JuicySwapper_Updater.Main.Classes
{
    class StatusAPI
    {
        public class Status
        {
            [JsonProperty("swapperlink")]
            public string Swapperlink { get; set; }

            [JsonProperty("version")]
            public string version { get; set; }
        }

    }
}
