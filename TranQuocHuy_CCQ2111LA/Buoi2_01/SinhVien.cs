using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_01
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public SinhVien() {  }
        public SinhVien(string masv, string hoten, double diem, string khoa)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.DiemTB = diem;
            this.Khoa = khoa;
        }
        public void NhapSV()
        {
            Console.Write("Nhập mã số sinh vien: ");
            MaSV=Console.ReadLine();
            Console.Write("Nhập họ tên sinh vien: ");
            HoTen=Console.ReadLine();
            Console.Write("Nhập điểm trung bình: ");
            DiemTB=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập khóa: ");
            Khoa=Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV: {0}, HoTen: {1}, DiemTB: {2}, Khoa: {3}", MaSV, HoTen, DiemTB, Khoa);
        }
    }
}
