using System;

namespace PG3301_Software_Design
{
    public interface IGame
    {
        string GetName();

        string GetDescription();

        double GetPrice();

        string GetEdition();

        string ToString();

        bool Equals(IGame game);
    }
}