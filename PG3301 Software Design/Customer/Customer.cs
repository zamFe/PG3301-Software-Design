using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
    class Customer : ThreadProxy
    {

        private int _ID;
        private string _name;
        Marketplace _market;
        //private Random rnd = new Random();

        public Customer(int ID, string name , Marketplace market)
        {
            _ID = ID;
            _name = name;
            _market = market;
          
        }

        protected override void Task()
        {
            while (_market.publisher.GetAvailableGames().Count > 0 && _isRunning) ;
            GameKey g = _market.BuyGame(_name);
        }

    }
}
