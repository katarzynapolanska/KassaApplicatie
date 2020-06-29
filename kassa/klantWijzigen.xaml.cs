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
    /// Interaction logic for klantWijzigen.xaml
    /// </summary>
    public partial class klantWijzigen : UserControl
    {
        kassaDbDataContext db = new kassaDbDataContext();
        public klantWijzigen(klant newklant)
        {
            InitializeComponent();
            txtTelefoon.Text = newklant.telefoonnummer;
            txtVoornaam.Text = newklant.voornaam;
            txtAchternaam.Text = newklant.achternaam;
            txtStad.Text = newklant.stad;
        }
    }
}
