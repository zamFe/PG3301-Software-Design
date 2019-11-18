using System;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseGame baseGame = new BaseGame(19.99);

            Standard standard = new Standard(baseGame);

            Super super = new Super(baseGame);

            Deluxe deluxe = new Deluxe(super);

            Console.WriteLine(standard.GetDescription() + " Edition" + "\nPrice: " + standard.GetPrice() + "\n");

            Console.WriteLine(super.GetDescription() + " Edition" + "\nPrice: " + super.GetPrice() + "\n");

            Console.WriteLine(deluxe.GetDescription() + " Edition" + "\nPrice: " + deluxe.GetPrice() + "\n");


        }
    }
}
