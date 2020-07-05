using AudioSwitcher.AudioApi.CoreAudio;
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
            mainmenu.Stop();          
            GameScreen gs = new GameScreen();
            if(gs.ShowDialog() == DialogResult.OK)
            {
                lbHS.Items.Clear();
                scores.Add(gs.hs);
                //fuction to sort
                foreach (string s in scores)
                {
                    lbHS.Items.Add(s);
                }
            }
            else
            {
                //not save score
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
