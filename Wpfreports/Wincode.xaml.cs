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
    /// Interaction logic for Wincode.xaml
    /// </summary>
    public partial class Wincode : Window
    {
        public Wincode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //creating reports with parameters in wpf
            ReportDocument Crystacode = new ReportDocument();
            Crystacode.Load(@"C:\Users\vegeta\Desktop\prueba\sistemapersonal\Wpfreports\CrystalReport3.rpt");

            ParameterFieldDefinitions CrParameterFieldDefinitions;
            ParameterFieldDefinition CrParameterFieldDefinition;

            ParameterValues CrParameterValues = new ParameterValues();
            ParameterDiscreteValue CrParameterDiscreteValue = new ParameterDiscreteValue();

            CrParameterDiscreteValue.Value = textBox1.Text;
            CrParameterFieldDefinitions = Crystacode.DataDefinition.ParameterFields;
            CrParameterFieldDefinition = CrParameterFieldDefinitions["Code"];

            CrParameterValues = CrParameterFieldDefinition.CurrentValues;
            CrParameterValues.Clear();
            CrParameterValues.Add(CrParameterDiscreteValue);
            CrParameterFieldDefinition.ApplyCurrentValues(CrParameterValues);

            crystalReportsViewer1.ViewerCore.ReportSource = Crystacode;

        }
    }
}
