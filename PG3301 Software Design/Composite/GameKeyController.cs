using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
   
    static class GameKeyController
    {
        //Create A Game with a Key and returns it
        public static Product MakeProduct()
        {
            return new Product(GameFactory.Create(), KeyGenerator.GenerateKey());
        }
    }
}
