using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L29_UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentHealth = 4;
            int maxHealth = 10;
            int healthBarPositionX = 0;
            int healthBarPositionY = 0;
            ConsoleColor healthBarFillColor = ConsoleColor.Green;

            int currentMana = 6;
            int maxMana = 8;
            int manaBarPositionX = 12;
            int manaBarPositionY = 0;
            ConsoleColor manaBarFillColor = ConsoleColor.Blue;

            DrawBar(currentHealth, maxHealth, healthBarFillColor, healthBarPositionX, healthBarPositionY);
            DrawBar(currentMana, maxMana, manaBarFillColor, manaBarPositionX, manaBarPositionY);
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int barPositionX, int barPositionY)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            char openSymbol = '[';
            char closedSymbol = ']';
            char availableHealthSymbol = '#';
            char missingHealthSymbol = '_';
            string bar = null;

            for (int i = 0; i < value; i++)
                bar += availableHealthSymbol;

            for (int i = value; i < maxValue; i++)
                bar += missingHealthSymbol;

            Console.SetCursorPosition(barPositionX, barPositionY);
            Console.Write(openSymbol);
            Console.BackgroundColor = color;

            for (int i = 0; i < value; i++)
                Console.Write(bar[i]);

            Console.BackgroundColor = defaultColor;

            for (int i = value; i < maxValue; i++)
                Console.Write(bar[i]);

            Console.WriteLine(closedSymbol);
        }
    }
}
