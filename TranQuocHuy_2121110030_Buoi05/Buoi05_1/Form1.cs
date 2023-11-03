using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_1
{
    public partial class Form1 : Form
    {
        string[] dskhoa = { "Công Nghệ Thông Tin", "Kế Toán", "Công Nghệ Oto", "Ngoại Ngữ Anh" };
        int rowchoose = -1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNS.MaxDate = DateTime.Now;
            loadKhoa();
        }
        private void loadKhoa()
        {
            cbKhoa.DataSource = dskhoa;
            cbKhoa.SelectedItem = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(mtxtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên không hợp lệ!");
                }    
                if(txtHoTen.Text.Length<2)
                {
                    throw new Exception("Họ và tên ít nhất 2 ký tự");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ns = dtpNS.Text;
                string khoa = cbKhoa.Text;
                //Lưu dữ liệu dạng lưới
                int rowinfo = dgvDS.Rows.Add(masv,hoten,ns,khoa);
                //dgvDS.Rows[rowinfo].Cells["dgvMaSV"].Value = masv;
                //dgvDS.Rows[rowinfo].Cells["dgvName"].Value = hoten;
                //dgvDS.Rows[rowinfo].Cells["dgvDate"].Value = ns;
                //dgvDS.Rows[rowinfo].Cells["dgvKhoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex==-1||e.RowIndex>=dgvDS.Rows.Count-1)
                {
                    throw new Exception("Chưa chọn sinh viên.");
                }
                rowchoose = e.RowIndex;
                mtxtMaSV.Text = dgvDS.Rows[rowchoose].Cells["dgvMaSV"].Value.ToString();
                txtHoTen.Text = dgvDS.Rows[rowchoose].Cells["dgvName"].Value.ToString();
                dtpNS.Text = dgvDS.Rows[rowchoose].Cells["dgvDate"].Value.ToString();
                cbKhoa.Text = dgvDS.Rows[rowchoose].Cells["dgvKhoa"].Value.ToString();
                btnCapNhap.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDS.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên để cập nhập.");
                }
                if (mtxtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không hợp lệ!");
                }
                if (txtHoTen.Text.Length < 2)
                {
                    throw new Exception("Họ và tên ít nhất 2 ký tự");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ns = dtpNS.Text;
                string khoa = cbKhoa.Text;
                //Lưu dữ liệu dạng lưới
                dgvDS.Rows[rowchoose].Cells["dgvMaSV"].Value = masv;
                dgvDS.Rows[rowchoose].Cells["dgvName"].Value = hoten;
                dgvDS.Rows[rowchoose].Cells["dgvDate"].Value = ns;
                dgvDS.Rows[rowchoose].Cells["dgvKhoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDS.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xóa.");
                }
                dgvDS.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
