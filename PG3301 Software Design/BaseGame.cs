using System;

namespace PG3301_Software_Design
{
    class BaseGame : Game
    {
        private string _description;
        private double _price;

        public BaseGame(double price, string description = "GameName")
        {
            _description = description;
            _price = price;

        }


        public virtual string GetDescription()
        {
            return _description;
        }

        public virtual double GetPrice()
        {
            return _price;
        }


    }
}
