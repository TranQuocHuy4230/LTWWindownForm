using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_03
{
    class Teacher : Person
    {
        public string MaGV { get; set; }
        public string Khoa { get; set; }
        public string ChucVu { get; set; }
        public Teacher(){}
        public Teacher(string cmnd,string magv, string hoten, string dc, string khoa, string cv)
        {
            this.CMND = cmnd;
            this.MaGV = magv;
            this.HoTen = hoten;
            this.DiaChi = dc;
            this.Khoa = khoa;
            this.ChucVu = cv;
        }
        public void NhapSV()
        {
            Console.Write("Nhập CMND giáo viên: ");
            CMND = Console.ReadLine();
            Console.Write("Nhập mã số giáo viên: ");
            MaGV = Console.ReadLine();
            Console.Write("Nhập họ tên giáo viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ giáo viên: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhập điểm trung bình: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhập khóa: ");
            ChucVu = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("CMND: {0}, MaSV: {1}, HoTen: {2},DiaChi: {3}, Khoa: {4}, Chucvu: {5}", CMND, MaGV, HoTen, DiaChi, Khoa, ChucVu);
        }
    }
}
