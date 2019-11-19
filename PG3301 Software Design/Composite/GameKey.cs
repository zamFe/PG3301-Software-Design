using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class GameKey
    {
        public Game Game;
        public string Key;

        public GameKey(Game Game, string Key)
        {
            this.Game = Game;
            this.Key = Key;

        }

        public override string ToString()
        {
            return "New Item available: " + Game.ToString() + "Key: " + Key + "\n";
        }
    }
}
