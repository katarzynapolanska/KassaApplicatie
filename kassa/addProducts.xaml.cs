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
    /// Interaction logic for addProducts.xaml
    /// </summary>
    public partial class addProducts : UserControl
    {
        kassaDbDataContext db = new kassaDbDataContext();
        public addProducts()
        {
            InitializeComponent();
            dgProducten.ItemsSource = db.products.ToList();
            //dgProducten.ItemsSource = db.productTypes.ToList();
            
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
  
            product product = new product();
            product.productNaam = txtNaam.Text;
            product.prijs = Decimal.Parse(txtPrijs.Text);

            productType type = new productType();
            type.omschrijving = txtType.Text;

            db.products.InsertOnSubmit(product);
            db.productTypes.InsertOnSubmit(type);
            db.SubmitChanges();

            dgProducten.ItemsSource = db.products.ToList();

        }
    }
}
