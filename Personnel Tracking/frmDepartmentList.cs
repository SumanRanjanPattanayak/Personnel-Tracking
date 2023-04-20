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
            frmDepartment frm = new frmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        List<DEPARTMENT> list = new List<DEPARTMENT>();

        private void frmDepartmentList_Load(object sender, EventArgs e)
        {
            list = DepartmentBLL.GetDepartment();
            dgvDepartmentList.DataSource = list;
            dgvDepartmentList.Columns[0].Visible = false;
            dgvDepartmentList.Columns[1].HeaderText = "Department Name";
        }
    }
}
