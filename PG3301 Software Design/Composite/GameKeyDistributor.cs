using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
    class GameKeyDistributor
    {

        private Dictionary<string, List<GameKey>> GameKeys = new Dictionary<string, List<GameKey>>();

        private readonly object _lock = new object();
        
        public void AddGame(GameKey gameKey)
        {
            if(!GameKeys.ContainsKey(gameKey.Game.getName()))
            {
                GameKeys.Add(gameKey.Game.getName(), new List<GameKey>());
            }
            List<GameKey> games = GameKeys[gameKey.Game.getName()];
            games.Add(gameKey);
            Console.WriteLine("Added - " + gameKey.Game.getName() + gameKey.Game.getDescription() + " Edition:\n");
            //Console.WriteLine("Amount of available games: " + GetAvailableGames().Count + "\n");
        }

        //We dont use it
        /*
        public void RemoveGame(GameKey gameKey)
        {
            List<GameKey> games = GameKeys[gameKey.Game.getName()];

            for(int i = 0; i < games.Count; i++)
            {
                GameKey current = games[i];
                if (current.Equals(gameKey)) {
                    games.RemoveAt(i);
                }
            }
        }
        */

        //gets first GameKey with matching name
        public GameKey GetGame(string gameName)
        {
            if(!GameAvailable(gameName))
            {
                //Game Not Available
                return null;
            }

            List<GameKey> games = GameKeys[gameName];

            GameKey game = games[0];
            games.RemoveAt(0);

            return game;

        }


        public bool GameAvailable(string gameName)
        {

            if (!GameKeys.ContainsKey(gameName))
            {
                return false;
            }

            List<GameKey> games = GameKeys[gameName];

            if(games.Count == 0)
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
