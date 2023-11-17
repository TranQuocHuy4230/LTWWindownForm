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
    public partial class frmAccountProfile : Form
    {
        AccountDAO accDAO = new AccountDAO();
        public frmAccountProfile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmChangePass f = new frmChangePass();
            this.Hide();
            f.ShowDialog();
        }

        private void frmAccountProfile_Load(object sender, EventArgs e)
        {
            loadAcc();
        }
        private void loadAcc()
        {
            //accDAO.LoadAccList();
            //txtDisplayName.DataBindings.Add("Text", ); 
            //txtUsername.Text = "UserName";
        }
    }
}
