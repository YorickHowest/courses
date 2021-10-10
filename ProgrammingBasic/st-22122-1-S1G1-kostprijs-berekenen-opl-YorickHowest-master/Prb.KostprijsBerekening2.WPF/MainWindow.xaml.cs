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

namespace Prb.KostprijsBerekening2.WPF
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


        private void btnBerekenTotaalprijs_Click(object sender, RoutedEventArgs e)
        {
            double deDagPrijs = double.Parse(txtDagPrijs.Text);
            int hetAantalDagen = int.Parse(txtAantalDagen.Text);
            double deTotaalPrijs = BerekenTotaalprijs(deDagPrijs, hetAantalDagen);
            lblTotaalPrijs.Content = "€ " + deTotaalPrijs.ToString("#,##0.000");

        }
        double BerekenTotaalprijs(double dagPrijs, int aantalDagen)
        {
            double totaalprijs = dagPrijs * aantalDagen;
            return totaalprijs;
        }

        private void sldAantalDagen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int aantalDagen = (int) sldAantalDagen.Value;
            txtAantalDagen.Text = aantalDagen.ToString();
            lblTotaalPrijs.Content = "";
        }


    }
}
