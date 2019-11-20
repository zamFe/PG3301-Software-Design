using System;

namespace PG3301_Software_Design
{
    class BaseGame : Game
    {
        private string _name;
        private string _description = "";
        private double _price;

        public BaseGame(double price = 0, string name = "unknown")
        {
            _name = name;
            _price = price;

        }

        public virtual string getName()
        {
            return _name;
        }

        public virtual string getDescription()
        {
            return _description;
        }

        public virtual double GetPrice()
        {
            return _price;
        }

        public override string ToString()
        {
            return _name + " Standard Edition\nPrice: " + _price + "\n";
        }

        public string GetEdition()
        {
            return _name + " Standard Edition\n";
        }


    }
}
