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
    public partial class frmChangePass : Form
    {
        AccountDAO accDAO = new AccountDAO();
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = txtNPass.Text;
                Account acc = new Account("",pass,"");

                accDAO.Update(acc);
                MessageBox.Show("Cập nhập thành công.", "Thông báo");
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Cập nhập mật khẩu thành công.", "Thông báo");
        }
    }
}
