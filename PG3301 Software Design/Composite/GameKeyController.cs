using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
   
    static class GameKeyController
    {
        public static Product MakeProduct()
        {
            return new Product(GameFactory.Create(), KeyGenerator.GenerateKey());
        }
    }
}
