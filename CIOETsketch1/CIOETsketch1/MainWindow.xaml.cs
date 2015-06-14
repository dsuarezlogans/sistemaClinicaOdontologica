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
using MahApps.Metro.Controls;

namespace CIOETsketch1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            registroPacientesFlyout.IsOpen = true;
        }

        private void buttonAñadir_Click(object sender, RoutedEventArgs e)
        {
            citasFlyout.IsOpen = true;
            
        }

        
        private void btOrtodoncia_Click(object sender, RoutedEventArgs e)
        {
            OrtodonciaFlyout.IsOpen = true;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 odg = new Window1();
            odg.Show();
        }

        
    }
}
