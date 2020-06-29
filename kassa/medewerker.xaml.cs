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
    /// Interaction logic for medewerker.xaml
    /// </summary>
    public partial class medewerker : UserControl
    {
        public medewerker()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            addProducts go = new addProducts();
            mGrid.Children.Clear();
            mGrid.Children.Add(go);
        }

        private void btnKtoevoegen_Click(object sender, RoutedEventArgs e)
        {
            nieuw go = new nieuw();
            mGrid.Children.Clear();
            mGrid.Children.Add(go);
        }

        private void btnMbestelling_Click(object sender, RoutedEventArgs e)
        {
            ucKlant go = new ucKlant();
            mGrid.Children.Clear();
            mGrid.Children.Add(go);
        }
    }
}
