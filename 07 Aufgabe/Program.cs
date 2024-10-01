using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30, die durch 3 und 5 ohne rest teilbar sind:");

            string result = "";

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i + ", ";
                }
            }

            if (result.Length > 0)
            {
                result = result.Substring(0, result.Length - 2);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
