using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacer
{
    public partial class Form1 : Form
    {

        bool left, right;



        public Form1()
        {
            InitializeComponent();
        }
        private int gamespeed = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveEnemy(gamespeed);
            moveline(gamespeed);
            if(right == true)
            {
                player.Left += 5;
            }
            if(left == true)
            {
                player.Left -= 5;
            }
        }

        private void moveEnemy(int speed)
        {
            if(enemy.Top >= 480)
            {
                enemy.Top = -75;
            }
            else
            {
                enemy.Top += speed;
            }
        }

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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
