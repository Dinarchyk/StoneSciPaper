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
    public partial class MainForm : Form
    {
        static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MainForm()
        {
            InitializeComponent();       
            player.Stream = Properties.Resources.Main;
            player.Load();
            player.PlayLooping();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            player.Stop();
            var game = new GameForm();
            game.Show();
            
        }

        private void instructions_Click(object sender, EventArgs e)
        {
            player.Stop();
            var inst = new Instuctions();
            inst.Show();
        }
        public static void AnotherFormClosed()
        {
            player.Stream = Properties.Resources.Main;
            player.Load();
            player.PlayLooping();
        }
    }
}
