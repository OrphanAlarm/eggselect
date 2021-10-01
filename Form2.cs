using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TamaGucci
{
    public partial class frmEggSelect : Form
    {
        int i = 0;
        SoundPlayer _soundPlayer = new SoundPlayer(@"C:\Users\rikus\Downloads\horror-halloween-night-scary-danger-mysterious-6659.wav");
        public frmEggSelect()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tmrEggHatch.Start();

        }

        private void frmEggSelect_Load(object sender, EventArgs e)
        {
        }

        private void class11_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();

            frmMain.Show();
            this.Close();
        }

        private void class12_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();

        }

        private void tmrEggHatch_Tick(object sender, EventArgs e)
        {
            
            i ++;

            if (i == 2)
            {
                pictureBox2.ImageLocation = @"C:\Users\rikus\Downloads\WhatsApp Image 2021-09-18 at 23.57.07 (1).png";
            }

            if (i == 3)
            {
                pictureBox2.ImageLocation = @"C:\Users\rikus\Downloads\GreenCrack2.png";
            }

            if (i == 4)
            {
                pictureBox2.ImageLocation = @"C:\Users\rikus\Downloads\Pengie.png";
                tmrEggHatch.Stop();
            }

          
        }
    }
}
