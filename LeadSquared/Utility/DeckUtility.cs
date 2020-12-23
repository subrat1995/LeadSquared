using LeadSquared.Models;
using System;

namespace LeadSquared.Utility
{
    public static class DeckUtility
    {
        // extension method to shuffle a deck
        public static Deck Shuffle(this Deck deck)
        {
            // if less than 2 cards it is not possible to shuffle
            if (deck.Cards.Count < 2)
            {
                throw new Exception("Less than 2 cards left in deck. Can not shuffle deck.");
            }

            Random r = new Random();
            for(int n = deck.Cards.Count - 1; n > 0; --n)
            {
                int randomCardIndex = r.Next(n + 1);
                Card tempCard = deck.Cards[n];
                deck.Cards[n] = deck.Cards[randomCardIndex];
                deck.Cards[randomCardIndex] = tempCard;
            }
            ConsoleUtility.ConsoleWriteColorLine($"Current deck shuffled.", ConsoleColor.Green);
            return deck;
        }

        // extension method to play the top card of a deck
        public static Deck PlayTopCard(this Deck deck)
        {
            if (deck.Cards.Count == 0)
            {
                throw new Exception("Empty deck. Can not play top card.");
            }

            Card playedCard = deck.Cards[0];
            ConsoleUtility.ConsoleWriteColorLine($"{playedCard.ToString()} played.", ConsoleColor.Green);
            deck.Cards.RemoveAt(0);
            return deck;
        }

        // extension method to print the current deck
        public static void PrintDeck(this Deck deck)
        {
            if (deck.Cards.Count == 0)
            {
                throw new Exception("Empty deck. Can not print deck.");
            }
            int iter = 0;

            ConsoleUtility.ConsoleWriteColorLine("\nAvailable Cards", ConsoleColor.Green);

            foreach (Card card in deck.Cards)
            {
                ConsoleUtility.ConsoleWriteColorLine($"Card {++iter} : {card.ToString()}", ConsoleColor.Yellow);
            }
        }
    }
}
