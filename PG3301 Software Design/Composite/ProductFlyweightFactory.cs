using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
   
    static class ProductFlyweightFactory
    {

        private static readonly Dictionary<IGame, Product> _productByGame = new Dictionary<IGame, Product>();

        //Combine game with an unique Key to get a sellable product and return it
        public static Product MakeProduct()
        {
            IGame game = GameFactory.Create();
            string key = KeyGenerator.GenerateKey();

            //product already exist? Just return existing product with new key
            if (_productByGame.ContainsKey(game))
            {

                Product product = _productByGame[game];
                product.Key = key;
                return product;
            }
            //new product, add to dictionary.
            else
            {
                _productByGame.Add(game, new Product(game, key));
            }
            return _productByGame[game];
        }
    }
} 
