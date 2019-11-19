using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Marketplace
    {

        GameKeyDistributor gameKeyDistributor = new GameKeyDistributor();

        List<Game> games = new List<Game>();
        

        public void CreateGame()
        {
            games.Add(gameKeyDistributor.getGame());
        }



    }
}
