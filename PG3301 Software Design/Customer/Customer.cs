using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
    class Customer
    {

        private int _ID;
        private string _name;
        private Random rnd = new Random();

        public Customer(int ID, string name )
        {
            _ID = ID;
            _name = name;
          
        }

        public void BuyGame()
        {
            List<string> availableGames = GameKeyDistributor.GetAvailableGames();
            Console.WriteLine("games available: " + availableGames.Count);

            if(availableGames.Count <= 0)
            {
                //no more games available
                return;
            }

            //Get random games from available games
            GameKey bougthGame = Marketplace.BuyGame(availableGames[rnd.Next(0, availableGames.Count)]);

            if(bougthGame != null)
            {
                Console.WriteLine("{0} bought: {1}\n", _name, bougthGame.ToString());
            }

        }



    }
}
