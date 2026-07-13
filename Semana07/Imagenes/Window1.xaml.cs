using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Imagenes
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"C:\PA_I\Imagenes\plaza_armas.jpg");
            bitmapImage.EndInit();
            imagen1.Source = bitmapImage;

            Uri uri = new Uri(@"C:\PA_I\Imagenes\plaza_armas.jpg");
            imagen2.Source = new BitmapImage(uri);

            imagen3.Source = new BitmapImage(new Uri($"pack://application:,,,/Imagenes/plaza_armas.jpg", UriKind.Absolute));
        }
    }
}
