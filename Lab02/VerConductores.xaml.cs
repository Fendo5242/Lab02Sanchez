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
    /// Lógica de interacción para VerConductores.xaml
    /// </summary>
    public partial class VerConductores : Window
    {
        public VerConductores()
        {
            InitializeComponent();
            List<Conductor> conductores = new List<Conductor>()
            {
                new Conductor { NombreConductor = "Juan Pérez", Licencia = "123456", Transporte = "Camión" },
                new Conductor { NombreConductor = "María Gómez", Licencia = "654321", Transporte = "Furgoneta" },
                new Conductor { NombreConductor = "Pedro Rodríguez", Licencia = "987654", Transporte = "Automóvil" }
            };

            conductoresDataGrid.ItemsSource = conductores;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window ventanaActual = Window.GetWindow(this);
            ventanaActual.Close();
        }
    }
}
