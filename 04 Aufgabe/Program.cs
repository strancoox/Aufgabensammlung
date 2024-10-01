﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _04_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Gebe eine Zahl zwischen 1 und 12 an: "); 
            string MonthNum = Console.ReadLine();
            int zahl = 0;

            string[] month  = {"Januar", "Februar", "März","April", "Mai", "Juni",
                                "Juli", "August", "September", "Oktober", "November", "Dezember"};


            if (int.TryParse(MonthNum, out zahl ) == true)
            {
                if (zahl > 0 && zahl < 13) 
                {
                    Console.WriteLine("Monat: " + (month[zahl - 1]));
                }
                else 
                {
                    Console.WriteLine("Ungültige Zahl bitte gebe eine Zahl zwischen 1 und 12 ein.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe bitte gebe eine Zahl ein.");

            }

            Console.ReadKey();
        }
    }
}
