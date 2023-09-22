using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, hieu;
            long tong, tich;
            double thuong = 0;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            if (b != 0)
            {
                thuong = (double)a / b;
            }
            Console.WriteLine("Tong = {0}, Hieu = {1}", tong, hieu);
            Console.WriteLine("Tich = {0}, Thuong = {1}", tich, thuong);
            Console.ReadKey();
        }
    }
}
