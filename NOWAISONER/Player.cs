using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOWAISONER
{
    class Player
    {
        private int x, y, num;
        private int fitnessScore = 0;
        private string state;
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
        public void AddNeighbour(Player p)
        {
            neighbour.Add(p);
        }
        public void AddMooreNeighbour(Player p)
        {
            mooreNeighbour.Add(p);
        }

        public int X
        {
            get { return x; }
            set { this.x = X; }
        }
        public int Y
        {
            get { return y; }
            set { this.y = Y; }
        }
        public int Num
        {
            get { return num; }
            set { this.num = Num; }
        }
        public int FitnessScore
        {
            get { return fitnessScore; }
            set { this.fitnessScore = value; }
        }
        
        public string State
        {
            get { return state; }
            set { this.state = value; }
        }

        public Player(int x, int y, int num, string State)
        {
            this.num = num;
            this.x = x;
            this.y = y;
            this.state = State;
            // this.fitnessScore = 0;
        }
       
    }
}
