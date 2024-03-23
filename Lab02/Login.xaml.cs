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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string usuario = Usuario.Text;
            string contraseña = Contraseña.Text;

            if (usuario == "Fernando" && contraseña == "123456")
            {
                MessageBox.Show("Inicio de sesión exitoso.");            
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                Usuario.Text = "";
                Contraseña.Text = "";
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
