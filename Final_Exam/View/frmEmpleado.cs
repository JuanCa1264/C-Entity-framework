using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam.View
{
    public partial class frmEmployee : Form
    {

        exafinalpeEntities context = new exafinalpeEntities();
        empleado em = new empleado();
        string option = string.Empty;

        public frmEmployee()
        {
            InitializeComponent();
            cmbParam.Items.Add("codEmpleado");
            cmbParam.Items.Add("nombres");
            cmbParam.Items.Add("apellidos");
            cmbParam.Items.Add("idDepartamento");
            cmbParam.Items.Add("salario");
            cmbParam.Items.Add("edad");
        }

        void filter(string criterio, string param)
        {
            dgvEmployee.DataSource = context.empleado.SqlQuery("select * from empleado where " + param + " like '%" + criterio + "%'").ToList();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadTable();
            disableTextbox();
            disableButton();

        }

        void loadCombobox()
        {
            cmbDepartment.DataSource = context.departamento.ToList();
            cmbDepartment.ValueMember = "idDepartamento";
            cmbDepartment.DisplayMember = "nombreDepto";


        }


        void loadData()
        {
            em = new empleado();


            em.nombres = txtName.Text;
            em.apellidos = txtLastName.Text;
            em.idDepartamento = int.Parse(cmbDepartment.SelectedValue.ToString());
            em.salario = int.Parse(txtSalary.Text);
            em.edad = int.Parse(txtAge.Text);
         
        }

        void disableButton()
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        void enableButton()
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        void enableTextbox()
        {
            txtName.Enabled = true;
            txtLastName.Enabled = true;
            cmbDepartment.Enabled = true;
            txtSalary.Enabled = true;
            txtAge.Enabled = true;
            
        }


        void disableTextbox()
        {
            txtName.Enabled = false;
            txtLastName.Enabled = false;
            cmbDepartment.Enabled = false;
            txtSalary.Enabled = false;
            txtAge.Enabled = false;
            txtCode.Enabled = false;
        }

        void loadTable()
        {
            dgvEmployee.DataSource = context.empleado.ToList();
        }

        void clear()
        {
            txtCode.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtSalary.Clear();
            txtAge.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            option = "Saving";
            enableTextbox();
            disableButton();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (option.Equals("Saving"))
            {
                loadData();

                context.empleado.Add(em);
                context.SaveChanges();
                clear();
                disableTextbox();
                loadTable();
            }

            else if (option.Equals("Modifying"))
            {

                em = new empleado();
                em.codEmpleado = int.Parse(txtCode.Text);
                em = context.empleado.FirstOrDefault(x => x.codEmpleado == em.codEmpleado);
                
                em.nombres = txtName.Text;
                em.apellidos = txtLastName.Text;
                em.idDepartamento = int.Parse(cmbDepartment.SelectedValue.ToString());
                em.salario = int.Parse(txtSalary.Text);
                em.edad = int.Parse(txtAge.Text);

                context.SaveChanges();
                clear();
                disableTextbox();
                btnNew.Enabled = true;
                loadTable();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            option = "Modifying";
            disableButton();
            btnSave.Enabled = true;
            btnNew.Enabled = false;
            enableTextbox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loadData();
            em.codEmpleado = int.Parse(txtCode.Text);
            em = context.empleado.FirstOrDefault(x => x.codEmpleado == em.codEmpleado);
            if (MessageBox.Show("¿Está seguro?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.empleado.Remove(em);
                context.SaveChanges();
                clear();

                loadTable();
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                txtCode.Text = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvEmployee.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
                int aux = int.Parse(dgvEmployee.SelectedRows[0].Cells[3].Value.ToString());
                cmbDepartment.SelectedValue = aux;
                txtSalary.Text = dgvEmployee.SelectedRows[0].Cells[4].Value.ToString();
                txtAge.Text = dgvEmployee.SelectedRows[0].Cells[5].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter(txtSearch.Text, cmbParam.Text);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = context.empleado.ToList();
        }


    }
}
