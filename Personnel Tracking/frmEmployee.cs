using BLL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONNEL_TRACKING
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        EmployeeDTO dto = new EmployeeDTO();
        public EmployeeDetailDTO details = new EmployeeDetailDTO();
        public bool isUpdate = false;
        string imagepath = "";

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbPosition.SelectedIndex = -1;
            comboFull = true;
            if (isUpdate)
            {
                txtName.Text = details.Name;
                txtSurname.Text = details.Surname;
                txtUserNo.Text = details.UserNo.ToString();
                txtPassword.Text = details.Password;
                chkAdmin.Checked = Convert.ToBoolean(details.isAdmin);
                txtAddress.Text = details.Address;
                dateTimePicker1.Value = Convert.ToDateTime(details.BirthDay);
                cmbDepartment.SelectedValue = details.DepartmentID;
                cmbPosition.SelectedValue = details.PositionID;
                txtSalary.Text = details.Salary.ToString();
                imagepath = Application.StartupPath + "\\Images\\" + details.ImagePath;
                txtImagePath.Text = imagepath;
                pictureBox1.ImageLocation = imagepath;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        bool comboFull = false;

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmentID =  Convert.ToInt32(cmbDepartment.SelectedValue);
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
            }
        }

        string fileName = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                string unique = Guid.NewGuid().ToString();
                fileName += unique + openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
            {
                MessageBox.Show("UserNo is Empty!");
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password is Empty!");
            }
            else if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name is Empty!");
            }
            else if (txtSurname.Text.Trim() == "")
            {
                MessageBox.Show("Surname is Empty!");
            }
            else if (txtSalary.Text.Trim() == "")
            {
                MessageBox.Show("Salary is Empty!");
            }
            else if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Select a department!");
            }
            else if (cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Select a position!");
            }
            else
            {
                if (!isUpdate)
                {
                    if (!EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
                    {
                        MessageBox.Show("This UserNo is not Available. Please try another");  
                    }
                    else 
                    {
                        EMPLOYEE employee = new EMPLOYEE();
                        employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                        employee.isAdmin = chkAdmin.Checked;
                        employee.Password = txtPassword.Text;
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Address = txtAddress.Text;
                        employee.BirthDay = dateTimePicker1.Value;
                        employee.ImagePath = fileName;
                        EmployeeBLL.AddEmployee(employee);
                        File.Copy(txtImagePath.Text, @"Images\\" + fileName);
                        MessageBox.Show("Employee was Added");
                        txtUserNo.Clear();
                        txtPassword.Clear();
                        txtSalary.Clear();
                        chkAdmin.Checked = false;
                        txtName.Clear();
                        txtSurname.Clear();
                        txtAddress.Clear();
                        txtImagePath.Clear();
                        pictureBox1.Image = null;
                        comboFull = false;
                        cmbDepartment.SelectedIndex = -1;
                        cmbPosition.SelectedIndex = -1;
                        cmbPosition.DataSource = dto.Positions;
                        comboFull = true;
                        dateTimePicker1.Value = DateTime.Today;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you Sure", "Warning!",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        EMPLOYEE employee = new EMPLOYEE();
                        if (txtImagePath.Text != imagepath)
                        {
                            if (File.Exists(@"Images\\" + details.ImagePath))
                            {
                                File.Delete(@"Images\\" + details.ImagePath);
                            }
                            File.Copy(txtImagePath.Text, @"Images\\" + fileName);
                            employee.ImagePath = fileName;
                        }
                        else
                        {
                            employee.ImagePath = details.ImagePath;
                        }
                        employee.ID = details.EmployeeID;
                        employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.isAdmin = chkAdmin.Checked;
                        employee.Password = txtPassword.Text;
                        employee.Address = txtAddress.Text;
                        employee.BirthDay = dateTimePicker1.Value;
                        employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        EmployeeBLL.UpdateEmployee(employee);
                        MessageBox.Show("Employee was Updated");
                        this.Close();
                    }
                }
            }
        }

        bool isUnique = false;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
            {
                MessageBox.Show("UserNo is Empty!");
            }
            else 
            {
                isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text));
                if (!isUnique)
                {
                    MessageBox.Show("This UserNo is not Available. Please try another");
                }
                else
                {
                    MessageBox.Show("This UserNo is Available.");
                }
            }
        }
    }
}
