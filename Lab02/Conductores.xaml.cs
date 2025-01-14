﻿using System;
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
    /// Lógica de interacción para Conductores.xaml
    /// </summary>
    public partial class Conductores : Window
    {
        public Conductores()
        {
            InitializeComponent();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AgregarConductor agregarConductor = new AgregarConductor();
            agregarConductor.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VerConductores conductores = new VerConductores();
            conductores.ShowDialog();
        }
    }
}
