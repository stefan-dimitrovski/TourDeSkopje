using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacer
{
    public partial class GameScreen : Form
    {
        SoundPlayer carengine = new SoundPlayer(Properties.Resources.car_engine);

        //car types list
        Bitmap[] colors =
        {
            Properties.Resources.car1,
            Properties.Resources.car2,
            Properties.Resources.car3,
            Properties.Resources.car4,
            Properties.Resources.car5
        };

        bool left, right;
        private int gamespeed = 4;
        private Stopwatch stopwatch;
        Random rnd = new Random();

        public GameScreen()
        {
            InitializeComponent();
        }

        //on gamescreen start do this
        private void GameScreen_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            
        }

        //functions called every new interval
        private void gameSpeed_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = string.Format("{0:mm\\:ss}", stopwatch.Elapsed); //Time format for highscore

            collision();//check for collision         

            spawnEnemy();//spawn random locations for enemy cars

            moveEnemy(gamespeed);//enemy movement function

            moveline(gamespeed);//road movement function

            playerRules();//player movement rules
        }


        //collision rules
        private void collision()
        {
            if (enemy1.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    gameTime.Enabled = false;
                    carengine.Stop();
                }
            }
            if (enemy2.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    gameTime.Enabled = false;
                    carengine.Stop();
                }
            }
            if (enemy3.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(enemy3.Bounds))
                {
                    gameTime.Enabled = false;
                    carengine.Stop();
                }
            }          
        }

        //enemy move pattern and color changer
        private void moveEnemy(int speed)
        {
            if(enemy1.Top >= 480)
            {
                enemy1.Top = -75;
                enemy1.Left = rnd.Next(12, 320);
                enemy1.Image = colors[rnd.Next(0, 5)];
            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 480)
            {
                enemy2.Top = -75;
                enemy2.Left=rnd.Next(12, 320);
                enemy2.Image = colors[rnd.Next(0, 5)];
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 480)
            {
                enemy3.Top = -75;
                enemy3.Left = rnd.Next(12, 320);
                enemy3.Image = colors[rnd.Next(0, 5)];
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

        //move on key down
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
            if(e.KeyCode == Keys.Escape)
            {
                carengine.Stop();
                this.Close(); 
            }                    
        }
        //stop on key up
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        //Increase speed every 30 seconds
        private void timerSpeedUp_Tick(object sender, EventArgs e)
        {

            //Console.WriteLine(Math.Floor(stopwatch.Elapsed.TotalSeconds));

            if (Math.Floor(stopwatch.Elapsed.TotalSeconds) % 30 == 0)
            {
                gamespeed +=1;
            }
        } 
        
        //random spawn location for enemies
        private void spawnEnemy()
        {
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
        }

        //start timer before game run
        private void timer321_Tick(object sender, EventArgs e)
        {
            switch (Math.Floor(stopwatch.Elapsed.TotalSeconds))
            {
                case 0:
                    lbl321.Text = "3";
                    break;
                case 1:
                    lbl321.Text = "2";
                    break;
                case 2:
                    lbl321.Text = "1";
                    break;
                case 3:
                    lbl321.Font = new Font("Arial", 100, FontStyle.Bold);
                    lbl321.ForeColor = Color.Red;
                    lbl321.Text = "GO";
                    break;
                case 4:
                    stopwatch.Restart();
                    lblTime.Visible = true;
                    gameTime.Enabled = true;
                    lbl321.Visible = false;
                    timer321.Stop();
                    carengine.PlayLooping();
                    break;
            }
        }
        
        //bounds for player staying in screen
        private void playerRules()
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
        }
    }
}
