using CarFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    internal class FactoryAutoVaz : FactoryMethod
    {
        public string owner {  get; set; }
        public FactoryAutoVaz(string owner) { this.owner = owner; }

        public override ICar FactoryGetCar() => new AutoVaz(owner);
    }
}
