
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JuicySwapper_Encryption.StatusAPI;

namespace JuicySwapper_Encryption
{
    public class Scan
    {
        public static bool Check(string key)
        {
            if (File.Exists("JuicySwapper_Launcher.exe"))
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        var StatusAPI = webClient.DownloadString("https://juicyswapper.netlify.app/api/status.json");
                        Swapper StatusResponse = JsonConvert.DeserializeObject<Swapper>(StatusAPI);
                        webClient.Proxy = null;

                        string text = StatusResponse.Launcher.Version;
                        string fv = GetFileInfo("JuicySwapper_Launcher.exe");

                        if (!text.Contains(fv))
                        {
                            MessageBox.Show("Error number: 74832432", "Juicy Swapper - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else if (text.Contains(fv))
                        {
                            string info = GetInfo("JuicySwapper_Launcher.exe");

                            if (info.Contains("JuicySwapper_Launcher Juicy Industries Copyright © Juicy Industries 2020"))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Couldnt download assets", "Juicy Launcher - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }

        private static string GetFileInfo(string file)
        {
            FileVersionInfo fileVersionInfo = null;
            try
            {
                fileVersionInfo = FileVersionInfo.GetVersionInfo(file);
            }
            catch
            {
                MessageBox.Show("Error number: 74832431", "Juicy Launcher - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string text = string.Format("{0}.{1}.{2}.{3}", new object[]
            {
                    fileVersionInfo.FileMajorPart,
                    fileVersionInfo.FileMinorPart,
                    fileVersionInfo.FileBuildPart,
                    fileVersionInfo.FilePrivatePart,
            });
            return text;
        }

        private static string GetInfo(string file)
        {
            FileVersionInfo fileVersionInfo = null;
            try
            {
                fileVersionInfo = FileVersionInfo.GetVersionInfo(file);
            }
            catch
            {
                MessageBox.Show("Error number: 74832434", "Juicy Launcher - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string text = string.Format("{0} {1} {2}", new object[]
            {
                    fileVersionInfo.FileDescription,
                    fileVersionInfo.CompanyName,
                    fileVersionInfo.LegalCopyright,
            });
            return text;
        }
    }

    class StatusAPI
    {
        public class Swapper
        {
            [JsonProperty("JuicySwapper_Launcher")]
            public Status Launcher { get; set; }
        }

        public class Status
        {
            [JsonProperty("version")]
            public string Version { get; set; }

        }

    }
}
