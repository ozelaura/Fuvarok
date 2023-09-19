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
using System.IO;
using System.Xaml;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Fuvar> fuvarok = new List<Fuvar>();
        public MainWindow()
        {
            InitializeComponent();

            var fuvar = File.ReadAllLines("fuvar.csv").Skip(1);

            foreach (var f in fuvar)
            {
                fuvarok.Add(new Fuvar(f));
            }

        }




        private void feladat3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{fuvarok.Count}");
        }

        private void feladat4_Click(object sender, RoutedEventArgs e)
        {


            var feladat4_1 = fuvarok.Where(x => x.TaxiAzonosito == 6185).Sum(y => y.Viteldij);
            var feladat4_2 = fuvarok.Where(x => x.TaxiAzonosito == 6185).Sum(y => y.Borravalo);
            var feladat4_3 = fuvarok.Where(x => x.TaxiAzonosito == 6185).Count();

            MessageBox.Show($"{feladat4_3} fuvar alatt: {feladat4_1 + feladat4_2}");

        }

        private void feladat6_Click(object sender, RoutedEventArgs e)
        {
            var feladat6 = fuvarok.Count(x => x.Tavolsag);
            MessageBox.Show($"{feladat6*1.6}");
        }
    }
}
