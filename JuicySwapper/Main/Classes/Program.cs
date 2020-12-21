//# Juicy Swapper
//**Juicy Swapper * * is a * *Fortnite skin swapper** developed in **C#**.

//### Important
//- **You are NOT authorized to rename Juicy Swapper and claim it as your own work.**
//- **You are NOT authorized to modify/distribute Juicy Swapper.**
//- **If you would like to add contributions, create a pull request or open a new issue.**


//### Links & Support

// -**For support and guidance, join[this Discord guild.](https://juicyswapper.xyz/discord)**
//-**My Discord username**: kaede@2005

//### Credits
// -**Myself * *: [@0xKaede on Twitter](https://twitter.com/0xkaede) 
// -**Tamely * *: [@TamelyFN on Twitter](https://twitter.com/TamelyFN)
//### Features
//-Installer
//   - Updater
//   - Advanced settings menu
//- Modern and clean design
//- Safe/secure loader (closes all Epic processes upon launch)
//-Json API based(developer mode, news/content, etc.)

//### Requirements
//This order also applies in the startup order.

//- **Visual Studio or any C# IDE**
using JuicySwapper.Main.GUI;
using System;
using System.IO;
using System.Windows.Forms;

namespace JuicySwapper
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Path.GetFileName(Path.GetDirectoryName(Environment.CurrentDirectory)) == "Temp")
            {
                MessageBox.Show("Juicy Swapper cannot be run from WinRAR! Please extract to a folder and try again.", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //JuicyUtilities.GetStatus();
                Application.Run(new Loader());
            }
        }
    }
}
