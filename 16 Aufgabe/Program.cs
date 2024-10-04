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

            int a = 0, e = 0, i = 0, o = 0, u = 0;
            int A = 0, E = 0, I = 0, O = 0, U = 0;
            int ä = 0, ö = 0, ü = 0;
            int Ä = 0, Ö = 0, Ü = 0;
            int vocalsCount = 0;


            for (int j = 0; j < sentence.Length; j++)
            {
                char currentLetter = sentence[j];

                if (currentLetter == 'a')
                {
                    a++;
                    vocalsCount++;
                }
                if (currentLetter == 'e')
                {
                    e++;
                    vocalsCount++;
                }
                if (currentLetter == 'i')
                {
                    i++;
                    vocalsCount++;
                }
                if (currentLetter == 'o')
                {
                    o++;
                    vocalsCount++;
                }
                if (currentLetter == 'u')
                {
                    u++;
                    vocalsCount++;
                }
                if (currentLetter == 'A')
                {
                    A++;
                    vocalsCount++;
                }
                if (currentLetter == 'E')
                {
                    E++;
                    vocalsCount++;
                }
                if (currentLetter == 'I')
                {
                    I++;
                    vocalsCount++;
                }
                if (currentLetter == 'O')
                {
                    O++;
                    vocalsCount++;
                }
                if (currentLetter == 'U')
                {
                    U++;
                    vocalsCount++;
                }
                if (currentLetter == 'ä')
                {
                    ä++;
                    vocalsCount++;
                }
                if (currentLetter == 'ö')
                {
                    ö++;
                    vocalsCount++;
                }
                if (currentLetter == 'ü')
                {
                    ü++;
                    vocalsCount++;
                }
                if (currentLetter == 'Ä')
                {
                    Ä++;
                    vocalsCount++;
                }
                if (currentLetter == 'Ö')
                {
                    Ö++;
                    vocalsCount++;
                }
                if (currentLetter == 'Ü')
                {
                    Ü++;
                    vocalsCount++;
                }
            }
            Console.WriteLine("\nDein Text hat total " + vocalsCount + " Vokale.");
            if (a > 0)
            {
                Console.WriteLine("Der Buchstabe 'a' kommt " + a + " vor.");
            }
            if (e > 0)
            {
                Console.WriteLine("Der Buchstabe 'e' kommt " + e + " vor.");
            }
            if (i > 0)
            {
                Console.WriteLine("Der Buchstabe 'i' kommt " + i + " vor.");
            }
            if (o > 0)
            {
                Console.WriteLine("Der Buchstabe 'o' kommt " + o + " vor.");
            }
            if (u > 0)
            {
                Console.WriteLine("Der Buchstabe 'u' kommt " + u + " vor.");
            }
            if (A > 0)
            {
                Console.WriteLine("Der Buchstabe 'A' kommt " + A + " vor.");
            }
            if (E > 0)
            {
                Console.WriteLine("Der Buchstabe 'E' kommt " + E + " vor.");
            }
            if (I > 0)
            {
                Console.WriteLine("Der Buchstabe 'I' kommt " + I + " vor.");
            }
            if (O > 0)
            {
                Console.WriteLine("Der Buchstabe 'O' kommt " + O + " vor.");
            }
            if (U > 0)
            {
                Console.WriteLine("Der Buchstabe 'U' kommt " + U + " vor.");
            }
            if (ä > 0)
            {
                Console.WriteLine("Der Buchstabe 'ä' kommt " + ä + " vor.");
            }
            if (ö > 0)
            {
                Console.WriteLine("Der Buchstabe 'ö' kommt " + ö + " vor.");
            }
            if (ü > 0)
            {
                Console.WriteLine("Der Buchstabe 'ü' kommt " + ü + " vor.");
            }
            if (Ä > 0)
            {
                Console.WriteLine("Der Buchstabe 'Ä' kommt " + Ä + " vor.");
            }
            if (Ö > 0)
            {
                Console.WriteLine("Der Buchstabe 'Ö' kommt " + Ö + " vor.");
            }
            if (Ü > 0)
            {
                Console.WriteLine("Der Buchstabe 'Ü' kommt " + Ü + " vor.");
            }
            Console.ReadKey();
        }
    }
}