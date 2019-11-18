using System;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseGame baseGame = GameFactory.Create("TheBestGame");

            BaseGame fortnite = GameFactory.Create("Fortnite");

            Super super = new Super(baseGame);

            Deluxe deluxe = new Deluxe(baseGame);

            Super superDeluxe = new Super( new Deluxe(baseGame));

            Gold goldSuperDeluxe = new Gold(new Super(new Deluxe(baseGame)));

            Legendary PureEpicness = new Legendary(new Gold(new Super(new Deluxe(baseGame))));

            Console.WriteLine(baseGame.toString());

            Console.WriteLine(super.toString());

            Console.WriteLine(deluxe.toString());

            Console.WriteLine(superDeluxe.toString());

            Console.WriteLine(goldSuperDeluxe.toString());

            Console.WriteLine(PureEpicness.toString());

            Console.WriteLine(fortnite.toString());

            Console.WriteLine("Your free fortnite key: " + KeyGenerator.GenerateKey() + "\n");

        }
    }
}
