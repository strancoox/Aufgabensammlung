using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace _11_Aufgabe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Wie lange soll die Linie sein?: ");
            int input = Convert.ToInt32(Console.ReadLine());
            DrawLine(input);

            Console.ReadKey();
        }

        static void DrawLine(int number)
        {

            for (int row = 1; row <= number; row++)
            {
                for (int column = 1; column <= number; column++)
                {
                    if (row == column)
                    {
                        Console.Write(" ");             
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

