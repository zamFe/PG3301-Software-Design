using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    static class GameFactory
    {

        private static string[] _games = { "Call of Duty", "Pokemon Sword", "Pokemon Shield", "Fortnite"};

        public static BaseGame Create()
        {
            Random rn = new Random();
            return new BaseGame((double) rn.Next(5,60) + 0.99, _games[rn.Next(0, 4)]);
        }

    }
}
