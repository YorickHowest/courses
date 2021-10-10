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

namespace Prb.Inleiding.ControlsAndEvents.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string lesuur;
        string dag;
        string module;
        public MainWindow()
        {
            InitializeComponent();
            cmbLesUur.Items.Add("1");
            cmbLesUur.Items.Add("2");
            cmbLesUur.Items.Add("3");
            cmbLesUur.Items.Add("4");
            cmbLesUur.Items.Add("5");
            cmbLesUur.Items.Add("6");
            cmbLesUur.Items.Add("7");
            cmbLesUur.Items.Add("8");
            lstDagVanDeWeek.Items.Add("Maandag");
            lstDagVanDeWeek.Items.Add("Dinsdag");
            lstDagVanDeWeek.Items.Add("Woensdag");
            lstDagVanDeWeek.Items.Add("Donderdag");
            lstDagVanDeWeek.Items.Add("Vrijdag");
            lstDagVanDeWeek.Items.Add("Zaterdag");
            lstDagVanDeWeek.Items.Add("Zondag");
            txtLesUur.Text = cmbLesUur.Text;
        }

        private void btnScenario1_Click(object sender, RoutedEventArgs e)
        {
            lesuur = txtLesUur.Text;
            dag = txtDagVanDeWeek.Text;
            module = txtModuleNaam.Text;
            tbkSummary.Text = $"Op {dag} is er {module} op lesuur {lesuur}.";
        }
    }
}
