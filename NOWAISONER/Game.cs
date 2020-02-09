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
using System.Windows.Input;
namespace NOWAISONER
{
    public partial class Game : Form
    {
        private int size; //size of grid
        private int defectors; // number of defectors
        private int iterations; // number of iterations
        private int xys;
        int it; // iterations
        

        private string bond;
        private string synchro;
        private string neighbourtype; // von neumann or moore neighbours
        private string defecttype;
        private bool drawn = false; // bool if grid is drawn
        private bool stopped = false;
        private Panel panel2;
       

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

        public Game(int size, int defectors, string neigh, int iters, string synchroyn, string bounda, string typedefe)
        {

            InitializeComponent();

            playersnum.Text = Convert.ToString(size * size);
            this.size = size;
            this.defectors = defectors;
            this.defecttype = typedefe;
            this.neighbourtype = neigh;
            this.iterations = iters;
            this.synchro = synchroyn; // if synchronous or asynchronous
            this.bond = bounda;

          //  chartload();
            infotab(typedefe);
        }


        public void DrawGrid()
        {
            gr = panel1.CreateGraphics();
            xys = panel1.Width / size;
            int x = 0;
            int y = 0;
            Agents = new Player[size, size];
            int counter = 0;
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Rectangle Rect = new Rectangle(x, y, panel1.Width / size, panel1.Height / size);

                    gr.FillRectangle(Brushes.Green, Rect);
                    gr.DrawRectangle(myPen, Rect);
                    Player p = new Player(Rect, c, r, counter, "C");
                    cooperatorslis.Add(p);
                    p.OldState = "C";
                    Agents[c, r] = p;
                    Players.Add(p);
                    x += xys;
                    counter++;
                }
                y += xys;
                x = 0;

            }
        }

        private void drawbtn_Click(object sender, EventArgs e)
        {
            drawbtn.Enabled = false;
            
            DrawGrid();
            if (defecttype == "perc")
            {
                drawStates();
            }

            foreach (Player p in Players)
            {
                p.Neighbour = GetNeighbour(p);
                if (neighbourtype == "M")
                {
                    p.MooreNeighbour = GetMooreNeigh(p);
                }
            }
            typeofplayers.Text = defecttype + "," + neighbourtype + "," + bond + " " + synchro + " " + Players[0].Neighbour[0].Num + " " + Players[0].MooreNeighbour[1].Num;
        }

        private void drawStates()
        {
            for (int k = 0; k < defectors; k++)
            {
                int xdef = rand.Next(size);
                int ydef = rand.Next(size);
                Player p = Agents[xdef, ydef];
                //int n = xdef * ydef;
                if (p.State != "D")
                {
                    p.State = "D";
                    defectorslis.Add(p);
                    cooperatorslis.Remove(p);
                    gr.FillRectangle(Brushes.Red, p.RectP);
                    gr.DrawRectangle(myPen, p.RectP);
                }
                else k--;
            }

            defelist.Text = Convert.ToString(defectorslis.Count);
            cooplist.Text = Convert.ToString(cooperatorslis.Count);
        } // draw initial configurations of defectors 

        private List<Player> GetMooreNeigh(Player p)
        {
            Player upl, upr, dwl, dwr;
            Player playernull = new Player("null");
            List<Player> plistM = new List<Player>(3);
            int xym = size - 1;
            int xp = p.X + 1;
            int xm = p.X - 1;
            int yp = p.Y + 1;
            int ym = p.Y - 1;

            if (p.X == 0 && p.Y == 0)
            {
                if (bond == "Taurus") upl = Agents[xym, xym];
                else upl = playernull;
            }
            else if (p.X == 0)
            {
                if (bond == "Taurus") upl = Agents[xym, ym];
                else upl = playernull;
            }
            else if (p.Y == 0)
            {
                if (bond == "Taurus") upl = Agents[xm, xym];
                else upl = playernull;
            }
            else upl = Agents[xm, ym]; // up-left
                                       //
                                       //
            if (p.X == 0 && p.Y == 0) // up-right
            {
                if (bond == "Taurus") upr = Agents[xp, xym];
                else upr = playernull;
            }
            else if (p.X == xym && p.Y == 0) // up-right
            {
                if (bond == "Taurus") upr = Agents[0, xym];
                else upr = playernull;
            }
            else if (p.X == xym) // up-right
            {
                if (bond == "Taurus") upr = Agents[0, ym];
                else upr = playernull;
            }
            else if (p.Y == 0) // up-right
            {
                if (bond == "Taurus") upr = Agents[xp, xym];
                else upr = playernull;
            }
            else upr = Agents[xp, ym];  // up-right
                                        //
                                        //
            if (p.X == 0 && p.Y == 0)
            {
                if (bond == "Taurus") dwl = Agents[xym, yp];
                else dwl = playernull;
            }
            else if (p.X == 0 && p.Y == xym)
            {
                if (bond == "Taurus") dwl = Agents[xym, 0];
                else dwl = playernull;
            }
            else if (p.X == 0)
            {
                if (bond == "Taurus") dwl = Agents[xym, yp];
                else dwl = playernull;
            }
            else if (p.Y == xym)
            {
                if (bond == "Taurus") dwl = Agents[xm, 0];
                else dwl = playernull;
            }
            else dwl = Agents[xm, yp];  // down-left
                                        //
                                        //
            if (p.X == xym && p.Y == xym)
            {
                if (bond == "Taurus") dwr = Agents[0, 0];
                else dwr = playernull;
            }
            else if (p.Y == xym)
            {
                if (bond == "Taurus") dwr = Agents[xp, 0];
                else dwr = playernull;
            }
            else if (p.X == xym)
            {
                if (bond == "Taurus") dwr = Agents[0, yp];
                else dwr = playernull;
            }
            else dwr = Agents[xp, yp]; //down-right

            plistM.Add(upl);
            plistM.Add(upr);
            plistM.Add(dwl);
            plistM.Add(dwr);
            return plistM;
        }

        private List<Player> GetNeighbour(Player p) // Von Neumann
        {
            Player left, right, up, down;
            Player playernull = new Player("null");
            List<Player> plist = new List<Player>();
            int xym = size - 1;
            int xp = p.X + 1;
            int xm = p.X - 1;
            int yp = p.Y + 1;
            int ym = p.Y - 1;

            if (p.X == 0)
            {
                if (bond == "Taurus") { left = Agents[xym, p.Y]; }
                else { left = playernull; }
                //  p.AddNeighbour(Agents[xym, p.Y]);
            }
            else left = Agents[xm, p.Y]; // left

            if (p.X == xym)
            {
                if (bond == "Taurus") right = Agents[0, p.Y];
                else right = playernull;
            }
            else right = Agents[xp, p.Y]; // right

            if (p.Y == 0)
            {
                if (bond == "Taurus") up = Agents[p.X, xym];
                else up = playernull;
            }
            else up = Agents[p.X, ym]; // up

            if (p.Y == xym)
            {
                if (bond == "Taurus") down = Agents[p.X, 0];
                else down = playernull;
            }
            else down = Agents[p.X, yp]; // down

            plist.Add(left);
            plist.Add(right);
            plist.Add(up);
            plist.Add(down);
            return plist;
        }



        private async void btnplay_Click(object sender, EventArgs e)
        {
            btnplay.Enabled = false;
            stopped = false;
            btnstop.Enabled = true;
            await Task.Run(() =>
            {
                for (int i = 0; i < iterations;)
                {
                    Parallel.ForEach(Players, p =>
                        {
                            Match(p);
                        });
                    newGeneration();

                    
                    System.Threading.Thread.Sleep(500);
                    if (stopped) return;
                   // chart1.Series["Cooperator"].Points.AddXY(iterations, cooperatorslis.Count);
                   // chart1.Series["Defector"].Points.AddXY(iterations, defectorslis.Count);
                    i++;
                }
                
            });

           defelist.Text = Convert.ToString(defectorslis.Count);
           cooplist.Text = Convert.ToString(cooperatorslis.Count);
           
        }

        void chartload()
        {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;
            chart.AxisX.Interval = 1;
            chart.AxisX.Interval = 50;
       

        }

            private void updateiter(int i)
        {
            
            
        }
        private void Match(Player p)
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
        }
        // let a player play with its 8 neighbour

        private double Play(Player player1, Player player2)
        {
            if (player2.State == "null")
            {
                return 0;
            }
            else
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
                return 0;
            }
        } // play pd with two player that neighbour

        private void newGeneration()
        {
            if (synchro == "syn")
            {
                Parallel.ForEach(Players, p =>
                {
                    Player best = BestNeighbour(p);

                    NewBehaviour(p, best.State);
                    
                });
            }
            else
            {
                foreach (Player p in Players)
                {
                    Player best = BestNeighbour(p);

                    NewBehaviour(p, best.State);
                }
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
                    if (BestV.FitnessScore >= p.FitnessScore)
                        return BestV;
                    else return p;
                    }
                    else
                    {
                    if (BestM.FitnessScore >= p.FitnessScore)
                        return BestM;
                    else return p;
                    }
            }
            else
            {
                if (BestV.FitnessScore >= p.FitnessScore)
                    return BestV;
                else return p;
            }
        }

        private void  NewBehaviour(Player p, string beststat)
        {
           
           Graphics gr = panel1.CreateGraphics();
            if (p.State == "C")
            {
                if (beststat == "D")
                {
                    gr.FillRectangle(Brushes.Yellow, p.RectP);
                    p.State = "D";
                   // gr.DrawRectangle(myPen, p.RectP);
                    defectorslis.Add(p);
                    cooperatorslis.Remove(p);
                   
                    
                }
                else
                {
                    gr.FillRectangle(Brushes.Blue, p.RectP);
                    p.State = "C";
                    //gr.DrawRectangle(myPen, p.RectP);
                    //cooperatorslis.Add(p);
                   
                }
            }
            else
            {
                if (beststat == "C")
                { 
                    gr.FillRectangle(Brushes.Green, p.RectP);
                    p.State = "C";
                   // gr.DrawRectangle(myPen, p.RectP);
                    cooperatorslis.Add(p);
                    defectorslis.Remove(p);
                  
                }
                else
                { 
                    gr.FillRectangle(Brushes.Red, p.RectP);
                    p.State = "D";
                    //  gr.DrawRectangle(myPen, p.RectP);
                    //defectorslis.Add(p);
                   
                }
            }
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (defecttype == "click")
            {
                var p = Players.FirstOrDefault(i => i.RectP.Contains(e.X, e.Y));
                if (p != null)
                {
                    gr.FillRectangle(Brushes.Red, p.RectP);
                    gr.DrawRectangle(myPen, p.RectP);
                    p.State = "D";
                    p.OldState = "D";
                    defectorslis.Add(p);
                    cooperatorslis.Remove(p);
                    
                }
                defelist.Text = Convert.ToString(defectorslis.Count);
                cooplist.Text = Convert.ToString(cooperatorslis.Count);
            }
            else
            {
              
            }


        }
        private void infotab(string s)
        {
            if (s == "click")
            {
                defecttype = "click";
                //DrawGrid();
            }
            else
            {
                label3.Text = "Percentage: the initial configurations will be on random basis by the percentage or number of defector selected.\nPress Play to let the iterations start.";
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            btnplay.Enabled = true;
            btnplay.Text = "RESUME";
            stopped = true;
            btnstop.Enabled = false;
        }
    }
}

