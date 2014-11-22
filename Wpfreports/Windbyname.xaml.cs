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
#region
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
#endregion

namespace Wpfreports
{
    /// <summary>
    /// Interaction logic for Windbyname.xaml
    /// </summary>
    public partial class Windbyname : Window
    {
        public Windbyname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //creating a reports with parameters
            ReportDocument crystal = new ReportDocument();
            crystal.Load(@"C:\Users\vegeta\Desktop\prueba\sistemapersonal\Wpfreports\CrystalReport2.rpt");

            ParameterFieldDefinitions CrParameterFieldDefinitions;
            ParameterFieldDefinition CrParameterFieldDefinition;

            ParameterValues CrParameterValues = new ParameterValues();
            ParameterDiscreteValue CrParameterDiscreteValue = new ParameterDiscreteValue();

            CrParameterDiscreteValue.Value = textBox1.Text;
            CrParameterFieldDefinitions = crystal.DataDefinition.ParameterFields;
            CrParameterFieldDefinition = CrParameterFieldDefinitions["Names"];

            CrParameterValues = CrParameterFieldDefinition.CurrentValues;
            CrParameterValues.Clear();
            CrParameterValues.Add(CrParameterDiscreteValue);
            CrParameterFieldDefinition.ApplyCurrentValues(CrParameterValues);

            crystalReportsViewer1.ViewerCore.ReportSource = crystal;
            
        }
    }
}
