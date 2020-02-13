using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOWAISONER
{
    public class NewGrid
    {
        private int size;
        private int iteration;
        private int defectors;

        private string typeofdefector;
        private string neightype;
        private string synchro;
        private string bound;

        public int Size
        {
            get { return size; }
            set { this.size = value; }
        }
        public int Iteration
        {
            get { return iteration; }
            set { this.iteration = value; }
        }
        public int Defectors
        {
            get { return defectors; }
            set { this.defectors = value; }
        }
        
        public string Neightype
        {
            get { return neightype; }
            set { this.neightype = value; }
        }
        public string Typeofdefector
        {
            get { return typeofdefector; }
            set { this.typeofdefector = value; }
        }

        public string Synchro
        {
            get { return synchro; }
            set { this.synchro = value; }
        }
        public string Bound
        {
            get { return bound; }
            set { this.bound = value; }
        }

    }
    
}
