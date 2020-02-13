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
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
namespace NOWAISONER
{
    public partial class Game : Form
    {
        private int size; //size of grid
        private int defectors; // number of defectors
        private int iterations; // number of iterations
        private int xys;
        private int it;

        
        private string bond;
        private string synchro;
        private string neighbourtype; // von neumann or moore neighbours
        private string defecttype;
       
        private bool stopped = false;
      

        private List<Player> defectorslis = new List<Player>();  //defector list to take count of defectors
        private List<Player> cooperatorslis = new List<Player>(); // cooperators list 
        private List<Player> Players = new List<Player>(); // list of players
        private List<int> synchroscores = new List<int>();

        
        Player[,] Agents; // 2d array for keep players location
      

        private Random rand = new Random(); //random number 

        Graphics gr;
        Rectangle Rectexp;
        Pen myPen = new Pen(Brushes.Black, 1);

        Scores classcore;

        public Graphics Gr
        {
            get { return gr; }
            set { this.gr = Gr; }
        }
        public Pen MyPen
        {
            get { return myPen; }
            set { this.myPen = MyPen; }
        }
        public string Synchro
        {
            get { return synchro; }
            set { this.synchro = value; }
        }
        public int Defectors
        {
            get { return defectors; }
            set { this.defectors = value; }
        }

        public string Neighbourtype
        {
            get { return neighbourtype; }
            set { this.neighbourtype = value; }
        }
        public List<Player> players
        {
            get { return Players; }
            set { this.Players = players; }
        }
        public List<Player> Defectorslis
        {
            get { return defectorslis; }
            set { this.defectorslis = Defectorslis; }
        }
        public List<Player> Cooperatorslis
        {
            get { return cooperatorslis; }
            set { this.cooperatorslis = Cooperatorslis; }
        }
        public Game(NewGrid newgame, Scores scor)
        {
            InitializeComponent();
            btnplay.Enabled = false;
            btnstop.Enabled = false;
            settingstxt.Text = string.Format("Size: {0} | Neighbours: {1} | Iterations: {2} | Boundaries: {3} | Updating: {4} ", Convert.ToString(newgame.Size), newgame.Neightype, Convert.ToString(newgame.Iteration), newgame.Bound, newgame.Synchro);

            playersnum.Text = Convert.ToString(size * size);
            this.size = newgame.Size;
            this.defectors = newgame.Defectors;
            this.defecttype = newgame.Typeofdefector;
            this.neighbourtype = newgame.Neightype ;
            this.iterations = newgame.Iteration;
            this.synchro = newgame.Synchro; // if synchronous or asynchronous
            this.bond = newgame.Bound;
            this.classcore = scor;
          //  chartload();
            infotab(defecttype);
            playersnum.Text = Convert.ToString(newgame.Size * newgame.Size);
        }


        public void DrawGrid()
        {
            gr = panel1.CreateGraphics();
            xys = panel1.Width / size;
            int x = 0;
            int y = 0;
            Agents = new Player[size, size];
            int counter = 0;
            Rectexp = new Rectangle(x, y, panel1.Width, panel1.Height);
            
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
            btnplay.Enabled = true;
            btnstop.Enabled = true;
            drawbtn.Text = "DRAWN";
            
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
            drawbtn.Text = "DRAWN";
        }

        private void drawStates()
        {
            for (int k = 0; k < defectors; k++)
            {
                int xdef = rand.Next(size);
                int ydef = rand.Next(size);
                Player p = Agents[xdef, ydef];
                
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
        } // draw initial configurations of defectors 

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

       
        private async void btnplay_Click(object sender, EventArgs e)
        {
            //chartload();
            btnplay.Enabled = false;
            stopped = false;
            btnstop.Enabled = true;

            GraphStyle(); // graph type
           
            await Task.Run(() =>
            {
                if (it != 0 || it != iterations)
                {
                    for (int i = it; i < iterations;)
                    {
                        UpdateGraph(); // update graph data
                        Parallel.ForEach(Players, p =>
                        {
                            Match(p);
                        });
                        newGeneration();
                        System.Threading.Thread.Sleep(500);
                        if (stopped) return;
                        it = i;
                        i++;
                    }
                }
                else
                {
                    for (int i = 0; i < iterations;)
                    {
                        UpdateGraph(); // update graph data
                        Parallel.ForEach(Players, p =>
                            {
                                Match(p);
                            });
                        newGeneration();
                        System.Threading.Thread.Sleep(500);
                        if (stopped) return;
                        it = i;
                        i++;
                    }
                }

            });

        
        }

        private void UpdateGraph()
        {
            Series sd = chart1.Series[1];
            Series sc = chart1.Series[0];
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    sd.Points.Add(defectorslis.Count);
                    sc.Points.Add(cooperatorslis.Count);
                    iter.Text = Convert.ToString(it);
                    defelist.Text = Convert.ToString(defectorslis.Count);
                    cooplist.Text = Convert.ToString(cooperatorslis.Count);
                }));
            }
            else
            {
                sd.Points.Add(defectorslis.Count);
                sc.Points.Add(cooperatorslis.Count);
                iter.Text = Convert.ToString(it);
                defelist.Text = Convert.ToString(defectorslis.Count);
                cooplist.Text = Convert.ToString(cooperatorslis.Count);
            }
        }

        private void GraphStyle()
        {
            if (graphcombo.Text == "Column")
            {
                chart1.Series[1].ChartType = SeriesChartType.Column;
                chart1.Series[0].ChartType = SeriesChartType.Column;
            }
            else if (graphcombo.Text == "Line")
            {
                chart1.Series[1].ChartType = SeriesChartType.Line;
                chart1.Series[0].ChartType = SeriesChartType.Line;
            }
            else if (graphcombo.Text == "Stacked Column")
            {
                chart1.Series[1].ChartType = SeriesChartType.StackedColumn;
                chart1.Series[0].ChartType = SeriesChartType.StackedColumn;
            }

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
                        return classcore.R; //reward C C
                    }
                    if (player2.State == "D")
                    {
                        return classcore.S; // sucker C D
                    }
                }
                else //if (player1.State == "D")
                {
                    if (player2.State == "C")
                    {
                        return classcore.T; // temptation D C
                    }
                    if (player2.State == "D")
                    {
                        return classcore.P; // punishment D D
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

        private void NewBehaviour(Player p, string beststat)
        {

            Graphics gr = panel1.CreateGraphics();
            if (p.State == "C")
            {
                if (beststat == "D")
                {
                    gr.FillRectangle(Brushes.Yellow, p.RectP);
                    p.State = "D";
                    this.Invoke(new MethodInvoker(delegate
                    {
                        gr.DrawRectangle(myPen, p.RectP);
                    }));
                    cooperatorslis.Remove(p);
                    defectorslis.Add(p);



                }
                else
                {
                    gr.FillRectangle(Brushes.Blue, p.RectP);
                    p.State = "C";
                    this.Invoke(new MethodInvoker(delegate
                    {
                        gr.DrawRectangle(myPen, p.RectP);
                    }));

                    //cooperatorslis.Add(p);

                }
            }
            else
            {
                if (beststat == "C")
                {
                    gr.FillRectangle(Brushes.Green, p.RectP);
                    p.State = "C";
                    this.Invoke(new MethodInvoker(delegate
                    {
                        gr.DrawRectangle(myPen, p.RectP);
                    }));
                    defectorslis.Remove(p);
                    cooperatorslis.Add(p);


                }
                else
                {
                    gr.FillRectangle(Brushes.Red, p.RectP);
                    p.State = "D";
                    this.Invoke(new MethodInvoker(delegate
                    {
                        gr.DrawRectangle(myPen, p.RectP);
                    }));
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

        private void exgrid_Click(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm;
            var bmp = new Bitmap(panel1.Width + 2, panel1.Height + 23);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(frm.Location.X + 28, frm.Location.Y + 61, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(@"C:\Users\rusci\Desktop\gridtrial.jpg");

        }

        private void exgraph_Click(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm;
            var bmp = new Bitmap(chart1.Width, chart1.Height - 3);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(frm.Location.X + 962, frm.Location.Y + 632, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(@"C:\Users\rusci\Desktop\Graphtrial.jpg");
        }
    }
}

