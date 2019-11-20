using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Product
    {
        public IGame Game;
        public string Key;

        public Product(IGame Game, string Key)
        {
            this.Game = Game;
            this.Key = Key;

        }

        public override string ToString()
        {
            return Game.ToString() + "".PadRight(51) + "Key: " + Key + "\n";
        }
    }
}
