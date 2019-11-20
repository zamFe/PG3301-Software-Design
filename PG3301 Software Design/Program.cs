using System;
using System.Collections.Generic;
using System.Threading;

namespace PG3301_Software_Design
{
    public class Program
    {
        static void Main(string[] args)
        {
            //g4a stands for games4all, name of the game market (WIP)
            Marketplace g4a = new Marketplace();
            List<Customer> customers = new List<Customer>() { new Customer(1, "Felix", g4a), new Customer(2, "Andreas", g4a), new Customer(3, "Tomas Uten H", g4a), new Customer(4, "Jesper", g4a)};

            g4a.Start();
            foreach (var customer in customers)
            {
                customer.Start();
            }

            Thread.Sleep(4000);

            g4a.Stop();
            foreach (var customer in customers)
            {
                customer.Stop();
            }
        }
    }
}