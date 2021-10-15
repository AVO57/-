using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] C = new int[5];// Массив для Главной Диагонали Матрицы

            int[,] A = new int[5, 5]; // Двумерный Массив
            Console.WriteLine("Матрица Х:");
            Random rnd = new Random(); // Класс Random
            for (i = 0; i <= 4; i++) // Строчки
            {
                for (j = 0; j <= 4; j++) // Столбцы
                {
                    A[i, j] = rnd.Next(10, 90); // Рандомные Числа для Записи в Массив
                    Console.Write(A[i, j] + " "); // Вывод

                }
                Console.WriteLine();

            }
            Console.WriteLine("Элементы главной диагонали:");
            for (i = 0; i <= 4; i++) // Строчки
            {
                for (j = 0; j <= 4; j++) // Стольбцы
                {
                    if (i == j) // Главная Диагональ - Проверка
                    {
                        C[i] = A[i, j];

                    }


                }
                Console.Write(C[i] + " "); // Вывод

            }
            Console.WriteLine(" ");
            Array.Sort(C); // Сортировка Главной Диагонали
            Console.WriteLine("Максимальный элемент: " + C[4]); // Максимальное Число - Вывод
            Console.ReadLine();
        }

    }
}