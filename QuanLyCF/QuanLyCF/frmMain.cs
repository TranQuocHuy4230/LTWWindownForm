using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCF
{
    public partial class frmMain : Form
    {
        TableFoodDAO tfDAO = new TableFoodDAO();
        public frmMain()
        {
            InitializeComponent();
            LoadTable();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }
        void LoadTable()
        {
            dgvTable.DataSource = tfDAO.LoadTableList();
        }
        //void LoadTBL()
        //{

        //    foreach(TableFood item in tfDAO.LoadTableList().Rows)
        //    {
        //        Button btn = new Button() { Width = 90, Height = 90 };
        //        flpTable.Controls.Add(btn);
        //    }
        //}
    }
}
