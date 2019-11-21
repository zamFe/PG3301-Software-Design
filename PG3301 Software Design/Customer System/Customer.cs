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

        public Customer(int ID, string name , Marketplace market)
        {
            _ID = ID;
            _name = name;
            _market = market;
          
        }

        public int GetID()
        {
            return _ID;
        }

        public void SetID(int newID)
        {
            _ID = newID;
        }

        //customer will try to purchase available products as long as thread is running
        protected override void Task()
        {
            while (_market.Publisher.GetAvailableGames().Count > 0 && _isRunning) ;
            Product g = _market.BuyGame(_name);
        }

    }
}
