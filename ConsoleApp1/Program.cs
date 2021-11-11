using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввдите текста: \t");

            string str = Console.ReadLine();
            string strrev = "";

            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + "";
            }
            Console.WriteLine(strrev);
            Console.ReadKey();
        }
    }
}
