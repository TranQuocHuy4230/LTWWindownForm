using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập tổng số sinh viên: ");
            int n = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSinhVien = new SinhVien[n];
            Console.Write("---------------Nhập Thông Tin Sinh Viên----------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập sinh viên thứ {0}: \n", i + 1);
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].NhapSV();
            }
            Console.Write("---------------Xuất Thông Tin Sinh Viên----------------\n");
            foreach (SinhVien sv in arrSinhVien)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
        }
    }
}
