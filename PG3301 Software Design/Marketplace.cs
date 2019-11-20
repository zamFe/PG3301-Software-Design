using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
     class Marketplace : ThreadProxy
    {
        private readonly object _lock = new object();

        public ProductDistributor Publisher = new ProductDistributor();

        Random rnd = new Random();

        public void CreateGame()
        {
            lock(_lock)
            {
                Publisher.AddGame(ProductController.MakeProduct());
            }
        }

        public Product BuyGame(string customer)
        {
            lock (_lock)
            {

                List<string> availableGames = Publisher.GetAvailableGames();

                if (availableGames.Count <= 0)
                {
                    //no more games available
                    return null;
                }

                //Get random games from available games
                Product bougthGame = Publisher.GetGame(availableGames[rnd.Next(0, availableGames.Count)]);

                if (bougthGame != null)
                {
                    //aligns purchase info to the right of the console, only used here so not put in function
                    String msg = String.Format("{0} bought: {1}", customer, bougthGame.Game.GetEdition());
                    if (Console.BufferWidth < msg.Length)
                        Console.CursorLeft = Console.BufferWidth / 2;
                    else
                        Console.CursorLeft = Console.BufferWidth - msg.Length;
                    Console.Write(msg);
                    if (Console.BufferWidth < msg.Length)
                        Console.CursorLeft = Console.BufferWidth / 2;
                    else
                        Console.CursorLeft = Console.BufferWidth - msg.Length;
                    Console.Write("price: " + bougthGame.Game.GetPrice() + "\n");
                    if (Console.BufferWidth < msg.Length)
                        Console.CursorLeft = Console.BufferWidth / 2;
                    else
                        Console.CursorLeft = Console.BufferWidth - msg.Length;
                    Console.Write("Key: " + bougthGame.Key + "\n\n");
                }

                return bougthGame;
            }
        }

        //Starts up the Market and creating games
        protected override void Task()
        {
            Thread.Sleep(rnd.Next(40, 600));
            CreateGame();
        }
    }
}