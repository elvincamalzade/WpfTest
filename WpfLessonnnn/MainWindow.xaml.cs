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

namespace WpfLessonnnn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2011
                },
                new Car
                {
                     Model="F10",
                     Vendor="BMW",
                     Year=2011
                }
            };
        }
        public MainWindow()
        {
            InitializeComponent();
            // prgbar.IsIndeterminate = true;
            lstbox.ItemsSource = GetCars();
        }

        //private void RepeatButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgbar.Value > prgbar.Minimum)
        //        prgbar.Value--;
        //}

        //private void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        //{
        //    if(prgbar.Value<prgbar.Maximum)
        //    prgbar.Value++;
        //}
    }
}
