using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double P = 0, S = 0;
            Console.Write("Nhap canh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (((a+b)>c) && ((a+c)>b) &&((b+c)>a))
            {
                P = a + b + c;
                S = Math.Sqrt(P * (P - a) * (P - b )* (P - c));
            }
            else
            {
                Console.WriteLine("Khong phai la 3 canh cua tam giac.");
            }
            Console.WriteLine("Chu vi: {0}, Dien tich: {1}", P, S);
            Console.ReadKey();
        }
    }
}
