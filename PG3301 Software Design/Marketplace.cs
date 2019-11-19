using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
     static class Marketplace
    {
        
        public static void CreateGame()
        {
            GameKeyDistributor.AddGame(GameKeyController.MakeGameKey());
        }

        public static GameKey BuyGame(string gameName)
        {
            return GameKeyDistributor.GetGame(gameName);
        }



    }
}
