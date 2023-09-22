﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sinh vien:");
            int n = int.Parse(Console.ReadLine());
            string[] dssinhvien = nhapsinhvien(n);
            Console.WriteLine("Danh sach sinh vien: ");
            xuatsinhvien(dssinhvien, n);
            Console.WriteLine();
            Console.ReadKey();
        }
        static string[] nhapsinhvien(int n)
        {
            string[] dssinhvien = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}: ", i + 1);
                dssinhvien[i] = Console.ReadLine();
            }

            return dssinhvien;
        }

        static void xuatsinhvien(string[] dssinhvien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien thu {0}: {1}", i + 1, dssinhvien[i]);
            }

        }

    }

}