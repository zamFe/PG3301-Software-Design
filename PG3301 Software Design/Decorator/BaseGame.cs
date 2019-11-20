using System;

namespace PG3301_Software_Design
{
    class BaseGame : IGame
    {
        private string _name;
        private string _description = "";
        private double _price;

        public BaseGame(double price = 0, string name = "unknown")
        {
            _name = name;
            _price = price;
        }

        public virtual string GetName()
        {
            return _name;
        }

        public virtual string GetDescription()
        {
            return _description;
        }

        public virtual double GetPrice()
        {
            return _price;
        }

        public string GetEdition()
        {
            return _name + " Standard Edition\n";
        }

        public override string ToString()
        {
            return GetEdition() + "\nPrice: " + _price + "\n";
        }
    }
}
