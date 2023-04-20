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

        private void frmPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
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
        }
    }
}
