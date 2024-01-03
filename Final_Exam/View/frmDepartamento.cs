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
    public partial class frmDepartment : Form
    {
        exafinalpeEntities context = new exafinalpeEntities();
        departamento d = new departamento();
        string option = string.Empty;
        
        public frmDepartment()
        {
            InitializeComponent();
            cmbParam.Items.Add("idDepartamento");
            cmbParam.Items.Add("nombreDepto");
            cmbParam.Items.Add("cantEmpleados");
            cmbParam.Items.Add("codTels");
            
        }

        void filter(string criterio, string param)
        {
            dgvDepartment.DataSource = context.departamento.SqlQuery("select * from departamento where " + param + " like '%" + criterio + "%'").ToList();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            disableTextbox();
            loadTable();
            loadCombobox();
            disableButton();
        }

        void loadCombobox(){
            cmbPhone.DataSource = context.telefono.ToList();
            cmbPhone.ValueMember = "codTels";
            cmbPhone.DisplayMember = "telefono1";
            
            
        }

        void loadData()
        {
            d = new departamento();

            
            d.nombreDepto = txtName.Text;
            d.cantEmpleados = int.Parse(txtQuantity.Text);
            d.codTels = int.Parse(cmbPhone.SelectedValue.ToString());

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
            txtQuantity.Enabled = true;
            cmbPhone.Enabled = true;
        }

        void disableTextbox()
        {
            txtName.Enabled = false;
            txtQuantity.Enabled = false;
            cmbPhone.Enabled = false;
            txtCode.Enabled = false;
        }

        void loadTable()
        {
            dgvDepartment.DataSource = context.departamento.ToList();
        }

        void clear()
        {
            txtName.Clear();
            txtQuantity.Clear();
            txtCode.Clear();
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

                context.departamento.Add(d);
                context.SaveChanges();
                disableTextbox();
                clear();
                loadTable();
            }

            else if (option.Equals("Modifying"))
            {

                d = new departamento();
                d.idDepartamento = int.Parse(txtCode.Text);
                d = context.departamento.FirstOrDefault(x => x.idDepartamento == d.idDepartamento);

                d.nombreDepto = txtName.Text;
                d.cantEmpleados = int.Parse(txtQuantity.Text);
                d.codTels = int.Parse(cmbPhone.SelectedValue.ToString());
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                context.SaveChanges();
                disableTextbox();
                clear();
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
            d.idDepartamento = int.Parse(txtCode.Text);
            d = context.departamento.FirstOrDefault(x => x.idDepartamento == d.idDepartamento);
            if (MessageBox.Show("¿Está seguro?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.departamento.Remove(d);
                context.SaveChanges();
                clear();
                loadTable();
            }
        }

        private void dgvDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                txtCode.Text = dgvDepartment.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvDepartment.SelectedRows[0].Cells[1].Value.ToString();
                txtQuantity.Text = dgvDepartment.SelectedRows[0].Cells[2].Value.ToString();
                int aux = int.Parse(dgvDepartment.SelectedRows[0].Cells[3].Value.ToString());
                cmbPhone.SelectedValue = aux;
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
            dgvDepartment.DataSource = context.departamento.ToList();
        }



       
    }
}
