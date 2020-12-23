using LeadSquared.Enums;
using LeadSquared.Models;
using LeadSquared.Utility;
using System;

namespace LeadSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck PlayingDeck = new Deck();
            PlayingDeck = PlayingDeck.Shuffle();

            ConsoleUtility.PrintOptions();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nEnter user action number: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case (int)InputActions.PlayCard:
                            PlayingDeck = PlayingDeck.PlayTopCard();
                            break;
                        case (int)InputActions.ShuffleDeck:
                            PlayingDeck = PlayingDeck.Shuffle();
                            break;
                        case (int)InputActions.RestartGame:
                            ConsoleUtility.ConsoleWriteColorLine("Restarting Game!", ConsoleColor.Green);
                            PlayingDeck = new Deck().Shuffle();
                            break;
                        case (int)InputActions.PrintDeck:
                            PlayingDeck.PrintDeck();
                            break;
                        default:
                            NotSupportedException ex = new NotSupportedException();
                            throw ex;
                    }
                } 
                catch (NotSupportedException)
                {
                    ConsoleUtility.ConsoleWriteColorLine("User action not supported!", ConsoleColor.Red);
                }
                catch (Exception e)
                {
                    ConsoleUtility.ConsoleWriteColorLine(e.Message, ConsoleColor.Red);
                }
                
            }
        }
    }
}
