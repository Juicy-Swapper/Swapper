using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuicySwapper_Default.Main.Classes
{

    public class ContentAPI
    {
        public class Type
        {
            [JsonProperty("cosmetics")]
            public string Cosmetics { get; set; }

            [JsonProperty("news")]
            public NewsInfo News { get; set; }

            [JsonProperty("patchnotes")]
            public PatchnotesInfo Patchnotes { get; set; }
        }

        public class CosInfo
        {
            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("IconSwap")]
            public string IconSwap { get; set; }

            [JsonProperty("Icon")]
            public string Icon { get; set; }

            [JsonProperty("Swap1")]
            public string Swap1 { get; set; }

            [JsonProperty("Swap2")]
            public string Swap2 { get; set; }
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


}
