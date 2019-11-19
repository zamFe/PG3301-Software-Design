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
            Game bougthGame = GameFactory.Create();
            if(bougthGame != null)
            {
                Console.WriteLine("{0} bought: {1}Game Key: {2}\n", _name, bougthGame.ToString(), KeyGenerator.GenerateKey());
            }

        }



    }
}
