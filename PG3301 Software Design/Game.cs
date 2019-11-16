using System;

namespace PG3301_Software_Design
{
    interface Game
    {
        //Return name of the game
        public string getName();

        //Return the price of the game
        public double getPrice();

        //Return the key for the game
        public string getKey();
    }
}