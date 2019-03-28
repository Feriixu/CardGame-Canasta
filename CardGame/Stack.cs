using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Stack
    {
        private List<Card> cards;

        public Stack(List<Card> cards)
        {
            this.cards = cards;
        }

        public Stack() : this(new List<Card>())
        {
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public List<Card> TakeStack()
        {
            return cards;
        }

        public Card TakeCard(int index)
        {
            if (index < cards.Count)
            {
                return cards[index];
            }
            else
            {
                return null;
            }
        }
    }
}
