using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void str(string b)
    {
        Console.WriteLine(b);
    }

    static void str1(string b)
    {
        Console.WriteLine(b);
    }

    static void Main(string[] args)
    {
        Random x = new Random();
        char[][] myArray = new char[4][];
        char[] myArray0 = new char[4];
        int b = 0;
        char c = ' ';
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = new char[x.Next(5, 15)];
            for (int j = 0; j < myArray[i].Length; j++)
            {
                myArray[i][j] = (char)x.Next(128);
            }
        }
        str1("Начало: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray[i].Length; j++)
                Console.Write($"{myArray[i][j]} ");
            str($"\n\t\t\t—\n");
        }
        //Находим последние элементы
        for (int i = 0; i != 4; i++)
            myArray0[i] = myArray[i][^1];
        str1("Последние символы: ");
        for (int i = 0; i != 4; i++)
            Console.Write($"{myArray0[i]} ");
        str("\n");

        //Находим максимальные Элементы
        for (int i = 0; i != 4; i++)
            myArray0[i] = myArray[i].Max();
        str1("Максимум: ");

        for (int i = 0; i != 4; i++)
            Console.Write($"{myArray0[i]} ");
        str("\n");

        //Нахождение Индекста - Смена местами
        for (int i = 0; i != 4; i++)
            for (int j = 0; j < myArray[i].Length; j++)
            {
                if (myArray[i][j] == myArray[i].Max())
                {
                    b = Array.IndexOf(myArray[i], myArray[i][j]);
                    c = myArray[i][0];
                    myArray[i][0] = myArray[i].Max();
                    myArray[i][b] = c;
                }
            }
        str1("Новый массив: ");

        for (int i = 0; i != 4; i++)
        {
            for (int j = 0; j < myArray[i].Length; j++)
                Console.Write($"{myArray[i][j]} ");
            str($"\n\t\t\t—\n");
        }


    }
}
}