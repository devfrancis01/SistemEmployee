using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Threading;

using Wpfreports.Properties;
using Wpfreports;

namespace sistemapersonal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
      
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //code for hour and date
            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
          
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            label1.Content = DateTime.Now.ToLongTimeString();
            label2.Content = DateTime.Now.ToString("d");
        }
        
        private void Salir(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
               
                //this.Close();
                //this.Hide();
                
               // Application.Current.Exit();
                /*averigua para que sirve este codigo
                Application.Current.Exit += new ExitEventHandler(Current_Exit);*/
               Application.Current.Shutdown(110);
                
                
                

            }
            else
            {
                MainWindow formu = new MainWindow();
                formu.Show();
                this.Hide();
                this.Close();
            }
        }

        void Current_Exit(object sender, ExitEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

       

        private void IngresarEmpleados(object sender, RoutedEventArgs e)
        {
            AddEmployees Emplo = new AddEmployees();
            Emplo.Show();

        }

        private void InforEmployees(object sender, RoutedEventArgs e)
        {
            InfoEmployees Info = new InfoEmployees();
            Info.Show();
        }

        private void ModifiEmplo(object sender, RoutedEventArgs e)
        {
            ModifiEmployee ModiEMP = new ModifiEmployee();
            ModiEMP.Show();
        }

        private void Hora(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Labelo(object sender, RoutedEventArgs e)
        {
            
        }

        private void Cancelemp(object sender, RoutedEventArgs e)
        {
            CancelEmployees cancel = new CancelEmployees();
            cancel.Show();
        }

        private void byyeardsreport(object sender, RoutedEventArgs e)
        {
            MainWindows hola = new MainWindows();
            hola.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Names(object sender, RoutedEventArgs e)
        {
            Windbyname winNames = new Windbyname();
            winNames.Show();
        }

        private void Codes(object sender, RoutedEventArgs e)
        {
            Wincode Windcodes = new Wincode();
            Windcodes.Show();
        }

        private void Emplocanceled(object sender, RoutedEventArgs e)
        {
            Winemplocanceled Canceled = new Winemplocanceled();
            Canceled.Show();
        }
       
    }
}
