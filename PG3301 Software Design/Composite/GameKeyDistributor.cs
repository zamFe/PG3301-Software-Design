using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
    class GameKeyDistributor
    {

        private readonly Dictionary<string, List<Product>> Products = new Dictionary<string, List<Product>>();

        private readonly object _lock = new object();

        /* Adds Game and Key to a Dictionary if not already, 
         * If its already there Add it to the correct list containing this game's name
         */
        public void AddGame(Product product)
        {
            if (!Products.ContainsKey(product.Game.GetName()))
            {
                Products.Add(product.Game.GetName(), new List<Product>());
            }
            List<Product> games = Products[product.Game.GetName()];
            games.Add(product);
            Console.WriteLine("Added - " + product.Game.GetEdition());
        }
        /* Remove Game and Key from a Dictionary
         * If not in Dictionary just return
         * If in Dictionary traverse list and remove the first matching it
         */
        public void RemoveGame(Product product)
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
            public Product GetGame(string gameName)
            {
                if (!GameAvailable(gameName))
                {
                    //Game Not Available
                    return null;
                }

                List<Product> games = Products[gameName];

                Product game = games[0];
                games.RemoveAt(0);

                return game;

            }

            //Returns if game is available
            public bool GameAvailable(string gameName)
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

            //Traverse a list of Available games and returns the list
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
                        if (GameAvailable(gameList[i]))
                        {
                            gameListAvailable.Add(gameList[i]);
                        }
                    }

                    return gameListAvailable;
                }
            }
        }
    }