using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string thongtin = null;
            int stt = 1;
            try
            {
                if (mtbMaSach.Text.Length != 6)
                {
                    throw new Exception("Mã sách không hợp lệ.");
                }
                if (txtTenSach.Text == "")
                {
                    throw new Exception("Vui lòng nhập tên sách.");
                }
                double chonGia = Convert.ToDouble(cbGia.SelectedIndex.ToString());
                if (chonGia == -1)
                {
                    MessageBox.Show("Vui lòng chọn giá");

                    //throw new Exception("Vui lòng chọn Khoa");
                }
                if (nudSoLuong.Value == 0)
                {
                    MessageBox.Show("Số lượng mua ít nhất là 1.");

                }
                string masach = mtbMaSach.Text;
                string tensach = txtTenSach.Text;
                int gia = Convert.ToInt32(cbGia.SelectedItem.ToString());
                double soluong = Convert.ToDouble(nudSoLuong.Value.ToString());
                thongtin += stt + ".  Mã Sách: " + masach + "  Tên Sách: " + tensach + "  Giá: " + gia + "  Số Lượng: " + soluong + "\r\n";
                lbDS.Text = thongtin;
                stt++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            int stt = 1;
            string thongtin = null;
            lbDS.Text = String.Empty;
        }
    }
}
