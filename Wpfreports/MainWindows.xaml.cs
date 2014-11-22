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
using SAPBusinessObjects.WPF.ViewerShared;
using SAPBusinessObjects.WPF.Viewer;
using CrystalDecisions.Shared;
using System.Collections;
using System.Configuration.Assemblies;
using System.Data.SqlClient;
#region
using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
#endregion


namespace Wpfreports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // string[] collectionFormst = Enum.GetNames(typeof(CrystalDecisions.Shared.ExportFormatType));
           // this.Esco.Items.Add(collectionFormst);
        }

        private void crystalReportsViewer1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1repo(object sender, RoutedEventArgs e)
        {
            //creating a reports with parameters
            ReportDocument CrystalYears = new ReportDocument();
            CrystalYears.Load(@"C:\Users\vegeta\Desktop\prueba\sistemapersonal\Wpfreports\CrystalReport1years.rpt");

            ParameterFieldDefinitions CrParameterFieldDefinitions;
            ParameterFieldDefinition CrParameterFieldDefinition;
            ParameterValues CrParameterValues = new ParameterValues();
            ParameterDiscreteValue CrParameterDiscreteValue = new ParameterDiscreteValue();

            CrParameterDiscreteValue.Value = textBox1.Text;
            CrParameterFieldDefinitions = CrystalYears.DataDefinition.ParameterFields;
            CrParameterFieldDefinition = CrParameterFieldDefinitions["Yeards"];

            CrParameterValues = CrParameterFieldDefinition.CurrentValues;
            CrParameterValues.Clear();
            CrParameterValues.Add(CrParameterDiscreteValue);
            CrParameterFieldDefinition.ApplyCurrentValues(CrParameterValues);

            
           // crystalReportsViewer1.Refresh+=new SAPBusinessObjects.WPF.Viewer.RefreshEventHandler(crystalReportsViewer1_Refresh);
           // crystalReportsViewer1 = crystalReportsViewer1_Refresh;
            crystalReportsViewer1.ViewerCore.ReportSource = CrystalYears;
          //  crystalReportsViewer1.Refresh+=new RefreshEventHandler(crystalReportsViewer1_Refresh);


        }

        private void crystalReportsViewer1_Refresh(object sender, RoutedEventArgs e)
        {
            //SAPBusinessObjects.WPF.Viewer.RefreshEventHandler();
            //crystalReportsViewer1.Refresh();
        }

        private void ButClicExpor(object sender, RoutedEventArgs e)
        {
            
           
        }
    }
}
