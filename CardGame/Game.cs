using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Game
    {
        private Deck deck;
        private Stack stack;

        private Player[] players;
        private int currentPlayer;

        public Game(int playerCount)
        {
            this.players = new Player[playerCount];
            for (int count = 0; count < players.Length; count++)
            {
                players[count] = new Player(count.ToString());
            }

            this.deck = new Deck();
            this.stack = new Stack();

            this.currentPlayer = 0;
        }


        public void Draw()
        {
            CurrP().AddToHand(deck.TakeCard());
        }

        public void StartGame()
        {
            deck.Shuffle();
            foreach (Player player in players)
            {
                for (int i = 0; i < 13; i++)
                {
                    player.AddToHand(deck.TakeCard());
                }
            }
        }

        public void GetCurrentHand()
        {
            CurrP().GetHand();
        }

        public bool IsEndOfGame()
        {
            foreach (var player in players)
            {
                if (player.hand.Count == 0)
                {
                    Console.WriteLine($"Player {player.Name} is out of cards.");
                    return true;
                }
            }

            if (deck.CardsLeft == 0)
            {
                return true;
            }

            return false;
        }

        private Player CurrP() => players[currentPlayer];
    }
}
