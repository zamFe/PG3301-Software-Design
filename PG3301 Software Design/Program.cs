using System;
using System.Collections.Generic;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            //Object randomGame = GameKeyController.MakeGameKey();
            //Object randomGame2 = GameKeyController.MakeGameKey();

            Marketplace market = new Marketplace();

            List<Customer> customers = new List<Customer>() { new Customer(1, "Felix", market), new Customer(2, "Andreas", market), new Customer(3, "Tomas Uten H", market), new Customer(4, "Jesper", market)};

            foreach (var customer in customers)
            {
                customer.BuyGame();
            }



            //Console.WriteLine(randomGame.ToString());
            //Console.WriteLine(randomGame2.ToString());

            Console.WriteLine(GameKeyController.MakeGameKey().ToString());

        }
    }
}
