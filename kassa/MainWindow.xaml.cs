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

namespace kassa
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

        private void btnKlant_Click(object sender, RoutedEventArgs e)
        {
            ucKlant go = new ucKlant();
            gInhoud.Children.Clear();
            gInhoud.Children.Add(go);
        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            nieuw go = new nieuw();
            gInhoud.Children.Clear();
            gInhoud.Children.Add(go);
        }

        private void btnMedewerker_Click(object sender, RoutedEventArgs e)
        {
            medewerker go = new medewerker();
            gInhoud.Children.Clear();
            gInhoud.Children.Add(go);
        }
    }
}
