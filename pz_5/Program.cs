﻿using System;
// Григорян Э. 2ПК2
namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1
            Console.WriteLine("Задание №1");
            int x;
            for (x = 20; x <= 80; x += 5)
            {
                Console.WriteLine(x);
            }
            // Задание №2

            Console.WriteLine();
            Console.WriteLine("Задание №2");

            char simvol = 'G';
            for (var i = 0; i < 5; i++)
            {
                Console.Write(simvol);
                simvol++;
            }

            // Задание №3
            Console.WriteLine();
            Console.WriteLine("Задание №3");
            var j1 = '#';
            for (int i4 = 0; i4 != 6; i4++)
            {
                for (int i0 = 0; i0 != 5; i0++)
                {
                    Console.Write(j1);
                }
                Console.WriteLine();
            }



            // Задание №4
            Console.WriteLine();
             Console.WriteLine("Задание №4");
                    for (int p = 1; p != 100; p++)
                    {
                        var cc = p % 6;
                        if (cc == 0)
                        {
                            Console.WriteLine(p);
                        }
                    }

             // Задание №5
             Console.WriteLine();
             Console.WriteLine("Задание №5");
             int j3 = 40;
             for (int i = 4; i < j3 + 24; i++)
              {
               Console.WriteLine(i + " " + j3);
                j3--;
              }




                
            }
        }
    }

