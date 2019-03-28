using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card : IComparable
    {
        string displayName;
        int order;
        string face;
        string suit;

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public string DisplayName { get => displayName; set => displayName = value; }
        public int Order { get => order; set => order = value; }
        public string Face { get => face; set => face = value; }
        public string Suit { get => suit; set => suit = value; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Card otherCard = obj as Card;
            if (otherCard != null)
            {
                if (this.Face != otherCard.Face)
                {
                    return this.Face.CompareTo(otherCard.Face);
                }
                else
                {
                    return this.Suit.CompareTo(otherCard.Suit);
                }
            }
            else
            {
                throw new ArgumentException("Object is not a Card");
            }
        }

        public override string ToString()
        {
            return Face + " " + Suit;
        }
    }
}
