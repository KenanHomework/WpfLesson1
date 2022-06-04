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

            //Fill Buttons With Random Color
            foreach (object item in panel.Children)
                if (item is Button btn)
                    btn.Background = GetRandomColor();

        }


        List<Brush> colors = new List<Brush>();

        Random rand = new Random();



        SolidColorBrush GetRandomColor()
        {
            SolidColorBrush color;
            while (true)
            {
                color = new SolidColorBrush(Color.FromRgb((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));
                if (!colors.Contains(color))
                {
                    colors.Add(color);
                    break;
                }
            }
            return color;
        }


        private void Click_Left(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Background = GetRandomColor();
                MessageBox.Show($"Name ~ {btn.Name}\nColor ID ~ {btn.Background}", "Button Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Click_Right(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                panel.Children.Remove(btn);
                colors.Remove(btn.Background);
                Title = $"Deleted Button : {btn.Name}";
            }
        }
    }
}
