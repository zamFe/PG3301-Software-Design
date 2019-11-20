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

            List<Customer> customers = new List<Customer>(5);

            customers.Add(CustomerFactory.Create("Felix", g4a));
            customers.Add(CustomerFactory.Create("Andreas", g4a));
            customers.Add(CustomerFactory.Create("Tomas uten H", g4a));
            customers.Add(CustomerFactory.Create("Jesper", g4a));
            customers.Add(CustomerFactory.Create("Trude", g4a));
            customers.Add(CustomerFactory.Create("Agnete", g4a));


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