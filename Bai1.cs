using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class b1ctdl
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;
            int min = b;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            if (b < min)
                min = b;
            if (c < min)
                min = c;

            int sum = a + b + c;
            double average = sum / 3.0;
            Console.WriteLine("Lon nhat: " + max);
            Console.WriteLine("Nho nhat: " + min);
            Console.WriteLine("Tong: " + sum);
            Console.WriteLine("Trung Binh: {average : F2}");
        }
    }
}
