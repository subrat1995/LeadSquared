using System;

namespace LeadSquared.Utility
{
    public static class ConsoleUtility
    {
        public static void PrintOptions()
        {
            Console.WriteLine(@"
Available User Actions:
1. Play A Card
2. Shuffle Deck
3. Restart The Game
4. Print Deck
            ");
        }

        public static void ConsoleWriteColorLine(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}
