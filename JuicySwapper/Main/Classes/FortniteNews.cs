using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper.Main.Classes
{
    public class FortniteJson
    {
        public string DataNews { get; set; } // this will store the JSON string
        public List<Data> DataList { get; set; } // this will be the actually list. 

        public class Data
        {
            [JsonProperty("data")]
            public Motds data { get; set; }
        }

        public class Motds
        {
            public string image { get; set; }
            public string tileImage { get; set; }
        }

    }

    public class FortniteNews
    {
        public void ChangeNews()
        {
            //Models.FortniteJson financialData = (Models.FortniteJson)JsonConvert.DeserializeObject(myJSON, typeof(Models.FinancialData));

            //var StatusAPI = new WebClient().DownloadString(Api.API.FortniteApiNews);
            //FortniteJson StatusResponse = JsonConvert.DeserializeObject<FortniteJson>(StatusAPI.data) as JArray;

            //MessageBox.Show("");

            //foreach (var account in StatusAPI)
            //{
            //    if (financialData.AccountsList == null)
            //    {
            //        financialData.AccountsList = new List<data.image>();
            //    }

            //}
        }



    }


}
