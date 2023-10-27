using CarFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    internal class FactoryMercedes : FactoryMethod
    {
        public string owner {  get; set; }
        public FactoryMercedes(string owner) 
        {
            this.owner = owner;
        }
        public override ICar FactoryGetCar() => new Mercedes(owner);
    }
}
