using Newtonsoft.Json;

namespace JuicySwapper.Main.Classes
{
    public class InstallLocation
    {
        [JsonProperty("InstallationList")]
        public Installation[] InstallationList { get; set; }

        public class Installation
        {
            [JsonProperty("InstallLocation")]
            public string InstallLocation { get; set; }

            [JsonProperty("AppName")]
            public string AppName { get; set; }

            [JsonProperty("AppVersion")]
            public string AppVersion { get; set; }
        }
    }
}
