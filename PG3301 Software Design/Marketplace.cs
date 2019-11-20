using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
     class Marketplace : ThreadProxy
    {

        Random rnd = new Random();

        private readonly object _lock = new object();

        public GameKeyDistributor publisher = new GameKeyDistributor();

        public void CreateGame()
        {
            lock(_lock)
            {
            publisher.AddGame(GameKeyController.MakeGameKey());
            }
        }

        public GameKey BuyGame(string customer)
        {
            lock (_lock)
            {

            List<string> availableGames = publisher.GetAvailableGames();

                if (availableGames.Count <= 0)
                {
                    //no more games available
                    return null;
                }

                //Get random games from available games
                GameKey bougthGame = publisher.GetGame(availableGames[rnd.Next(0, availableGames.Count)]);

                if (bougthGame != null)
                {
                    //aligns purchase info to the right of the console, only used here so not put in function
                    String msg = String.Format("{0} bought: {1}\n", customer, bougthGame.Game.getName() + bougthGame.Game.getDescription() + " Edition");
                    Console.CursorLeft = Console.BufferWidth - msg.Length;
                    Console.Write(msg);
                    Console.CursorLeft = Console.BufferWidth - msg.Length;
                    Console.Write("price: " + bougthGame.Game.GetPrice() + "\n");
                    Console.CursorLeft = Console.BufferWidth - msg.Length;
                    Console.Write("Key: " + bougthGame.Key + "\n\n");
                }

                return bougthGame;
            }
        }

        protected override void Task()
        {
            Thread.Sleep(rnd.Next(400, 600));
            CreateGame();
        }



    }
}
