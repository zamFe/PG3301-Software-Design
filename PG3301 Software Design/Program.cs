using System;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            //BaseGame baseGame = new BaseGame(19.99, "Fortnite");

            BaseGame baseGame = GameFactory.Create();

            Super super = new Super(baseGame);

            Deluxe deluxe = new Deluxe(baseGame);

            Super superDeluxe = new Super( new Deluxe(baseGame));

            Gold goldSuperDeluxe = new Gold(new Super(new Deluxe(baseGame)));

            Legendary PureEpicness = new Legendary(new Gold(new Super(new Deluxe(baseGame))));

            Console.WriteLine(baseGame.GetDescription() + " Edition" + "\nPrice: " + baseGame.GetPrice() + "\n");

            Console.WriteLine(super.GetDescription() + " Edition" + "\nPrice: " + super.GetPrice() + "\n");

            Console.WriteLine(deluxe.GetDescription() + " Edition" + "\nPrice: " + deluxe.GetPrice() + "\n");

            Console.WriteLine(superDeluxe.GetDescription() + " Edition" + "\nPrice: " + superDeluxe.GetPrice() + "\n");

            Console.WriteLine(goldSuperDeluxe.GetDescription() + " Edition" + "\nPrice: " + goldSuperDeluxe.GetPrice() + "\n");

            Console.WriteLine(PureEpicness.GetDescription() + " Edition" + "\nPrice: " + PureEpicness.GetPrice() + "\n");

        }
    }
}
