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

namespace Prb.VoorkeursModule.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string naam;
        string voorkeur;
        public MainWindow()
        {
            InitializeComponent();
            btnOK.Visibility = Visibility.Hidden;
            lstVoorkeur.Items.Add("PRB");
            lstVoorkeur.Items.Add("WFB");
            lstVoorkeur.Items.Add("CIB");
            lstVoorkeur.IsEnabled = false;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            naam = txtNaam.Text;
            lstVoorkeur.IsEnabled = true;
            lblWelkom.Content = $"Welkom in Howest, {naam}";
        }

        private void lstVoorkeur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            voorkeur = lstVoorkeur.SelectedItem.ToString();
            tbkFeedBack.Text = $"{naam}, je voorkeur gaat uit naar {voorkeur}.";
        }
    }
}
