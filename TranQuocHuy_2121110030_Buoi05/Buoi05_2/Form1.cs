using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_2
{
    public partial class Form1 : Form
    {
        int rowIndex = -1;
        String[] listKhoa = { "Công Nghệ Thông Tin", "Kế Toán", "Ngoại Ngữ Anh", "Điện Tử" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listKhoa;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if(mtxtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên không hợp lệ!");
                }
                if(this.checkMaSV(mtxtMaSV.Text)==false)
                {
                    throw new Exception("Mã sinh viên không hợp lệ!");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ và tên không được để trống.");

                }
                if(!double.TryParse(txtDTB.Text,out diemtb))
                {
                    throw new Exception("Vui Lòng nhập số.");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa  = cbKhoa.Text;
                int row = dgvDS.Rows.Add();
                dgvDS.Rows[row].Cells["MaSV"].Value = masv;
                dgvDS.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDS.Rows[row].Cells["DiemTB"].Value = diemtb;
                dgvDS.Rows[row].Cells["Khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
           
        }
        public bool checkMaSV(string masv)
        {
            if(dgvDS.Rows.Count==0)
            {
                return true;
            }    
            for(int row =0;row<dgvDS.Rows.Count-1; row++)
            {
                if(dgvDS.Rows[row].Cells["MaSV"].Value.ToString()==masv)
                {
                    return false;   
                }
            }
            return true;
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex != -1 && rowIndex < dgvDS.Rows.Count - 1)
            {
                mtxtMaSV.Text = dgvDS.Rows[rowIndex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDS.Rows[rowIndex].Cells["HoTen"].Value.ToString();
                txtDTB.Text = dgvDS.Rows[rowIndex].Cells["DiemTB"].Value.ToString();
                string tenkhoa = dgvDS.Rows[rowIndex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while(i<listKhoa.Length&&listKhoa[i]!=tenkhoa)
                {
                    i++;
                }
                cbKhoa.SelectedIndex = i;
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (mtxtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên không hợp lệ!");
                }
                if (this.checkMaSV(mtxtMaSV.Text) == false&&mtxtMaSV.Text!=dgvDS.Rows[rowIndex].Cells["MaSV"].Value.ToString())
                {
                    throw new Exception("Mã sinh viên đã tồn tại.");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ và tên không được để trống.");

                }
                if (!double.TryParse(txtDTB.Text, out diemtb))
                {
                    throw new Exception("Vui Lòng nhập số.");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                dgvDS.Rows[rowIndex].Cells["MaSV"].Value = masv;
                dgvDS.Rows[rowIndex].Cells["HoTen"].Value = hoten;
                dgvDS.Rows[rowIndex].Cells["DiemTB"].Value = diemtb;
                dgvDS.Rows[rowIndex].Cells["Khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(rowIndex==-1||rowIndex>=dgvDS.Rows.Count-1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xóa!");
                }
                dgvDS.Rows.RemoveAt(rowIndex);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
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
