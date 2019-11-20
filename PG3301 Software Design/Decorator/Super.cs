using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Super : GameDecorator
    {

        public Super(IGame game) : base(game)
        {
            _description = "Super";
            _price = 1.75;
        }
    }
}