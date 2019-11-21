using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    static class KeyGenerator
    {

       private static Random rnd = new Random();

        //Generates a random Key with format AAAAA-BBBBB-CCCCC-DDDDD using specified set of chars
        public static string GenerateKey()
        {

            string keyCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder key = new StringBuilder("", 23);

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    key.Append(keyCharset[rnd.Next(0, 36)]);
                }
                if(i != 3)
                {
                    key.Append('-');
                }
            }

            return key.ToString();
        }
    }
}