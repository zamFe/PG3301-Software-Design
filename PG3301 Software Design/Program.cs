using System;
using System.Collections.Generic;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            Marketplace market = new Marketplace();

            List<Customer> customers = new List<Customer>() { new Customer(1, "Felix", market), new Customer(2, "Andreas", market), new Customer(3, "Tomas Uten H", market), new Customer(4, "Jesper", market)};
     

            for(int i = 0; i < 3
                ; i++)
            {
                GameKeyDistributor.AddGame(GameKeyController.MakeGameKey());
            }


            foreach (var customer in customers)
            {
                customer.BuyGame();
            }

            while (true)
            {
                //Console.WriteLine("\nAttempting to buy Overwatch");

                GameKey coolGame = GameKeyDistributor.GetGame("Pokemon");

                if (coolGame == null)
                {
                    Console.WriteLine("game is out of stock");
                    break;
                }
                else
                {
                    Console.WriteLine("Successfuly purchased: " + coolGame.ToString());
                }
            }

         

        }
    }
}
