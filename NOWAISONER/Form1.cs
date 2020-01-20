using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOWAISONER
{
    public partial class Form1 : Form
    {
        private int Size = 0; //size of grid 
        private string Strategy; // if player is cooperative or defective
        private int playersnumber; // players idenficative number
                                   // private int defectorperc; // percentage of defectors chosen
        private int defectors = 0; // actual number of defectors and cooperators
        private int cooperators = 0;
        private List<Player> defectorslis = new List<Player>(); //defector list filled to test
        private List<Player> cooperatorslis = new List<Player>(); // cooperator list filled TEST
        Random rand = new Random(); //get random number
        private int xloc, yloc; // position of player

        List<Player> Players = new List<Player>(); // list of players class 


        public Form1(int size, int defe)
        {
            InitializeComponent();
            this.Size = size;

            this.defectors = defe;
            test.Text = Convert.ToString(GetRandomNumber());

        }
        public int GetRandomNumber() // get number from 1 to 2 to distribute defectors over the grid
        {
            Random rand = new Random();
            return rand.Next(Size);
        }

        private void GetNeighbours()
        {

        }
        private void button1_Click(object sender, EventArgs e) // draw grid 
        {

            Graphics gr = panel.CreateGraphics(); // create graph
            Pen myPen = new Pen(Brushes.Black, 1); // pen to draw lines of grid
            Font myFont = new Font("Arial", 15); // font used in the graph
            int lines = Size; // size of graph
            playersnumber = Size * Size; // number of player to deploy

            players.Text = Convert.ToString(playersnumber);

             // get percentage of players
            cooperators = playersnumber - defectors; // and cooperator
            float x = 0f;
            float y = 0f;
            float xSpace = ((panel.Width - myPen.Width) * 1.0f / lines);
            float ySpace = ((panel.Height - myPen.Width) * 1.0f / lines);

            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(myPen, x, y, x, panel.Height); // draw grid
                x += xSpace;
            }
            x = 0f;
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(myPen, x, y, panel.Width, y);
                y += ySpace;
            }

            x = 0f;
            y = 0f;
            int[,] Agents = new int[lines, lines]; // Agents array of position
            float[] locx = new float[lines];
            float[] locy = new float[lines];
                // int[,] Behaviour = new int[lines, lines];

            int counter = 0;

            for (int r = 0; r < lines; r++)
            {
                for (int c = 0; c < lines; c++)
                {
                    xloc = c;
                    yloc = r;
                    Player p = new Player(xloc, yloc, counter, "C");
                    Players.Add(p);
                    cooperatorslis.Add(p);
                    gr.DrawString("C", myFont, Brushes.Green, x, y);
                    locx[c] = x;
                    
                    x += xSpace;
                    counter++;
                    

                    
                }
                locy[r] = y;
                y += ySpace;
                x = 0;
            }

            for (int k = 0; k < Players.Count; k++)
            {
                int xdef = rand.Next(Size);
                int ydef = rand.Next(Size);
               
                //test2.Text += Convert.ToString(xdef) + Convert.ToString(ydef);
                foreach (Player p in Players.Where(p => p.X == xdef && p.Y == ydef))
                {
                    if (cooperatorslis.Count > cooperators)
                    {

                        p.setState("D");
                        gr.DrawString("D", myFont, Brushes.Red, locx[xdef], locy[ydef]);
                        cooperatorslis.Remove(p);
                        defectorslis.Add(p);
                        test2.Text = "porcodio";
                    }
                }
                    //else if (defectorslis.Count == defectors)
                    //{
                     //   break;
                   // }

                
            }
            foreach (var p in Players)
            {
                test.Text += ("Player : " + Convert.ToString(p.Num) + " Position: " + Convert.ToString(p.X) + "," + Convert.ToString(p.Y) + " " + p.State + Environment.NewLine);
            }
            //else //  if (Players.Count <= playersnumber)
            //{
            //    Player p = new Player(r, c, counter, "cooperate");
            //    Players.Add(p);
            //    cooperatorslis.Add(p);
            //    gr.DrawString("C", myFont, Brushes.Green, x, y);

            //}



            // gr.DrawString((Convert.ToString(r)+","+Convert.ToString(c)+" NUM "+counter), myFont, Brushes.Red, x, y);

        }

        // coopshould.Text = Convert.ToString(cooperators);
        // defeshould.Text = Convert.ToString(defectors);
        // cooplist.Text = Convert.ToString(cooperatorslis.Count);
        // defelist.Text = Convert.ToString(defectorslis.Count);
        //  test.Text = "Player " + Agents[2, 8] + "\nBehaviour: " + Behaviour[2, 8] +"\nplayer num "+ Convert.ToString(Players[Agents[2,8]].Num) + " position x: \n"+ Convert.ToString(Players[Agents[2, 8]].X) + "\n Y: " + Convert.ToString(Players[Agents[2, 8]].Y);

    }
}
        

    

