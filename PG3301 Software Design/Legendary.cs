using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Legendary : GameDecorator
    {

        public Legendary (Game game) : base(game)
        {
            _name = "Legendary";
            _price = 3;

        }


    }
}
