using LeadSquared.Enums;

namespace LeadSquared.Models
{
    public class Card
    {
        public Suite Suite { get; set; }
        public CardValue CardValue { get; set; }

        public override string ToString()
        {
            return $"{CardValue.ToString()} of {Suite.ToString()}";
        }
    }
}
