using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Marketplace
    {
        List<Game> games = new List<Game>();
        

        public void CreateGame()
        {
            Console.WriteLine("Adding Game to market");

            GameKeyDistributor.AddGame(GameKeyController.MakeGameKey());
        }

        public GameKey BuyGame(string gameName)
        {
            return GameKeyDistributor.GetGame(gameName);
        }



    }
}
