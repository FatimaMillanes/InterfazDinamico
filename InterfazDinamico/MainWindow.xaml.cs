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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterfazDinamico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbElegir_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridDeInfo.Children.Clear();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Guardar.Visibility = Visibility.Visible;
            Cerrar.Visibility = Visibility.Visible;
            gridDeInfo.Children.Clear();
            switch (cbElegir.SelectedIndex)

            {
                case 0:

                    gridDeInfo.Children.Add(new ParametrosAlumnos());
                    break;

                case 1:

                    gridDeInfo.Children.Add(new ParametrosMaestros());
                    break;
            }
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            gridDeInfo.Children.Clear();
            Guardar.Visibility = Visibility.Hidden;
            Cerrar.Visibility = Visibility.Hidden;
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            gridDeInfo.Children.Clear();
            Guardar.Visibility = Visibility.Hidden;
            Cerrar.Visibility = Visibility.Hidden;
        }
    }
}
