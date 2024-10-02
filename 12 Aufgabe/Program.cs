using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                doSomething(); // kann i manipulieren 
            } 
            while (i >= 0);
            doSomething();
        }
        static void doSomething()
        {
            Console.WriteLine("Hallo");
        }
    }
}
