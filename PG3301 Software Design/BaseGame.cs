using System;

namespace PG3301_Software_Design
{
    class BaseGame : Game
    {
        public int gameID { get; private set; }
        public string name { get; private set; }
        public string key { get; private set; }
        public double price { get; private set; }

        public BaseGame(int gameID, string name, string key, double price)
        {

            this.gameID = gameID;
            this.name = name;
            this.key = key;
            this.price = price;
        }
    }
}
