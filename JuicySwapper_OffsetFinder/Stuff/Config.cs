using JuicySwapper_OffsetFinder.Properties;
using JuicySwapper_OffsetFinder.Stuff;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JuicySwapper_OffsetFinder.Config
{
    class Configuration
    {
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "offsets.json");

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

        public void Open()
        {

            if (File.Exists(path))
            {
                Body = "";
                Head = "";
                Pickaxe = "";
                Backbling = "";
                Emotes = "";

            }
            else
            {
                Body = "";
                Head = "";
                Pickaxe = "";
                Backbling = "";
                Emotes = "";

                Save();
            }
        }

        public void Save() =>
            File.WriteAllText(path,
                JsonConvert.SerializeObject(this));
    }
}
