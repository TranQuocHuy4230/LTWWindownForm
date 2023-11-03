using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06_1
{
    public partial class QLKhoa : Form
    {
        string insertupdate = "";
        KhoaDAO khDao = new KhoaDAO();

        public QLKhoa()
        {
            InitializeComponent();
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            loadDSKhoa();
        }
        private void loadDSKhoa()
        {
            dataGridView1.DataSource = khDao.getList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnSave.Enabled = true;
            txtbKhoa.Enabled = true;
            //txtbMK.ReadOnly = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnSave.Enabled = true;
            txtbKhoa.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbKhoa.Text.Length == 0)
                {
                    throw new Exception("Mã Khoa không được để chống");
                }
                if (txtbName.Text.Length == 0)
                {
                    throw new Exception("Tên khoa không được để chống");
                }
                string makhoa = txtbKhoa.Text;
                string hoten = txtbName.Text;
                string note = txtbNote.Text;
                Khoa k = new Khoa(makhoa, hoten, note);
                //Khoa k = new Khoa(makhoa, hoten);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            khDao.InsertTwo(k);
                            loadDSKhoa();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            khDao.UpdateTwo(k);
                            loadDSKhoa();
                            MessageBox.Show("cập nhật thành công", "thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhoa = txtbKhoa.Text;
                khDao.DeleteTwo(maKhoa);
                loadDSKhoa();
                MessageBox.Show("Xóa thành công", "thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dataGridView1.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                txtbKhoa.Text = dataGridView1.Rows[rowindex].Cells["MaKhoa"].Value.ToString();
                txtbName.Text = dataGridView1.Rows[rowindex].Cells["TenKHoa"].Value.ToString();
                txtbNote.Text = dataGridView1.Rows[rowindex].Cells["GhiChu"].Value.ToString();
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
