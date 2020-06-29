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
    /// Interaction logic for ucKlant.xaml
    /// </summary>
    public partial class ucKlant : UserControl
    {
        kassaDbDataContext db = new kassaDbDataContext();
        public ucKlant()
        {
            InitializeComponent();
            dgDranken.ItemsSource = db.products.ToList();
            //dgKlanten.ItemsSource = db.klants.ToList();
        }

        private void dgDranken_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            product dranken = (product)dgDranken.SelectedItem;
            dgBestelling.Items.Add(dranken);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int bestellingId = (from bestelling in db.bestellings select bestelling).Count();

            bestelling be = new bestelling();
            be.datum = DateTime.Today.ToString();
            be.klantId = Convert.ToInt16(txtKlantId.Text);
            be.bestellingId = bestellingId++;

            db.bestellings.InsertOnSubmit(be);

            int antalProduct = 0;
    
            ItemPerBestelling item = new ItemPerBestelling();
            foreach (object i in dgBestelling.Items) 
            {
                antalProduct++;

            }

            item.aantal = antalProduct;
            item.bestellingId = bestellingId;

            db.ItemPerBestellings.InsertOnSubmit(item);
            db.SubmitChanges();

        }
    }
}
