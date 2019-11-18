using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Gold : GameDecorator
    {
        public Gold(Game game) : base(game)
        {
            _name = "Gold";
            _price = 2;
        }

    }
}
