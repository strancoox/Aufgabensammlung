using System;
using System.Collections.Generic;
using System.Linq;
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

            // Solange die Zahl nicht 0 ist, summiere die Ziffern
            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }

            return sum; // Gib die berechnete Quersumme zurück
        }
        static void Main(string[] args)
            {
            Console.WriteLine("Zahl 1: ");
            string zahl1 = Console.ReadLine();
            Console.WriteLine("Zahl 2: ");
            string zahl2 = Console.ReadLine();
            }
        }
    }

