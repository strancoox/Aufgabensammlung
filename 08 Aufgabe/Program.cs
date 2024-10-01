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
            // Eingabe vom Benutzer (leer)
            string input = "";

            // Endlose Schleife, solang die taste q nicht gedrückt wird
            while (input != "q")
            {
                // Eingabe vom Benutzer
                Console.WriteLine("Ganzzahlige Dezimalzahl (Q to Quit)");
                input = Console.ReadLine();

                // Überprüfung ob der Benutzer die Taste q eingegeben hat
                if (input == "q")
                {
                    break;
                }

                // Eingabe vom Benutzer in Zahl umwandeln, falls möglich
                if (int.TryParse(input, out int zahl))
                {
                    // Wenn keine richtige Zahl eingegeben wird
                    string bin = Convert.ToString(zahl, 2);
                    Console.WriteLine("Die binäre Darstellung von " + zahl + "ist: " + bin);
                }
                else
                {
                    Console.WriteLine("Üngültige Eingabe, bitte gebe eine Zahl ein.");
                }
            }
            // Ende des Programms falls "q" gedrückt wird
            Console.WriteLine("Programm beendet");
        }      
    }
}

