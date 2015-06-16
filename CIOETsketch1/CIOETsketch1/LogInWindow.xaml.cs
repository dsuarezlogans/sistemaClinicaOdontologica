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
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace CIOETsketch1
{
	/// <summary>
	/// Interaction logic for LogInWindow.xaml
	/// </summary>
	public partial class LogInWindow : MetroWindow
	{
        DispatcherTimer log = new DispatcherTimer();

		public LogInWindow()
		{
			this.InitializeComponent();
            log.Tick += new EventHandler(loginProcess_Tick);
            log.Interval = new TimeSpan(0,0,5);
            

            
			
			// Insert code required on object creation below this point.
		}

        private void loginProcess_Tick(object sender, EventArgs e)
        {

            log.Stop();
            
            string u, p;


            bool uv = false, pv = false;
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
            if (uv == true && pv == true)
            {
                uv = false; pv = false;
                MainWindow m = new MainWindow();
                m.Show();
                this.Close();

            }
            else
            {
                lblog.Content = "Error: Usuario o Contraseña incorrecta";
                tbuser.Focus();
                tbuser.Clear();
                tbpass.Clear();

                uv = false; pv = false;
            }

            btLogin.Visibility = Visibility.Visible;
            progressRingLogin.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            btLogin.Visibility = Visibility.Hidden;
            progressRingLogin.Visibility = Visibility.Visible;
            log.Start();
            
        }

        private void tbpass_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            lblog.Content = "";
        }

        
	}
}