﻿using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacer
{
    public partial class MainMenu : Form
    {
        SoundPlayer mainmenu = new SoundPlayer(Properties.Resources.main_menu);
        ArrayList scores = new ArrayList();

        public MainMenu()
        {
            InitializeComponent();
            mainmenu.Play();
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
                mainmenu.Stop();  
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

    }
}
