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
            List<string> names = new List<string>() {"Felix", "Andreas", "Jesper", "Tomas uten H", "Bjarne", "Torild", "Beate"};
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                customers.Add(CustomerFactory.Create(names[rnd.Next(0, names.Count - 1)], g4a));
            }

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