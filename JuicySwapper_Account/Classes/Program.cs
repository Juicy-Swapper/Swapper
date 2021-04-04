using JuicySwapper_Account.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using static JuicySwapper_Account.Classes.JuicyUtilities;
using static JuicySwapper_Account.Classes.Mongodb;
using System.Threading;

namespace JuicySwapper_Account
{
    class Program
    {
        public static MongoCRUD db = new MongoCRUD();

        static void Main(string[] args)
        {
            Thread.Sleep(5000);
            Console.WriteLine("sds");
            try
            {
                ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]JuicySwapper[/DarkYellow] - info] Getting infomation from our database.");

                string hwid = JuicyUtilities.GET_HARDWAREID;
                var onerec = db.LoadRecordByHwid<UserModel>("Juicy", hwid);

                ColorConsole.WriteEmbeddedColorLine($"[DarkYellow]------------------------------Details------------------------------[/DarkYellow]");
                ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]Username[/DarkYellow] - info] {onerec.username}");
                ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]Password[/DarkYellow] - info] {Decrypt(onerec.password)}");
                ColorConsole.WriteEmbeddedColorLine($"[DarkYellow]------------------------------Other------------------------------[/DarkYellow]");
                ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]CreatedAt[/DarkYellow] - info] {onerec.CreatedAt}");
                ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]HWID[/DarkYellow] - info] {onerec.HWID}");
                ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]ID[/DarkYellow] - info] {onerec.Id}");
            }
            catch
            {
                Console.Clear();
                ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [red]Error[/red] - info] Hwid not found in our database!");
            }
            Console.Read();
        }
    }
}
