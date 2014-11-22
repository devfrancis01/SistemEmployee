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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace sistemapersonal
{
    /// <summary>
    /// Interaction logic for Winemplocanceled.xaml
    /// </summary>
    public partial class Winemplocanceled : Window
    {
        public Winemplocanceled()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //method for disable controller
            this.Disable();
        }
        public void Disable()
        {
            textBox7.IsEnabled = false;
            textBox2.IsEnabled = false;
            textBox3.IsEnabled = false;
            textBox4.IsEnabled = false; 
            textBox5.IsEnabled = false; 
            textBox10.IsEnabled = false;
            textBox8.IsEnabled = false;
            textBox61.IsEnabled = false;
            textBox9.IsEnabled = false;
        }
        //creating method for to do a search in the database for table emp_canceled
        public bool searchsEmplo(string employee_id)
        {
            //creating command for storedprocedure
            SqlCommand command = new SqlCommand("canceledemployes");
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Employee_ID", employee_id);

            //Creating a connection for database
            string Road = @"Data Source = .\sqlexpress;Initial Catalog = SistemaEmpleados;Integrated Security = true";
            using (SqlConnection conections = new SqlConnection(Road))
            {
               //open connection
                conections.Open();
                //command for the connection
                command.Connection = conections;
                //add sqldataAdapter for the table
                SqlDataAdapter adp = new SqlDataAdapter(command);
                //creating a dataset a dataset is a connectedor for the database
                DataSet ds = new DataSet();
                //filtramos el dataset mediant el objecto del sqldataAdapter y agregamo la tabal dentro de la filtracion
                adp.Fill(ds, "Emp_canceled");
                //creatin a condiction for extraer the table
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("this code is not founded in the database");
                    ds.Dispose();
                    return false;
                }
                else
                {
                    textBox7.Text = (string)ds.Tables["Emp_canceled"].Rows[0]["identification"];//extraer el registro del identifications
                    textBox2.Text = (string)ds.Tables["Emp_canceled"].Rows[0]["First_Name"];//extrae el regitro del nombre
                    textBox3.Text = (string)ds.Tables["Emp_canceled"].Rows[0]["Last_Name"];//extrae el registro del apellido
                    textBox4.Text = ds.Tables["Emp_canceled"].Rows[0]["Hirin_date_start"].ToString();//extrae la fecha de inicio de ese empleado
                    textBox5.Text = ds.Tables["Emp_canceled"].Rows[0]["Hirin_date_end"].ToString();//extrae la fecha de cancelacion del empleado
                    textBox10.Text = (string)ds.Tables["Emp_canceled"].Rows[0]["Job_Title"];//extrae la posicion del empleados
                    textBox8.Text = (string)ds.Tables["Emp_canceled"].Rows[0]["Department_Name"];//extra el nombre del departamento donde trabajaba ese empleado
                    textBox61.Text = ds.Tables["Emp_canceled"].Rows[0]["LAST_SALARY"].ToString();//extrae el ultimo salario que obtuvo el empleado
                    textBox9.Text = (string)ds.Tables["Emp_canceled"].Rows[0]["REASON_FOR_CANCELLATION"];//extrae el motivo por la cual fue cancelado este empleado
                    ds.Dispose();
                    return true;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.searchsEmplo(textBox1.Text);
            }
        }

        private void textBox61_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
