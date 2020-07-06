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

    public partial class HighScore : Form
    {

        public static string pscore;

        //Array Serializer
        private static void BinarySerializeF(ArrayList list)
        {
            using (FileStream fs = File.Create("hsfinal.bin"))
            {
                BinaryFormatter bfm = new BinaryFormatter();
                bfm.Serialize(fs, list);
            }
        }
        //Array Deserializer
        private static ArrayList BinaryDeserializeF()
        {
            ArrayList list = null;
            try
            {

                using (FileStream fs = File.OpenRead("hsfinal.bin"))
                {

                    BinaryFormatter bfm = new BinaryFormatter();
                    list = (ArrayList)bfm.Deserialize(fs);

                }

            }
            catch (FileNotFoundException)
            {
                using (FileStream fs = File.Create("hsfinal.bin"))
                {
                    ArrayList templist = new ArrayList();
                    templist.Add("test");
                    BinaryFormatter bfm = new BinaryFormatter();
                    bfm.Serialize(fs, templist);
                    fs.Close();
                };

                using (FileStream fs = File.OpenRead("hsfinal.bin"))
                {

                    BinaryFormatter bfm = new BinaryFormatter();
                    list = (ArrayList)bfm.Deserialize(fs);
                }


            }
            return list;
        }

        public HighScore()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            ArrayList playersnscores = new ArrayList();
            string name = PlayerInput.NameTempval;
            if (name != null && pscore != null)
            {

                playersnscores = BinaryDeserializeF();
                playersnscores.Add(name + " - " + pscore);
                //In case the high score button is hit before starting a new game, this controlls the addition of new members to high score table and prevents duplicates
                if (playersnscores[playersnscores.Count - 2].ToString() == playersnscores[playersnscores.Count - 1].ToString())
                {
                    playersnscores.RemoveAt(playersnscores.Count - 1);
                };
                //In order to create a fresh bin file, we had to add an array member to the new file and this deletes that member
                for (var i = 0; i < playersnscores.Count; i++)
                {
                    if (playersnscores[i].ToString() == "test")
                    {
                        playersnscores.RemoveAt(i);
                    }


                }
                //Adding data to listbox and serializing list to bin file
                lbScore.DataSource = playersnscores;
                BinarySerializeF(playersnscores);
                name = null;
                pscore = null;
            }
            else
            {

                playersnscores = BinaryDeserializeF();
                for (var i = 0; i < playersnscores.Count; i++)
                {
                    if (playersnscores[i].ToString() == "test")
                    {
                        playersnscores.RemoveAt(i);
                    }


                }
                lbScore.DataSource = playersnscores;
            }

        }
    }
}
