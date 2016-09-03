using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class frmStartMenu : Form
    {
        public frmStartMenu()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rbEasy.Checked)
            {
                EasyForm frm = new EasyForm();
                frm.Show();
            }
            else if (rbMedium.Checked)
            {
                MediumForm frm = new MediumForm();
                frm.Show();
            }

            else if (rbHard.Checked)
            {
                HardForm frm = new HardForm();
                frm.Show();
            }
        }

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void frmStartMenu_Load(object sender, EventArgs e)
        {
            

            wplayer.URL = "Snake.mp3";
            wplayer.controls.play();
           

        }
    }
}
