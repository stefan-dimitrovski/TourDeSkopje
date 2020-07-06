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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            PlayerInput pinp = new PlayerInput();
            pinp.ShowDialog();
            GameScreen gs = new GameScreen();
            gs.ShowDialog();
            //When game is over, send result to score table
            if (gs.DialogResult == DialogResult.OK)
            {
                HighScore.pscore = GameScreen.scoreTime;
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay hp = new HowToPlay();
            hp.ShowDialog();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            HighScore hs = new HighScore();
            hs.ShowDialog();
        }
    }
}
