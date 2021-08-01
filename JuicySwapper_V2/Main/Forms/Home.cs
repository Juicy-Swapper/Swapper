using MaterialSkin.Controls;
using System.Windows.Forms;
using MaterialSkin;
using JuicySwapper_V2.IO;
using System.IO;
using JuicySwapper_V2.Main.Classes;

namespace JuicySwapper_V2
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
            var MsM = MaterialSkinManager.Instance;
            MsM.AddFormToManage(this);
            MsM.Theme = MaterialSkinManager.Themes.DARK;
            MsM.ColorScheme = new ColorScheme(Primary.Pink200, Primary.Grey900, Primary.Grey900,
                Accent.DeepOrange100, TextShade.WHITE);

            PaksSorter a = new();
            a.ShowDialog();

        }

        public static void testswap(string a, long b, byte[] c)
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(a, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(b, SeekOrigin.Begin);
            binaryWriter.Write(c);
            binaryWriter.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var uassetpath = "FortniteGame/Content/Athena/Heroes/Meshes/Bodies/CP_124_Body_F_AuroraGlow.uasset";
            var uassetpath1 = "FortniteGame/Content/Characters/CharacterParts/Female/Medium/Heads/CP_Head_F_AuroraGlow.uasset";
            var uassetpath11 = "FortniteGame/Content/Characters/CharacterParts/Hats/CP_Hat_F_Commando_AuroraGlow.uasset";

            byte[] hi = Engine.ExportCompress(uassetpath, Directory.GetCurrentDirectory());
            File.WriteAllBytes(uassetpath, hi);

            Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\{uassetpath1.Replace(Path.GetFileName(uassetpath1), "")}");

            byte[] hii = Engine.ExportCompress(uassetpath1, Directory.GetCurrentDirectory());
            File.WriteAllBytes(uassetpath1, hii);

            //Engine.ExportCompresse(uassetpath, Directory.GetCurrentDirectory());
            //Engine.ExportCompresse(uassetpath1, Directory.GetCurrentDirectory());
            //Engine.ExportCompresse(uassetpath11, Directory.GetCurrentDirectory());


            return;
            

            Engine.disope();

            Researcher.ConvertInUasset(uassetpath, "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Aurora_Glow/Materials/M_F_Med_Soldier_01_AuroraGlow.M_F_Med_Soldier_01_AuroraGlow", "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/F_MED_Zombie_Pink/Materials/F_MED_Zombie_Pink_Body.F_MED_Zombie_Pink_Body");

            Directory.CreateDirectory("Fileee");

            Oodle.Oodle.Compress(uassetpath, Directory.GetCurrentDirectory()+ "\\Fileee\\" + "justyk.compressed");

            MessageBox.Show("Export Done");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var dataswap = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\Fileee\\justyk" + ".compressed");

            testswap($"D:\\Games\\Fortnite\\FortniteGame\\Content\\Paks\\{CUE4Parse.Kaede.PakFile.Replace("10", "100")}", CUE4Parse.Kaede.offset, dataswap);

            MessageBox.Show("Uasset added to fortnite");
        }
    }
}
