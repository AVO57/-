using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string InputString;
            InputString = Console.ReadLine();
            Console.WriteLine(String.Join(" ", InputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
        }
    }
}
