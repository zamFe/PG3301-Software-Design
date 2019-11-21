using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
    public class ProductDistributor
    {

        private readonly Dictionary<string, List<Product>> Products = new Dictionary<string, List<Product>>();

        private readonly object _lock = new object();

        /* Adds Product to list in ditionary corresponding to the games name
         * If games name isn't in dictionary, create new list and map to that name
         */
        public void AddProduct(Product product)
        {
            if (!Products.ContainsKey(product.Game.GetName()))
            {
                Products.Add(product.Game.GetName(), new List<Product>());
            }

            List<Product> games = Products[product.Game.GetName()];
            games.Add(product);
            
            Console.WriteLine("Added - " + product.Game.GetEdition());
        }

        /* Removes specific product
         * If not in Dictionary just return
         */
        public void RemoveProduct(Product product)
        {
            if(!Products.ContainsKey(product.Game.GetName()))
            {
                return;
            }

            List<Product> games = Products[product.Game.GetName()];

            for (int i = 0; i < games.Count; i++)
            {
                Product current = games[i];
                if (current.Equals(product))
                {
                    games.RemoveAt(i);
                }
            }
        }

        //gets first GameKey with matching name 
        public Product GetProduct(string gameName)
        {
            if (!ProductAvailable(gameName))
            {
                //Game Not Available
                return null;
            }

            List<Product> games = Products[gameName];

            Product game = games[0];
            games.RemoveAt(0);

            return game;

        }

        //Returns true if there are products of specified game available
        public bool ProductAvailable(string gameName)
            {

                if (!Products.ContainsKey(gameName))
                {
                    return false;
                }

                List<Product> games = Products[gameName];

                if (games.Count == 0)
                {
                    return false;
                }

                return true;
            }

        //Return all registered games that have products available
        public List<string> GetAvailableGames()
        {
            lock (_lock)
            {
                //games registered in dictionary
                List<string> gameList = new List<string>(Products.Keys);

                //check if there are keys left for each game
                List<string> gameListAvailable = new List<string>(gameList.Count);
                    
                for (int i = 0; i < gameList.Count; i++)
                    {
                    if (ProductAvailable(gameList[i]))
                    {
                        gameListAvailable.Add(gameList[i]);
                    }
                }
                return gameListAvailable;
            }
        }
        
    }
}