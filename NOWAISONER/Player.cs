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
        private string state;

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
        public string State
        {
            get { return state; }
            set { this.state = State; }
        }

        public Player(int x, int y, int num, string State)
        {
            this.num = num;
            this.x = x;
            this.y = y;
            this.state = State;
            // this.fitnessScore = 0;
        }
        public void setScore(int s)
        {
            fitnessScore = s;
        }
        public void setState(string s)
        {
            state = s;
        }


    }
}
