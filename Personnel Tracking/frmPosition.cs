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
        public PositionDTO detail = new PositionDTO();
        public bool isUpdate = false;

        private void frmPosition_Load(object sender, EventArgs e)
        {
            departmentlist = DepartmentBLL.GetDepartment();
            cmbDepartment.DataSource = departmentlist;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            if (isUpdate)
            {
                txtPosition.Text = detail.PositionName;
                cmbDepartment.SelectedValue = detail.DepartmentID;
            }
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
                if (!isUpdate)
                {
                    POSITION position = new POSITION();
                    position.PositionName = txtPosition.Text;
                    position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    BLL.PositionBLL.AddPosition(position);
                    MessageBox.Show("Position was Added");
                    txtPosition.Clear();
                    cmbDepartment.SelectedIndex = -1;
                }
                else 
                {
                    POSITION position = new POSITION();
                    position.ID = detail.ID;
                    position.PositionName = txtPosition.Text;
                    position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    bool control = false;
                    if (Convert.ToInt32(cmbDepartment.SelectedValue) != detail.OldDepartmentID)
                    {
                        control = true;
                    }
                    PositionBLL.UpdatePosition(position, control);
                    MessageBox.Show("Position was Updated");
                    this.Close();
                }
            }
        }
    }
}
