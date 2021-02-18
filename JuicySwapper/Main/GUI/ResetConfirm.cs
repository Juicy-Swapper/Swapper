using JuicySwapper.Properties;
using System;
using System.Configuration;
using System.Media;
using System.Windows.Forms;

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
                if (currentProperty.PropertyType == typeof(bool))
                    Settings.Default[currentProperty.Name] = false;

                Settings.Default.Save();
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
