using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string thongtin = null;
            int stt = 1;
            try
            {
                if (mtxtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không hợp lệ.");
                }
                if (mtxtHoTen.Text.Length==0)
                {
                    throw new Exception("Tên không được để trống.");
                }
                if (mxtNgaySinh.Text.Length != 10)
                {
                    throw new Exception("Nhày sinh không hợp lệ.");
                }
                string masv = mtxtMaSV.Text;
                string hoten = mtxtHoTen.Text;
                string ngaysinh = mxtNgaySinh.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sotich = null;
                if(chbDuLich.Checked)
                {
                    sotich += "Du Lịch";
                }
                if (chbMuaSam.Checked)
                {
                    sotich += "Mua Sắm";
                }
                if (chbTheThao.Checked)
                {
                    sotich += "Thể Thao";
                }
                if (sotich !=null)
                {
                    sotich = "Sở thích: "+sotich;
                }
                thongtin += stt+". Họ tên: " + hoten +" Ngày sinh: " + ngaysinh +" Giới tính: " + gioitinh + "\r\n" + " Sở thích: " + sotich;
                lbShow.Text = thongtin;
                stt++;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int stt = 1;
            string thongtin = null;
            lbShow.Text = String.Empty;
        }
    }
}
