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
            this.ActiveControl = label1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            foreach (SettingsProperty currentProperty in Settings.Default.Properties)
            {
                if (currentProperty.PropertyType == typeof(bool))
                    Settings.Default[currentProperty.Name] = false;

                Settings.Default.Save();
            }

            new ResetComplete().ShowDialog();
            Close();
        }

        private void ResetConfirm_Load(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
        }
    }
}
