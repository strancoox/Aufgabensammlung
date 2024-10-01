using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _08_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            // Solange die Eingabe nicht "q" ist, lauft das Programm weiter 
            while (input != "q")
            {
                // Eingabe
                Console.WriteLine("Ganzzahlige Dezimalzahl (Q to Quit)");
                input = Console.ReadLine();

                // Prüfen, ob der Benutzer "q" eingegeben hat
                if (input == "q")
                {
                    break;
                }

                // Versuch, die Eingabe in eine Zahl umzuwandeln
                if (int.TryParse(input, out int zahl))
                {
                    // Binäre Umwandlung, falls die Umwandlung erfolgt
                    string bin = Convert.ToString(zahl, 2);
                    Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);
                }
                else
                {
                    // Wenn die Eingabe keine gültige Zahl ist
                    Console.WriteLine("Ungültige Eingabe, bitte gib eine Zahl ein.");
                }
            }

            // Das Programm endet, wenn "q" eingegeben wird
            Console.WriteLine("Programm beendet.");
        }
    }
}

