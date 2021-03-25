using JuicySwapper_Account.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JuicySwapper_Account.Classes.JuicyUtilities;
using static JuicySwapper_Account.Classes.Mongodb;

namespace JuicySwapper_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]JuicySwapper[/DarkYellow] - info] Getting infomation from our database.");
            MongoCRUD db = new MongoCRUD("JuicySwapper");
            string hwid = JuicyUtilities.GET_HARDWAREID;

            var onerec = db.LoadRecordByHwid<UserModel>("Juicy", hwid);

            ColorConsole.WriteEmbeddedColorLine($"[DarkYellow]------------------------------Details------------------------------[/DarkYellow]");
            ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]Username[/DarkYellow] - info] {onerec.username}");
            ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]Password[/DarkYellow] - info] {Decrypt(onerec.password)}");
            ColorConsole.WriteEmbeddedColorLine($"[DarkYellow]------------------------------Other------------------------------[/DarkYellow]");
            ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]CreatedAt[/DarkYellow] - info] {onerec.CreatedAt}");
            ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]HWID[/DarkYellow] - info] {onerec.HWID}");
            ColorConsole.WriteEmbeddedColorLine($"[{DateTime.Now:H:mm:ss} - [DarkYellow]ID[/DarkYellow] - info] {onerec.Id}");

            Console.Read();
        }
    }
}
