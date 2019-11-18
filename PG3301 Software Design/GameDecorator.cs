using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    abstract class GameDecorator : Game
    {
        private Game _game;

        protected string _name = "undefined Game";
        protected double _price = 0.0;

        public GameDecorator(Game newGame)
        {
            _game = newGame;
        }

        public string GetDescription()
        {
            return string.Format("{0} {1}", _game.GetDescription(), _name);
        }

        public double GetPrice()
        {
            return Math.Round(_game.GetPrice() * _price, 2);
        }
 
    }
}
