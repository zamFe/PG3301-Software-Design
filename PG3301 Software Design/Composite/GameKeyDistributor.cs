using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
    class GameKeyDistributor
    {

        private Dictionary<string, List<Product>> GameKeys = new Dictionary<string, List<Product>>();

        private readonly object _lock = new object();

        public void AddGame(Product gameKey)
        {
            if (!GameKeys.ContainsKey(gameKey.Game.GetName()))
            {
                GameKeys.Add(gameKey.Game.GetName(), new List<Product>());
            }
            List<Product> games = GameKeys[gameKey.Game.GetName()];
            games.Add(gameKey);
            Console.WriteLine("Added - " + gameKey.Game.GetEdition());
            //Console.WriteLine("Added - " + gameKey.Game.getName() + gameKey.Game.getDescription() + " Edition:\n");
            //Console.WriteLine("Amount of available games: " + GetAvailableGames().Count + "\n");
        }

        public void RemoveGame(Product gameKey)
        {
            List<Product> games = GameKeys[gameKey.Game.GetName()];

            for (int i = 0; i < games.Count; i++)
            {
                Product current = games[i];
                if (current.Equals(gameKey))
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

                List<Product> games = GameKeys[gameName];

                Product game = games[0];
                games.RemoveAt(0);

                return game;

            }


            public bool GameAvailable(string gameName)
            {

                if (!GameKeys.ContainsKey(gameName))
                {
                    return false;
                }

                List<Product> games = GameKeys[gameName];

                if (games.Count == 0)
                {
                    return false;
                }

                return true;
            }

            public List<string> GetAvailableGames()
            {
                lock (_lock)
                {
                    //games registered in dictionary
                    List<string> gameList = new List<string>(GameKeys.Keys);

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