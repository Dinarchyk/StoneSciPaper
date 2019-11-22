using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoneSciPaper
{
    public partial class Instuctions : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        int k = 0;
        public Instuctions()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            player.Stream = Properties.Resources.Main;
            player.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k == 2)
                label1.Visible = true;
            if (k == 4)
                label2.Visible = true;
            if (k == 5)
            {
                label3.Visible = true;
                timer1.Stop();
            }
            k++;
        }

        private void Instuctions_Load(object sender, EventArgs e)
        {

        }
        private void Instuction_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.AnotherFormClosed();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            player.Stop();
            var game = new GameForm();
            game.Show();
            Close();
        }
    }
}
