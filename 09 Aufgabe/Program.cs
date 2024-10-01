using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Aufgabe
{
    using System;

    internal class Program
    {
        // Dies ist die Methode zur Berechnung der Quersumme
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
        public static void Main(string[] args)
        {
            // Benutzereingabe
            Console.Write("Bitte gebe eine ganze Zahl ein: ");
            string input = Console.ReadLine(); 

            // Versuchen, die Eingabe in eine Zahl umzuwandeln
            if (int.TryParse(input, out int eingabe))
            {
                // Quersumme berechnen und ausgeben
                int quersumme = BerechneQuersumme(eingabe);
                Console.WriteLine("Die Quersumme ist: " + quersumme);
            }
            else
            {
                // Wenn die Eingabe keine gültige Zahl ist
                Console.WriteLine("Ungültige Eingabe, bitte gib eine gültige ganze Zahl ein.");
            }
        }
    }
}
   