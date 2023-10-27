using CarFactory.Domain;
using CarFactory.Factories;

class Program
{
    static void Main(string[] args)
    {
        ICar car = SpeakWithClient();
    }
    static ICar SpeakWithClient()
    {
        Console.WriteLine(">> What car do you want? ");
        Console.WriteLine(">> M -- Mercedes");
        Console.WriteLine(">> B -- BMW");
        Console.WriteLine(">> A -- AutoVaz");
        Console.Write(">>");
        string nameOfCar = Console.ReadLine();

        Console.WriteLine(">> What is your name?");
        Console.Write(">>");
        string nameOfOwner = Console.ReadLine();

        FactoryMethod FactoryOfCar = TypeOfCar(nameOfCar, nameOfOwner);
        ICar car = FactoryOfCar.FactoryGetCar();

        Console.WriteLine($">> Congratulations! You've bought a new car! {car.description}");
        Console.WriteLine($">> But you must pay for it, don't you forget about it??? \nPrice is {car.GetPrice()}");
        Console.WriteLine($">> Car is beloged by you, {car.owner}!");
        return car;
    }
    static FactoryMethod TypeOfCar(string nameOfCar, string nameOfOwner)
    {
        switch(nameOfCar) 
        {
            case "M":
                return new FactoryMercedes(nameOfOwner);
            case "B":
                return new FactoryBMW(nameOfOwner);
            case "A":
                return new FactoryAutoVaz(nameOfOwner);
        }
        return null;
    }
}
