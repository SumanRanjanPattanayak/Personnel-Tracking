﻿using BLL;
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
    public partial class frmTask : Form
    {
        public frmTask()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TaskDTO dto = new TaskDTO();
        private bool comboFull = false;
        public bool isUpdate = false;
        public TaskDetailDTO details = new TaskDetailDTO();

        private void frmTask_Load(object sender, EventArgs e)
        {
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            comboFull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbPosition.SelectedIndex = -1;
            comboFull = true;
            cmbTaskState.DataSource = dto.TaskStates;
            cmbTaskState.DisplayMember = "StateName";
            cmbTaskState.ValueMember = "ID";
            cmbTaskState.SelectedIndex = -1;
            if (isUpdate)
            {
                txtName.Text = details.Name;
                txtUserNo.Text = details.UserNo.ToString();
                txtSurname.Text = details.Surname;
                txtTitle.Text = details.Title;
                txtContent.Text = details.Content;
                cmbTaskState.DataSource = dto.TaskStates;
                cmbTaskState.DisplayMember = "StateName";
                cmbTaskState.ValueMember = "ID";
                cmbTaskState.SelectedValue = details.TaskStateID;
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
                List<EmployeeDetailDTO> list = dto.Employees;
                dataGridView1.DataSource = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            task.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                List<EmployeeDetailDTO> list = dto.Employees;
                dataGridView1.DataSource = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            }
        }

        TASK task = new TASK();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (task.EmployeeID == 0)
            {
                MessageBox.Show("Please Select an Employee");
            }
            else if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Task Title is empty");
            }
            else if (txtContent.Text.Trim() == "")
            {
                MessageBox.Show("Content is empty");
            }
            else
            {
                if (!isUpdate)
                {
                    lblTaskState.Visible = true;
                    cmbTaskState.Visible = true;
                    task.TaskTitle = txtTitle.Text;
                    task.TaskContent = txtContent.Text;
                    task.TaskStartDate = DateTime.Today;
                    task.TaskState = 1;
                    TaskBLL.AddTask(task);
                    MessageBox.Show("Task was Added");
                    txtTitle.Clear();
                    txtContent.Clear();
                    task = new TASK();
                }
                else if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        TASK update = new TASK();
                        update.ID = details.TaskID;
                        if (Convert.ToInt32(txtUserNo.Text) != details.UserNo)
                        {
                            update.EmployeeID = task.EmployeeID;
                        }
                        else
                        {
                            update.EmployeeID = details.EmployeeID;
                        }
                        update.TaskTitle = txtTitle.Text;
                        update.TaskContent = txtContent.Text;
                        update.TaskState = Convert.ToInt32(cmbTaskState.SelectedValue);
                        TaskBLL.UpdateTask(update);
                        MessageBox.Show("Task was Updated.");
                        this.Close();
                    }
                }
            }
        }
    }
}
