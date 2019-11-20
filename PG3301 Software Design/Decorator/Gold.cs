using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Gold : GameDecorator
    {
        public Gold(IGame game) : base(game)
        {
            _description = "Gold";
            _price = 2;
        }

    }
}
