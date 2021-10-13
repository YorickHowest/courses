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

namespace Prb.Radiators.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbRadiatorHeight.Items.Add(50);
            cmbRadiatorHeight.Items.Add(60);
            cmbRadiatorHeight.Items.Add(70);
            cmbRadiatorHeight.Items.Add(80);
            cmbRadiatorHeight.Items.Add(90);
            cmbRadiatorHeight.Items.Add(100);
            cmbRadiatorWidth.Items.Add(50);
            cmbRadiatorWidth.Items.Add(60);
            cmbRadiatorWidth.Items.Add(70);
            cmbRadiatorWidth.Items.Add(80);
            cmbRadiatorWidth.Items.Add(90);
            cmbRadiatorWidth.Items.Add(100);
            cmbRadiatorPanels.Items.Add(1);
            cmbRadiatorPanels.Items.Add(2);
            cmbRadiatorPanels.Items.Add(3);
            panBottom.IsEnabled = false;
            txtRoomHeight.Text = "";
            txtRoomLenght.Text = "";
            txtRoomWidth.Text = "";
            lblRoomVolume.Content = "";
            lblRoomWatts.Content = "";
            lstRadiators.Items.Clear();
            lblRadiatorWatts.Content = "";
            btnAddRadiator.Visibility = Visibility.Hidden;
        }

        private void btnCalculateVolumeAndWatts_Click(object sender, RoutedEventArgs e)
        {
            string roomlenghtAsText = txtRoomLenght.Text;
            string roomwidthAsText = txtRoomWidth.Text;
            string roomheightAsText = txtRoomHeight.Text;
            int roomlenght = int.Parse(roomlenghtAsText);
            int roomwidth = int.Parse(roomwidthAsText);
            int roomheight = int.Parse(roomheightAsText);
            var roomvolumecalc = roomlenght * roomwidth * roomheight / 1000000;
            lblRoomVolume.Content = roomvolumecalc;
            var roomwattscalc = roomvolumecalc * 50;
            lblRoomWatts.Content = roomwattscalc;
            panTop.IsEnabled = false;
            panBottom.IsEnabled = true;
        }

        private void btnCalculateRadiatorWatts_Click(object sender, RoutedEventArgs e)
        {
            string radiatorheightAsText = cmbRadiatorHeight.Text;
            string radiatorwidthAsText = cmbRadiatorWidth.Text;
            string radiatorpanelsAsText = cmbRadiatorPanels.Text;
            int radiatorheight = int.Parse(radiatorheightAsText);
            int radiatorwidth = int.Parse(radiatorwidthAsText);
            int radiatorpanels = int.Parse(radiatorpanelsAsText);
            var volumeradiator = radiatorheight * radiatorwidth * radiatorpanels * 0.15;
            lblRadiatorWatts.Content = volumeradiator;
            btnAddRadiator.Visibility = Visibility.Visible;
        }

        private void cmbRadiatorHeight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnAddRadiator.Visibility = Visibility.Hidden;
        }

        private void cmbRadiatorWidth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnAddRadiator.Visibility = Visibility.Hidden;
        }

        private void cmbRadiatorPanels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnAddRadiator.Visibility = Visibility.Hidden;
        }

        private void btnRadiatorAdd_Click(object sender, RoutedEventArgs e)
        {
            string radiatorheightAsText = cmbRadiatorHeight.Text;
            string radiatorwidthAsText = cmbRadiatorWidth.Text;
            string radiatorpanelsAsText = cmbRadiatorPanels.Text;
            int radiatorheight = int.Parse(radiatorheightAsText);
            int radiatorwidth = int.Parse(radiatorwidthAsText);
            int radiatorpanels = int.Parse(radiatorpanelsAsText);
            var volumeradiator = radiatorheight * radiatorwidth * radiatorpanels * 0.15;
            lblRadiatorWatts.Content = volumeradiator;
            lstRadiators.Items.Add("Hoogte = " + radiatorheight.ToString() + " , breedte = " + radiatorwidth.ToString() + " , panelen = " + radiatorpanels.ToString() + " , vermogen paneel = " + volumeradiator.ToString());
            lblTotalWatts.Content = volumeradiator;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            panTop.IsEnabled = true;
            panBottom.IsEnabled = false;
            txtRoomHeight.Text = "";
            txtRoomLenght.Text = "";
            txtRoomWidth.Text = "";
            lblRoomVolume.Content = "";
            lblRoomWatts.Content = "";
            lstRadiators.Items.Clear();
            lblRadiatorWatts.Content = "";
            btnAddRadiator.Visibility = Visibility.Hidden;
        }
    }
}
