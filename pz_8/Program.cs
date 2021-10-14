using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];
            int[] b = new int[10];
            Console.Write("Исходный массив:");
            for (int i = 0; i < 10; i++) //Заполняем массив случайными данными
            {
                a[i] = rnd.Next(-10, 11);
                Console.Write(" " + a[i]);
            }
            Console.WriteLine();
            Console.Write("Массив после изменений:");
            for (int i = 0; i < 5; i++)
            {
                b[i] = a[4 - i];
            }
            for (int i = 0; i < 5; i++)
            {
                b[i + 5] = a[9 - i];

            }
            for (int i = 0; i < 10; i++)
            {
                a[i] = b[i];
                Console.Write(" " + a[i]);
            }
        }
    }
}