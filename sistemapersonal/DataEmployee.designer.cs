﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemapersonal
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sistemaEmpleados")]
	public partial class DataEmployeeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertemp_details_view(emp_details_view instance);
    partial void Updateemp_details_view(emp_details_view instance);
    partial void Deleteemp_details_view(emp_details_view instance);
    partial void InsertDepartments(Departments instance);
    partial void UpdateDepartments(Departments instance);
    partial void DeleteDepartments(Departments instance);
    #endregion
		
		public DataEmployeeDataContext() : 
				base(global::sistemapersonal.Properties.Settings.Default.sistemaEmpleadosConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<emp_details_view> emp_details_view
		{
			get
			{
				return this.GetTable<emp_details_view>();
			}
		}
		
		public System.Data.Linq.Table<Employees> Employees
		{
			get
			{
				return this.GetTable<Employees>();
			}
		}
		
		public System.Data.Linq.Table<Departments> Departments
		{
			get
			{
				return this.GetTable<Departments>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.searchLingtosqls")]
		public int searchLingtosqls([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Char(7)")] string employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, mjs);
			mjs = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.searchLingtosql")]
		public int searchLingtosql([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, mjs);
			mjs = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.searchsslinqtosql")]
		public int searchsslinqtosql([global::System.Data.Linq.Mapping.ParameterAttribute(Name="First_Name", DbType="VarChar(20)")] string first_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Message", DbType="VarChar(50)")] ref string message)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), first_Name, message);
			message = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ModifyEmpleadoslinqtosql")]
		public int ModifyEmpleadoslinqtosql([global::System.Data.Linq.Mapping.ParameterAttribute(Name="First_Name", DbType="VarChar(30)")] string first_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Last_Name", DbType="VarChar(30)")] string last_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string identification, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(70)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Address", DbType="VarChar(100)")] string address, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string marital_status, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Phone_Number", DbType="VarChar(15)")] string phone_Number, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Job_Title", DbType="VarChar(40)")] string job_Title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="VarChar(30)")] string salary, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string profession, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nomina", DbType="VarChar(30)")] string nomina, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string messages)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), first_Name, last_Name, identification, email, address, marital_status, phone_Number, job_Title, salary, profession, nomina, employee_ID, messages);
			messages = ((string)(result.GetParameterValue(12)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CancelEmployee")]
		public int CancelEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Messages", DbType="VarChar(50)")] ref string messages)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, messages);
			messages = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CancelEmployees")]
		public ISingleResult<CancelEmployeesResult> CancelEmployees([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Messages", DbType="VarChar(50)")] ref string messages)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, messages);
			messages = ((string)(result.GetParameterValue(1)));
			return ((ISingleResult<CancelEmployeesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertEmpCancele")]
		public int InsertEmpCancele([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hirin_date_start", DbType="Date")] System.Nullable<System.DateTime> hirin_date_start, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hirin_date_end", DbType="Date")] System.Nullable<System.DateTime> hirin_date_end, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Job_Title", DbType="VarChar(40)")] string job_Title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="First_Name", DbType="VarChar(30)")] string first_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="REASON_FOR_CANCELLATION", DbType="VarChar(40)")] string rEASON_FOR_CANCELLATION, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> last_Salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LAST_NAME", DbType="VarChar(40)")] string lAST_NAME, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string identification, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string message)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, hirin_date_start, hirin_date_end, job_Title, first_Name, rEASON_FOR_CANCELLATION, last_Salary, lAST_NAME, identification, message);
			message = ((string)(result.GetParameterValue(9)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertEmpCanceleds")]
		public int InsertEmpCanceleds([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hirin_date_start", DbType="Date")] System.Nullable<System.DateTime> hirin_date_start, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hirin_date_end", DbType="Date")] System.Nullable<System.DateTime> hirin_date_end, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Job_Title", DbType="VarChar(40)")] string job_Title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="First_Name", DbType="VarChar(30)")] string first_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="REASON_FOR_CANCELLATION", DbType="VarChar(40)")] string rEASON_FOR_CANCELLATION, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> last_Salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LAST_NAME", DbType="VarChar(40)")] string lAST_NAME, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string identification, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string message)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, hirin_date_start, hirin_date_end, job_Title, first_Name, rEASON_FOR_CANCELLATION, last_Salary, lAST_NAME, identification, message);
			message = ((string)(result.GetParameterValue(9)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertEmpCancel")]
		public int InsertEmpCancel([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hirin_date_start", DbType="Date")] System.Nullable<System.DateTime> hirin_date_start, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hirin_date_end", DbType="Date")] System.Nullable<System.DateTime> hirin_date_end, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Job_Title", DbType="VarChar(40)")] string job_Title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="First_Name", DbType="VarChar(30)")] string first_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="REASON_FOR_CANCELLATION", DbType="VarChar(40)")] string rEASON_FOR_CANCELLATION, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> last_Salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LAST_NAME", DbType="VarChar(40)")] string lAST_NAME, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string identification, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string message)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, hirin_date_start, hirin_date_end, job_Title, first_Name, rEASON_FOR_CANCELLATION, last_Salary, lAST_NAME, identification, message);
			message = ((string)(result.GetParameterValue(9)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EmpCance")]
		public int EmpCance([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Employee_ID", DbType="Int")] System.Nullable<int> employee_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string messages)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), employee_ID, messages);
			messages = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.emp_details_view")]
	public partial class emp_details_view : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _identification;
		
		private string _Email;
		
		private System.Nullable<System.DateTime> _Hiring;
		
		private string _Address;
		
		private string _marital_status;
		
		private string _Phone_Number;
		
		private string _Job_Title;
		
		private string _Salary;
		
		private string _profession;
		
		private string _Department_Name;
		
		private System.Nullable<int> _Department_ID;
		
		private string _Nomina;
		
		private int _Employee_ID;
		
		private EntityRef<Departments> _Departments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnidentificationChanging(string value);
    partial void OnidentificationChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnHiringChanging(System.Nullable<System.DateTime> value);
    partial void OnHiringChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void Onmarital_statusChanging(string value);
    partial void Onmarital_statusChanged();
    partial void OnPhone_NumberChanging(string value);
    partial void OnPhone_NumberChanged();
    partial void OnJob_TitleChanging(string value);
    partial void OnJob_TitleChanged();
    partial void OnSalaryChanging(string value);
    partial void OnSalaryChanged();
    partial void OnprofessionChanging(string value);
    partial void OnprofessionChanged();
    partial void OnDepartment_NameChanging(string value);
    partial void OnDepartment_NameChanged();
    partial void OnDepartment_IDChanging(System.Nullable<int> value);
    partial void OnDepartment_IDChanged();
    partial void OnNominaChanging(string value);
    partial void OnNominaChanged();
    partial void OnEmployee_IDChanging(int value);
    partial void OnEmployee_IDChanged();
    #endregion
		
		public emp_details_view()
		{
			this._Departments = default(EntityRef<Departments>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(30)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(30)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identification", DbType="VarChar(20)")]
		public string identification
		{
			get
			{
				return this._identification;
			}
			set
			{
				if ((this._identification != value))
				{
					this.OnidentificationChanging(value);
					this.SendPropertyChanging();
					this._identification = value;
					this.SendPropertyChanged("identification");
					this.OnidentificationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(70)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hiring", DbType="Date")]
		public System.Nullable<System.DateTime> Hiring
		{
			get
			{
				return this._Hiring;
			}
			set
			{
				if ((this._Hiring != value))
				{
					this.OnHiringChanging(value);
					this.SendPropertyChanging();
					this._Hiring = value;
					this.SendPropertyChanged("Hiring");
					this.OnHiringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marital_status", DbType="VarChar(40)")]
		public string marital_status
		{
			get
			{
				return this._marital_status;
			}
			set
			{
				if ((this._marital_status != value))
				{
					this.Onmarital_statusChanging(value);
					this.SendPropertyChanging();
					this._marital_status = value;
					this.SendPropertyChanged("marital_status");
					this.Onmarital_statusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(15)")]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this.OnPhone_NumberChanging(value);
					this.SendPropertyChanging();
					this._Phone_Number = value;
					this.SendPropertyChanged("Phone_Number");
					this.OnPhone_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job_Title", DbType="VarChar(40)")]
		public string Job_Title
		{
			get
			{
				return this._Job_Title;
			}
			set
			{
				if ((this._Job_Title != value))
				{
					if (this._Departments.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnJob_TitleChanging(value);
					this.SendPropertyChanging();
					this._Job_Title = value;
					this.SendPropertyChanged("Job_Title");
					this.OnJob_TitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="VarChar(30)")]
		public string Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_profession", DbType="VarChar(40)")]
		public string profession
		{
			get
			{
				return this._profession;
			}
			set
			{
				if ((this._profession != value))
				{
					this.OnprofessionChanging(value);
					this.SendPropertyChanging();
					this._profession = value;
					this.SendPropertyChanged("profession");
					this.OnprofessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department_Name", DbType="VarChar(30)")]
		public string Department_Name
		{
			get
			{
				return this._Department_Name;
			}
			set
			{
				if ((this._Department_Name != value))
				{
					this.OnDepartment_NameChanging(value);
					this.SendPropertyChanging();
					this._Department_Name = value;
					this.SendPropertyChanged("Department_Name");
					this.OnDepartment_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department_ID", DbType="Int")]
		public System.Nullable<int> Department_ID
		{
			get
			{
				return this._Department_ID;
			}
			set
			{
				if ((this._Department_ID != value))
				{
					this.OnDepartment_IDChanging(value);
					this.SendPropertyChanging();
					this._Department_ID = value;
					this.SendPropertyChanged("Department_ID");
					this.OnDepartment_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nomina", DbType="VarChar(30)")]
		public string Nomina
		{
			get
			{
				return this._Nomina;
			}
			set
			{
				if ((this._Nomina != value))
				{
					this.OnNominaChanging(value);
					this.SendPropertyChanging();
					this._Nomina = value;
					this.SendPropertyChanged("Nomina");
					this.OnNominaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Employee_ID
		{
			get
			{
				return this._Employee_ID;
			}
			set
			{
				if ((this._Employee_ID != value))
				{
					this.OnEmployee_IDChanging(value);
					this.SendPropertyChanging();
					this._Employee_ID = value;
					this.SendPropertyChanged("Employee_ID");
					this.OnEmployee_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departments_emp_details_view", Storage="_Departments", ThisKey="Job_Title", OtherKey="Job_Title", IsForeignKey=true)]
		public Departments Departments
		{
			get
			{
				return this._Departments.Entity;
			}
			set
			{
				Departments previousValue = this._Departments.Entity;
				if (((previousValue != value) 
							|| (this._Departments.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departments.Entity = null;
						previousValue.emp_details_view.Remove(this);
					}
					this._Departments.Entity = value;
					if ((value != null))
					{
						value.emp_details_view.Add(this);
						this._Job_Title = value.Job_Title;
					}
					else
					{
						this._Job_Title = default(string);
					}
					this.SendPropertyChanged("Departments");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employees
	{
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _identification;
		
		private string _Email;
		
		private System.Nullable<System.DateTime> _Hiring;
		
		private string _Address;
		
		private string _marital_status;
		
		private string _Phone_Number;
		
		private string _Job_Title;
		
		private string _Salary;
		
		private string _profession;
		
		private int _Manager_ID;
		
		private string _Nomina;
		
		private System.Nullable<int> _Employee_ID;
		
		public Employees()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this._First_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this._Last_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identification", DbType="VarChar(20)")]
		public string identification
		{
			get
			{
				return this._identification;
			}
			set
			{
				if ((this._identification != value))
				{
					this._identification = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(70)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hiring", DbType="Date")]
		public System.Nullable<System.DateTime> Hiring
		{
			get
			{
				return this._Hiring;
			}
			set
			{
				if ((this._Hiring != value))
				{
					this._Hiring = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marital_status", DbType="VarChar(40)")]
		public string marital_status
		{
			get
			{
				return this._marital_status;
			}
			set
			{
				if ((this._marital_status != value))
				{
					this._marital_status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(15)")]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this._Phone_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job_Title", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Job_Title
		{
			get
			{
				return this._Job_Title;
			}
			set
			{
				if ((this._Job_Title != value))
				{
					this._Job_Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="VarChar(30)")]
		public string Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_profession", DbType="VarChar(40)")]
		public string profession
		{
			get
			{
				return this._profession;
			}
			set
			{
				if ((this._profession != value))
				{
					this._profession = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manager_ID", DbType="Int NOT NULL")]
		public int Manager_ID
		{
			get
			{
				return this._Manager_ID;
			}
			set
			{
				if ((this._Manager_ID != value))
				{
					this._Manager_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nomina", DbType="VarChar(30)")]
		public string Nomina
		{
			get
			{
				return this._Nomina;
			}
			set
			{
				if ((this._Nomina != value))
				{
					this._Nomina = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_ID", DbType="Int")]
		public System.Nullable<int> Employee_ID
		{
			get
			{
				return this._Employee_ID;
			}
			set
			{
				if ((this._Employee_ID != value))
				{
					this._Employee_ID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departments")]
	public partial class Departments : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Department_ID;
		
		private string _Department_Name;
		
		private int _Manager_ID;
		
		private string _Job_Title;
		
		private EntitySet<emp_details_view> _emp_details_view;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepartment_IDChanging(int value);
    partial void OnDepartment_IDChanged();
    partial void OnDepartment_NameChanging(string value);
    partial void OnDepartment_NameChanged();
    partial void OnManager_IDChanging(int value);
    partial void OnManager_IDChanged();
    partial void OnJob_TitleChanging(string value);
    partial void OnJob_TitleChanged();
    #endregion
		
		public Departments()
		{
			this._emp_details_view = new EntitySet<emp_details_view>(new Action<emp_details_view>(this.attach_emp_details_view), new Action<emp_details_view>(this.detach_emp_details_view));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department_ID", DbType="Int NOT NULL")]
		public int Department_ID
		{
			get
			{
				return this._Department_ID;
			}
			set
			{
				if ((this._Department_ID != value))
				{
					this.OnDepartment_IDChanging(value);
					this.SendPropertyChanging();
					this._Department_ID = value;
					this.SendPropertyChanged("Department_ID");
					this.OnDepartment_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Department_Name
		{
			get
			{
				return this._Department_Name;
			}
			set
			{
				if ((this._Department_Name != value))
				{
					this.OnDepartment_NameChanging(value);
					this.SendPropertyChanging();
					this._Department_Name = value;
					this.SendPropertyChanged("Department_Name");
					this.OnDepartment_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manager_ID", DbType="Int NOT NULL")]
		public int Manager_ID
		{
			get
			{
				return this._Manager_ID;
			}
			set
			{
				if ((this._Manager_ID != value))
				{
					this.OnManager_IDChanging(value);
					this.SendPropertyChanging();
					this._Manager_ID = value;
					this.SendPropertyChanged("Manager_ID");
					this.OnManager_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job_Title", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Job_Title
		{
			get
			{
				return this._Job_Title;
			}
			set
			{
				if ((this._Job_Title != value))
				{
					this.OnJob_TitleChanging(value);
					this.SendPropertyChanging();
					this._Job_Title = value;
					this.SendPropertyChanged("Job_Title");
					this.OnJob_TitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departments_emp_details_view", Storage="_emp_details_view", ThisKey="Job_Title", OtherKey="Job_Title")]
		public EntitySet<emp_details_view> emp_details_view
		{
			get
			{
				return this._emp_details_view;
			}
			set
			{
				this._emp_details_view.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_emp_details_view(emp_details_view entity)
		{
			this.SendPropertyChanging();
			entity.Departments = this;
		}
		
		private void detach_emp_details_view(emp_details_view entity)
		{
			this.SendPropertyChanging();
			entity.Departments = null;
		}
	}
	
	public partial class CancelEmployeesResult
	{
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _identification;
		
		private string _Email;
		
		private System.Nullable<System.DateTime> _Hiring;
		
		private string _Address;
		
		private string _marital_status;
		
		private string _Phone_Number;
		
		private string _Job_Title;
		
		private string _Salary;
		
		private string _profession;
		
		private int _Manager_ID;
		
		private string _Nomina;
		
		private System.Nullable<int> _Employee_ID;
		
		public CancelEmployeesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this._First_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this._Last_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identification", DbType="VarChar(20)")]
		public string identification
		{
			get
			{
				return this._identification;
			}
			set
			{
				if ((this._identification != value))
				{
					this._identification = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(70)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hiring", DbType="Date")]
		public System.Nullable<System.DateTime> Hiring
		{
			get
			{
				return this._Hiring;
			}
			set
			{
				if ((this._Hiring != value))
				{
					this._Hiring = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marital_status", DbType="VarChar(40)")]
		public string marital_status
		{
			get
			{
				return this._marital_status;
			}
			set
			{
				if ((this._marital_status != value))
				{
					this._marital_status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(15)")]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this._Phone_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job_Title", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Job_Title
		{
			get
			{
				return this._Job_Title;
			}
			set
			{
				if ((this._Job_Title != value))
				{
					this._Job_Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="VarChar(30)")]
		public string Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_profession", DbType="VarChar(40)")]
		public string profession
		{
			get
			{
				return this._profession;
			}
			set
			{
				if ((this._profession != value))
				{
					this._profession = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manager_ID", DbType="Int NOT NULL")]
		public int Manager_ID
		{
			get
			{
				return this._Manager_ID;
			}
			set
			{
				if ((this._Manager_ID != value))
				{
					this._Manager_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nomina", DbType="VarChar(30)")]
		public string Nomina
		{
			get
			{
				return this._Nomina;
			}
			set
			{
				if ((this._Nomina != value))
				{
					this._Nomina = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_ID", DbType="Int")]
		public System.Nullable<int> Employee_ID
		{
			get
			{
				return this._Employee_ID;
			}
			set
			{
				if ((this._Employee_ID != value))
				{
					this._Employee_ID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591