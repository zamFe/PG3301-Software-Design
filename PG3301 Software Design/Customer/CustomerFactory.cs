using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    static class CustomerFactory
    {

        //increases on each customer
        private static int customerID = 0;

        public static Customer Create(string name, Marketplace market)
        {
            customerID++;

            return new Customer(customerID, name, market);
        }

    }
}
