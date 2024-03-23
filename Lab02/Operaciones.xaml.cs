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
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ingresos ingresos = new Ingresos();
            ingresos.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Salidas salidas = new Salidas();
            salidas.ShowDialog();
        }
    }
}
