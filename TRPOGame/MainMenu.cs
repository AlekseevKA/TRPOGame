using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1920, 1080);

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Form ifrm = new Game();
            ifrm.Show();
            this.Hide();
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            Form ifrm = new Settings();
            ifrm.Show();
        }
    }
}
