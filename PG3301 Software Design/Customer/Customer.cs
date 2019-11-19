using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    class Customer
    {

        private int _ID;
        private string _name;
        private Marketplace _market;


        public Customer(int ID, string name, Marketplace market)
        {
            _ID = ID;
            _name = name;
            _market = market;
        }

        public void BuyGame()
        {
            GameKey bougthGame = _market.BuyGame("Pokemon Shield");

            if(bougthGame != null)
            {
                Console.WriteLine("{0} bought: {1}\n", _name, bougthGame.ToString());
            }

        }



    }
}
