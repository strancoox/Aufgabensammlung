using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            
            // Eingabe
            byte Days = Convert.ToByte(Console.ReadLine());

            // Verarbeitung
            switch (Days)
            {
                case 28:
                case 29:
                case 30:
                case 31:
                    Console.WriteLine("Ein Monat mit" + " " + Days + " " + "Tagen hat" + " " + (86400 * Days) + "Sekunden");
                    break;
                default:
                    Console.WriteLine("Deine Anzahl an Tagen (" + Days + ") ist ungültig.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
