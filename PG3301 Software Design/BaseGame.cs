using System;

namespace PG3301_Software_Design
{
    class BaseGame : Game
    {
        int gameID { get; private set; }
        string name { get; private set; }
        string key { get; private set; }
        double price { get; private set; }

        public BaseGame(int gameID, string name, string key, double price) {

            this.gameID = gameID;
            this.name = name;
            this.key = key;
			this.price = price;
		}
    }
}
