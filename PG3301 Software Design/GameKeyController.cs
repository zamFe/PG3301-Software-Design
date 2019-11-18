using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
   
    public static class GameKeyController
    {
        public class GameKey
        {
            public Object Game;
            public string Key;

            public GameKey(Object Game, string Key)
            {
                this.Game = Game;
                this.Key = Key;

            }

            public override string ToString()
            {
                return Game.ToString() + "Key: " + Key + "\n";
            }
        }

        public static GameKey MakeGameKey()
        {
            return new GameKey(GameFactory.Create(), KeyGenerator.GenerateKey());
        }
    }
}
