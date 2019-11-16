using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    abstract class GameDecorator : Game
    {
        private Game tmpGame; //unsure if private is correct

        public GameDecorator(Game newGame)
        {
            tmpGame = newGame;
        }

        public int gameID { get; }

        public string key { get; }

        public string name { get; }

        public double price { get; }
    }
}
