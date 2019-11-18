using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class StandardDecorator : GameDecorator
    {

        public StandardDecorator(Game game) : base(game)
        {
            _name = "Standard";
            _price = 0.0;
        }
    }
}
