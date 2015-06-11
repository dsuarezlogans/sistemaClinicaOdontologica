using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace CIOETsketch1
{
	/// <summary>
	/// Interaction logic for LogInWindow.xaml
	/// </summary>
	public partial class LogInWindow : MetroWindow
	{
		public LogInWindow()
		{
			this.InitializeComponent();


            
			
			// Insert code required on object creation below this point.
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            string u, p;
          
        
            bool uv=false, pv=false;
            u = tbuser.Text;
            p = tbpass.Password;

            if (u.CompareTo("doctor") == 0)
            {
                uv = true;
            }

            if (p.CompareTo("123456") == 0)
            {
                pv = true;
            }
            if(uv==true && pv==true)
            {
                uv = false; pv = false;
                MainWindow m = new MainWindow();
                m.Show();
                this.Close();

            }
            else
            {
                lblog.Content="Error: Usuario o Contraseña incorrecta";
                tbuser.Focus();
                tbuser.Clear();
                tbpass.Clear();
            
                uv = false; pv = false;
            }
        }

        private void tbpass_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            lblog.Content = "";
        }

        
	}
}