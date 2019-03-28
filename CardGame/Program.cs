using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    static class Program
    {
        const int PLAYER_COUNT = 1;

        static void Main()
        {
            Game game = new Game(1);
            game.StartGame();
            while (true)
            {
                Console.Clear();
                game.GetCurrentHand();
                game.Draw();

                Console.ReadLine();
            }
        

            Console.ReadLine();
        }
    }
}
