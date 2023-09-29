using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if(!double.TryParse(txtSoA.Text,out a))
                {
                    throw new Exception("Số A khong được để trống hoặc phải là số.");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B khong được để trống hoặc phải là số.");
                }
                txtKetQua.Text = (a + b).ToString();
            }
            catch(Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A khong được để trống hoặc phải là số.");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B khong được để trống hoặc phải là số.");
                }
                txtKetQua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A khong được để trống hoặc phải là số.");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B khong được để trống hoặc phải là số.");
                }
                txtKetQua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A khong được để trống hoặc phải là số.");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B khong được để trống hoặc phải là số.");
                }
                if(b>0)
                {
                    txtKetQua.Text = (a / b).ToString();
                }else
                {
                    throw new Exception("Số B phải lớn hơn 0.");
                }    
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
