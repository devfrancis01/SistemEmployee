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
using System.Configuration;
using System.Data.Entity;
using System.Collections;
namespace sistemapersonal
{
    /// <summary>
    /// Interaction logic for InfoEmployees.xaml
    /// </summary>
    public partial class InfoEmployees : Window
    {
        DataEmployeeDataContext db = new DataEmployeeDataContext();
        public InfoEmployees()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Interfaces_Datos();
        }
        public void Interfaces_Datos()
        {
            textBox1.IsEnabled = true;
            textBox15.IsEnabled = false;/*this data hiring fields*/
            textBox2.IsEnabled = false; /*this Name fields*/
            textBox3.IsEnabled = false;/*this Last Name fields*/
            textBox4.IsEnabled = false;/*this Email fields*/
            textBox5.IsEnabled = false;/*this identification fields*/
            textBox7.IsEnabled = false;/*this address fields*/
            textBox8.IsEnabled = false;/*this telephone fields*/
            textBox10.IsEnabled = false;/*this profession fields*/
            textBox6.IsEnabled = false;/*this status fields */
            textBox9.IsEnabled = false;/*this salary fields*/
            textBox14.IsEnabled = false;/*this payroll fields*/
           // textBox11.IsEnabled = false;
            textBox12.IsEnabled = false;
            textBox13.IsEnabled = false;
        }
        
        public void Interfaces_IsEnableData()
        {
            textBox1.IsEnabled = true;
            textBox15.IsEnabled = true;/*this data hiring fields*/
            textBox2.IsEnabled = true; /*this Name fields*/
            textBox3.IsEnabled = true;/*this Last Name fields*/
            textBox4.IsEnabled = true;/*this Email fields*/
            textBox5.IsEnabled = true;/*this identification fields*/
            textBox7.IsEnabled = true;/*this address fields*/
            textBox8.IsEnabled = true;/*this telephone fields*/
            textBox10.IsEnabled = true;/*this profession fields*/
            textBox6.IsEnabled = true;/*this status fields */
            textBox9.IsEnabled = true;/*this salary fields*/
            textBox14.IsEnabled = true;/*this payroll fields*/
           // textBox11.IsEnabled = true;
            textBox12.IsEnabled = true;
            textBox13.IsEnabled = true;
        }
        public bool search(string Employee_ID)
        {
              //creating a command storeprocedure
                SqlCommand comand = new SqlCommand("searchs");
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.AddWithValue("@Employee_ID", Employee_ID);

            //creating a connection with databases
                string Conection = @"Data Source = .\sqlexpress; initial catalog = SistemaEmpleados; integrated security = true";
                using (SqlConnection Conections = new SqlConnection(Conection))
                {
                    Conections.Open();
                    comand.Connection = Conections;
                    SqlDataAdapter adp = new SqlDataAdapter(comand);
                    DataSet ds = new DataSet();
                    adp.Fill(ds,"emp_details_view");
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("this code Employee is no found in the Database");
                        ds.Dispose();
                        return false;
                    }
                    else
                    {
                        
                        textBox2.Text = (string)ds.Tables["emp_details_view"].Rows[0]["First_Name"];
                        textBox3.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Last_Name"];
                        textBox5.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Email"];
                        textBox4.Text = (string)ds.Tables["emp_details_view"].Rows[0]["identification"];
                        textBox7.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Address"];
                        textBox8.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Phone_Number"];
                        textBox10.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Profession"];
                        textBox6.Text = (string)ds.Tables["emp_details_view"].Rows[0]["marital_status"];
                        textBox9.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Salary"];
                        textBox14.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Nomina"];
                        textBox12.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Job_Title"];
                        textBox13.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Department_Name"];
                        textBox15.Text = (string)ds.Tables["emp_details_view"].Rows[0]["Hiring"].ToString();
                        
                        ds.Dispose();
                        Conections.Close();
                        return true;
                        
                    }
                }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.Key == Key.Enter)
            {
                this.search(textBox1.Text);
                
                
            }
            else if (e.Key == Key.Escape)
            {
                this.Close();
            }
               
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void sav(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Clears(object sender, RoutedEventArgs e)
        {
            this.Interfaces_clears();
        }

        public void Interfaces_clears()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
            textBox14.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox15.Text = "";
        }

        
    }
}
