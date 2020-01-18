using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NOWAISONER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public int size;
        private int defectorsperc;

        public int[,] gamegrid;
        private int x { get; set; }
        private int y { get; set; }
        
        
        
        private void txtslider2_TextChanged(object sender, TextChangedEventArgs e)
        {
           defectorsperc = Convert.ToInt32(txtslider2.Text);
        }

        private void CreateGrid(int i, int t)
        {
            
            for (i = 0; i < size; i++)
            {
                for (t = 0; t < size; t++)
                {
                    

                }
            }
        }

        private void latticesize_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isNumeric = int.TryParse(latticesize.Text, out size);
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Form1 form = new Form1(size,defectorsperc);
            form.Show();
        }
    }
}
