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
            List<GameKey> games = GameKeys[gameKey.Game.getName()];
            games.Add(gameKey);
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

        public static GameKey GetGame(string gameName)
        {
            if(GameKeys[gameName] == null)
            {
                //game is out of stock
                return null;
            }

            List<GameKey> games = GameKeys[gameName];

            return games[0];

        }




    }
}
