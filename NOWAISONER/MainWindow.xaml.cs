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
            
            perctxt.Visibility = Visibility.Collapsed;
            numtxt.Visibility = Visibility.Collapsed;
            n.Visibility = Visibility.Collapsed;
            n_Copy.Visibility = Visibility.Collapsed;
        }
        private int size;
        private int iterationn;
        private int defectorsperc = 0;
        private int percdef;
        private string neightype;
        private string typeofdefectors;
        private string synchro;
        private string bound;
        
        private void txtslider2_TextChanged(object sender, TextChangedEventArgs e)
        {
                bool isNumer2 = int.TryParse(perctxt.Text, out percdef);
                defectorsperc = percdef * (size * size) / 100;

                numtxt.Text = Convert.ToString(defectorsperc);
        }

        private void latticesize_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isNumeric = int.TryParse(latticesize.Text, out size);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                string boun = boundaries.Text;
            
                Game game = new Game(size, defectorsperc, neightype, iterationn, synchro, boun, typeofdefectors);
                game.Show();
                

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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            typeofdefectors = "perc";
            perctxt.Visibility = Visibility.Visible;
            numtxt.Visibility = Visibility.Visible;
            n.Visibility = Visibility.Visible;
            n_Copy.Visibility = Visibility.Visible;

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            typeofdefectors = "click";
            perctxt.Visibility = Visibility.Collapsed;
            numtxt.Visibility = Visibility.Collapsed;
            n.Visibility = Visibility.Collapsed;
            n_Copy.Visibility = Visibility.Collapsed;
            
        }

        private void asyn_Checked(object sender, RoutedEventArgs e)
        {
            synchro = "asy";
        }

        private void sync_Checked(object sender, RoutedEventArgs e)
        {
            synchro = "syn";
        }

        private void numtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            //defectorsperc = Convert.ToInt32(numtxt.Text);
        }

        private void boundaries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
       
    }
}
