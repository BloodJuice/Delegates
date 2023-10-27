using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Domain
{
    internal interface ICar
    {
        string owner { get; set; }
        string description { get; set; }
        int GetPrice();
    }
}
