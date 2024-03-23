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
using System.Windows.Shapes;

namespace Lab02
{
    /// <summary>
    /// Lógica de interacción para Mantenimientos.xaml
    /// </summary>
    public partial class Mantenimientos : Window
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conductores conductores = new Conductores();
            conductores.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Transportistas transportistas = new Transportistas();
            transportistas.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Camiones camiones = new Camiones();
            camiones.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }
    }
}
