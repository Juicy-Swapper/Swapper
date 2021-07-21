using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace JuicySwapper_PakFixer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fixing swapper path");
            dupepaks();
        }

        static void dupepaks()
        {
            var pakPath = $"{EpicGames.GetEpicInstallLocations().FirstOrDefault(x => x.AppName == "Fortnite")?.InstallLocation}\\FortniteGame\\Content\\Paks";

            Console.WriteLine($"Paks found at - {pakPath}");
            var pak = pakPath + "\\pakchunk100_s3-WindowsClient.ucas";

            if (!File.Exists(pak))
            {
                //ucas
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.ucas", pakPath + "\\pakchunk100_s3-WindowsClient.ucas");
                Console.WriteLine("Copied pakchunk10_s3-WindowsClient.ucas - pakchunk100_s3-WindowsClient.ucas 1/5");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.ucas", pakPath + "\\pakchunk100_s4-WindowsClient.ucas");
                Console.WriteLine("Copied pakchunk10_s4-WindowsClient.uca - pakchunk100_s4-WindowsClient.ucas 2/5");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.ucas", pakPath + "\\pakchunk100_s5-WindowsClient.ucas");
                Console.WriteLine("Copied pakchunk10_s5-WindowsClient.ucas - pakchunk100_s5-WindowsClient.ucas 3/5");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.ucas", pakPath + "\\pakchunk100_s17-WindowsClient.ucas");
                Console.WriteLine("Copied pakchunk10_s17-WindowsClient.ucas - pakchunk100_s17-WindowsClient.ucas 4/5");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.ucas", pakPath + "\\pakchunk100_s22-WindowsClient.ucas");
                Console.WriteLine("Copied pakchunk10_s22-WindowsClient.ucas - pakchunk100_s22-WindowsClient.ucas 5/5");
                Console.WriteLine("Done 1/4");

                //utoc
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.utoc", pakPath + "\\pakchunk100_s3-WindowsClient.utoc");
                Console.WriteLine("Copied pakchunk10_s3-WindowsClient.utoc - pakchunk100_s3-WindowsClient.utoc 1/5");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.utoc", pakPath + "\\pakchunk100_s4-WindowsClient.utoc");
                Console.WriteLine("Copied pakchunk10_s4-WindowsClient.utoc - pakchunk100_s4-WindowsClient.utoc 2/5");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.utoc", pakPath + "\\pakchunk100_s5-WindowsClient.utoc");
                Console.WriteLine("Copied pakchunk10_s5-WindowsClient.utoc - pakchunk100_s5-WindowsClient.utoc 3/5");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.utoc", pakPath + "\\pakchunk100_s17-WindowsClient.utoc");
                Console.WriteLine("Copied pakchunk10_s17-WindowsClient.utoc - pakchunk100_s17-WindowsClient.utoc 4/5");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.utoc", pakPath + "\\pakchunk100_s22-WindowsClient.utoc");
                Console.WriteLine("Copied pakchunk10_s22-WindowsClient.utoc - pakchunk100_s22-WindowsClient.utoc 5/5");
                Console.WriteLine("Done 2/4");

                //pak
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.pak", pakPath + "\\pakchunk100_s3-WindowsClient.pak");
                Console.WriteLine("Copied pakchunk10_s3-WindowsClient.pak - pakchunk100_s3-WindowsClient.pak 1/5");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.pak", pakPath + "\\pakchunk100_s4-WindowsClient.pak");
                Console.WriteLine("Copied pakchunk10_s4-WindowsClient.pak - pakchunk100_s4-WindowsClient.pak 2/5");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.pak", pakPath + "\\pakchunk100_s5-WindowsClient.pak");
                Console.WriteLine("Copied pakchunk10_s5-WindowsClient.pak - pakchunk100_s5-WindowsClient.pak 3/5");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.pak", pakPath + "\\pakchunk100_s17-WindowsClient.pak");
                Console.WriteLine("Copied pakchunk10_s17-WindowsClient.pak - pakchunk100_s17-WindowsClient.pak 4/5");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.pak", pakPath + "\\pakchunk100_s22-WindowsClient.pak");
                Console.WriteLine("Copied pakchunk10_s22-WindowsClient.pak - pakchunk100_s22-WindowsClient.pak 5/5");
                Console.WriteLine("Done 3/4");

                //sig
                File.Copy(pakPath + "\\pakchunk10_s3-WindowsClient.sig", pakPath + "\\pakchunk100_s3-WindowsClient.sig");
                Console.WriteLine("Copied pakchunk10_s3-WindowsClient.sig - pakchunk100_s3-WindowsClient.sig 1/5");

                File.Copy(pakPath + "\\pakchunk10_s4-WindowsClient.sig", pakPath + "\\pakchunk100_s4-WindowsClient.sig");
                Console.WriteLine("Copied pakchunk10_s4-WindowsClient.sig - pakchunk100_s4-WindowsClient.sig 2/5");

                File.Copy(pakPath + "\\pakchunk10_s5-WindowsClient.sig", pakPath + "\\pakchunk100_s5-WindowsClient.sig");
                Console.WriteLine("Copied pakchunk10_s5-WindowsClient.sig - pakchunk100_s5-WindowsClient.sig 3/5");

                File.Copy(pakPath + "\\pakchunk10_s17-WindowsClient.sig", pakPath + "\\pakchunk100_s17-WindowsClient.sig");
                Console.WriteLine("Copied pakchunk10_s17-WindowsClient.sig - pakchunk100_s17-WindowsClient.sig 4/5");

                File.Copy(pakPath + "\\pakchunk10_s22-WindowsClient.sig", pakPath + "\\pakchunk100_s22-WindowsClient.sig");
                Console.WriteLine("Copied pakchunk10_s22-WindowsClient.sig - pakchunk100_s22-WindowsClient.sig 5/5");
                Console.WriteLine("Done 4/4");
                Console.Read();

            }
            Console.WriteLine("Paks already fixed");
            Console.Read();
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
