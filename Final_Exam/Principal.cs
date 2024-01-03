using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Exam.View;

namespace Final_Exam
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void teléfonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhone p = new frmPhone();
            p.MdiParent = this;
            p.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment d = new frmDepartment();
            d.MdiParent = this;
            d.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee em = new frmEmployee();
            em.MdiParent = this;
            em.Show();
        }

        private void reporteTeléfonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteTelefono rt = new frmReporteTelefono();
            rt.MdiParent = this;
            rt.Show();
        }

        private void reporteEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEmpleado re = new frmReporteEmpleado();
            re.MdiParent = this;
            re.Show();
        }

        private void reporteDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDepartamento rd = new frmReporteDepartamento();
            rd.MdiParent = this;
            rd.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformación i = new frmInformación();
            i.MdiParent = this;
            i.Show();
        }
    }
}
