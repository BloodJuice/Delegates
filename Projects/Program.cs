using System;
using System.Globalization;

namespace Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExchangeMonitor result = new ExchangeMonitor();
            result.PriceRandom = Print;
            result.Start();
        }
        public static void Print(int price) => Console.WriteLine($"Price now is {price}");
    }
}
