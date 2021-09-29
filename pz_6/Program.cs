using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            while (N <= 0)
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            int a = 3;
       
            if (N/a!=0)
                Console.WriteLine ("True");
            else
                Console.WriteLine("False");

        }
    }
}
