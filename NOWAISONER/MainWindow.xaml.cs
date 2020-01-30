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
        private int size;
        private int iterationn;
        private int defectorsperc = 0;
        private string neightype;
    
        
        private void txtslider2_TextChanged(object sender, TextChangedEventArgs e)
        {
            defectorsperc = Convert.ToInt32(txtslider2.Text) * (size * size) / 100;
            numdef.Text = Convert.ToString(defectorsperc);
            
        }

        private void latticesize_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isNumeric = int.TryParse(latticesize.Text, out size);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                Game game = new Game(size, defectorsperc, neightype, iterationn);
                game.Show();
            
        }

        private void numdef_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void neighbourbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (neighbourbox.Text == "Von Neumann")
            {
                neightype = "V";
            }
            else
            {
                neightype = "M";
            }
        }

        private void iteration_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isNumeric = int.TryParse(iteration.Text, out iterationn);
        }
    }
}
