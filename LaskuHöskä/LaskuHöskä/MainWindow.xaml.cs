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

namespace LaskuHöskä
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private bool check(int x, int y)
        {
            if (x == y) return true;
            return false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int l1 = 0, l2 = 0;

            try
            {
                l1 = int.Parse(luku1.Text);
                l2 = int.Parse(luku2.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            tulos.Content = check(l1, l2).ToString();
        }
    }
}
