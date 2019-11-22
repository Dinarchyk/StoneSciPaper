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
    public partial class GameForm : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Random rand = new Random(DateTime.Now.Millisecond);
        String[] Draw = Properties.Resources.Draw.Split('\n');
        String[] Lose = Properties.Resources.Lose.Split('\n');
        String[] Win = Properties.Resources.Win.Split('\n');
        String[] OutOfTime = Properties.Resources.OnTime.Split('\n');
        enum Tool
        {
            Scissors,
            Stone,
            Paper
        }

        int timeNow = 5;

        int doubleWin = 0;

        public GameForm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer3.Interval = 3000;
            timer3.Tick += timer3_Tick;
            timer3.Enabled = false;
            player.Stream = Properties.Resources.Main;
            player.PlayLooping();
            //file = new System.IO.StreamReader(Properties.Resources.Draw);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.Main;
            player.PlayLooping();
            timer3.Stop();
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                label1.Text = "Seconds left to choose";
                button1.Text = "Scissors";
                button2.Text = "Stone";
                button3.Text = "Paper";
                player.Stream = Properties.Resources.Fight;
                player.Load();
                button3.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = true;
                compChoice.Text = "";
                compChoice.Image = null;
                player.PlayLooping();
                timer1.Enabled = true;
                timer1.Start();
                timer3.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = "\t\t"+timeNow;
            timeNow--;
            if (timeNow == -1)
            {
                timeNow = 5;
                timer1.Stop();
                timer1.Enabled = false;
                label1.Text = OutOfTime[rand.Next(0, 5)];
                MusicPlayTool("Lose");
                timer3.Start();
            }
        }
        /// <summary>
        /// compChoice - int that choose which tool to use in game (0 - scissors , 1 - stone , 2 - paper)
        /// </summary>
        private void TheGame(Tool clientChoice)
        {
            var compChoice = ToTOOL(rand.Next(0, 3));
            ShowCompChoice(compChoice);
            if (clientChoice == compChoice)
            {
                MusicPlayTool("Lose");
                label1.Text = Draw[rand.Next(0, 5)];
                doubleWin = 0;
            }
            else if ((clientChoice == Tool.Paper && compChoice == Tool.Stone) ||
                    (clientChoice == Tool.Stone && compChoice == Tool.Scissors) ||
                    (clientChoice == Tool.Scissors && compChoice == Tool.Paper))
            {
                doubleWin++;
                MusicPlayTool("Win");
                label1.Text = Win[rand.Next(0, 5)];
            }
            else
            {
                label1.Text = Lose[rand.Next(0, 5)];
                MusicPlayTool("Lose");
                doubleWin = 0;
            }
        }
        private void MusicPlayTool(string winOrLose)
        {
            timer3.Start();
            if (winOrLose == "Lose")
            {
                LoseStream();
                //player.Stream = (new System.ComponentModel.ComponentResourceManager(typeof(GameForm))).GetStream("Lose"+rand.Next(0,10));
                player.Play();
            }
            else if (doubleWin >=2)
            {
                WinStream();
               // player.Stream = Properties.Resources.MKwin0;
                player.Play();
            }
            else 
            {
                MKWinStream();
                player.Play();
            }
            timerLabel.Text = "Again?(Click me)";
        }
        private void LoseStream()
        {
            switch (rand.Next(0,10))
            {
                case 0:
                    player.Stream = Properties.Resources.Lose0;
                    break;
                case 1:
                    player.Stream = Properties.Resources.Lose1;
                    break;
                case 2:
                    player.Stream = Properties.Resources.Lose2;
                    break;
                case 3:
                    player.Stream = Properties.Resources.Lose3;
                    break;
                case 4:
                    player.Stream = Properties.Resources.Lose4;
                    break;
                case 5:
                    player.Stream = Properties.Resources.Lose5;
                    break;
                case 6:
                    player.Stream = Properties.Resources.Lose6;
                    break;
                case 7:
                    player.Stream = Properties.Resources.Lose7;
                    break;
                case 8:
                    player.Stream = Properties.Resources.Lose8;
                    break;
                case 9:
                    player.Stream = Properties.Resources.Lose9;
                    break;
                default:
                    break;
            }
        }
        private void WinStream()
        {
            switch (rand.Next(0, 12))
            {
                case 0:
                    player.Stream = Properties.Resources.Win0;
                    break;
                case 1:
                    player.Stream = Properties.Resources.Win1;
                    break;
                case 2:
                    player.Stream = Properties.Resources.Win2;
                    break;
                case 3:
                    player.Stream = Properties.Resources.Win3;
                    break;
                case 4:
                    player.Stream = Properties.Resources.Win4;
                    break;
                case 5:
                    player.Stream = Properties.Resources.Win5;
                    break;
                case 6:
                    player.Stream = Properties.Resources.Win6;
                    break;
                case 7:
                    player.Stream = Properties.Resources.Win7;
                    break;
                case 8:
                    player.Stream = Properties.Resources.Win8;
                    break;
                case 9:
                    player.Stream = Properties.Resources.Win9;
                    break;
                case 10:
                    player.Stream = Properties.Resources.Win10;
                    break;
                case 11:
                    player.Stream = Properties.Resources.Win11;
                    break;
                default:
                    break;
            }
        }
        private void MKWinStream()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    player.Stream = Properties.Resources.MKwin0;
                    break;
                case 1:
                    player.Stream = Properties.Resources.MKwin1;
                    break;
                case 2:
                    player.Stream = Properties.Resources.MKwin2;
                    break;
                case 3:
                    player.Stream = Properties.Resources.MKwin3;
                    break;
                default:
                    break;
            }
        }
        private void ShowCompChoice (Tool compChoic)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            if (compChoic == Tool.Scissors)
            {
                compChoice.Image = ((System.Drawing.Image)(Properties.Resources.Scissors_comp));
                compChoice.Text = "Scissors";
            }
            if (compChoic == Tool.Stone)
            {
                compChoice.Image = ((System.Drawing.Image)(Properties.Resources.Stone_comp));
                compChoice.Text = "Stone";
            }
            if (compChoic == Tool.Paper)
            {
                compChoice.Image = ((System.Drawing.Image)(Properties.Resources.Paper_comp));
                compChoice.Text = "Paper";
            }
        }
        private static Tool ToTOOL(int transfer)
        {
            if (transfer < 1)
                return Tool.Scissors;
            if (transfer == 1)
                return Tool.Stone;
            else return Tool.Paper;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true)
            {
                timeNow = 5;
                timer1.Stop();
                timer1.Enabled = false;
                TheGame(Tool.Scissors);
                
            }
            else
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timeNow = 5;
                timer1.Stop();
                timer1.Enabled = false;
                TheGame(Tool.Stone);
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timeNow = 5;
                timer1.Stop();
                timer1.Enabled = false;
                TheGame(Tool.Paper);
            }
            else
            {

            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.AnotherFormClosed();
        }
    }
}
