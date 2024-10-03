using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen ob sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("********************************************************");

            for (int i = 0; i <= 1; )
            {
                Console.Write("\nEingabe Jahr (Q to Quit): ");
                string jahr = Console.ReadLine();
                
                if (jahr.ToLower() == "q")
                {
                    Console.WriteLine("Programm beendet.");
                    break;
                }
                if (int.TryParse(jahr, out int Schaltjahr))
                {
                    if (Schaltjahr % 4 == 0 && Schaltjahr % 400 == 0 && Schaltjahr % 100 == 0) // Vielfachen von 400 (1200,1600,2000...)
                    {
                        Console.WriteLine("Das Jahr " + jahr + " ist ein Schaltjahr.");
                    }
                    if (Schaltjahr % 4 == 0 && Schaltjahr % 400 != 0 && Schaltjahr % 100 != 0) // Durch 4 teilbare Jahre
                    {
                        Console.WriteLine("Das Jahr " + jahr + " ist ein Schaltjahr.");
                    }
                    if (Schaltjahr % 4 != 0 && Schaltjahr % 400 != 0 && Schaltjahr % 100 != 0) // Durch nichts Teilbar (keine Schaltjahre)
                    {
                        Console.WriteLine("Das Jahr " + jahr + " ist KEIN ein Schaltjahr.");
                    }
                    if (Schaltjahr % 4 == 0 && Schaltjahr % 100 == 0 && Schaltjahr % 400 != 0) // 100er Jahre (1100,1300,1400...)
                    {
                        Console.WriteLine("Das Jahr " + jahr + " ist KEIN ein Schaltjahr.");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
