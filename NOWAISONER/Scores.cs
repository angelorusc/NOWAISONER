using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOWAISONER
{
    public class Scores
    {
        private double t, s, r, p;

        public double T
        {
            get { return t; }
            set { this.t = value; }
        }
        public double R
        {
            get { return r; }
            set { this.r = value; }
        }
        public double S
        {
            get { return s; }
            set { this.s = value; }
        }
        public double P
        {
            get { return p; }
            set { this.p = value; }
        }
    }
}
