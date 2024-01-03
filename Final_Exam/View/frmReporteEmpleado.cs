using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;



namespace Final_Exam.View
{
    public partial class frmReporteEmpleado : Form
    {

        ParameterFields parametros = new ParameterFields();
        ParameterField parametro = new ParameterField();
        ParameterDiscreteValue valorParametro = new ParameterDiscreteValue();
        exafinalpeEntities context = new exafinalpeEntities();
        public frmReporteEmpleado()
        {
            InitializeComponent();
        }

        private void frmReporteEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            parametro.ParameterValueType = ParameterValueKind.NumberParameter;
            parametro.Name = "@salario";
            valorParametro.Value = int.Parse(txtSalario.Text.ToString());

            parametro.CurrentValues.Add(valorParametro);

            parametros.Add(parametro);

            crystalReportViewer1.ParameterFieldInfo = parametros;

            rptEmpleado rpt = new rptEmpleado();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
