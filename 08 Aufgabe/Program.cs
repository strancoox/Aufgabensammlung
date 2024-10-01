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
            // Beispiel zeigen
            int zahl = 10;
            string bin = Convert.ToString(zahl, 2); // Konvertieren in binäre Darstellung

            Console.WriteLine("Ganzzahlige Dezimalzahl (q to Quit)");
            Console.WriteLine(zahl);
            Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);


            while (true) 
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); 

               
                if (keyInfo.Key == ConsoleKey.Q)
                {
                    break; 
                }
           
            }
        }
    }
}
