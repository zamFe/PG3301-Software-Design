using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
   
    static class ProductController
    {
        //Combine game with an unique Key to get a sellable product and return it
        public static Product MakeProduct()
        {
            return new Product(GameFactory.Create(), KeyGenerator.GenerateKey());
        }
    }
}
