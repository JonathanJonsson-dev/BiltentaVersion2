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

namespace Uppgift2
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

        public bool HasCorrectLength(string plate)
        {
            int counter = 0;
            foreach (char letter in plate)
            {
                counter++;
            }

            if (counter == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (HasCorrectLength(txtBox.Text) == false)
            {
                MessageBox.Show("Skylten har fel antal tecken");
            }
        }
    }
}
