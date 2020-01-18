using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;


namespace NOWAISONER
{
    class Panel 
    {
       private int lenght;
        private int max;
        private int[] data0;
        private int[] data1;
        private double[] data2;

        private ConsoleColor col0, col1, col2;
        private string Label0, Label1, Label2, Labelx;

        private int lastHeight0;
        private int lastHeight1;
        private int lastHeight2;
        private int pos;
        private int count;
        

        public Panel()
        {
            count = 0;
            max = 5;
            lenght = 51;
            lastHeight0 = 0;
            lastHeight1 = 0;
            lastHeight2 = 0;
            pos = -1;
            data0 = new int[lenght];
            data1 = new int[lenght];
            data2 = new double[lenght];
            for (int i=0; i< lenght; i++)
            {
                data0[i] = -1;
                data1[i] = -1;
                data2[i] = -1;
            }
            col0 = ConsoleColor.Red;
            col1 = ConsoleColor.Blue;
            col2 = ConsoleColor.Green;

            Label0 = null;
            Label1 = null;
            Label2 = null;
            Labelx = null;
        }

   
       
    }
}
