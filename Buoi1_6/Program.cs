using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int delta;
            double n1, n2;
            Console.Write("Nhap canh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                n1 = (double)-a / c;
                Console.WriteLine("Phuong trinh co 1 nghiem duy nhat: " + n1);
            }
            else 
            {
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else
                {
                    n1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                    n2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", n1, n2);
                }
            }
            Console.ReadKey();
        }
    }
}
