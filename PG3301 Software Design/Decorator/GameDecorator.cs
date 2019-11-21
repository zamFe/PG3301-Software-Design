using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    abstract class GameDecorator : IGame
    {
        private IGame _game;

        protected string _name = "undefined Game";
        protected string _description;
        protected double _price = 0.0;

        public GameDecorator(IGame newGame)
        {
            _game = newGame;
        }

        public string GetName()
        {
            return _game.GetName();
        }

        public string GetDescription()
        {
            return string.Format("{0} {1}", _game.GetDescription(), _description);
        }

        public double GetPrice()
        {
            return Math.Round(_game.GetPrice() * _price, 2);
        }

        public string GetEdition()
        {
            return GetName() + GetDescription() + " Edition\n";
        }

        public override string ToString()
        {
            return GetEdition() + "Price:" + GetPrice() + "\n";
        }

        public bool Equals(IGame game)
        {
            if (_name != game.GetName())
                return false;
            if (_description != game.GetDescription())
                return false;
            if (_price != game.GetPrice())
                return false;

            return true;
        }
    }
}