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
    /// Lógica de interacción para Transportistas.xaml
    /// </summary>
    public partial class Transportistas : Window
    {
        public Transportistas()
        {
            InitializeComponent();
            List<Transportista> transportistas = new List<Transportista>()
            {
                new Transportista { Nombre = "Juan Pérez", DNI = "12345678" },
                new Transportista { Nombre = "María Gómez", DNI = "87654321" },
                new Transportista { Nombre = "Pedro Rodríguez", DNI = "98765432" }
            };

            transportistasDataGrid.ItemsSource = transportistas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window ventanaActual = Window.GetWindow(this);
            ventanaActual.Close();
        }
    }
}
