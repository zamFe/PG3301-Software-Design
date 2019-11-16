using System;

namespace PG3301_Software_Design
{
    interface Game
    {
        //Return the game's ID
        public int gameID { get; }

        //Return name of the game
        public string name { get; }

        //Return the price of the game
        public string key { get; }

        //Return the key for the game
        public double price { get; }
    }
}