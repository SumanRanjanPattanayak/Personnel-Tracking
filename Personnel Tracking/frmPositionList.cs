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
    public partial class frmPositionList : Form
    {
        public frmPositionList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPosition frm = new frmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            fillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPosition frm = new frmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        List<PositionDTO> positionList = new List<PositionDTO>();

        void fillGrid()
        {
            positionList = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionList;
        }

        private void frmPositionList_Load(object sender, EventArgs e)
        {
            fillGrid();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[3].HeaderText = "Position Name";
        }
    }
}
