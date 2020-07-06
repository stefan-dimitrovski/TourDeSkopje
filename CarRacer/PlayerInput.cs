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
using System.IO;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
namespace CarRacer
{
    public partial class PlayerInput : Form
    {

        public PlayerInput()
        {
            InitializeComponent();
        }

        public static string NameTempval;

        //Button to get name of player
        private void startBtn_Click(object sender, EventArgs e)
        {
            NameTempval = textBox1.Text;
            this.Close();
                

        }

    }
}
