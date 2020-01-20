using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NOWAISONER
{
    class Interactions
    {
        private Player[][] world;
        private int[,] scores;
        private int[] scaledScores;
        private Hashtable encounter;

        private Payoff payoff;
        private int X;
        private int Y;

        private Random rand = new Random();
        private int[] lastP;

        public Interactions(Player[][] Players, Payoff r)
        {
            world = Players;
            payoff = r;
            X = world.Length;
            Y = world.Length;
            scores = new int[X,Y];
            encounter = new Hashtable(0);

            lastP = new int[2];
            lastP[0] = -1;
            lastP[1] = -1;
        }

        public void Play()
        {
            int x, xm, xp = 0;
            int y, ym, yp = 0;

            for (x = 0; x < X; x++) // Taurus connections
            {
                if (x <= 0) { xm = X - 1; }
                else { xm = x - 1; }

                if (x < (X - 1)) { xp = x + 1; }
                else { xp = 0; }

                for (y = 0; y < Y; y++)
                {
                    if (y <= 0) { ym = Y - 1; }
                    else { ym = y - 1; }

                    if (y < (Y - 1)) { yp = y + 1; }
                    else { yp = 0; }

                    world[x][y].setScore(0);

                    match(x, y, x, ym);
                }
            }
        }
        private void match(int x0, int y0, int x1, int y1)
        {
            int iterations;
            string key;
            int pos;

        }



    }
}
