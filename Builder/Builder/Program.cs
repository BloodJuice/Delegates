using Builder;


class Program
{
    static void Main(string[] args)
    {
        IBuilderCheeseBurger burger = new CheeseBurgerBuilder();
        Shef shef = new Shef(burger);
        shef.ConstuctCheeseburger();
        Product product = burger.GetBurger();
        string a = product.GetProduct()[0];
        Console.WriteLine(a);
    }
}