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
    public partial class frmReporteDepartamento : Form
    {
        ParameterFields parametros = new ParameterFields();
        ParameterField parametro = new ParameterField();
        ParameterDiscreteValue valorParametro = new ParameterDiscreteValue();
        exafinalpeEntities context = new exafinalpeEntities();
        public frmReporteDepartamento()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            parametro.ParameterValueType = ParameterValueKind.NumberParameter;
            parametro.Name = "@cantidadE";
            valorParametro.Value = int.Parse(txtCantidad.Text.ToString());

            parametro.CurrentValues.Add(valorParametro);

            parametros.Add(parametro);

            crystalReportViewer1.ParameterFieldInfo = parametros;

            rptDepartamento rpt = new rptDepartamento();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
