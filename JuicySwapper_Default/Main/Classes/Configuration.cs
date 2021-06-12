using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuicySwapper_Default.Main
{
    class Configuration
    {
        private string appdataPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Juicy Industries");
            }
        }

        string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Juicy Industries\\Configuration.Juicy";

        [JsonProperty("InstallLocation")]
        public string InstallLocation { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }

        public void Open()
        {
            if (!Directory.Exists(appdataPath))
            {
                Directory.CreateDirectory(appdataPath);
            }
            if (File.Exists(ConfigPath))
            {
                var configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(ConfigPath));

                InstallLocation = configuration.InstallLocation;

                Username = configuration.Username;
                Password = configuration.Password;

            }
            else
            {
                InstallLocation = EpicGames.GetEpicInstallLocations().FirstOrDefault(x => x.AppName == "Fortnite")?.InstallLocation;

                Username = "";
                Password = "";

                Save();
            }
        }

        public void Save() =>
            File.WriteAllText(ConfigPath,
                JsonConvert.SerializeObject(this));
    }
}

static class EpicGames
{
    public static List<Installation> GetEpicInstallLocations()
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");

        if (!Directory.Exists(Path.GetDirectoryName(path)) || !File.Exists(path))
            return null;

        return JsonConvert.DeserializeObject<EpicInstallLocations>(File.ReadAllText(path)).InstallationList;
    }

    public class EpicInstallLocations
    {
        [JsonProperty("InstallationList")]
        public List<Installation> InstallationList { get; set; }
    }

    public class Installation
    {
        [JsonProperty("InstallLocation")]
        public string InstallLocation { get; set; }

        [JsonProperty("AppName")]
        public string AppName { get; set; }
    }
}
