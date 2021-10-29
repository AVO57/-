using System;

namespace pz_10
{
    class Program
    {
        static void str(string b)
        {
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            Random x = new Random();
            char[][] myArray = new char[4][];
            char[] myArray0 = new char[4];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new char[x.Next(5, 15)];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = (char)x.Next(128);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write($"{myArray[i][j]} ");
                }
                str($"\n—\n");
            }
            for (int i = 0; i != 4; i++)
                myArray0[i] = myArray[i][^1];
            str("Последний символ: ");
            for (int i = 0; i != 4; i++)
                Console.Write($"{myArray0[i]} ");
            str("");
        }
    }
}
