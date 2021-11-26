using System;
using System.IO;

namespace pz_16
{
    class Program
    {
        static void SqLrt(int a, out double b, out double c, out double d)
        {
            b = Math.Sqrt(a);
            c = Math.Pow(a, 1.0/3);
            d = Math.Pow(a, 1.0/4);
            Console.WriteLine("A (2): " + $"{b:F3}");
            Console.WriteLine("A (3): " + $"{c:F3}");
            Console.WriteLine("A (4): " + $"{d:F3}");
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 2, 3, 4 }; // Я так думаю, что в условии ошибка, так как у нас "sqrt", а в конце требуют найти степени
            double[] b = new double[5];
            double[] c = new double[5];
            double[] d = new double[5];
            for (int i = 0; i <a.Length; i++)
            {
                SqLrt(a[i], out b[i], out c[1], out d[i]);
                Console.WriteLine();
            }
        }
    }
}