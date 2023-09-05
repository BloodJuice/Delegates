using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projects
{
    public class ExchangeMonitor
    {
        public delegate void Price(int price);

        public Price PriceRandom { get; set; }
        
        public void Start()
        {
            while (true)
            {
                int bankPrice = (new Random()).Next(100);
                PriceRandom(bankPrice);
                Thread.Sleep(2000);
            }
        }
    }
}
