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
    /// Lógica de interacción para Salidas.xaml
    /// </summary>
    public partial class Salidas : Window
    {
        public Salidas()
        {
            InitializeComponent();
            List<Registro> registros = new List<Registro>()
            {
                new Registro { TipoDocumento = "DNI", NumeroDocumento = "12345678", Placa = "ABC123", Turno = "Mañana", NombreConductor = "Juan Pérez", NombreCliente = "Cliente 1", FechaHora = DateTime.Now, PesoIngreso = 1500.5 },
                new Registro { TipoDocumento = "RUC", NumeroDocumento = "987654321", Placa = "XYZ789", Turno = "Tarde", NombreConductor = "María Gómez", NombreCliente = "Cliente 2", FechaHora = DateTime.Now, PesoIngreso = 1800.75 }
            };

            dataGrid.ItemsSource = registros;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window ventanaActual = Window.GetWindow(this);
            ventanaActual.Close();
        }
    }
}
