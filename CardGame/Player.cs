using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        public List<Card> hand;
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
            hand = new List<Card>();
        }

        public void AddToHand(Card drawnCard)
        {
            hand.Add(drawnCard);
        }

        public Card TakeFromHand(int index)
        {
            if (index < hand.Count)
            {
                Card temp = hand[index];
                hand.RemoveAt(index);
                return temp;
            }
            else
            {
                return null;
            }
        }

        public void GetHand()
        {
            hand.Sort();
            foreach (Card card in hand)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
