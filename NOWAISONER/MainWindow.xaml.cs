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
        private int[] scores;
        
        NewGrid New = new NewGrid();
        Scores score = new Scores();
        
        private void txtslider2_TextChanged(object sender, TextChangedEventArgs e)
        {
                bool isNumer2 = int.TryParse(perctxt.Text, out percdef);
                defectorsperc = percdef * (size * size) / 100;
                New.Defectors = defectorsperc;
                
            
                
        }

        private void latticesize_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isNumeric = int.TryParse(latticesize.Text, out size);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            New.Size = size;
            score.T = Convert.ToDouble(t.Text);
            score.R = Convert.ToDouble(r.Text);
            score.S = Convert.ToDouble(s.Text);
            score.P = Convert.ToDouble(p.Text);
            Game game = new Game(New,score);
                game.Show();
                

        }
       
        
        private void neighbourbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (neighbourbox.Text == "Von Neumann")
            {
                New.Neightype = "V";
            }
            else
            {
                New.Neightype = "M";
            }
        }

        private void iteration_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isNumeric = int.TryParse(iteration.Text, out iterationn);
            New.Iteration = iterationn;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            New.Typeofdefector = "perc";
            perctxt.Visibility = Visibility.Visible;
            numtxt.Visibility = Visibility.Visible;
            n.Visibility = Visibility.Visible;
            n_Copy.Visibility = Visibility.Visible;

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            New.Typeofdefector = "click";
            perctxt.Visibility = Visibility.Collapsed;
            numtxt.Visibility = Visibility.Collapsed;
            n.Visibility = Visibility.Collapsed;
            n_Copy.Visibility = Visibility.Collapsed;
            
        }

        private void asyn_Checked(object sender, RoutedEventArgs e)
        {
            New.Synchro = "asy";
        }

        private void sync_Checked(object sender, RoutedEventArgs e)
        {
            New.Synchro = "syn";
        }

        private void numtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                New.Defectors = Convert.ToInt32(numtxt.Text);
            }
            catch
            {
                MessageBox.Show("Insert a correct number of defectors");
            }
        }

        private void boundaries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (boundaries.Text == "Fixed")
            {
                New.Bound = "Fix";
            }
            else
            {
                New.Bound = "Tau";
            }
        }
        
        private void t_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void r_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
