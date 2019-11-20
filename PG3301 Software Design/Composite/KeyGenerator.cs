using System;
using System.Collections.Generic;
using System.Text;

namespace PG3301_Software_Design
{
    //Generating a random Key with format AAAAA-BBBBB-CCCCC-DDDDD with specified Charset
    static class KeyGenerator
    {
        public static string GenerateKey()
        {

            string keyCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder key = new StringBuilder("", 23);
            Random rnd = new Random();

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