using System;

namespace PG3301_Software_Design
{
    interface IGame
    {
        string GetName();

        string GetDescription();

        double GetPrice();

        string ToString();

        string GetEdition();
    }
}