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
    /// Interaction logic for nieuw.xaml
    /// </summary>
    public partial class nieuw : UserControl
    {
        kassaDbDataContext db = new kassaDbDataContext();
        public nieuw()
        {
            InitializeComponent();
            dgKlanten.ItemsSource = db.klants.ToList();
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            klant persoon = new klant();
            persoon.telefoonnummer = txtTelefoon.Text;
            persoon.voornaam = txtVoornaam.Text;
            persoon.achternaam = txtAchternaam.Text;
            persoon.stad = txtStad.Text;
            db.klants.InsertOnSubmit(persoon);
            db.SubmitChanges();

            dgKlanten.ItemsSource = db.klants.ToList();
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            var vklant = (klant)dgKlanten.SelectedItem;
            gWijzig.Children.Clear();
            //klantWijzigen kw = new klantWijzigen();
            //gWijzig.Children.Add(kw);
        }
    }
}
