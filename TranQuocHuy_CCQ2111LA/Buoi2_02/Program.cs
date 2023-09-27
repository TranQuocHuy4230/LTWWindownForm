using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_02
{
    class Program
    {
        private static List<SinhVien> NhapDSSV()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.Write("Nhập tổng số sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("---------------Nhập Thông Tin Sinh Viên----------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập sinh viên thứ {0}: \n", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }
        private static void XuatDSSV(List<SinhVien> listSinhVien)
        {
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }
        private static void DSSVCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT");
            }
            else
            {
                Console.Write("---------------Xuất Thông Tin Sinh Viên Khoa CNTT----------------\n");
                XuatDSSV(listCNTT);
            }
        }
        private static void SVDTBLonHon5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = (from s in listSinhVien where s.DiemTB >= 5 select s).ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("Không có Sinh Viên có điểm trên 5.");
            }
            else
            {
                Console.Write("---------------Xuất Thông Tin Sinh Viên Có DTB Lớn Hơn 5----------------\n");

                XuatDSSV(listSV);
            }
        }
        private static void SapXepDSSV(List<SinhVien> listSInhVien)
        {
            List<SinhVien> listSV = listSInhVien.OrderBy(p => p.DiemTB).ToList();
            Console.Write("---------------Xuất Thông Tin Sinh Viên Theo ĐTB----------------\n");

            XuatDSSV(listSV);
        }
        private static void SVCNTTDTBHon5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).Where(p => p.Khoa == "CNTT").ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên nào của khoa CNTT có điểm trung bình trên 5.");
            }
            else
            {
                Console.Write("---------------Xuất Thông Tin Sinh Viên Khoa CNTT Có Điểm Lớn Hơn 5----------------\n");

                XuatDSSV(listSV);
            }
        }
        private static void SVDTBLonNhat(List<SinhVien> listSinhVIen)
        {
            double diemMax = listSinhVIen.Where(p => p.Khoa == "CNTT").Max(p => p.DiemTB);
            List<SinhVien> listSV = listSinhVIen.Where(p => p.Khoa == "CNTT" && p.DiemTB >= diemMax).ToList();
            Console.Write("---------------Xuất Thông Tin Sinh Viên Khoa CNTT Có ĐTB Lớn Nhất----------------\n");

            XuatDSSV(listSV);
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<SinhVien> listSinhVIen = NhapDSSV();
            Console.Write("---------------Xuất Thông Tin Sinh Viên----------------\n");
            XuatDSSV(listSinhVIen);
            DSSVCNTT(listSinhVIen);
            SVDTBLonHon5(listSinhVIen);
            SapXepDSSV(listSinhVIen);
            SVCNTTDTBHon5(listSinhVIen);
            SVDTBLonNhat(listSinhVIen);
            Console.ReadKey();
        }
    }
}
