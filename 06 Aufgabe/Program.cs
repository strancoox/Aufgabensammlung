﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine("-----------");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
