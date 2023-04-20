using BLL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONNEL_TRACKING
{
    public partial class frmPermission : Form
    {
        public frmPermission()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TimeSpan PermissionDay;
        public bool isUpdate = false;
        public PermissionDetailDTO detail = new PermissionDetailDTO();

        private void frmPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
            if (isUpdate)
            {
                dtpStart.Value = detail.StartDate;
                dtpFinish.Value = detail.EndDate;
                txtxDayAmount.Text = detail.PermissionDayAmount.ToString();
                txtExplanation.Text = detail.Explanation;
                txtUserNo.Text = detail.UserNo.ToString();
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dtpFinish.Value.Date-dtpStart.Value.Date;
            txtxDayAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void dtpFinish_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dtpFinish.Value.Date - dtpStart.Value.Date;
            txtxDayAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtxDayAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please Select a valid Date");
            }
            else if (Convert.ToInt32(txtxDayAmount.Text) <= 0)
            {
                MessageBox.Show("Permission Day must be greater Than 0");
            }
            else if (txtExplanation.Text.Trim() == "")
            {
                MessageBox.Show("Enter an explanation!");
            }
            else
            {
                PERMISSION permission = new PERMISSION();
                if (!isUpdate)
                {
                    permission.EmployeeID = UserStatic.EmployeeID;
                    permission.PermissionState = 1;
                    permission.PermissionStartDate = dtpStart.Value.Date;
                    permission.PermissionEndDate = dtpFinish.Value.Date;
                    permission.PermissionDay = Convert.ToInt32(txtxDayAmount.Text);
                    permission.PermissionExplanation = txtExplanation.Text;
                    PermissionBLL.AddPermission(permission);
                    MessageBox.Show("Permission was Added");
                    permission = new PERMISSION();
                    dtpStart.Value = DateTime.Today;
                    dtpFinish.Value = DateTime.Today;
                    txtxDayAmount.Clear();
                    txtExplanation.Clear();
                }
                else if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you Sure!","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        permission.ID = detail.PermissionID;
                        permission.PermissionExplanation = txtExplanation.Text;
                        permission.PermissionStartDate = dtpStart.Value;
                        permission.PermissionEndDate = dtpFinish.Value;
                        permission.PermissionDay = Convert.ToInt32(txtxDayAmount.Text);
                        PermissionBLL.UpdatePermission(permission);
                        MessageBox.Show("Permission was updated");
                        this.Close();
                    }
                }
            }
        }
    }
}
