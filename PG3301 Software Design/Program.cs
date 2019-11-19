using System;
using System.Collections.Generic;
using System.Threading;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Customer> customers = new List<Customer>() { new Customer(1, "Felix"), new Customer(2, "Andreas"), new Customer(3, "Tomas Uten H"), new Customer(4, "Jesper")};
     

            for(int i = 0; i < 3; i++)
            {
                Marketplace.CreateGame();
            }

            foreach (var customer in customers)
            {
                
                customer.BuyGame();
            }


        }



    }
}
