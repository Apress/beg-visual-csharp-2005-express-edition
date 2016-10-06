using System;
using System.Collections.Generic;
using System.Text;
using ExchangeRate.WebServiceX;

namespace ExchangeRate
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConvertor service = new CurrencyConvertor();
            double rate = service.ConversionRate(Currency.GBP, Currency.USD);
            Console.WriteLine("The conversion rate from British Pounds to Dollars is {0}",
                rate);
            Console.ReadLine();
        }
    }
}
