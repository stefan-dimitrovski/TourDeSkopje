using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacer
{
    public partial class GameScreen : Form
    {

        bool left, right;
        private int gamespeed = 4;
        private Stopwatch stopwatch;
        Random rnd = new Random();


        public GameScreen()
        {
            InitializeComponent();
        }

        //functions called every new interval
        private void timer1_Tick(object sender, EventArgs e)
        {
            collision();//check for collision

            this.lblTime.Text = string.Format("{0:mm\\:ss}", stopwatch.Elapsed);


            if (enemy1.Enabled == false)
            {
                if (Math.Floor(stopwatch.Elapsed.TotalSeconds) >= 0 && enemy1.Top == -75)
                {
                    enemy1.Enabled = true;
                    enemy1.Visible = true;
                }
            }
            if (enemy2.Enabled == false)
            {
                if (Math.Floor(stopwatch.Elapsed.TotalSeconds) >= 5 && enemy1.Top == -75)
                {
                    enemy2.Top = -262;
                    enemy2.Enabled = true;
                    enemy2.Visible = true;
                }
            }
            if (enemy3.Enabled == false)
            {
                if (Math.Floor(stopwatch.Elapsed.TotalSeconds) >= 10 && enemy2.Top == -75)
                {
                    enemy3.Top = -262;
                    enemy3.Enabled = true;
                    enemy3.Visible = true;
                }
            }
         

            moveEnemy(gamespeed);//enemy movement function

            moveline(gamespeed);//road movement function
            
            {
                if (right == true)
                {
                    if (player.Left < 320) //stay in right bound
                    {
                        player.Left += 7;
                    }
                }
                if (left == true)
                {
                    if (player.Left > 12) // stay in left bound
                    {
                        player.Left -= 7;
                    }
                }
            }//player movement rules
        }
        //collision rules
        private void collision()
        {
            if (enemy1.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    gameTime.Enabled = false;
                }
            }
            if (enemy2.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    gameTime.Enabled = false;
                }
            }
            if (enemy3.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(enemy3.Bounds))
                {
                    gameTime.Enabled = false;
                }
            }
            

        }

        //enemy move pattern
        private void moveEnemy(int speed)
        {


            if(enemy1.Top >= 480)
            {
                enemy1.Top = -75;
                enemy1.Left = rnd.Next(0, 320);

            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 480)
            {
                enemy2.Top = -75;
                enemy2.Left=rnd.Next(0, 320);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 480)
            {
                enemy3.Top = -75;
                enemy3.Left = rnd.Next(0, 320);
            }
            else
            {
                enemy3.Top += speed;
            }
            
        }

        //move lines and restart after leaving screen
        private void moveline(int speed)
        {
            if(pb1.Top >= 480)
            {
                pb1.Top = -75;
            }
            else
            {
                pb1.Top += speed;
            }
            if (pb2.Top >= 480)
            {
                pb2.Top = -75;
            }
            else
            {
                pb2.Top += speed;
            }
            if (pb3.Top >= 480)
            {
                pb3.Top = -75;
            }
            else
            {
                pb3.Top += speed;
            }
            if (pb4.Top >= 480)
            {
                pb4.Top = -75;
            }
            else
            {
                pb4.Top += speed;
            }
        }

        //move on key down, stop on key up
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
            if(e.KeyCode == Keys.Escape) { this.Close(); }
   

           // if(e.KeyCode == Keys.Escape) { this.Close(); }                      

        }


        private void GameScreen_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Console.WriteLine(Math.Floor(stopwatch.Elapsed.TotalSeconds));

            if (Math.Floor(stopwatch.Elapsed.TotalSeconds) % 30 == 0)
            {
                gamespeed +=1;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
