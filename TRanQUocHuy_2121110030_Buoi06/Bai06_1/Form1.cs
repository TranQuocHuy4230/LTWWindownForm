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
    public partial class Form1 : Form
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        KhoaDAO khDao = new KhoaDAO();
        string insertupdate = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            mtxtMaSV.Enabled = false;
            btnDelete.Enabled = false;
            loadDSSinhVien();
            loadDSKhoa();
            TongSinhVien();
        }
        private void loadDSSinhVien()
        {
            dgvDS.DataSource = svDAO.getList();
        }
        private void loadDSKhoa()
        {
            cbKhoa.DataSource = khDao.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        private void TongSinhVien()
        {
            txtTongSV.Text = svDAO.getCount().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnSave.Enabled = true;
            mtxtMaSV.Enabled = true;
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnSave.Enabled = true;
            mtxtMaSV.Enabled = false;
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDS.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }
                mtxtMaSV.Text = dgvDS.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtName.Text = dgvDS.Rows[rowindex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = dgvDS.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtDiemTB.Text = dgvDS.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                if(mtxtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên phải có 10 kí tự số.");
                }
                if(!double.TryParse(txtDiemTB.Text,out diemtb))
                {
                    throw new Exception("Điểm trung bình không hợp lệ!");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtName.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv = new SinhVien(masv, hoten, makhoa, diemtb);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            svDAO.Insert(sv);
                            loadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Thêm thành công.", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            svDAO.Update(sv);
                            loadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Cập nhập thành công.", "Thông báo");
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(mtxtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên không chính xác!");
                }
                string masv = mtxtMaSV.Text;
                svDAO.Delete(masv);
                loadDSSinhVien();
                TongSinhVien();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
            dgvDS.DataSource = svDAO.getList(makhoa);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
