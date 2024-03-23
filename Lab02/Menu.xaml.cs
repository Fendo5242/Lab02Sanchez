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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        internal void ShowDialig()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mantenimientos mantenimientos = new Mantenimientos();
            mantenimientos.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }
    }
}
