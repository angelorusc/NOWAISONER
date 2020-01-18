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
        private int Size = 0;
        private string Strategy;
        private int playersnumber;
        private int defectorperc;
        private int defectors;
        private int cooperators;
        private List<Player> defectorslis = new List<Player>();
        private List<Player> cooperatorslis = new List<Player>();
        Random rand = new Random();
        private int xloc, yloc;
        
        
       
        
        List<Player> Players = new List<Player>();

        
        public Form1(int size, int defe)
        {
            InitializeComponent();
            this.Size = size;
            
            this.defectorperc = defe;
           test.Text = Convert.ToString(GetRandomNumber());
            
        }
        public double GetRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics gr = panel.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            Font myFont = new Font("Arial", 15);
            int lines = Size;
            playersnumber = Size * Size;
            players.Text = Convert.ToString(playersnumber);
            defectors = defectorperc * playersnumber / 100;
            cooperators = playersnumber - defectors;
            float x = 0f;
            float y = 0f;
            float xSpace = ((panel.Width - myPen.Width) * 1.0f / lines);
            float ySpace = ((panel.Height - myPen.Width) * 1.0f / lines);

            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(myPen, x, y, x, panel.Height);
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
            int[,] Agents = new int[lines, lines];
            int[,] Behaviour = new int[lines, lines];
            int[][] location = new int[lines][];
            int counter = 0;

            for (int r = 0; r < lines; r++)
            {
                for (int c = 0; c < lines; c++)
                {
                    Behaviour[r, c] = rand.Next(0, 2);
                    if (Behaviour[r, c] == 0 && defectorslis.Count < defectors)
                    {
                        xloc = r;
                        yloc = c;
                        Player p = new Player(xloc, yloc, counter, "defect");
                        Players.Add(p);
                        defectorslis.Add(p);

                        gr.DrawString("D", myFont, Brushes.Red, x, y);
                    }
                    else //if (cooperatorslis.Count < cooperators)
                    {
                        Player p = new Player(r, c, counter, "cooperate");
                        Players.Add(p);
                        cooperatorslis.Add(p);
                        gr.DrawString("C", myFont, Brushes.Green, x, y);

                    }


                    Agents[r, c] = counter;
                    // gr.DrawString((Convert.ToString(r)+","+Convert.ToString(c)+" NUM "+counter), myFont, Brushes.Red, x, y);
                    x += xSpace;
                    counter++;
                }
                y += ySpace;
                x = 0;
            }
            coopshould.Text = Convert.ToString(cooperators);
            defeshould.Text = Convert.ToString(defectors);
            cooplist.Text = Convert.ToString(cooperatorslis.Count);
            defelist.Text = Convert.ToString(defectorslis.Count);
            test.Text = "Player " + Agents[2, 8] + "\nBehaviour: " + Behaviour[2, 8] +"\nplayer num "+ Convert.ToString(Players[Agents[2,8]].Num) + " position x: \n"+ Convert.ToString(Players[Agents[2, 8]].X) + "\n Y: " + Convert.ToString(Players[Agents[2, 8]].Y);
        }

    }
}
