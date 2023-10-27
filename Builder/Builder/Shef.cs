using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Shef
    {
        IBuilderCheeseBurger cheeseburger = new CheeseBurgerBuilder();
        IBuilderBurger hamburger = new HamburgerBuilder();
        public Shef(IBuilderBurger burger)
        {
            hamburger = burger;
        }
        public Shef(IBuilderCheeseBurger burger)
        {
            cheeseburger = burger;
        }

        public void ConstuctHamburger()
        {
            hamburger.BeefCutlet();
            hamburger.Sause();
        }
        public void ConstuctCheeseburger()
        {
            cheeseburger.BeefCutlet();
            cheeseburger.Sause();
            cheeseburger.AddCheese();
        }
    }
}
