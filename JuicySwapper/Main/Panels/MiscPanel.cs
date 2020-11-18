using JuicySwapper.Main.GUI;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class MiscPanel : UserControl
    {
        private static MiscPanel _instance;      
        public static MiscPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MiscPanel();
                return _instance;
            }
        }
        public MiscPanel()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
