using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vokale in Sätzen zählen...");
            Console.WriteLine("Deine Eingabe [Satz]: ");
            string sentence = Console.ReadLine();

           
            int vocalsCount = 0;


            // int[,] vocals = new vocals[16, 2]
            // vocals[0, 0] = 'a';
            // vocals[0, 1] = 0;
            // etc 

            //                 0   1
            int[,] vocals = {
                            { 'a', 0 },   
                            { 'e', 0 },   
                            { 'i', 0 },   
                            { 'o', 0 },
                            { 'u', 0 },
                            { 'A', 0 },
                            { 'E', 0 },
                            { 'I', 0 },
                            { 'O', 0 },
                            { 'U', 0 },
                            { 'ä', 0 },
                            { 'ö', 0 },
                            { 'ü', 0 },
                            { 'Ä', 0 },
                            { 'Ö', 0 },
                            { 'Ü', 0 } }; 

            for (int j = 0; j < sentence.Length; j++)
            {
                char currentLetter = sentence[j];
              
                for (int v = 0; v < vocals.GetLength(0); v++)
                {
                    if (currentLetter == vocals[v, 0])
                    {
                        vocals[v, 1]++;
                        vocalsCount++;
                    }
                }
            }
            Console.WriteLine("\nDein Text hat total " + vocalsCount + " Vokale.");

            for (int v = 0; v < vocals.GetLength(0); v++)
            {
                if (vocals[v, 1] > 0)
                {
                    Console.WriteLine("Der Buchstabe '" + Convert.ToChar(vocals[v, 0]) + "' kommt " + vocals[v, 1] + " Mal vor.");
                }
            }
            Console.ReadKey();
        }
    }
}