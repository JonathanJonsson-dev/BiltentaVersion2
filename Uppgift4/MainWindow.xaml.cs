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

namespace Uppgift4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalSum1 = 0;
        int totalSum2 = 0;
        int totalSum3 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private static int[] GetRandomNumber()
        {
            Random r = new Random();
            int[] numbers = { r.Next(10), r.Next(10), r.Next(10)};
            return numbers;
        }

        private void btnBet_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = GetRandomNumber();

            lblCode1.Content = numbers[0];
            lblCode2.Content = numbers[1];
            lblCode3.Content = numbers[2];

            lblTotal1.Content = totalSum1;
            lblTotal2.Content = totalSum2;
            lblTotal3.Content = totalSum3;

            if (chk1.IsChecked != true)
            {
                totalSum1 += numbers[0];
            }
            if (chk2.IsChecked != true)
            {
                totalSum2 += numbers[1];
            }
            if (chk1.IsChecked != true)
            {
                totalSum3 += numbers[2];
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
