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
        private string strategy;
        private int fitnessScore;
        private int boxNo = 0;
        private int state = 0;

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
            set { this.fitnessScore = FitnessScore; }
        }
        public int BoxNo
        {
            get { return boxNo; }
            set { this.boxNo = BoxNo; }
        }
        public int State
        {
            get { return state; }
            set { this.state = State; }
        }

        public Player(int x, int y, int num, string strategy)
        {
            this.num = num;
            this.x = x;
            this.y = y;
            this.strategy = strategy;
            // this.fitnessScore = 0;
        }
    }
}
