﻿using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                QuoteGenerator.kanyeQuote();

                QuoteGenerator.RonQuote();
            }
            

            
        }
    }
}
