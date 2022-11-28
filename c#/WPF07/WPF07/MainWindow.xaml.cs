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

namespace WPF07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Manchester United", Team2 = "Liverpool", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Manchester United", Team2 = "Liverpool", Score1 = 3, Score2 = 2, Completion = 75 });
            matches.Add(new Match() { Team1 = "Manchester United", Team2 = "Liverpool", Score1 = 3, Score2 = 2, Completion = 53 });
            matches.Add(new Match() { Team1 = "Manchester United", Team2 = "Liverpool", Score1 = 3, Score2 = 2, Completion = 24 });
            matches.Add(new Match() { Team1 = "Manchester United", Team2 = "Liverpool", Score1 = 3, Score2 = 2, Completion = 25 });
            matches.Add(new Match() { Team1 = "Manchester United", Team2 = "Liverpool", Score1 = 3, Score2 = 2, Completion = 12 });

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                    + (lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " +
                    (lbMatches.SelectedItem as Match).Score2 + " " +
                    (lbMatches.SelectedItem as Match).Team2
                    );
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}
