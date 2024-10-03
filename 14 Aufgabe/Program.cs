using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes?: ");
            int trunkWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe des Stammes?: ");
            int trunkHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone?: ");
            int crownHeight = Convert.ToInt32(Console.ReadLine());

            
            DrawTree(trunkWidth, trunkHeight, crownHeight);

            Console.ReadKey();
        }

        static void DrawTree(int trunkWidth, int trunkHeight, int crownHeight)
        {
            DrawCrown(crownHeight);
            DrawTrunk(trunkHeight, trunkWidth, crownHeight);
        }

        static void DrawTrunk(int trunkHeight, int trunkWidth, int crownHeight)
        {
            int spaceCount = (crownHeight - 1) - (trunkWidth / 2) ;

            for (int i = 1; i <= trunkHeight; i++)
            {
                DrawLine(spaceCount, trunkWidth);
            }
        }

        static void DrawCrown(int crownHeight)
        {
            int stars = 1;
            int space = crownHeight - 1;

            for (int i = 1; i <= crownHeight; i++)
            {
                DrawLine(space, stars);
                stars += 2;
                space -= 1;
            }
        }

        static void DrawLine(int spaceCount, int starsCount)
        {
            for (int i = 1; i <= spaceCount; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= starsCount; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

  
