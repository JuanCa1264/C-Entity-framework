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
    public partial class frmPhone : Form
    {

        exafinalpeEntities context = new exafinalpeEntities();
        telefono t = new telefono();
        string option = string.Empty;

        public frmPhone()
        {
            InitializeComponent();
            cmbParam.Items.Add("codTels");
            cmbParam.Items.Add("telefono");
            cmbParam.Items.Add("telDescrip");
        }

        private void frmPhone_Load(object sender, EventArgs e)
        {
            disableButton();
            disableTextbox();
            loadTable();

        }

        void filter(string criterio, string param)
        {
            dgvPhone.DataSource = context.telefono.SqlQuery("select codTels, telefono as telefono1, telDescrip from telefono where " + param + " like '%"+criterio+"%'").ToList(); 
        }

        void loadData()
        {
            t = new telefono();

            
            t.telefono1 = txtPhoneNumber.Text;
            t.telDescrip = txtDescription.Text;

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
            txtPhoneNumber.Enabled = true;
            txtDescription.Enabled = true;
        }

        void disableTextbox()
        {
            txtPhoneNumber.Enabled = false;
            txtDescription.Enabled = false;
            txtCode.Enabled = false;
        }


        void loadTable()
        {
            dgvPhone.DataSource = context.telefono.ToList();
        }

        void clear()
        {
            txtCode.Clear();
            txtPhoneNumber.Clear();
            txtDescription.Clear();
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

                context.telefono.Add(t);
                context.SaveChanges();
                clear();
                btnSave.Enabled = false;
                loadTable();
            }

            else if (option.Equals("Modifying"))
            {

                t = new telefono();
                t.codTels = int.Parse(txtCode.Text);
                t = context.telefono.FirstOrDefault(x => x.codTels == t.codTels);

                t.telefono1 = txtPhoneNumber.Text;
                t.telDescrip = txtDescription.Text;
                context.SaveChanges();
                clear();
                btnNew.Enabled = true;
                disableTextbox();
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
            t.codTels = int.Parse(txtCode.Text);
            t = context.telefono.FirstOrDefault(x => x.codTels == t.codTels);
            if (MessageBox.Show("¿Está seguro?", "Confirmar Eliminación", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                context.telefono.Remove(t);
                context.SaveChanges();
                clear();
                loadTable();
            }
            
        }

        private void dgvPhone_Click(object sender, EventArgs e)
        {
            if (dgvPhone.SelectedRows.Count > 0)
            {
                txtCode.Text = dgvPhone.SelectedRows[0].Cells[0].Value.ToString();
                txtPhoneNumber.Text = dgvPhone.SelectedRows[0].Cells[1].Value.ToString();
                txtDescription.Text = dgvPhone.SelectedRows[0].Cells[2].Value.ToString();
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
            dgvPhone.DataSource = context.telefono.ToList();
        }

        private void cmbParam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
