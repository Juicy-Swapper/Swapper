
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
        //Use uppercase letters
        public static string[] windownames = { "DNSPY", "ILSPY", "DOTPEEK", "FIDDLER", "JUSTDECOMPILE" };
        /// <summary>
        /// Kills a programs just as C# Decompilers and Net Debuggers
        /// </summary>
        public static void KillSuspicious() => 
            Process.GetProcesses().Where(x => windownames.Any(x.MainWindowTitle.ToUpper().Contains)).All(a => { a.Kill(); return true; });

        public static bool Check(string key)
        {
            KillSuspicious();

            if (File.Exists("JuicySwapper.exe"))
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        var StatusAPI = webClient.DownloadString("http://juicyswapper.xyz/api/status.json");
                        Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
                        webClient.Proxy = null;

                        string text = StatusResponse.version;
                        string fv = GetFileInfo("JuicySwapper.exe");

                        if (!text.Contains(fv))
                        {
                            MessageBox.Show("Error number: 74832432", "Juicy Swapper - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else if (text.Contains(fv))
                        {
                            string info = GetInfo("JuicySwapper.exe");

                            if (info.Contains("JuicySwapper Juicy Industries Copyright © Juicy Industries 2020"))
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
                        MessageBox.Show("Couldnt download assets", "Juicy Swapper - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error number: 74832431", "Juicy Swapper - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error number: 74832434", "Juicy Swapper - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public class Status
        {
            [JsonProperty("version")]
            public string version { get; set; }
        }

    }
}
