using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NOWAISONER
{
    class Player
    {
        private int x, y;
        private int  num;
        private Rectangle rectP;
        private double fitnessScore = 0;
        private string state;
        private string oldstate;
        private List<Player> neighbour = new List<Player>(); // index 0 = left, 1 = right, 2 = up, 3 = down;
        private List<Player> mooreNeighbour = new List<Player>(); // index 0 = up-left, 1 = up-right, 2 = down-left, 3 = down-right;

        public List<Player> Neighbour
        {
            get { return neighbour; }
            set { this.neighbour = Neighbour; }
        }
        public List<Player> MooreNeighbour
        {
            get { return mooreNeighbour; }
            set { this.mooreNeighbour = MooreNeighbour; }
        }
       
        //public void AddNeighbour(Player p)
        //{
        //    neighbour.Add(p);
        //}
        //public void AddMooreNeighbour(Player p)
        //{
        //    mooreNeighbour.Add(p);
        //}
        public Rectangle RectP
        {
            get { return rectP; }
            set { this.rectP = RectP;}
        }
        public int X
        {
            get { return x; }
            set { this.x = X; }
        }
        public int Y
        {
            get { return y; }
            set { this.y = X; }
        }
        public int Num
        {
            get { return num; }
            set { this.num = Num; }
        }
        public double FitnessScore
        {
            get { return fitnessScore; }
            set { this.fitnessScore = value; }
        }
        
        public string State
        {
            get { return state; }
            set { this.state = value; }
        }
        public string OldState
        {
            get { return oldstate; }
            set { this.oldstate = value; }
        }

        public void PassNeighbour(Player up, Player down, Player left, Player right)
        {
            neighbour.Add(up);
            neighbour.Add(down);
            neighbour.Add(left);
            neighbour.Add(right);
        }
        public void PassMooreNeighbour(Player upl, Player upr, Player dwl, Player dwr)
        {
            mooreNeighbour.Add(upl);
            mooreNeighbour.Add(upr);
            mooreNeighbour.Add(dwl);
            mooreNeighbour.Add(dwr);
        }
       
        public Player(Rectangle rp,int x, int y, int num, string State)
        {
            this.num = num;
            this.state = State;
            this.rectP = rp;
            this.x = x;
            this.y = y;
            // this.fitnessScore = 0;
        }
       
    }
}
