using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.DTO;

namespace PERSONNEL_TRACKING
{
    public partial class frmDepartmentList : Form
    {
        public frmDepartmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDepartment frm = new frmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            list = DepartmentBLL.GetDepartment();
            dgvDepartmentList.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("Please Select a Department!");
            }
            else 
            {
                frmDepartment frm = new frmDepartment();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                list = DepartmentBLL.GetDepartment();
                dgvDepartmentList.DataSource = list;
            }
        }

        List<DEPARTMENT> list = new List<DEPARTMENT>();
        public DEPARTMENT detail = new DEPARTMENT();

        private void frmDepartmentList_Load(object sender, EventArgs e)
        {
            list = DepartmentBLL.GetDepartment();
            dgvDepartmentList.DataSource = list;
            dgvDepartmentList.Columns[0].Visible = false;
            dgvDepartmentList.Columns[1].HeaderText = "Department Name";
        }

        private void dgvDepartmentList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dgvDepartmentList.Rows[e.RowIndex].Cells[0].Value);
            detail.DepartmentName = dgvDepartmentList.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure to delete this Department?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DepartmentBLL.DeleteDepartment(detail.ID);
                MessageBox.Show("Department was deleted");
                list = DepartmentBLL.GetDepartment();
                dgvDepartmentList.DataSource = list;
            }
        }
    }
}
