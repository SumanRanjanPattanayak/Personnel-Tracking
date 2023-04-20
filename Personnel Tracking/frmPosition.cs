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
using DAL;
using DAL.DTO;

namespace PERSONNEL_TRACKING
{
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DEPARTMENT> departmentlist = new List<DEPARTMENT>();

        private void frmPosition_Load(object sender, EventArgs e)
        {
            departmentlist = DepartmentBLL.GetDepartment();
            cmbDepartment.DataSource = departmentlist;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the Position Name");
            }
            else if (cmbDepartment.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select a Department");
            }
            else
            {
                POSITION position = new POSITION();
                position.PositionName = txtPosition.Text;
                position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                BLL.PositionBLL.AddPosition(position);
                MessageBox.Show("Position was Added");
                txtPosition.Clear();
                cmbDepartment.SelectedIndex = -1;
            }
        }
    }
}
