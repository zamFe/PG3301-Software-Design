﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Legendary : GameDecorator
    {
        public Legendary (IGame game) : base(game)
        {
            _description = "Legendary";
            _price = 3;

        }
    }
}