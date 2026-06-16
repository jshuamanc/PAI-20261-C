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

namespace Semana03
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if(txtCantidad.Text.Length == 0)
            {
                MessageBox.Show("La cantidad no puede ser nulo");
                return;
            }
            int cantidad = Int32.Parse(txtCantidad.Text);
            decimal total = 0;
            if(cbCebolla.IsChecked == true )
            {
                total += cantidad * 3;
            }
            if (cbTomate.IsChecked == true) {
                total += cantidad * 1.5m;
            }
            if (cbPapa.IsChecked == true)
            {
                total += cantidad * 2;
            }

            lbTotal.Content = $"Total S/.: {total}";
        }
    }
}