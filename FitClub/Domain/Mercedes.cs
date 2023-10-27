using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Domain
{
    internal class Mercedes : ICar
    {
        public string owner { get; set; }
        public string description { get; set; }
        private readonly int price = 10000;
        public Mercedes(string owner)
        {
            this.owner = owner;
            description = "It's Mercedes-Benz";
        }

        public int GetPrice()
        {
            return price;
        }

    }
}
