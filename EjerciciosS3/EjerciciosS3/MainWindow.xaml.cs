using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjerciciosS3
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

        private void btnAplicar_Click(object sender, RoutedEventArgs e)
        {
            lbTexto.FontFamily = new FontFamily("Segoe UI");
            lbTexto.Foreground = Brushes.Black;
            lbTexto.Background = Brushes.Transparent;

            if (cbTipoLetra.IsChecked == true)
            {
                lbTexto.FontFamily = new FontFamily("Consolas");
            }
            if(cbColorTexto.IsChecked == true) {
                lbTexto.Foreground = Brushes.Blue;
            }
            if(cbColorFondo.IsChecked == true) { 
                lbTexto.Background = Brushes.Aqua;
            }
        }

        private void btnAplicarRadio_Click(object sender, RoutedEventArgs e)
        {
            lbTextoRadio.FontFamily = new FontFamily("Segoe UI");
            lbTextoRadio.Foreground = Brushes.Black;
            lbTextoRadio.Background = Brushes.Transparent;

            if(rbTipoLetra.IsChecked == true) 
            {
                lbTextoRadio.FontFamily = new FontFamily("Times New Roman");
            }else if (rbColorTexto.IsChecked == true)
            {
                lbTextoRadio.Foreground = Brushes.Red;
            }else if(rbColorFondo.IsChecked == true)
            {
                lbTextoRadio.Background = Brushes.Yellow;
            }
        }
    }
}