using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    public class Product
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
            return Game.ToString() + "Key: " + Key + "\n";
        }
    }
}