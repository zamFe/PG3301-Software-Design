using NUnit.Framework;
using System;
using PG3301_Software_Design;

namespace ProductDistributerTest
{

    public class Tests
    {

        [Test]
        public void TestGetAvailbleGamesEmtyList()
        {
            //TEST: get games from empty list
            ProductDistributor producer = new ProductDistributor();

            Assert.IsEmpty(producer.GetAvailableGames());
        }


        [Test]
        public void TestGetAvailableGamesNonEmptyList()
        {
            //Get games from non-empty list
            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);

            Assert.IsNotEmpty(producer.GetAvailableGames());
        }


        [Test]
        public void TestProductNotAvailableNonElements()
        {

            ProductDistributor producer = new ProductDistributor();

            Assert.IsFalse(producer.ProductAvailable("Joe Mama"));

        }


        [Test]
        public void TestProductNotAvailableWithElements()
        {

            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);

            Assert.IsFalse(producer.ProductAvailable("Candis"));
        }


        [Test]
        public void TestProductAvailable()
        {

            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);

            Assert.IsTrue(producer.ProductAvailable(testProduct.Game.GetName()));
        }


        [Test]
        public void TestGetProductNoGamesFound()
        {
            ProductDistributor producer = new ProductDistributor();

            Assert.IsNull(producer.GetProduct("Call of Duty"));
        }


        [Test]
        public void TestGetProductGamesFound()
        {
            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);

            Assert.IsNotNull(producer.GetProduct(testProduct.Game.GetName()));

        }


        [Test]
        public void TestRemoveProduct()
        {
            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);

            producer.RemoveProduct(testProduct);

            Assert.IsEmpty(producer.GetAvailableGames());

        }


        [Test]
        public void TestAddGame()
        {

            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);
            int testAvailableGames = producer.GetAvailableGames().Count;

            Assert.AreEqual(1, testAvailableGames);

        }


        [Test]
        public void TestAddMoreGames()
        {

            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();
            Product testProduct2 = ProductFlyweightFactory.MakeProduct();
            Product testProduct3 = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);
            producer.AddProduct(testProduct2);
            producer.AddProduct(testProduct3);

            int testAvailableGames = producer.GetAvailableGames().Count;

            Assert.AreEqual(3, testAvailableGames);

        }


        [Test]
        public void TestAddAndRemoveMoreGames()
        {

            ProductDistributor producer = new ProductDistributor();
            Product testProduct = ProductFlyweightFactory.MakeProduct();
            Product testProduct2 = ProductFlyweightFactory.MakeProduct();
            Product testProduct3 = ProductFlyweightFactory.MakeProduct();

            producer.AddProduct(testProduct);
            producer.AddProduct(testProduct2);
            producer.AddProduct(testProduct3);

            producer.RemoveProduct(testProduct2);

            int testAvailableGames = producer.GetAvailableGames().Count;

            Assert.AreEqual(2, testAvailableGames);

        }

    }
}