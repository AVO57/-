using System;

namespace pz_18
{
    class Program
    {
        static int Arifm(int n, int a, int b)
        {
            if (n < 1) return 0;
            else if (n == 1) return a;
            return Arifm(n - 1, a + b, b);
        }
        static double Geom(int n, double b1, double q)
        {
            if (n < 1) return 0;
            else if (n == 1) return b1;
            return Geom(n - 1, b1 * q, q);
        }
        static void numbers(int a, int b)
        {
            if (a < b)
            {
                Console.Write(a + " ");
                numbers(a + 1, b);
            }
            else if (b < a)
            {
                Console.Write(a + " ");
                numbers(a - 1, b);
            }
            else if (b == a) Console.WriteLine(b);
            else
            {
                Console.Write("");
            }
        }
        static double Power(double a, int b)
        {
            if (b == 0) return a;
            else
            {
                return Power(Math.Pow(a, b), b - 1);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ариф. прогресия:" + Arifm(4, 55, -5));
            Console.WriteLine("Геом. прогресия:" + Geom(2, 8, 0.3));
            Console.WriteLine("№3");
            numbers(50, 200);
            Console.WriteLine('\n' + "№5 " + Power(2, 4));

        }
    }
}
