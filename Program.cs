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
            int maxHealth = 10;
            int currentHealthPercentage = 42;
            int healthBarPositionX = 0;
            int healthBarPositionY = 0;

            int maxMana = 8;
            int currentManaPercentage = 60;
            int manaBarPositionX = 12;
            int manaBarPositionY = 0;

            ConsoleColor healthBarFillColor = ConsoleColor.Green;
            ConsoleColor manaBarFillColor = ConsoleColor.Blue;

            DrawBar(currentHealthPercentage, maxHealth, healthBarFillColor, healthBarPositionX, healthBarPositionY);
            DrawBar(currentManaPercentage, maxMana, manaBarFillColor, manaBarPositionX, manaBarPositionY);
        }

        static void DrawBar(int currentValuePercentage, int maxValue, ConsoleColor color, int barPositionX, int barPositionY)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            char openSymbol = '[';
            char closedSymbol = ']';
            char availableHealthSymbol = '#';
            char missingHealthSymbol = '_';

            int minValue = 0;
            int currentValue = (int)Math.Ceiling(currentValuePercentage * (maxValue / 100.0));

            string bar = FillBar(minValue, currentValue, availableHealthSymbol);
            bar += FillBar(currentValue, maxValue, missingHealthSymbol);

            Console.SetCursorPosition(barPositionX, barPositionY);
            Console.Write(openSymbol);
            Console.BackgroundColor = color;
            WriteBar(bar, minValue, currentValue);
            Console.BackgroundColor = defaultColor;
            WriteBar(bar, currentValue, maxValue);
            Console.WriteLine(closedSymbol);
        }

        private static string FillBar(int value, int maxValue, char filler)
        {
            string tempLine = null;

            for (int i = value; i < maxValue; i++)
                tempLine += filler;

            return tempLine;
        }

        private static void WriteBar(string bar, int value, int maxValue)
        {
            for (int i = value; i < maxValue; i++)
                Console.Write(bar[i]);
        }
    }
}
