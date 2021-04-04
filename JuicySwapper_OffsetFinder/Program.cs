using JuicySwapper_OffsetFinder.Config;
using JuicySwapper_OffsetFinder.Properties;
using JuicySwapper_OffsetFinder.Stuff;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JuicySwapper_OffsetFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pakPath = "C:\\Program Files\\Epic Games\\Fortnite";
            var Pathtopaks = $"{pakPath}\\FortniteGame\\Content\\Paks";

            string Skin_Body_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";
            string Skin_Head_Path = $"{Pathtopaks}\\pakchunk10_s5-WindowsClient.ucas";
            string Pickaxe_Mesh_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";
            string Backbling_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";
            string Emote_Path = $"{Pathtopaks}\\pakchunk10_s4-WindowsClient.ucas";

            string Body = "6C 53 6B 69 6E 73 2F 42 52 5F 31 33 2F 4D 61 74 65 72 69 61 6C 45 44 42 6F 64 79 5F 42 52 31 33";
            string Head = "8C 02 04 A6 F2 04 00 91 40 08 00 7F 17 00 20 00 80 5A 08 00 00 40 00 00 00 EC 04 00 00 30 05 00 00 60 01 00 00 90 06 00 00 B8 06 00 00 48 07 00 00 70 07 30 00 1F 11 37 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 48 61 74 73 2F 4D 61 74 65 72 69 61 6C";
            string PickMesh = "57 49 44 5F 48 72 76 65 73 74 5F 50 69 63 6B 61 78 65 5F 43 61 6E 64 79 43 61 6E 65";
            string BackMesh = "8C 0A 00 04 85 88 04 83 06 00 00 00 00 00 00 00 00 03 36 00 20 00 80 EB 08 40 00 00 00 6B 05 B0 05 30 01 E0 06 18 07 A8 07 D0 18 5C 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 46 4F 52 54 5F 42 61 63 6B 70 61 63";
            string Emote = "8C 0A 00 05 89 88 05 87 04 00 00 00 00 00 00 00 00 04 06 00 20 04 80 A0 08 40 00 00 00 A3 05 E8 05 68 01 50 07 78 07 C0 D8 07 50 2F 47 61 6D 65 2F 41 6E 69 6D 61 74 69 6F 6E 4D 61 69 6E 50 6C 61 79 65 72 2F 45 6F 74 65 73";
            string Blaze = "8C 0A 00 05 8C 88 05 8A 00 00 00 00 00 00 00 00 00 03 CF 20 00 80 2A 0B 40 00 00 00 99 07 E0 07 88 01 68 09 90 09 20 0A 48 0A 04 45 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 5F 42 6F 64 79 5F 46 5F 52 65 6E 65 67 61 64 65 52 61 69 64 65 72 46 69 72 65 00 44 43 68 61 72 61 63 74 65 72 73";
            
            LOGS.Logs.WriteEmbeddedColorLine($"[DarkYellow]---------------------Juicy Ofsets Finder---------------------[/DarkYellow]");
            LOGS.Logs.WriteEmbeddedColorLine($"[DarkYellow]------------------------By kaede#2005------------------------[/DarkYellow]");
            Console.WriteLine(FindOffset(0, Skin_Body_Path, Body) - 8259645); //Body
            Console.WriteLine(FindOffset(0, Skin_Head_Path, Head) - 5090624); //Head
            Console.WriteLine(FindOffset(0, Pickaxe_Mesh_Path, PickMesh) - 4945909); //Pick_Mesh
            Console.WriteLine(FindOffset(0, Backbling_Path, BackMesh) - 2814016); //Back
            Console.WriteLine(FindOffset(0, Emote_Path, Emote) - 1458880); //Emote
            Console.WriteLine(FindOffset(0, Skin_Body_Path, Blaze) - 14940416); //blazemush
            LOGS.Logs.WriteEmbeddedColorLine($"[DarkYellow]---------------------------Done!----------------------------[/DarkYellow]");
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
}
