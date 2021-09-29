using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            while (N>1)
            {
                N /= 3;
            }
            Console.WriteLine(N == 1);
        }
    }
}
