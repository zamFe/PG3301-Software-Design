using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class GameKeyDistributor
    {

        Dictionary<string, List<GameKey>> GameKeys = new Dictionary<string, List<GameKey>>();

        
        public void AddGame(GameKey gameKey)
        {
            List<GameKey> games = GameKeys[gameKey.Game.getName()];
            games.Add(gameKey);
        }

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

        public GameKey GetGame(string gameName)
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
