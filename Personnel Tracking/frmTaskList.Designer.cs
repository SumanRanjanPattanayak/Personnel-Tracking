namespace PERSONNEL_TRACKING
{
    partial class frmTaskList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlForAllUsers = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDeliveryDate = new System.Windows.Forms.RadioButton();
            this.rbStartDate = new System.Windows.Forms.RadioButton();
            this.lblTaskState = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlForAllUsers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlForAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlForAllUsers);
            this.panel1.Controls.Add(this.pnlForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 149);
            this.panel1.TabIndex = 0;
            // 
            // pnlForAllUsers
            // 
            this.pnlForAllUsers.Controls.Add(this.btnClear);
            this.pnlForAllUsers.Controls.Add(this.btnSearch);
            this.pnlForAllUsers.Controls.Add(this.cmbTaskState);
            this.pnlForAllUsers.Controls.Add(this.groupBox1);
            this.pnlForAllUsers.Controls.Add(this.lblTaskState);
            this.pnlForAllUsers.Controls.Add(this.dtpFinish);
            this.pnlForAllUsers.Controls.Add(this.dtpStart);
            this.pnlForAllUsers.Controls.Add(this.lblFinish);
            this.pnlForAllUsers.Controls.Add(this.lblStart);
            this.pnlForAllUsers.Controls.Add(this.lblTaskDate);
            this.pnlForAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForAllUsers.Location = new System.Drawing.Point(282, 0);
            this.pnlForAllUsers.Name = "pnlForAllUsers";
            this.pnlForAllUsers.Size = new System.Drawing.Size(381, 149);
            this.pnlForAllUsers.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(251, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(163, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(119, 88);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(126, 21);
            this.cmbTaskState.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeliveryDate);
            this.groupBox1.Controls.Add(this.rbStartDate);
            this.groupBox1.Location = new System.Drawing.Point(251, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 46);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rbDeliveryDate
            // 
            this.rbDeliveryDate.AutoSize = true;
            this.rbDeliveryDate.Location = new System.Drawing.Point(7, 29);
            this.rbDeliveryDate.Name = "rbDeliveryDate";
            this.rbDeliveryDate.Size = new System.Drawing.Size(89, 17);
            this.rbDeliveryDate.TabIndex = 1;
            this.rbDeliveryDate.TabStop = true;
            this.rbDeliveryDate.Text = "Delivery Date";
            this.rbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            this.rbStartDate.AutoSize = true;
            this.rbStartDate.Location = new System.Drawing.Point(7, 8);
            this.rbStartDate.Name = "rbStartDate";
            this.rbStartDate.Size = new System.Drawing.Size(73, 17);
            this.rbStartDate.TabIndex = 0;
            this.rbStartDate.TabStop = true;
            this.rbStartDate.Text = "Start Date";
            this.rbStartDate.UseVisualStyleBackColor = true;
            // 
            // lblTaskState
            // 
            this.lblTaskState.AutoSize = true;
            this.lblTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskState.Location = new System.Drawing.Point(6, 88);
            this.lblTaskState.Name = "lblTaskState";
            this.lblTaskState.Size = new System.Drawing.Size(96, 20);
            this.lblTaskState.TabIndex = 8;
            this.lblTaskState.Text = "Task State";
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(119, 62);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(126, 20);
            this.dtpFinish.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(119, 38);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(126, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(6, 62);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(57, 20);
            this.lblFinish.TabIndex = 9;
            this.lblFinish.Text = "Finish";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(6, 36);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(49, 20);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "Start";
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.AutoSize = true;
            this.lblTaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDate.Location = new System.Drawing.Point(6, 12);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(91, 20);
            this.lblTaskDate.TabIndex = 9;
            this.lblTaskDate.Text = "Task Date";
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.cmbPosition);
            this.pnlForAdmin.Controls.Add(this.txtSurname);
            this.pnlForAdmin.Controls.Add(this.lblPosition);
            this.pnlForAdmin.Controls.Add(this.txtName);
            this.pnlForAdmin.Controls.Add(this.cmbDepartment);
            this.pnlForAdmin.Controls.Add(this.lblSurName);
            this.pnlForAdmin.Controls.Add(this.lblDepartment);
            this.pnlForAdmin.Controls.Add(this.txtUserNo);
            this.pnlForAdmin.Controls.Add(this.lblName);
            this.pnlForAdmin.Controls.Add(this.lblUserNo);
            this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(282, 149);
            this.pnlForAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(132, 117);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(100, 21);
            this.cmbPosition.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(132, 64);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(22, 117);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(73, 20);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Position";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(132, 90);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(100, 21);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurName.Location = new System.Drawing.Point(22, 62);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(81, 20);
            this.lblSurName.TabIndex = 7;
            this.lblSurName.Text = "Surname";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(22, 88);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(104, 20);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(132, 12);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(100, 20);
            this.txtUserNo.TabIndex = 0;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNo.Location = new System.Drawing.Point(22, 12);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(74, 20);
            this.lblUserNo.TabIndex = 9;
            this.lblUserNo.Text = "User No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnApprove);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(445, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(357, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(269, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(81, 31);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(94, 44);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(181, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 201);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // frmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaskList";
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.frmTaskList_Load);
            this.panel1.ResumeLayout(false);
            this.pnlForAllUsers.ResumeLayout(false);
            this.pnlForAllUsers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlForAllUsers;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserNo;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDeliveryDate;
        private System.Windows.Forms.RadioButton rbStartDate;
        private System.Windows.Forms.Label lblTaskState;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}