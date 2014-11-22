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
    /// Interaction logic for AddEmployees.xaml
    /// </summary>
    public partial class AddEmployees : Window
    {
        public AddEmployees()
        {
            InitializeComponent();
        }

        public void Insertarempleadoss(string First_Name, string Last_Name, string identification, string Email, string Hiring, string Address, string marital_Status, string Phone_Number, string job_title, string salary, string profession, string nomina, string Employee_ID)
        {
            SqlParameter Hirin2 = new SqlParameter();
            DateTime Hirings = new DateTime();
            if (DateTime.TryParse(datePicker1.Text, out Hirings))
            {
                Hirin2.Value = Hirings;
                Hirin2.Value = DBNull.Value;
                Hirings.ToString("dd/mm/yyyy");
            }

            SqlConnection MYcon = new SqlConnection(@"Data Source = .\sqlexpress;Initial Catalog = SistemaEmpleados;Integrated Security =true");
            SqlCommand comandos = MYcon.CreateCommand();
            comandos.CommandText = "InsertarEmpleados";
            comandos.CommandType = System.Data.CommandType.StoredProcedure;

            
            comandos.Parameters.AddWithValue("@First_Name", First_Name);
            comandos.Parameters.AddWithValue("@Last_Name", Last_Name);
            comandos.Parameters.AddWithValue("@identification", identification);
            comandos.Parameters.AddWithValue("@Email", Email);
            comandos.Parameters.AddWithValue("@Hiring", Hirings.Date);
            comandos.Parameters.AddWithValue("@Address", Address);
            comandos.Parameters.AddWithValue("@marital_Status", marital_Status);
            comandos.Parameters.AddWithValue("@Phone_Number", Phone_Number);
            comandos.Parameters.AddWithValue("@Job_title", job_title);
            comandos.Parameters.AddWithValue("@Salary", salary);
            comandos.Parameters.AddWithValue("@profession", profession);
            comandos.Parameters.AddWithValue("@Nomina", nomina);
            comandos.Parameters.AddWithValue("@Employee_ID", Employee_ID);

            try
            {
                MYcon.Open();
                comandos.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                MYcon.Close();
            }
        }

        public void InsertarEmpleado(string First_Name, string Last_Name, string identification, string Email, string Hiring, string Address, string marital_status, string Phone_Number, string Job_Title, string Salary, string profession, string Nomina, string Employee_ID)
        {
            SqlParameter Hirin1 = new SqlParameter();
            DateTime Hirin = new DateTime();
            if (DateTime.TryParse(datePicker1.Text, out Hirin))
            {
                Hirin1.Value = Hirin;
                Hirin1.Value = DBNull.Value;
                Hirin.ToString("dd/mm/yyyy");
            }

            SqlConnection Myconexion = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog = SistemaEmpleados;Integrated Security = true");
            SqlCommand Comando = Myconexion.CreateCommand();
            Comando.CommandText = "InsertarDetailsView"/*"InsertarDetailsViewSS"*/;
            Comando.CommandType = System.Data.CommandType.StoredProcedure;


            Comando.Parameters.AddWithValue("@First_Name", First_Name);
            Comando.Parameters.AddWithValue("@Last_Name", Last_Name);
            Comando.Parameters.AddWithValue("@identification", identification);
            Comando.Parameters.AddWithValue("@Email", Email);
            Comando.Parameters.AddWithValue("@Hiring", Hirin.Date);
            Comando.Parameters.AddWithValue("@Address", Address);
            Comando.Parameters.AddWithValue("@marital_status", marital_status);
            Comando.Parameters.AddWithValue("@Phone_Number", Phone_Number);
            Comando.Parameters.AddWithValue("@Job_Title", Job_Title);
            Comando.Parameters.AddWithValue("@Salary", Salary);
            Comando.Parameters.AddWithValue("@profession", profession);
            Comando.Parameters.AddWithValue("@Nomina", Nomina);
            Comando.Parameters.AddWithValue("@Employee_ID", Employee_ID);

            try
            {
                Myconexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Myconexion.Close();
            }
        }

        public bool searchEmployee(string Employee_ID)
        {
            int cod = Convert.ToInt32(Employee_ID);
            SqlCommand coman = new SqlCommand("BuscarIdEmployee");
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.AddWithValue("@Employee_ID", cod);

            //connection with database
            SqlConnection conection = new SqlConnection(@"Data Source = .\sqlexpress;Initial Catalog = SistemaEmpleados;Integrated Security = true");
            coman.Connection = conection;
            SqlDataAdapter dap = new SqlDataAdapter(coman);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                this.Interfaces_Datoshabilitado();
                ds.Dispose();
                return false;

            }
            else
            {
                MessageBox.Show("This code exist");
                ds.Dispose();
                ds.Dispose();
                return true;
            }
        }

        public void Interfaces_Datoshabilitado()
        {
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = true;/*field first name*/
            textBox3.IsEnabled = true;/*field last name*/
            textBox4.IsEnabled = true;/*field identifications*/
            textBox5.IsEnabled = true;/*filed email*/
            datePicker1.IsEnabled = true;/*field date hiring*/
            textBox7.IsEnabled = true;/*field address*/
            textBox8.IsEnabled = true;/*filed telephone*/
            textBox9.IsEnabled = true;/*field salary*/
            textBox10.IsEnabled = true; /*field profession*/
            comboBox1.IsEnabled = true;/*combobox status*/
            comboBox2.IsEnabled = true;/*comboBox2 status*/
            comboBox4.IsEnabled = true;/*comboBox4 payroll*/
            button10.IsEnabled = true;/*button send*/
            button21.IsEnabled = true;/*button cancelar*/
        }

        public void Interfaces_Dehabilitado()
        {
            textBox1.IsEnabled = true;
            textBox2.IsEnabled = false;/*field first name*/
            textBox3.IsEnabled = false;/*field last name*/
            textBox4.IsEnabled = false;/*field identifications*/
            textBox5.IsEnabled = false;/*filed email*/
            datePicker1.IsEnabled = false;/*field date hiring*/
            textBox7.IsEnabled = false;/*field address*/
            textBox8.IsEnabled = false;/*filed telephone*/
            textBox9.IsEnabled = false;/*field salary*/
            textBox10.IsEnabled = false; /*field profession*/
            comboBox1.IsEnabled = false;/*combobox status*/
            comboBox2.IsEnabled = false;/*comboBox2 status*/
            comboBox4.IsEnabled = false;/*comboBox4 payroll*/
            button10.IsEnabled = false;/*button send*/
            button21.IsEnabled = true;/*button cancelar*/
        }

        public void Interfaces_clear()
        {
            textBox1.Clear();
            textBox2.Text = "";/*field first name*/
            textBox3.Text = "";/*field last name*/
            textBox4.Text = "";/*field identifications*/
            textBox5.Text = "";/*filed email*/
            datePicker1.Text = "";/*field date hiring*/
            textBox7.Text = "";/*field address*/
            textBox8.Text = "";/*filed telephone*/
            textBox9.Text = "";/*filed salary*/
            textBox10.Text = "";/*field profession*/
            comboBox1.Text = "";/*combobox status*/
            comboBox2.Text = "";/*comboBox2 status*/
            comboBox4.Text = "";/*comboBox4 payroll*/
            button10.IsEnabled = false;/*button send*/
            button21.IsEnabled = true;/*button cancelar*/
        }
        private void InsertButton(object sender, RoutedEventArgs e)
        {


        }
        private void Saves(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty || textBox7.Text == string.Empty || datePicker1.Text == string.Empty || comboBox1.Text == string.Empty || textBox8.Text == string.Empty || comboBox2.Text == string.Empty || textBox9.Text == string.Empty || textBox10.Text == string.Empty || comboBox4.Text == string.Empty)
            {
                MessageBox.Show("Please fill empty fields!!");
            }
            else
            {


                MessageBoxResult questions = MessageBox.Show("Agregar Este Empleado", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
                {
                    if (questions == MessageBoxResult.Yes)
                    {
                        // this.valid();
                        this.InsertarEmpleado(textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, Convert.ToString(datePicker1.Text), textBox7.Text, Convert.ToString(comboBox1.Text), textBox8.Text, Convert.ToString(comboBox2.Text), textBox9.Text, textBox10.Text, Convert.ToString(comboBox4.Text), textBox1.Text);
                        this.Insertarempleadoss(textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, Convert.ToString(datePicker1.Text), textBox7.Text, Convert.ToString(comboBox1.Text), textBox8.Text, Convert.ToString(comboBox2.Text), textBox9.Text, textBox10.Text, Convert.ToString(comboBox4.Text), textBox1.Text);

                        MessageBox.Show("employee inserted succeful");
                        //this.Interfaces_clear();
                        // this.Interfaces_Datosdesabilitado();
                        this.Interfaces_clear();
                        this.Interfaces_Dehabilitado();


                    }
                }
            }
        }

        private void Closes(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
 
            if (e.Key == Key.Enter)
            {
                this.searchEmployee(textBox1.Text);
                
            }
        }

        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            int valid = Convert.ToInt32(Convert.ToChar(e.Text));
            if (valid >= 48 && valid <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }




        }

        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first form validation caracter
            int carater = Convert.ToInt32(Convert.ToChar(e.Text));
            if (carater >= 65 && carater <= 90 || carater >= 97 && carater <= 122)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            //second form validation caracter only
           // e.Handled = ValidationCarater.Caracter(Convert.ToChar(e.Text));

        }

        private void textBox3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first form validation carater
            int caraters = Convert.ToInt32(Convert.ToChar(e.Text));
            if (caraters >= 65 && caraters <= 90 || caraters >= 97 && caraters <= 122)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            //second forms validation caracter
            //e.Handled = ValidationCarater.Caracter(Convert.ToChar(e.Text));

        }

        private void textBox4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first form validation carater
           /* int caraters = Convert.ToInt32(Convert.ToChar(e.Text));
            if (caraters >=48 && caraters <= 57 || caraters >= 65 && caraters <= 90 || caraters >= 97 && caraters <= 122)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }*/
            //second forms validation caracter
            
                e.Handled = ValidationCarater.Caracter(Convert.ToChar(e.Text));
               

            

        }

        private void textBox7_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first form validation carater
            /* int caraters = Convert.ToInt32(Convert.ToChar(e.Text));
             if (caraters >=48 && caraters <= 57 || caraters >= 65 && caraters <= 90 || caraters >= 97 && caraters <= 122)
             {
                 e.Handled = false;
             }
             else
             {
                 e.Handled = true;
             }*/
            //second forms validation caracter
            e.Handled = ValidationCarater.Caracter(Convert.ToChar(e.Text));

        }

        private void textBox8_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first form validation number only without caracter
           /* int telephone = Convert.ToInt32(Convert.ToChar(e.Text));
            if (telephone >= 48 && telephone <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }*/

            //second forms validation number with caracter -
            e.Handled = ValidationNumber.Numbers(Convert.ToChar(e.Text));
        }

        private void textBox10_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first form validation carater
            /*int caraters = Convert.ToInt32(Convert.ToChar(e.Text));
            if (caraters >= 65 && caraters <= 90 || caraters >= 97 && caraters <= 122)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }*/
            //second forms validation caracter
            e.Handled = ValidationCarater.Caracter(Convert.ToChar(e.Text));
        }

        private void textBox9_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first forms validation number without caracter
           int salary = Convert.ToInt32(Convert.ToChar(e.Text));
            if (salary >= 48 && salary <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //second forms validation number with caracter
            //e.Handled = ValidationNumber.Numbers(Convert.ToChar(e.Text));
        }

        private void textBox5_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //first form validation only numbers for identificacion fields
          /*  int salary = Convert.ToInt32(Convert.ToChar(e.Text));
            if (salary >= 48 && salary <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }*/

            //second forms validation caracter and numbers for identificacion fields
            e.Handled = ValidationCarater.Caracter(Convert.ToChar(e.Text));




        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //methos for desable controller
            this.Interfaces_Dehabilitado();
        }


    }
}