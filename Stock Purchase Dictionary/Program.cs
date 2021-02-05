using System;
using System.Collections.Generic;

namespace Stock_Purchase_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            var stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("GE", "General Electric");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GME", "Gamestop");
            stocks.Add("AMC", "AMC Entertainment Holdings Inc");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "GME", shares: 60, price: 22.33));
            purchases.Add((ticker: "AMC", shares: 50, price: 7.09));
            purchases.Add((ticker: "CAT", shares: 120, price: 14.45));
            purchases.Add((ticker: "CAT", shares: 60, price: 5.45));

            var congregatedDictionary = new Dictionary<string, int>();


            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (!congregatedDictionary.ContainsKey(stocks[purchase.ticker]))
                {
                    congregatedDictionary.Add(stocks[purchase.ticker], (int)(Convert.ToDouble(purchase.shares) * purchase.price));
                }
                else
                {
                    congregatedDictionary[stocks[purchase.ticker]] += (int)(Convert.ToDouble(purchase.shares) * purchase.price);
                }

            }
            foreach (var item in congregatedDictionary)
            {
                Console.WriteLine($"Stock name is {item.Key} and its value is {item.Value}");
            }

        }
    }
}
