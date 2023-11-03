using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06_3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSp_Click(object sender, EventArgs e)
        {
            Form form = new frmSach();
            form.ShowDialog();
        }

        private void btnloaiSach_Click(object sender, EventArgs e)
        {
            Form form = new frmLoaiSach();
            form.ShowDialog();
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            Form form = new frmNXB();
            form.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            Form form = new frmNhanVien();
            form.ShowDialog();
        }
    }
}
