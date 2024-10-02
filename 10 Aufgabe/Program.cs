using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _10_Aufgabe
{
    internal class Program
    {
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }

            return sum; // Gib die berechnete Quersumme zurück für die erste Eingabe

        }
        
        static void Main(string[] args)
            {

            Console.WriteLine("Zahl 1: ");
            string zahl1 = Console.ReadLine();
            Console.WriteLine("Zahl 2: ");
            string zahl2 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Zahl\t" + "| Quersumme\t" + "| Zahl / Quersumme");
            Console.WriteLine("------------------------------------------");

            if(int.TryParse(zahl1, out int start) && int.TryParse(zahl2,out int end))
            {
                for (int i = start; i <= end; i++)
                {
                    int quersumme = BerechneQuersumme(i);
                    
                    if (i % quersumme == 0)
                    {
                        Console.WriteLine(i + "\t|" + " " + quersumme + "\t\t|" + " " + i / quersumme);
                    }
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingaben. Bitte geben Sie gültige Ganzzahl ein.");
            }
            Console.ReadKey();
        }
    }
}




