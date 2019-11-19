using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    static class GameKeyDistributor
    {

        static Dictionary<string, List<GameKey>> GameKeys = new Dictionary<string, List<GameKey>>();

        
        public static void AddGame(GameKey gameKey)
        {
            if(!GameKeys.ContainsKey(gameKey.Game.getName()))
            {
                GameKeys.Add(gameKey.Game.getName(), new List<GameKey>());
            }
            List<GameKey> games = GameKeys[gameKey.Game.getName()];
            games.Add(gameKey);
            Console.WriteLine("Added - " + gameKey.Game.getName() + gameKey.Game.getDescription());
        }

        public static void RemoveGame(GameKey gameKey)
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

        //gets first GameKey with matching name
        public static GameKey GetGame(string gameName)
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


        public static bool GameAvailable(string gameName)
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
    }
}
