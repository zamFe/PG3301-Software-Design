using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    static class GameFactory
    {
        public static BaseGame Create(string name)
        {
            Random rn = new Random();
            return new BaseGame((double) rn.Next(5,60) + 0.99, name);
        }
    }
}
