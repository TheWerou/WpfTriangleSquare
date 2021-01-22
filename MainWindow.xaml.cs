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

namespace TrojkatyKwadraty
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

        private void trojkat_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/trojkat.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }

        private void kwadrat_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/kwadrat.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }

        private void prostokat_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/prostokat.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }

        private void rownobok_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/rownobok.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }

        private void deltoid_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/deltoid.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }

        private void romb_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/romb.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }

        private void trapez_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/trapez.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }

        private void kolo_Click(object sender, RoutedEventArgs e)
        {
            var path = "Images/kolo.png";
            Uri fileUri = new Uri(path, UriKind.Relative);
            obrazek.Source = new BitmapImage(fileUri);
        }
    }
}
