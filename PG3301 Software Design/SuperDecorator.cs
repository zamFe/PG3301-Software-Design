using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class SuperDecorator : GameDecorator
    {

        public SuperDecorator(Game game) : base(game)
        {
            _name = "Super";
            _price = 19.99;
        }
    }
}