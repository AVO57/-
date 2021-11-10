using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string InputString; // Обозначение переменной
            InputString = Console.ReadLine(); // Вводим текст, который хотим сделать нормированным
            Console.WriteLine(String.Join(" ", InputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))); // Удаление лишних пробелов
        }
    }
}
