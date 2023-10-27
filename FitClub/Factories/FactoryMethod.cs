using CarFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    internal abstract class FactoryMethod
    {
        public abstract ICar FactoryGetCar();
    }
}
