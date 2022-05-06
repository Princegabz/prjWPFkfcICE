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

namespace prjWPFkfcICE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductData pd = new ProductData();
        Products p = new Products();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnStreetwise1_Click(object sender, RoutedEventArgs e)
        {
            p.Streetwise1(); //This adds the Price of one Streetwise 1 to the Total
            MessageBox.Show(p.CartItems()+"Your Cart total is: R"+p.CartTotal(), "Cart Total", MessageBoxButton.OK, MessageBoxImage.Information);
        }
       
        private void btnStreetwise2_Click(object sender, RoutedEventArgs e)
        {
            p.Streetwise2(); //This adds the Price of one Streetwise 2 to the Total
            MessageBox.Show(p.CartItems() + "Your Cart total is: R" + p.CartTotal(), "Cart Total", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnStreetwise3_Click(object sender, RoutedEventArgs e)
        {
            p.Streetwise3(); //This adds the Price of one Streetwise 3 to the Total
            MessageBox.Show(p.CartItems() + "Your Cart total is: R" + p.CartTotal(), "Cart Total", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnStreetwise4_Click(object sender, RoutedEventArgs e)
        {
            p.Streetwise4(); //This adds the Price of one Streetwise 3 to the Total
            MessageBox.Show(p.CartItems() + "Your Cart total is: R" + p.CartTotal(), "Cart Total", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
