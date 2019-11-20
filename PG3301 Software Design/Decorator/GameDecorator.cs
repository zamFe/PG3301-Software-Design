using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    abstract class GameDecorator : Game
    {
        private Game _game;

        protected string _name = "undefined Game";
        protected string _description;
        protected double _price = 0.0;

        public GameDecorator(Game newGame)
        {
            _game = newGame;
        }

        public string getName()
        {
            return _game.getName();
        }

        public string getDescription()
        {
            return string.Format("{0} {1}", _game.getDescription(), _description);
        }

        public double GetPrice()
        {
            return Math.Round(_game.GetPrice() * _price, 2);
        }

        public override string ToString()
        {
            return getName() + getDescription() + " Edition\n".PadRight(60) + "Price:" + GetPrice() + "\n";
        }
 
    }
}
