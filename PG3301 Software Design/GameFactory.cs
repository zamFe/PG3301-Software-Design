using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    static class GameFactory
    {

        private static string[] _games = { "Call of Duty", "Pokemon Sword", "Pokemon Shield", "Fortnite"};

        public static Game Create()
        {
            Random rn = new Random();

            Game game = new BaseGame((double) rn.Next(5,60) + 0.99, _games[rn.Next(0, 4)]);

            if(rn.Next(2) == 1)
                game = new Super(game);
            if (rn.Next(2) == 1)
                game = new Deluxe(game);
            if (rn.Next(2) == 1)
                game = new Gold(game);
            if (rn.Next(2) == 1)
                game = new Legendary(game);

            return game;
        }

    }
}