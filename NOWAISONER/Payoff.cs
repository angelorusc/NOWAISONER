using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;


namespace NOWAISONER
{
    class Payoff 
    {
        private int iterations, generations, players;

        private int T, R, S, P;
        private double mutateP, crossP;

        public Payoff()
        {
            iterations = 100;
            T = 5;
            R = 3;
            S = 0;
            P = 1;
            mutateP = 0.001;
            crossP = 0.95;
            generations = 250;
            players = 50;
        }

        public Payoff(int it, int t, int r, int s, int p)
        {
            iterations = it;
            T = t;
            R = r;
            S = s;
            P = p;
            mutateP = 0.001;
            crossP = 0.95;
            generations = 250;
            players = 50;
        }

        public Payoff(int it, int t, int r, int s, int p, double m, double c, int gen, int pl)
        {
            iterations = it;
            T = t;
            R = r;
            S = s;
            P = p;
            mutateP = m;
            crossP = c;
            generations = gen;
            players = pl;
        }

        public int Iterations
        {
            get { return iterations; }
            set { this.iterations = Iterations; }
        }
        public int Generations
        {
            get { return generations; }
            set { this.generations = Generations; }
        }
        public int Players
        {
            get { return players; }
            set { this.players = Players; }
        }
        public int Tp
        {
            get { return Tp; }
            set { this.T = Tp; }
        }
        public int Rp
        {
            get { return Rp; }
            set { this.R = Rp; }
        }
        public int Sp
        {
            get { return Sp; }
            set { this.S = Sp; }
        }
        public int Pp
        {
            get { return Pp; }
            set { this.P = Pp; }
        }
        public int MutateP
        {
            get { return MutateP; }
            set { this.mutateP = MutateP; }
        }
        public int CrossP
        {
            get { return CrossP; }
            set { this.crossP = CrossP; }
        }




    }
}
