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
    /// Interaction logic for ModifiEmployee.xaml
    /// </summary>
    public partial class ModifiEmployee : Window
    {
        public ModifiEmployee()
        {
            InitializeComponent();
        }
        DataEmployeeDataContext dbos = new DataEmployeeDataContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DISABLE CONTROLLER
            this.Interfaces_Disables();
        }

        //creating method for storedprocedure
       /* public void ModifyEmployee(string First_Name, string Last_Name, string identification, string Email, string Address, string marital_Status, string Phone_Number, string job_title, string salary, string profession, string Nomina, string Employee_ID)
        {
            //creating connection for connect with database
            string Connection = @"Data Source = .\Sqlexpress; Initial Catalog = SistemaEmpleados;Integrated Security = true";
            using (SqlConnection connections = new SqlConnection(Connection))
            {
                SqlCommand command = connections.CreateCommand();
                command.CommandText = "ModifyEmpleados";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Employee_ID", Employee_ID);
                command.Parameters.AddWithValue("@First_Name", First_Name);
                command.Parameters.AddWithValue("@Last_Name", Last_Name);
                command.Parameters.AddWithValue("@identification", identification);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@marital_Status", marital_Status);
                command.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                command.Parameters.AddWithValue("job_Title", job_title);
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@profession", profession);
                command.Parameters.AddWithValue("@Nomina", Nomina);

                try
                {
                    connections.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hay una Exception" + ex.Message);
                }
                finally
                {
                    connections.Close();
                }
            }
        }*/

        public bool SerchId(string Employee_ID)
        {
            //Creating store procedure search
            SqlCommand coman = new SqlCommand("search");
            coman.CommandType = System.Data.CommandType.StoredProcedure;

            coman.Parameters.AddWithValue("@Employee_ID", Employee_ID);

            //creating a conexion
            string Conexion = @"Data Source = .\sqlexpress; Initial Catalog = SistemaEmpleados; Integrated Security = true";
            using (SqlConnection conexions = new SqlConnection(Conexion))
            {
                conexions.Open();
                coman.Connection = conexions;
                SqlDataAdapter adaptador = new SqlDataAdapter(coman);
                DataSet data = new DataSet();
                adaptador.Fill(data, "Employees");
                if (data.Tables[0].Rows.Count == 0)
                {
                    //message por si no existe el codigo de empleado
                    MessageBox.Show("this code Employee is not found in the Database");
                    //method para desabilidar los controles del form
                    this.Interfaces_Disables();
                    data.Dispose();
                    return false;
                }
                else
                {
                    
                    //cargando los datos a los textbox
                    textBox2.Text = (string)data.Tables["Employees"].Rows[0]["First_Name"];
                    textBox3.Text = (string)data.Tables["Employees"].Rows[0]["Last_Name"];
                    textBox4.Text = (string)data.Tables["Employees"].Rows[0]["Email"];
                    textBox5.Text = (string)data.Tables["Employees"].Rows[0]["identification"];
                    textBox7.Text = (string)data.Tables["Employees"].Rows[0]["Address"];
                    textBox8.Text = (string)data.Tables["Employees"].Rows[0]["Phone_Number"];
                    textBox10.Text = (string)data.Tables["Employees"].Rows[0]["Profession"];
                    comboBox111.Text = (string)data.Tables["Employees"].Rows[0]["marital_status"];
                    textBox66.Text = (string)data.Tables["Employees"].Rows[0]["Salary"];
                    comboBox41.Text = (string)data.Tables["Employees"].Rows[0]["Nomina"];
                    comboBox21.Text = (string)data.Tables["Employees"].Rows[0]["Job_Title"];
                   // textBox13.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Department_Name"];
                    textBox61.Text = (string)data.Tables["Employees"].Rows[0]["Hiring"].ToString();
                    data.Dispose();
                    conexions.Close();
                    return true;
                }
            }
        }
        //creando metodos para habilitar los controles
        public void Interfaces_Enables()
        {
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = true;
            textBox3.IsEnabled = true;
            textBox4.IsEnabled = true;
            textBox5.IsEnabled = true;
            textBox7.IsEnabled = true;
            textBox8.IsEnabled = true;
            textBox10.IsEnabled = true;
            textBox66.IsEnabled = false;
            comboBox111.IsEnabled = true;
            comboBox41.IsEnabled = true;
            comboBox21.IsEnabled = true;
            textBox61.IsEnabled = false;
            button22.IsEnabled = true;
            button33.IsEnabled = true;
            textBox2.Focus();
        }
        //creando metodos para desabilitar los controales
        public void Interfaces_Disables()
        {
            textBox1.IsEnabled = true;
            textBox2.IsEnabled = false;
            textBox3.IsEnabled = false;
            textBox4.IsEnabled = false;
            textBox5.IsEnabled = false;
            textBox7.IsEnabled = false;
            textBox8.IsEnabled = false;
            textBox10.IsEnabled = false;
            textBox66.IsEnabled = false;
            comboBox111.IsEnabled = false;
            comboBox41.IsEnabled = false;
            comboBox21.IsEnabled = false;
            textBox61.IsEnabled = false;
            button22.IsEnabled = true;
            button33.IsEnabled = false;
            textBox1.Focus();
        }
        //metodos para limpiar lo textbox
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Text = "";
            comboBox111.Text = "";
            textBox66.Text = "";
            comboBox41.Text = "";
            comboBox21.Text = "";
            // textBox13.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Department_Name"];
            textBox61.Clear();
        
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                
                    this.Interfaces_Enables();
                    this.SerchId(textBox1.Text);
             
            }
        }

        private void Cancelm(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ModifyEmplo(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Questions = MessageBox.Show("DO you Really to Want to Modify This Employee", "Employees Sistem", MessageBoxButton.YesNo, MessageBoxImage.Question);
            {
                if (Questions == MessageBoxResult.Yes)
                {
                    //usando linqtosql para hacer modificaciones a la base de datos con try.catch
                    try
                    {
                        string messages = "";
                        dbos.ModifyEmpleadoslinqtosql(textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, textBox7.Text, Convert.ToString(comboBox111.Text), textBox8.Text, Convert.ToString(comboBox21.Text), textBox66.Text, textBox10.Text, Convert.ToString(comboBox41.Text),Convert.ToInt32(textBox1.Text), ref messages);
                        int cod = Convert.ToInt32(textBox1.Text);
                        MessageBox.Show(messages);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   // this.ModifyEmployee(textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, textBox7.Text, Convert.ToString(comboBox111.Text), textBox8.Text, Convert.ToString(comboBox21.Text), textBox66.Text, textBox10.Text, Convert.ToString(comboBox41.Text), textBox1.Text);
                  //  MessageBox.Show("Modify Employees Succeful");
                    this.Clear();
                   this.Interfaces_Disables();
                   textBox1.Focus();
                }
                else
                {
                    this.Close();
                }
            }
        }

    }
}
