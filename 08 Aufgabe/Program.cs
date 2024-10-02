using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
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
            string inputString = "";

            while (inputString.ToLower()!="q")
            {
                string bin = "";
                Console.WriteLine("Ganzzahlige Dezimalzahl (Q to Quit):");
                inputString = Console.ReadLine();

                if (inputString.ToLower() == "q")
                {
                    Console.WriteLine("Programm beendet.");
                    break;
                }
  
                if (int.TryParse(inputString, out int input))
                {
                    do
                    {
                        int rest = input % 2;
                        bin = rest + bin;
                        input /= 2;
                    }
                    while (input != 0);
                    Console.WriteLine(bin);
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte eine Ganzzahl eingeben.");
                }
            }
            Console.WriteLine("Programm beendet.");
        }
    }
}      
    


