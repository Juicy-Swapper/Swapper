using Newtonsoft.Json;

namespace JuicySwapper.Api
{
    class API
    {
        public static string HOST = "http://juicyswapper.xyz";
        public static string Content = "api/content.json";
        public static string Status = "api/status.json";
        public static string Offsets = "api/offsets.json";
        public static string Discord = "discord";
        public static string Images = "api/images/";
        public static string Paks = "";
    }

    class ContentAPI
    {
        public class Type
        {
            [JsonProperty("news")]
            public NewsInfo News { get; set; }

            [JsonProperty("patchnotes")]
            public PatchnotesInfo Patchnotes { get; set; }
        }

        public class NewsInfo
        {
            [JsonProperty("title")]
            public string NewsTitle { get; set; }

            [JsonProperty("body")]
            public string NewsText { get; set; }

            [JsonProperty("image")]
            public string NewsImage { get; set; }
        }

        public class PatchnotesInfo
        {
            [JsonProperty("title")]
            public string PatchnotesTitle { get; set; }

            [JsonProperty("body")]
            public string PatchnotesText { get; set; }
        }
    }

    class OffsetsAPI
    {
        public class Offsets
        {
            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("head")]
            public string Head { get; set; }

            [JsonProperty("pickaxesmesh")]
            public string Pickaxe { get; set; }

            [JsonProperty("backbling")]
            public string Backbling { get; set; }

            [JsonProperty("emotes")]
            public string Emotes { get; set; }

            [JsonProperty("lobby")]
            public string Lobby { get; set; }
        }
    }

    class PaksAPI
    {
        public class Paks
        {
            [JsonProperty("body")]
            public string NormalBody { get; set; }

            [JsonProperty("head")]
            public string NormalHead { get; set; }

            [JsonProperty("pickaxesmesh")]
            public string NormalPickaxesmesh { get; set; }

            [JsonProperty("pickaxesound")]
            public string NormalPickaxesound { get; set; }

            [JsonProperty("backbling")]
            public string NormalBackbling { get; set; }

            [JsonProperty("emotes")]
            public string NormalEmotes { get; set; }

            [JsonProperty("lobby")]
            public string NormalLobby { get; set; }
        }
    }

    class SatusAPI
    {
        public class Status
        {
            [JsonProperty("isOnline")]
            public bool IsOnline { get; set; }

            [JsonProperty("offlineMessage")]
            public string OfflineMessage { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("updaterlink")]
            public string updaterlink { get; set; }
        }
    }
}
