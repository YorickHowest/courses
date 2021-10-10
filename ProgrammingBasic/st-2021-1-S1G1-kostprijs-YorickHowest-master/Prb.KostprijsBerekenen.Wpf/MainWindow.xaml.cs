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

namespace Prb.KostprijsBerekenen.Wpf
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

        private void SldAantalDagen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Slider value naar tekstbox
            int sliderdays = Convert.ToInt32(sldAantalDagen.Value);
            txtAantalDagen.Text = Convert.ToString(sliderdays);
        }
    }
}
