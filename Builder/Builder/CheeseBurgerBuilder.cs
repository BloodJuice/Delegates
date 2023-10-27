using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CheeseBurgerBuilder : IBuilderCheeseBurger
    {
        Product product = new Product();
        public void BeefCutlet()
        {
            product.AddIngridients("BeefCutlet");
        }
        public void AddCheese()
        {
            product.AddIngridients("Cheese");
        }

        public void Sause()
        {
            product.AddIngridients("Sause");
        }

        public Product GetBurger()
        {
            return product;
        }
    }
}
