using System;

namespace PG3301_Software_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseGame baseGame = new BaseGame(19.99);

            StandardDecorator standard = new StandardDecorator(baseGame);

            SuperDecorator super = new SuperDecorator(baseGame);

            Deluxe deluxe = new Deluxe(super);

            Console.WriteLine(standard.GetDescription() + " Edition" + "\nPrice: " + standard.GetPrice() + "\n");

            Console.WriteLine(super.GetDescription() + " Edition" + "\nPrice: " + super.GetPrice() + "\n");

            Console.WriteLine(deluxe.GetDescription() + " Edition" + "\nPrice: " + deluxe.GetPrice() + "\n");


        }
    }
}
