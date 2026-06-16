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

namespace Semana04
{
    /// <summary>
    /// Lógica de interacción para ListView.xaml
    /// </summary>
    public partial class ListView : Window
    {
        List<Alumno> alumnos = new List<Alumno>();
        public ListView()
        {
            InitializeComponent();

            alumnos.Add(new Alumno("Juan","Perez",30));
            alumnos.Add(new Alumno("Carlos","Aguilar",40));

            lvAlumnos.ItemsSource = alumnos;
        }
    
    }
}
