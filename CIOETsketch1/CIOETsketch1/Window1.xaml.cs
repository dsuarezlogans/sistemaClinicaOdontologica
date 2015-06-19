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

namespace CIOETsketch1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public ContextMenu ctx;
        public Rectangle rect;
        public Window1()
        {
            InitializeComponent();
            ctx = new ContextMenu();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rect = (Rectangle)sender;
          opciones.IsOpen = true;
        }

        private void cari_Click(object sender, RoutedEventArgs e)
        {
            rect.Fill = Brushes.Red;
        }

        private void sel_Click(object sender, RoutedEventArgs e)
        {
            rect.Fill = Brushes.Blue;
        }

        private void ext_Click(object sender, RoutedEventArgs e)
        {
            rect.Fill = Brushes.Purple;
        }



          

   
    }
}
