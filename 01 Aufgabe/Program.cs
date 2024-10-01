using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");

            // Eingabe 
            Console.Write("\nZahl 1: ");
            string number1 = Console.ReadLine();
           
            Console.Write("Zahl 2: ");
            string number2 = Console.ReadLine();

            // Verarbeitung
            int summe = Convert.ToInt32(number1) + Convert.ToInt32(number2);

            // Ausgabe
            Console.WriteLine("Summe: " + summe);
            Console.ReadKey();
        }
    }
}
