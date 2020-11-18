using Newtonsoft.Json;

namespace JuicySwapper.Classes.Json_Api
{
    class ContentAPI
    {
        //What Swapper
        public class Type
        {
            [JsonProperty("swapper")]
            public Content Swapper { get; set; }

            [JsonProperty("idswapper")]
            public Content IDswapper { get; set; }
        }

        //Get The Content
        public class Content
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
        //What Offsets
        public class Offsets
        {
            [JsonProperty("normaloffsets")]
            public NormalOffsets Normal { get; set; }

            [JsonProperty("cpoffsets")]
            public CpOffsets CP { get; set; }
        }

        //Get Offsets
        public class NormalOffsets
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

        //Get Offsets
        public class CpOffsets
        {
            [JsonProperty("body")]
            public string CPBody { get; set; }

            [JsonProperty("head")]
            public string CPHead { get; set; }

            [JsonProperty("rdm")]
            public string CPRdm { get; set; }

            [JsonProperty("rdf")]
            public string CPRdf { get; set; }
        }
    }

    class PaksAPI
    {
        //What paks
        public class Paks
        {
            [JsonProperty("normalpaks")]
            public NormalPaks Normal { get; set; }

            [JsonProperty("cppaks")]
            public CpPaks CP { get; set; }
        }

        //Gets paks
        public class NormalPaks
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

        //Gets paks
        public class CpPaks
        {
            [JsonProperty("body")]
            public string CPBody { get; set; }

            [JsonProperty("head")]
            public string CPHead { get; set; }
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

            [JsonProperty("annoucement")]
            public bool Annoucement { get; set; }

            [JsonProperty("annoucementmessage")]
            public string AnnoucementMessage { get; set; }
        }
    }
}
