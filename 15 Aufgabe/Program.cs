using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Methode für das Neustarten des Spiels
            StartGame();
        }

        static void StartGame() 
        {
            // Zufällige Zahl generieren
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            bool correctGuess = true;
            int tries = 1;
            while (correctGuess)
            {
                Console.WriteLine("Deine Zahl (1..100):");
                string input = Console.ReadLine();


                // Falls der Benutzer eine richtige Eingabe eingegeben hat wird diese konvertiert
                if (int.TryParse(input, out int guessedNumber))
                {
                    // Versuche zählen, bis der Benutzer die Zahl erraten hat
                    if (guessedNumber != randomNumber)
                    {
                        tries = tries + 1;
                    }
                    // Benutzer melden ob seine Zahl zu gross oder klein ist 
                    if (guessedNumber > randomNumber)
                    {
                        Console.WriteLine("Zahl zu groß! Versuch's nochmal:\n");
                    }
                    if (guessedNumber < randomNumber)
                    {
                        Console.WriteLine("Zahl zu klein! Versuch's nochmal:\n");
                    }
                    // Benutzer melden ob seine Zahl mit der generierten Zahl übereinstimmt
                    if (guessedNumber == randomNumber)
                    {
                        Console.WriteLine("Die Zahl stimmt! Du hast total " + tries + " Versuche benötigt. Noch einmal spielen? [y/n]\n");
                        string newGame = Console.ReadLine();

                        // Spiel beenden
                        if (newGame.ToLower() == "n")
                        {
                            Console.WriteLine("Spiel beendet");
                            break;
                        }
                        // Spiel neustarten durch eine Methode, die den ganzen Vorgang wiederholt
                        if (newGame.ToLower() == "y")
                        {
                            StartGame();
                        }
                    }

                }
                // Falsche Eingabe im Benutzer melden
                else
                {
                    Console.WriteLine("Bitte eine gültige Zahl eingeben.\n");
                }
            }
        }
    }
}











