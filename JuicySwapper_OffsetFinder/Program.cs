using JuicySwapper_OffsetFinder.Config;
using JuicySwapper_OffsetFinder.Properties;
using JuicySwapper_OffsetFinder.Stuff;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Environment;

namespace JuicySwapper_OffsetFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pathtopaks = $"{EpicGames.GetEpicInstallLocations().FirstOrDefault(x => x.AppName == "Fortnite")?.InstallLocation}\\FortniteGame\\Content\\Paks";

            LOGS.Logs.WriteEmbeddedColorLine($"[DarkYellow]Paks[/DarkYellow] - Found out {Pathtopaks}");

            string Skin_Body_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";
            string Skin_Head_Path = $"{Pathtopaks}\\pakchunk10_s5-WindowsClient.ucas";
            string Pickaxe_Mesh_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";
            string Backbling_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";
            string Emote_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";

            string Body = "6C 53 6B 69 6E 73 2F 42 52 5F 31 33 2F 4D 61 74 65 72 69 61 6C 45 44 42 6F 64 79 5F 42 52 31 33";
            string Head = "8C 02 04 99 F2 04 00 91 40 08 00 7F 17 00 20 00 80 6B 08 00 00 40 00 00 00 FD 04 00 00 40 05 00 00 60 01 00 00 A0 06 00 00 C8 06 00 00 58 07 00 00 80 07 30 00 1F 11 3F 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 48 61 74 73 2F 4D 61 74 65 72 69 61 6C";
            string PickMesh = "57 49 44 5F 48 72 76 65 73 74 5F 50 69 63 6B 61 78 65 5F 43 61 6E 64 79 43 61 6E 65";
            string BackMesh = "8C 02 04 04 F2 04 00 91 40 08 00 2F 1A 00 20 00 80 CF 07 00 00 40 00 00 00 64 04 00 00 A8 04 00 00 18 01 00 00 C0 05 00 00 F8 05 00 00 88 06 00 00 B0 06 00 00 18 37 00 5F 24 00 00 5C 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63 6B 73";
            string Emote = "8C 0A 00 06 7F 88 06 7D 06 00 00 00 00 00 00 00 00 04 C8 00 20 04 80 08 0A 40 00 00 00 D3 06 18 07 A8 01 C0 08 E8 08 30 09 48 09 04 3A 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73";
            string Blaze = "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 43 6F 73 6D 65 74 69 63 73 2F 42 6C 75 65 70 72 69 6E 74 73 2F 50 61 72 74 5F 4D 6F 64 69 66 69 65 72 73 42 5F 5F 5F 52 65 6E 65 67 61 64 65 52";
            
            Console.WriteLine(FindOffset(0, Skin_Body_Path, Body) - 8259645); //Body
            Console.WriteLine(FindOffset(0, Skin_Head_Path, Head) - 5090624); //Head
            Console.WriteLine(FindOffset(0, Pickaxe_Mesh_Path, PickMesh) - 4945909); //Pick_Mesh
            Console.WriteLine(FindOffset(0, Backbling_Path, BackMesh) - 2814016); //Back
            Console.WriteLine(FindOffset(0, Emote_Path, Emote) - 1458880); //Emote
            Console.WriteLine(FindOffset(0, Skin_Body_Path, Blaze) - 14940416); //blazemush
            LOGS.Logs.WriteEmbeddedColorLine($"[DarkYellow]Juicy[/DarkYellow] -  Found all offsets");
            Console.Read();
        }

        static long FindOffset(int Base, string Path, string Search)
        {
            while (true)
            {
                if (Researcher.FindPosition(Base, Path, Search))
                {
                    return Settings.Default.current_offset;
                }
                else
                    Base += Base / 2 / 2;
            }
        }
    }

    static class EpicGames
    {
        public static List<Installation> GetEpicInstallLocations()
        {
            var path = Path.Combine(GetFolderPath(SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");

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
}
