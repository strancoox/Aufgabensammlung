using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 400;
            Console.WriteLine("Wie viele Km möchtest du rennen?: ");
            int distance = Convert.ToInt32(Console.ReadLine());
           
            if (distance > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
                Console.ReadKey();
            }
            else
            {
                float rounds = (float)distance * 1000 / 400;  
                Console.WriteLine($"Das sind {rounds} Runden" + " " + "Bist du bereit?: ");
                char ready = Convert.ToChar(Console.ReadLine());
                
                if (ready == 'j' || ready == 'J')
                {
                    for (int i = 1; i <= rounds; i++)
                    {
                        Console.WriteLine("Du läufst Runde" + " " + i);
                    }
                    Console.WriteLine("Du hast es geschafft!");
                }
                else
                {
                    Console.WriteLine("Ende");
                }
                if (ready == 'n' || ready == 'N')
                {
                    Console.WriteLine("Ende");
                }
            }
            Console.ReadKey();
        }
    }
}
