using System;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            Object randomGame = GameKeyController.MakeGameKey();

            Console.WriteLine(randomGame.ToString());

        }
    }
}
