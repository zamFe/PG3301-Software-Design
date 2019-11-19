using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
   
    static class GameKeyController
    {
        public static GameKey MakeGameKey()
        {
            return new GameKey(GameFactory.Create(), KeyGenerator.GenerateKey());
        }
    }
}
