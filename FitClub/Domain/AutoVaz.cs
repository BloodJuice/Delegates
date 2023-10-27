using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Domain
{
    internal class AutoVaz : ICar
    {
        public string owner { get; set; }
        public string description { get; set; }
        private readonly int price = 3000;
        public AutoVaz(string owner) 
        {
            this.owner = owner;
            description = "It's Vaz-Patriot";
        }
        public int GetPrice() => price;
    }
}
