using JuicySwapper_Default.IO;
using JuicySwapper_Default.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Default.Main.GUI
{
    public partial class SkinSwapper : Form
    {
        private static BackgroundWorker Bw;
        private static BackgroundWorker BwRevert;

        Configuration Configuration;

        public SkinSwapper()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            
            Bw = new BackgroundWorker();
            BwRevert = new BackgroundWorker();
            vars.Swap1 = "";
            vars.Swap2 = "";
            vars.Swap3 = "";

            Configuration = new Configuration();
            Configuration.Open();


            WebClient ProgramClient = new WebClient();

            dynamic parsed = JObject.Parse(ProgramClient.DownloadString("https://juicyswapper.xyz/api/Defualt/Content.json"));
            foreach (var Cosmetics in parsed.Items)
            {
                if (Cosmetics.Name.ToString().Contains(vars.item))
                {
                    controlBar.Text = $"Juicy Default Swapper - {Cosmetics.Name}";
                    try
                    {
                        vars.Swap1 = Cosmetics.Swap1;
                        vars.BdynHead = parsed.Utilities.BodyNHead;
                        vars.BdynHeadFile = "//" + parsed.Utilities.BodyNHeadPak; 
                        vars.BdynHeadOffset = long.Parse(parsed.Utilities.BodyNHeadoffsets.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Unable to find the swaps! Contact Kaede on Discord!", "ERROR");
                        Process.GetCurrentProcess().Kill();
                    }

                    try
                    {
                        vars.Swap2 = parsed.Utilities.InvalidBoy2;
                        vars.InvalidBoy = parsed.Utilities.InvalidBoy;
                        vars.InvalidBoypak = "//" + parsed.Utilities.InvalidBoypak;
                        vars.InvalidBoyoffsets = long.Parse(parsed.Utilities.InvalidBoyoffsets.ToString());
                    }
                    catch
                    {
                    }

                    try
                    {
                        vars.Swap3 = parsed.Utilities.InvalidBoy;
                        vars.InvalidGirl = parsed.Utilities.InvalidBoy;
                        vars.InvalidGirlpak = "//" + parsed.Utilities.InvalidGirlpak;
                        vars.InvalidGirloffsets = long.Parse(parsed.Utilities.InvalidGirloffsets.ToString());
                    }
                    catch
                    {
                    }                    
                }

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Bw.DoWork += Convert;
            Bw.RunWorkerAsync();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            BwRevert.DoWork += Revert;
            BwRevert.RunWorkerAsync();
        }

        private void Convert(object sender, EventArgs e)
        {
            var pakfolder = $"{Settings.Default.pakPath}";

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            if (vars.Swap1 == "") return;
            bool Swap1 = Researcher.Convert(vars.BdynHeadOffset, $"{pakfolder}\\{vars.BdynHeadFile}", vars.BdynHead, vars.Swap1, 0, 0, false, true);
            if (Swap1)
            {
                Settings.Default.SkinSwapped = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            if (vars.Swap2 == "") return;
            bool Swap2 = Researcher.Convert(vars.InvalidBoyoffsets, $"{pakfolder}\\{vars.InvalidBoypak}", vars.InvalidBoy, vars.Swap2, 0, 0, false, true);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head added";

            if (vars.Swap3 == "") return;
            bool Swap3 = Researcher.Convert(vars.InvalidGirloffsets, $"{pakfolder}\\{vars.InvalidGirlpak}", vars.InvalidGirl, vars.Swap3, 0, 0, false, true);
            if (Swap3)
                LogBox.Text += "\n[LOG] Invalid added";

            LogBox.Text += "\n[LOG] Converted!";
        }

        private void Revert(object sender, EventArgs e)
        {
            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            var pakfolder = $"{Settings.Default.pakPath}\\FortniteGame\\Content\\Paks";

            if (vars.Swap1 == "") return;
            bool Swap1 = Researcher.Revert(vars.BdynHeadOffset, $"{pakfolder}\\{vars.BdynHeadFile}", vars.BdynHead, vars.Swap1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.SkinSwapped = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            if (vars.Swap2 == "") return;
            bool Swap2 = Researcher.Revert(vars.InvalidBoyoffsets, $"{pakfolder}\\{vars.InvalidBoypak}", vars.InvalidBoy, vars.Swap2, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head removed";

            if (vars.Swap3 == "") return;
            bool Swap3 = Researcher.Revert(vars.InvalidGirloffsets, $"{pakfolder}\\{vars.InvalidGirlpak}", vars.InvalidGirl, vars.Swap3, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Invalid removed";

            LogBox.Text += "\n[LOG] Reverted!";
        }

        private void Complete(object sender, EventArgs e)
        {
            LogBox.Text += "[LOG]: Successfully Completed!";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

