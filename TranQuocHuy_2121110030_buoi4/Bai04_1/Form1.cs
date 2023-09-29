using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtHoTen.Text;
                if (ten.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống.");
                }
                lbDanhSach.Items.Add(ten);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            string chonTen = lbDanhSach.SelectedIndex.ToString();
            string chonKhoa = cbKhoa.SelectedIndex.ToString();
            if (chonKhoa == "-1")
            {
                MessageBox.Show("Vui lòng chọn khoa");

                //throw new Exception("Vui lòng chọn Khoa");
            }
            if (chonTen == "-1")
            {
                MessageBox.Show("Vui lòng chọn tên");

                //throw new Exception("Vui lòng chọn tên");
            }
            else
            {
      string hoten = lbDanhSach.SelectedItem.ToString();
                string khoa = cbKhoa.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvSinhVien.Items.Add(item);
                lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndex);
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDanhSach.Items.Add("Đinh Ngọc Hoàng");
            lbDanhSach.Items.Add("Trần Quốc Huy");
            lbDanhSach.Items.Add("Vũ Minh hiếu");
            lbDanhSach.Items.Add("Trần Minh Phát");
            cbKhoa.SelectedIndex = 0;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            int count = lbDanhSach.Items.Count;
            for (int vt=0;vt<count;vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbDanhSach.Items[vt].ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvSinhVien.Items.Add(item);
            }
            lbDanhSach.Items.Clear();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvSinhVien.Items)
            {
                if(item.Checked)
                {
                    lvSinhVien.Items.Remove(item);
                    lbDanhSach.Items.Add(item.Text);
                }    
            }    
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvSinhVien.Items)
            {
                lvSinhVien.Items.Remove(item);
                lbDanhSach.Items.Add(item.Text);
            }    
        }
    }
}
