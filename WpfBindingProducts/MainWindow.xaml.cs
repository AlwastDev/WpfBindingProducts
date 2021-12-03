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

namespace WpfBindingProducts
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Products> Product { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Product = new List<Products>
            {
                new Products{Name = "Мандарины", Price=150.5, Amount = 105.2, Really = 100, Barcode = 10201342, Bought = true},
                new Products{Name = "Бананы", Price=300.9, Amount = 5.3, Really = 99, Barcode = 65423432, Bought = false},
                new Products{Name = "Апельсины", Price=1000.5, Amount = 2.2, Really = 5, Barcode = 5646546, Bought = true}
            };
        }

        private void gridProducts_Loaded(object sender, RoutedEventArgs e)
        {
            ListBox.ItemsSource = Product;
        }
        
    }
}
