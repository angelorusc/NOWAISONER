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
    public partial class Game : Form
    {
        private int size; //size of grid
        private int defectors; // number of defectors
        private string neighbourtype; // von neumann or moore neighbours
        private int iterations; // number of iterations
        bool drawn = false; // bool if grid is drawn

        private List<Player> defectorslis = new List<Player>();  //defector list to take count of defectors
        private List<Player> cooperatorslis = new List<Player>(); // cooperators list 
        private List<Player> Players = new List<Player>(); // list of players
        
        Player[,] Agents; // 2d array for keep players location

        private float[] locx; // location of panel for graphics drawing
        private float[] locy;

        Random rand = new Random(); //random number 

        Graphics gr;
        Pen myPen = new Pen(Brushes.Black, 1); 
        Font myFont = new Font("Arial", 10); //  (panel1.Width <= panel1.Height) ? xSpace / 3 : ySpace / 3)

        public Game(int size, int defectors, string neigh, int iters)
        {
            InitializeComponent();
            playersnum.Text = Convert.ToString(size * size);
            this.size = size;
            this.defectors = defectors;
            this.neighbourtype = neigh;
            this.iterations = iters;
        }

        public int GetRandomNumber()  // get next random int for decide which cell defect
        {
            Random rand = new Random();
            return rand.Next(size);
        }

        private void drawbtn_Click(object sender, EventArgs e)
        {
            drawn = true;
            gr = panel1.CreateGraphics();
            float x = 0f;
            float y = 0f;
            float xSpace = ((panel1.Width - myPen.Width) * 1.0f / size);
            float ySpace = ((panel1.Height - myPen.Width) * 1.0f / size);
            Agents = new Player[size, size];
            int counter = 0;

            for (int i = 0; i < size + 1; i++)
            {
                gr.DrawLine(myPen, x, y, x, ySpace * size);// draw grid
                x += xSpace;
            }
            x = 0f;

            for (int i = 0; i < size + 1; i++)
            {
                gr.DrawLine(myPen, x, y, xSpace * size, y);
                y += ySpace;
            }
            x = 0f;
            y = 0f;
            locx = new float[size];
            locy = new float[size];

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    
                    Player p = new Player(c, r, counter, "");
                    Players.Add(p);
                    Agents[c, r] = p;
                    //test2.Text += Convert.ToString(Players.Count) + " ";
                    gr.DrawString("", myFont, Brushes.Green, x, y);
                    locx[c] = x;
                    x += xSpace;
                    counter++;
                }
                locy[r] = y;
                y += ySpace;
                x = 0;
            }
            drawStates();
            

            GetNeighbour();
        }

        private void drawStates()
        {
            for (int k = 0; k < defectors; k++)
            {
                int xdef = rand.Next(size);
                int ydef = rand.Next(size);
                if (Agents[xdef, ydef].State != "D")
                {
                    Agents[xdef, ydef].State = "D";
                    defectorslis.Add(Agents[xdef, ydef]);
                    gr.DrawString("D", myFont, Brushes.Red, locx[xdef], locy[ydef]);
                }
                else k--;
            }
            foreach (Player p in Players.Where(p => p.State != "D"))
            {
                p.State = "C";
                gr.DrawString("C", myFont, Brushes.Green, locx[p.X], locy[p.Y]);
                cooperatorslis.Add(p);

            }
            defelist.Text = Convert.ToString(defectorslis.Count);
            cooplist.Text = Convert.ToString(cooperatorslis.Count);
        }
       
        private void GetNeighbour()
        {
            foreach (Player p in Players)
            {
                // Von Neumann

                if (p.X == 0)
                {
                    p.AddNeighbour(Agents[size - 1, p.Y]);
                }
                else p.AddNeighbour(Agents[p.X - 1, p.Y]); // left

                if (p.X == size - 1)
                {
                    p.AddNeighbour(Agents[0, p.Y]);
                }
                else p.AddNeighbour(Agents[p.X + 1, p.Y]); // right

                if (p.Y == 0)
                {
                    p.AddNeighbour(Agents[p.X, size - 1]);
                }
                else p.AddNeighbour(Agents[p.X, p.Y - 1]); // up

                if (p.Y == size - 1)
                {
                    p.AddNeighbour(Agents[p.X, 0]);
                }
                else p.AddNeighbour(Agents[p.X, p.Y + 1]); // down

                // Moore Neighbours

                if (neighbourtype == "M")
                {
                    if (p.X == 0 && p.Y == 0)
                    {
                        p.AddMooreNeighbour(Agents[size - 1, size - 1]);
                    }
                    else if (p.X == 0)
                    {
                        p.AddMooreNeighbour(Agents[size - 1, p.Y - 1]);
                    }
                    else if (p.Y == 0)
                    {
                        p.AddMooreNeighbour(Agents[p.X - 1, size - 1]);
                    }
                    else p.AddMooreNeighbour(Agents[p.X - 1, p.Y - 1]); // up-left

                    if (p.X == 0 && p.Y == 0)
                    {
                        p.AddMooreNeighbour(Agents[p.X + 1, size - 1]);
                    }
                    else if (p.X == size - 1 && p.Y == 0)
                    {
                        p.AddMooreNeighbour(Agents[0, size - 1]);
                    }
                    else if (p.X == size - 1)
                    {
                        p.AddMooreNeighbour(Agents[0, size - 1]);
                    }
                    else if (p.X == 0)
                    {
                        p.AddMooreNeighbour(Agents[p.X + 1, p.Y - 1]);
                    }
                    else if (p.Y == 0)
                    {
                        p.AddMooreNeighbour(Agents[p.X + 1, size - 1]);
                    }
                    else p.AddMooreNeighbour(Agents[p.X + 1, p.Y - 1]);  // up-right

                    if (p.X == 0 && p.Y == 0)
                    {
                        p.AddMooreNeighbour(Agents[size - 1, p.Y + 1]);
                    }
                    else if (p.X == 0 && p.Y == size - 1)
                    {
                        p.AddMooreNeighbour(Agents[size - 1, 0]);
                    }
                    else if (p.X == 0)
                    {
                        p.AddMooreNeighbour(Agents[size - 1, p.Y + 1]);
                    }
                    else if (p.Y == size - 1)
                    {
                        p.AddMooreNeighbour(Agents[p.X - 1, 0]);
                    }
                    else p.AddMooreNeighbour(Agents[p.X - 1, p.Y + 1]);  // down-left

                    if (p.X == size - 1 && p.Y == size - 1)
                    {
                        p.AddMooreNeighbour(Agents[0, 0]);
                    }
                    else if (p.Y == size - 1)
                    {
                        p.AddMooreNeighbour(Agents[p.X + 1, 0]);
                    }
                    else if (p.X == size - 1)
                    {
                        p.AddMooreNeighbour(Agents[0, p.Y + 1]);
                    }
                    else p.AddMooreNeighbour(Agents[p.X + 1, p.Y + 1]); //down-right
                }
            }

            // typeofplayers.Text = Convert.ToString(Agents[7,9].Neighbour[3].X + "," + Agents[7,9].Neighbour[3].Y + " : " + Agents[9,9].MooreNeighbour[3].Num + ".... " + Agents[7,9].Neighbour[3].State);
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
           // for (int i = 0; i < iterations; iterations++)
           // {
                Match();
                newGeneration();
           // }
            // drawStates();

        }

       

        private void Match()
        {
            if (drawn)
            {
                foreach (Player p in Players)
                {
                    Play(p, p.Neighbour[0]);
                    Play(p, p.Neighbour[1]);
                    Play(p, p.Neighbour[2]);
                    Play(p, p.Neighbour[3]);

                    if (neighbourtype == "M")
                    {
                        Play(p, p.MooreNeighbour[0]);
                        Play(p, p.MooreNeighbour[1]);
                        Play(p, p.MooreNeighbour[2]);
                        Play(p, p.MooreNeighbour[3]);
                    }
                }

              //  typeofplayers.Text = Convert.ToString(Agents[3, 0].X + " " + Agents[3, 0].Y + " " + Agents[3, 0].Num + " " + Agents[3, 0].State + " " + Agents[3, 0].FitnessScore + " // " + Players[3].X + " " + Players[3].Y + " " + Players[3].Num + " " + Players[3].State + " " + Players[3].FitnessScore + " ");
            }
        }
        private void Play(Player player1, Player player2)
        {
            if (player1.State == "C")
            {
                if (player2.State == "C")
                {
                    player1.FitnessScore += 3;
                }
                if (player2.State == "D")
                {
                    player1.FitnessScore += 0;
                }
            }
            if (player1.State == "D")
            {
                if (player2.State == "C")
                {
                    player1.FitnessScore += 5;
                }
                if (player2.State == "D")
                {
                    player1.FitnessScore += 1;
                }
            }
        }
        private void newGeneration()
        {
            cooperatorslis.Clear();
            defectorslis.Clear(); 

           foreach (Player p in Players)
           {
                Player BestV = p.Neighbour.Aggregate((p1, p2) => p1.FitnessScore > p2.FitnessScore ? p1 : p2);
                if (neighbourtype == "M")
                {
                    Player BestM = p.MooreNeighbour.Aggregate((p1, p2) => p1.FitnessScore > p2.FitnessScore ? p1 : p2);

                    if (BestV.FitnessScore >= BestM.FitnessScore)
                    {
                        p.State = BestV.State;
                    }
                    else
                    {
                        p.State = BestM.State;
                    }
                }
                else p.State = BestV.State;
                // typeofplayers.Text += Best.Num;
           }
            foreach (Player p in Players.Where(p => p.State == "D"))
            {
                gr.DrawString("D", myFont, Brushes.Red, locx[p.X], locy[p.Y]);
                defectorslis.Add(p);
            }
            foreach (Player p in Players.Where(p => p.State == "C"))
            {
                gr.DrawString("C", myFont, Brushes.Green, locx[p.X], locy[p.Y]);
                cooperatorslis.Add(p);
            }
            defelist.Text = Convert.ToString(defectorslis.Count);
            cooplist.Text = Convert.ToString(cooperatorslis.Count);
        }
    }
}
