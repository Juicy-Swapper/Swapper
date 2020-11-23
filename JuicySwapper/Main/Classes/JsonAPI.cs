using Newtonsoft.Json;

namespace JuicySwapper.Classes.Json_Api
{
    class ContentAPI
    {
        //Get The Content
        public class Type
        {
            [JsonProperty("news")]
            public NewsInfo News { get; set; }

            [JsonProperty("patchnotes")]
            public PatchnotesInfo Patchnotes { get; set; }
        }

        //news
        public class NewsInfo
        {
            [JsonProperty("title")]
            public string NewsTitle { get; set; }

            [JsonProperty("body")]
            public string NewsText { get; set; }

            [JsonProperty("image")]
            public string NewsImage { get; set; }
        }

        //patchnotes
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
        //Get Offsets
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
        //Gets paks
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
        //Gets Status
        public class Status
        {
            [JsonProperty("isOnline")]
            public bool IsOnline { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("updaterlink")]
            public string updaterlink { get; set; }

            [JsonProperty("annoucement")]
            public bool Annoucement { get; set; }

            [JsonProperty("annoucementmessage")]
            public string AnnoucementMessage { get; set; }
        }
    }
}
