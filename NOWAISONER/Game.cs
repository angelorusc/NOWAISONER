using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NOWAISONER
{
    public partial class Game : Form
    {
        private int size; //size of grid
        private int defectors; // number of defectors
        private int iterations; // number of iterations
        private int xys;

        private string synchro;
        private string neighbourtype; // von neumann or moore neighbours

        private bool drawn = false; // bool if grid is drawn
        private bool stopped = false;

        private List<Player> defectorslis = new List<Player>();  //defector list to take count of defectors
        private List<Player> cooperatorslis = new List<Player>(); // cooperators list 
        private List<Player> Players = new List<Player>(); // list of players
        private List<int> synchroscores = new List<int>();
        
        private int[] fitnessscores;
        Player[,] Agents; // 2d array for keep players location
        Rectangle[,] GridRect;
        
        private Random rand = new Random(); //random number 

        Graphics gr;
        Pen myPen = new Pen(Brushes.Black, 1);

        public Game(int size, int defectors, string neigh, int iters, string synchroyn)
        {
            InitializeComponent();
            playersnum.Text = Convert.ToString(size * size);
            this.size = size;
            this.defectors = defectors;
            this.neighbourtype = neigh;
            this.iterations = iters;
            this.synchro = synchroyn; // if synchronous or asynchronous

        }

        private void drawbtn_Click(object sender, EventArgs e)
        {
            drawn = true;
            
            gr = panel1.CreateGraphics();
            int x = 0;
            int y = 0;
            Agents = new Player[size, size];
            GridRect = new Rectangle[size, size];
            int counter = 0;
            xys = panel1.Width / size;
            

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Rectangle Rect = new Rectangle(x, y, panel1.Width / size, panel1.Height / size);
                    gr.DrawRectangle(myPen, Rect);
                    Player p = new Player(Rect, c,r, counter, "U");
                    Agents[c, r] = p;
                    Players.Add(p);
                    x += xys;
                    counter++;

                }
                y += xys;
                x = 0;
            }
            

            drawStates();
            GetNeighbour();

            // Rectangle Rect = new Rectangle(x, y, panel1.Width / size, panel1.Height / size);
            //  Rectangle Rect2 = new Rectangle(x + panel1.Width / size, y + panel1.Height / size, panel1.Width / size, panel1.Height / size);


        } // draw grid and initialize array and lists of player

        private void drawStates()
        {
           // Player p = Agents[size / 2 , size / 2 ];
           ////Player p1 = Agents[size / 2 + 1, size / 2 - 1];
           ////Player p2 = Agents[size / 2 + 1, size / 2 + 1];
           ////Player p3 = Agents[size / 2 - 1, size / 2 + 1];

           // gr.FillRectangle(Brushes.Red, p.RectP);
           // //gr.FillRectangle(Brushes.Red, p1.RectP);
           // //gr.FillRectangle(Brushes.Red, p2.RectP);
           // //gr.FillRectangle(Brushes.Red, p3.RectP);
           // p.State = "D";
           //// p1.State = "D";
           //// p2.State = "D";
           //// p3.State = "D";
           //defectorslis.Add(p);
           // // defectorslis.Add(p2);
           // // defectorslis.Add(p1);
           // // defectorslis.Add(p3);
            for (int k = 0; k < defectors; k++)
            {
                int xdef = rand.Next(size);
                int ydef = rand.Next(size);
                Player p = Agents[xdef, ydef];
                int n = xdef * ydef;
                if (p.State != "D")
                {
                    p.State = "D";
                    defectorslis.Add(p);
                    gr.FillRectangle(Brushes.Red, p.RectP);
                }
                else k--;
            }
            Parallel.ForEach(Players, t =>
           {
               if (t.State != "D")
               {
                   Graphics gr = panel1.CreateGraphics();
                   gr.FillRectangle(Brushes.Green, t.RectP);
                   t.State = "C";
                   cooperatorslis.Add(t);
               }
           });
            defelist.Text = Convert.ToString(defectorslis.Count);
            cooplist.Text = Convert.ToString(cooperatorslis.Count);
        } // draw initial configurations of defectors and cooperators

        private void GetNeighbour()
        {
            foreach (Player p in Agents)
            {
                Player left, right, up, down, upl, upr, dwl, dwr;
                // Von Neumann
                int xym = size - 1;

                int xp = p.X + 1;
                int xm = p.X - 1;

                int yp = p.Y + 1;
                int ym = p.Y - 1;

                if (p.X == 0)
                {
                    left = Agents[xym, p.Y];
                    //  p.AddNeighbour(Agents[xym, p.Y]);
                }
                else left = Agents[xm, p.Y]; // left

                if (p.X == xym)
                {
                    right = Agents[0, p.Y];
                }
                else right = Agents[xp, p.Y]; // right

                if (p.Y == 0)
                {
                    up = Agents[p.X, xym];
                }
                else up = Agents[p.X, ym]; // up

                if (p.Y == xym)
                {
                    down = Agents[p.X, 0];
                }
                else down = Agents[p.X, yp]; // down

                // Moore Neighbours
                if (neighbourtype == "M")
                {
                    if (p.X == 0 && p.Y == 0)
                    {
                        upl = Agents[xym, xym];
                    }
                    else if (p.X == 0)
                    {
                        upl = Agents[xym, ym];
                    }
                    else if (p.Y == 0)
                    {
                        upl = Agents[xm, xym];
                    }
                    else upl = Agents[xm, ym]; // up-left

                    if (p.X == 0 && p.Y == 0)
                    {
                        upr = Agents[xp, xym];
                    }
                    else if (p.X == xym && p.Y == 0)
                    {
                        upr = Agents[0, xym];
                    }
                    else if (p.X == xym)
                    {
                        upr = Agents[0, xym];
                    }
                    else if (p.X == 0)
                    {
                        upr = Agents[xp, ym];
                    }
                    else if (p.Y == 0)
                    {
                        upr = Agents[xp, xym];
                    }
                    else upr = Agents[xp, xm];  // up-right

                    if (p.X == 0 && p.Y == 0)
                    {
                        dwl = Agents[xym, yp];
                    }
                    else if (p.X == 0 && p.Y == xym)
                    {
                        dwl = Agents[xym, 0];
                    }
                    else if (p.X == 0)
                    {
                        dwl = Agents[xym, yp];
                    }
                    else if (p.Y == xym)
                    {
                        dwl = Agents[xm, 0];
                    }
                    else dwl = Agents[xm, yp];  // down-left

                    if (p.X == xym && p.Y == xym)
                    {
                        dwr = Agents[0, 0];
                    }
                    else if (p.Y == xym)
                    {
                        dwr = Agents[xp, 0];
                    }
                    else if (p.X == xym)
                    {
                        dwr = Agents[0, yp];
                    }
                    else dwr = Agents[xp, yp]; //down-right
                    p.PassMooreNeighbour(upl, upr, dwl, dwr);
                    // typeofplayers.Text += Convert.ToString(upl.X + upl.Y + " ");
                }
                p.PassNeighbour(left, right, up, down);
            }

        } // get neighbour of each cell
        
        private void btnplay_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < iterations;)
           {
                Match();
                newGeneration();
                string iters = i.ToString();
                //Thread thr1 = new Thread(newGeneration);
                //thr1.Start();
                i++;
              System.Threading.Thread.Sleep(500);
                
           }
               
        }
                   
        private void Match()
        {
            if (drawn)
            {
                Parallel.ForEach(Players, p =>
                {
                    
                    p.FitnessScore += Play(p, p.Neighbour[0]);
                    p.FitnessScore += Play(p, p.Neighbour[1]);
                    p.FitnessScore += Play(p, p.Neighbour[2]);
                    p.FitnessScore += Play(p, p.Neighbour[3]);

                    if (neighbourtype == "M")
                    {
                        p.FitnessScore += Play(p, p.MooreNeighbour[0]);
                        p.FitnessScore += Play(p, p.MooreNeighbour[1]);
                        p.FitnessScore += Play(p, p.MooreNeighbour[2]);
                        p.FitnessScore += Play(p, p.MooreNeighbour[3]);
                    }
                   // synchroscores.Add(p.FitnessScore);
                    // p.FitnessScore = 0;

                });
            }
        } // let a player play with its 8 neighbour

        private double Play(Player player1, Player player2)
        {
            if (player1.State == "C")
            {
                if (player2.State == "C")
                {
                    return 1;
                }
                if (player2.State == "D")
                {
                    return 0;
                }
            }
            else //if (player1.State == "D")
            {
                if (player2.State == "C")
                {
                    return 2;
                }
                if (player2.State == "D")
                {
                    return 0;
                }
            }
            return 0 ;

        } // play pd with two player that neighbour

        private async void newGeneration()
        {
            cooperatorslis.Clear(); defectorslis.Clear();
            
            if (synchro == "syn")
            {
                Parallel.ForEach(Players, p =>
                {
                    Player best = BestNeighbour(p);
                    p.State = NewBehaviour(p, best);
                });
                    //defelist.Text = Convert.ToString(defectorslis.Count);
                   // cooplist.Text = Convert.ToString(cooperatorslis.Count);
            }
            else
            {
                foreach (Player p in Players)
                {
                    Player best = BestNeighbour(p);
                    p.State = NewBehaviour(p, best);
                }
                    defelist.Text = Convert.ToString(defectorslis.Count);
                    cooplist.Text = Convert.ToString(cooperatorslis.Count);
            }
        } // draw a new generation in synch or asynchro

        private Player BestNeighbour(Player p)
        {
            Player BestV = p.Neighbour.Aggregate((p1, p2) => p1.FitnessScore > p2.FitnessScore ? p1 : p2);

            if (neighbourtype == "M")
            {
                    Player BestM = p.MooreNeighbour.Aggregate((p1, p2) => p1.FitnessScore > p2.FitnessScore ? p1 : p2);
                    if (BestV.FitnessScore >= BestM.FitnessScore)
                    {
                        return BestV;
                    }
                    else
                    {
                        return BestM;
                    }
            }
            else
            {
                    return BestV;
            }
        }

        private string NewBehaviour(Player p, Player best)
        {
            Graphics gr = panel1.CreateGraphics();
            if (p.State == "C")
            {
                if (best.State == "D")
                {
                    gr.FillRectangle(Brushes.Yellow, p.RectP);
                    defectorslis.Add(p);
                    return "D";
                    
                }
                else
                {
                    gr.FillRectangle(Brushes.Blue, p.RectP);
                    cooperatorslis.Add(p);
                    return "C";
                    
                }
            }
            else
            {
                if (best.State == "C")
                {
                    gr.FillRectangle(Brushes.Green, p.RectP);
                    cooperatorslis.Add(p);
                    return "C";
                    
                }
                else
                {
                    gr.FillRectangle(Brushes.Red, p.RectP);
                    defectorslis.Add(p);
                    return "D";
                }
            }
        }
        
    }
}

