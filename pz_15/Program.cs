using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\pz\\output.txt";
            string[] str = File.ReadAllLines(path);
            Console.WriteLine("Количество строк: " + str.Length); // Выводим количество строк
            for (int i = 0; i < str.Length; i++) // Перебираем каждую строку
            {
                int x = 0;
                char[] ch = str[i].ToCharArray();
                for (int d = 0; d < ch.Length; d++) // Проверяем каждый символ на знак препинания
                {
                    if (ch[d] == '.' || ch[d] == ',' || ch[d] == '!' || ch[d] == ':' || ch[d] == '?' || ch[d] == ';') x++;
                }
                Console.WriteLine("Количество знаков препинания в " + i + " строке: " + x);

            }
        }
    }
}