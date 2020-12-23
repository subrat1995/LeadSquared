using LeadSquared.Enums;
using LeadSquared.Utility;
using System;
using System.Collections.Generic;
namespace LeadSquared.Models
{
    public class Deck
    {
        public List<Card> Cards { get; } = new List<Card>();

        // Deck Constructor should initialise the Cards with available suites and card values
        public Deck()
        {
            foreach (Suite suite in Enum.GetValues(typeof(Suite)))
            {
                foreach (CardValue cardValue in Enum.GetValues(typeof(CardValue)))
                {
                    Cards.Add(new Card
                    {
                        Suite = suite,
                        CardValue = cardValue
                    });
                }
            }

            ConsoleUtility.ConsoleWriteColorLine("New Deck Generated!", ConsoleColor.Cyan);
        }
    }
}
