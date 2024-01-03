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
    public partial class frmReporteTelefono : Form
    {
        ParameterFields parametros = new ParameterFields();
        ParameterField parametro = new ParameterField();
        ParameterDiscreteValue valorParametro = new ParameterDiscreteValue();
        exafinalpeEntities context = new exafinalpeEntities();
        public frmReporteTelefono()
        {
            InitializeComponent();
            cmbDepartment.DataSource = context.departamento.ToList();
            cmbDepartment.ValueMember = "idDepartamento";
            cmbDepartment.DisplayMember = "nombreDepto";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            parametro.ParameterValueType = ParameterValueKind.NumberParameter;
            parametro.Name = "@idDep";
            valorParametro.Value = int.Parse(cmbDepartment.SelectedValue.ToString());

            parametro.CurrentValues.Add(valorParametro);

            parametros.Add(parametro);

            crystalReportViewer1.ParameterFieldInfo = parametros;

            rptTelefono rpt = new rptTelefono();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmReporteTelefono_Load(object sender, EventArgs e)
        {

        }
    }
}
