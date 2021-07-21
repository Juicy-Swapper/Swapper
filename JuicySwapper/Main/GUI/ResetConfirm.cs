using JuicySwapper.Properties;
using System;
using System.Configuration;
using System.IO;
using System.Media;
using System.Windows.Forms;
using JuicySwapper.Main.Classes;

namespace JuicySwapper.Main.GUI
{
    public partial class ResetConfirm : Form
    {
        public ResetConfirm()
        {
            InitializeComponent();
        }

        private void ResetConfirm_Load(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
        }

        private void ResetconfigBtn_Click(object sender, EventArgs e)
        {
            foreach (SettingsProperty currentProperty in Settings.Default.Properties)
            {
                if (!currentProperty.Name.Contains("MusicAct"))
                {
                    if (currentProperty.PropertyType == typeof(bool))
                        Settings.Default[currentProperty.Name] = false;
                }
                Settings.Default.Save();
            }

            var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";

            foreach (var pak in Directory.GetFiles(Pathtopaks))
            {
                if (pak.Contains("100_s"))
                {
                    File.Delete(pak);
                }
            }

            SwapUtilities SwapUtilities = new SwapUtilities();

            foreach (var file in SwapUtilities.GetSwapPath())
            {
                if (!File.Exists(file))
                {
                    var toc = file.Replace(".ucas", ".utoc");
                    var pak = file.Replace(".ucas", ".pak");
                    var sig = file.Replace(".ucas", ".sig");

                    File.Copy(file.Replace("100", "10"), file);
                    File.Copy(toc.Replace("100", "10"), toc);
                    File.Copy(pak.Replace("100", "10"), pak);
                    File.Copy(sig.Replace("100", "10"), sig);
                }
            }

            Message ResetComplete = new Message(Resources.ResetComplete);
            ResetComplete.ShowDialog();
            Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
