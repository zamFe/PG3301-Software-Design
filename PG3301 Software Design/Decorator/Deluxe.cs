using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Deluxe : GameDecorator
    {
        public Deluxe(IGame game) : base(game)
        {
            _description = "Deluxe";
            _price = 1.50;
        }
    }
}