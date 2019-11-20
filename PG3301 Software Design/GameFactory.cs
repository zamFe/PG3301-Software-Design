using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    static class GameFactory
    {
        //Name of Games sold in the Market
        private static string[] _games = {"Call of Duty", "Pokemon Sword", "Pokemon Shield", "Fortnite", "Dark Souls", "Escape From Tarkov", "Minecraft", "Joe's Adventure", "Overwatch"};

        //Creating game with random version and returns it
        public static IGame Create()
        {
            Random rnd = new Random();

            IGame game = new BaseGame((double) rnd.Next(5,40) + 0.99, _games[rnd.Next(0, _games.Length)]);

            if(rnd.Next(2) == 1)
                game = new Super(game);
            if (rnd.Next(2) == 1)
                game = new Deluxe(game);
            if (rnd.Next(2) == 1)
                game = new Gold(game);
            if (rnd.Next(2) == 1)
                game = new Legendary(game);

            return game;
        }
    }
}