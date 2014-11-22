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
    /// Interaction logic for CancelEmployees.xaml
    /// </summary>
    public partial class CancelEmployees : Window
    {
        public CancelEmployees()
        {
            InitializeComponent();
        }
        DataEmployeeDataContext db = new DataEmployeeDataContext();
        private void Cancelempl(object sender, RoutedEventArgs e)
        {
            //close form
            this.Close();
        }

        private void DeleteEmplo(object sender, RoutedEventArgs e)
        {
            //creating method for delete
           MessageBoxResult Questions = MessageBox.Show("Do you want to delete this employees","Warning",MessageBoxButton.YesNo,MessageBoxImage.Question);
            {
                if(Questions == MessageBoxResult.Yes)
                {
                    string messages = "";
                    db.EmpCance(Convert.ToInt32(textBox1.Text), ref messages);
                    MessageBox.Show(messages);
                    this.AddEmpCancel(textBox1.Text,Convert.ToString(textBox15.Text), Convert.ToString(datePicker1.Text), textBox12.Text, textBox2.Text, textBox6.Text, textBox9.Text, textBox3.Text, textBox4.Text);
                    textBox1.Focus();
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.searchs(textBox1.Text);
               // this.searchEmployee(textBox1.Text);
                this.Interfaces_date_enable();

            }
        }

        public void Interfaces_date_disable()
        {
            textBox1.Focus();
            textBox1.IsEnabled = true;/*Fields Id*/
            textBox15.IsEnabled = false; /*fileds date start*/
            datePicker1.IsEnabled = false;/*field date end*/
            textBox2.IsEnabled = false;/*fileds name*/
            textBox3.IsEnabled = false;/*fileds last name*/
            textBox5.IsEnabled = false;/*fields email*/
            textBox4.IsEnabled = false;/*fields identificacion*/
            textBox10.IsEnabled = false;/*fields professtion*/
            textBox12.IsEnabled = false;/*fields position*/
            textBox9.IsEnabled = false;/*fields salary*/
            textBox14.IsEnabled = false;/*fields payroll*/
            textBox6.IsEnabled = false;/*fields razon for cancellations*/
            button34.IsEnabled = false;/*fields button cancel*/
  
        }
        public void Interfaces_date_enable()
        {
            
            textBox15.IsEnabled = false; /*fileds date start*/
            datePicker1.IsEnabled = true;/*field date end*/
            textBox2.IsEnabled = false;/*fileds name*/
            textBox3.IsEnabled = false;/*fileds last name*/
            textBox5.IsEnabled = false;/*fields email*/
            textBox4.IsEnabled = false;/*fields identificacion*/
            textBox10.IsEnabled = false;/*fields professtion*/
            textBox12.IsEnabled = false;/*fields position*/
            textBox9.IsEnabled = false;/*fields salary*/
            textBox14.IsEnabled = false;/*fields payroll*/
            textBox6.IsEnabled = true;/*fields razon for cancellations*/
            button34.IsEnabled = true;/*fields button cancel*/
        }

        public void Interfaces_clear()
        {
            textBox1.Focus();
            textBox15.Clear(); /*fileds date start*/
            datePicker1.Text = "";/*field date end*/
            textBox2.Clear();/*fileds name*/
            textBox3.Clear();/*fileds last name*/
            textBox5.Clear();/*fields email*/
            textBox4.Clear();/*fields identificacion*/
            textBox10.Clear();/*fields professtion*/
            textBox12.Clear();/*fields position*/
            textBox9.Clear();/*fields salary*/
            textBox14.Clear();/*fields payroll*/
            textBox6.Clear();/*fields razon for cancellations*/
           
        }
         public void AddEmpCancel(string Employee_ID,string Hirin_date_start,string Hirin_date_end,string Job_Title,string First_Name,string REASON_FOR_CANCELLATION,string LAST_SALARY,string Last_Name,string identification)
        {
            SqlParameter HirinEnd = new SqlParameter();
            DateTime Hiringsend = new DateTime();
            if (DateTime.TryParse(datePicker1.Text, out Hiringsend))
            {
                HirinEnd.Value = Hiringsend;
                HirinEnd.Value = DBNull.Value;
                Hiringsend.ToString("dd/mm/yyyy");
            }

            SqlParameter Hirin3star = new SqlParameter();
            DateTime Hirinstar = new DateTime();
            if (DateTime.TryParse(textBox15.Text, out Hirinstar))
            {
                Hirin3star.Value = Hirinstar;
                Hirin3star.Value = DBNull.Value;
                Hirinstar.ToString("dd/mm/yyyy");
            }

             //creating connection with database
            SqlConnection conections = new SqlConnection(@"Data Source = .\Sqlexpress;Initial Catalog = SistemaEmpleados;Integrated Security = true");
             //creating a command
            SqlCommand command = conections.CreateCommand();
            command.CommandText = "InsertEmpCanceled";
            command.CommandType = System.Data.CommandType.StoredProcedure;

             //adding parameters
            command.Parameters.AddWithValue("@Employee_ID", Employee_ID);
           command.Parameters.AddWithValue("@Hirin_date_start", Hirinstar.Date);
            command.Parameters.AddWithValue("@Hirin_date_end", Hiringsend.Date);
            command.Parameters.AddWithValue("@Job_Title", Job_Title);
           // command.Parameters.AddWithValue("@Department_Name", Department_Name);
            command.Parameters.AddWithValue("@First_Name", First_Name);
            command.Parameters.AddWithValue("@REASON_FOR_CANCELLATION", REASON_FOR_CANCELLATION);
            command.Parameters.AddWithValue("@LAST_SALARY", LAST_SALARY);
            command.Parameters.AddWithValue("@Last_Name", Last_Name);
            command.Parameters.AddWithValue("@identification", identification);

            try
            {
                conections.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conections.Close();
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Interfaces_date_disable();
        }
        public bool searchs(string Employee_ID)
        {
            //creating method for search with storedprocedure
            SqlCommand coman = new SqlCommand("search");
            coman.CommandType = System.Data.CommandType.StoredProcedure;

            coman.Parameters.AddWithValue("@Employee_ID", Employee_ID);

            //creating conection for conect with database
            string Conections = @"Data Source = .\SQLExpress;Initial Catalog = SistemaEmpleados;Integrated Security = true";
            using (SqlConnection conect = new SqlConnection(Conections))
            {
                conect.Open();
                coman.Connection = conect;
                SqlDataAdapter adp = new SqlDataAdapter(coman);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Employees");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    //this.Interfaces_date_enable();
                    MessageBox.Show("This Employees is not found in database");
                    ds.Dispose();
                    return false;
                }
                else
                {
                    this.Interfaces_date_enable();
                    textBox2.Text = (string)ds.Tables["Employees"].Rows[0]["First_Name"];
                    textBox3.Text = (string)ds.Tables["Employees"].Rows[0]["Last_Name"];
                    textBox15.Text = ds.Tables["Employees"].Rows[0]["Hiring"].ToString();
                    textBox4.Text = (string)ds.Tables["Employees"].Rows[0]["identification"];
                    textBox5.Text = (string)ds.Tables["Employees"].Rows[0]["Email"];
                    textBox12.Text = (string)ds.Tables["Employees"].Rows[0]["jOB_title"];
                    textBox10.Text = (string)ds.Tables["Employees"].Rows[0]["Profession"];
                    textBox9.Text = (string)ds.Tables["Employees"].Rows[0]["Salary"];
                    textBox14.Text = (string)ds.Tables["Employees"].Rows[0]["Nomina"];
                    ds.Dispose();
                    return true;
                }

            }
        }

            
        

        }

    }

