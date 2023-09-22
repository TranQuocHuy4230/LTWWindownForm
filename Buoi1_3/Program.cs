using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            long tong=0;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 2*a-1; i++)
            {
                if (i % 2 != 0)
                {
                    tong = tong + i;
                }
            }
            Console.WriteLine("Tong = "+ tong);
            Console.ReadKey();

        }
    }
}
