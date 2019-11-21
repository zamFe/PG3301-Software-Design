using NUnit.Framework;
using System;
using PG3301_Software_Design;

namespace ProductDistributerTest
{
  
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {

            ProductDistributor produser = new ProductDistributor();

            //TEST: get games on empty
            Assert.IsNull(produser.GetAvailableGames());
        }
    }
}