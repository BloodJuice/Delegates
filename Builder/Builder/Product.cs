using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Product
    {
        List<string> burger = new List<string>();
        public void AddIngridients(string newEl)
        {
            burger.Add(newEl);
        }
        public List<string> GetProduct()
        {
            return burger;
        }
    }
}
