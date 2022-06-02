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

namespace WpfLesson1
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

        private void Click_Left(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                Random rand = new Random();
                btn.Background = new SolidColorBrush(Color.FromRgb((byte)rand.Next(1, 255), (byte)rand.Next(1, 255), (byte)rand.Next(1, 233))); ;
                MessageBox.Show($"Name ~ {btn.Name}\nColor ID ~ {btn.Background}", "Button Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }



        private void Click_Right(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                panel.Children.Remove(btn);
                Title = (string)btn.Content;
            }
        }
    }
}
