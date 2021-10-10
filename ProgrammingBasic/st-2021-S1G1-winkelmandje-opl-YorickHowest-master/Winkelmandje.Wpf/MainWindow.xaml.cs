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

namespace Winkelmandje.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string userName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //uitlezen van textboxes
            userName = txtUserName.Text;
            string product = txtProductName.Text;
            int numberOfProducts = int.Parse(txtNumberOfProducts.Text);
            int price = int.Parse(txtProductPrice.Text);

            //omzettingen doen
            userName = userName.ToUpper();
            product = product.ToLower();

            //prijs berekenen
            int totalPrice = numberOfProducts * price;

            //listbox entry maken
            lstOrders.Items.Add(userName + " bestelt " + numberOfProducts + " " + product + 
                " voor " + totalPrice + " euro.");

            //textboxes blanco maken
            txtUserName.Text = "";
            txtProductName.Text = "";
            txtNumberOfProducts.Text = "";
            txtProductPrice.Text = "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Laatste klant: " + userName);
        }
    }
}
