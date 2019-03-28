using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        private List<Card> deck;
        private int currentCard;
        private const int CARDS_TOTAL = 108;
        private Random ranNum;

        public int CardsLeft => (deck.Count - currentCard);

        public Deck()
        {
            string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            this.deck = new List<Card>();
            currentCard = 0;
            ranNum = new Random();
            for (int count = 0; count < CARDS_TOTAL; count++)
            {
                if (count >= 104)
                {
                    deck.Add( new Card("Joker", "Jokers") );
                }
                else
                {
                    int face = count % 13;
                    int suit = count / 26;
                    deck.Add( new Card(faces[face], suits[suit]) );
                }
            }
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Count; first++)
            {
                int second = ranNum.Next(CARDS_TOTAL);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card TakeCard()
        {
            if (currentCard < deck.Count)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
