using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Bai2
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 2 || n > 100000)
            {
                Console.WriteLine("n phai nam trong khoang tu 2 den 100000");
                return;
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap a[i]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            // tim so lon nhat thu 1
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            // tim so lon thu 2
            int second = 0;
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < max)
                {
                    if (!found || a[i] > second)
                    {
                        second = a[i];
                        found = true;
                    }
                }
            }
            Console.WriteLine($"So lon nhat: {max}");
            if (found)
            {
                Console.WriteLine($"So lon thu hai: {second}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}