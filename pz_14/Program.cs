using System;
using System.IO;

namespace Sobes
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\pz\\output.txt";
            StreamWriter sw = new StreamWriter(path);
            string read = Console.ReadLine();
            while (read != "")
            {
                sw.WriteLine(read); // Записываем в файл строку
                                    // Если файл отстутвовал, то создаётся автоматически
                read = Console.ReadLine();
            }
            sw.Close();
            Console.WriteLine("Операция завершена!"); // Операция завершена

        }
    }
}