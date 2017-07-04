using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region NewUsing
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Proyecto_BD_HA_V2
{
    public partial class ControlReporte : Form
    {
        //public string fact;
        public ControlReporte(string fact)
        {
            //this.fact = fact;
            int val = Convert.ToInt32(fact);
            InitializeComponent();
            FactReport2.SetParameterValue("otrofact", val);
        }
        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            // ULTIMA PRUEBA


            
            // CODIGO FUNCIONANDO PRUEBA 3
            // ---------------------------------------------------------------------------
            //ReportDocument doc = new ReportDocument();
            //doc.Load(@"C:\Users\DANNA\Documents\Visual Studio 2015\Projects\Proyecto_BD_HA_V2\Proyecto_BD_HA_V2\FactReport.rpt");
            //ParameterFieldDefinitions parametroDefs; //
            //ParameterFieldDefinition parametroDef; //
            //ParameterValues parametroVals = new ParameterValues(); //
            //ParameterDiscreteValue dicrete = new ParameterDiscreteValue(); //
            ////ReportDocument doc = new ReportDocument();

            //dicrete.Value = Convert.ToInt32(fact); // Revisar código
            //parametroDefs = FactReport1.DataDefinition.ParameterFields; //
            //parametroDef = parametroDefs["otrofact"]; //
            //parametroVals = parametroDef.CurrentValues; //

            //parametroVals.Clear(); //
            //parametroVals.Add(dicrete); //
            //parametroDef.ApplyCurrentValues(parametroVals); //


            //doc.SetParameterValue("otrofact", fact);
            crystalReportViewer1.ReportSource = FactReport1; //
            //crystalReportViewer1.ReportSource = doc;
            crystalReportViewer1.Refresh(); //
            // ---------------------------------------------------------------------------

            /*
            primer.ParameterValueType = ParameterValueKind.NumberParameter;
            dicrete.Value = Convert.ToInt32(fact);
            primer.CurrentValues.Add(dicrete);
            parametros.Add(primer);
            crystalReportViewer1.ParameterFieldInfo = parametros;
            FactReport info = new FactReport();
            crystalReportViewer1.ReportSource = info;
            */

            //FactReport1.SetParameterValue("idFactura", fact);
            //crystalReportViewer1.ReportSource = FactReport1;
            //crystalReportViewer1.Refresh();
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            /*
            FactReport1.SetParameterValue("idFactura", fact);
            crystalReportViewer1.ReportSource = FactReport1;
            crystalReportViewer1.Refresh();
            */
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void ControlReporte_Load(object sender, EventArgs e)
        {

        }

        private void FactReport1_InitReport(object sender, EventArgs e)
        {

        }
    }
}

#endregion
