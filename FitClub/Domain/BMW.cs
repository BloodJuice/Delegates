using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Domain 
{
    internal class BMW : ICar
    {
        public string owner { get; set; }
        public string description { get; set; }
        private readonly int price = 15000;
        public BMW(string owner)
        {
            this.owner = owner;
            description = "It's BMW x6";
        }

        public int GetPrice() => price;
    }
}
