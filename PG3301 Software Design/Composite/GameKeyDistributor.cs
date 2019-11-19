using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class GameKeyDistributor
    {

        Dictionary<string, Game> GameKeys = new Dictionary<string, Game>();

        
        public void addGame()
        {
            GameKeys.Add(KeyGenerator.GenerateKey(), GameFactory.Create());
        }

        public void removeGame()
        {

        }

        public Game getGame()
        {
            return null;
        }




    }
}
