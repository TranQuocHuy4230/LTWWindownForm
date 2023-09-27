using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_03
{
    class Student:Person
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }
        public Student() { }
        public Student(string cmnd, string masv, string hoten, string dc, double dtb, string khoa)
        {
            this.CMND = cmnd;
            this.MaSV = masv;
            this.HoTen = hoten;
            this.DiaChi = dc;
            this.DiemTB = dtb;
            this.Khoa = khoa;
        }
        public void NhapSV()
        {
            Console.Write("Nhập CMND sinh vien: ");
            CMND = Console.ReadLine();
            Console.Write("Nhập mã số sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhập họ tên sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ sinh vien: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhập điểm trung bình: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập khóa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("CMND: {0}, MaSV: {1}, HoTen: {2},DiaChi: {3}, DiemTB: {4}, Khoa: {5}",CMND, MaSV, HoTen,DiaChi, DiemTB, Khoa);
        }
    }
}
