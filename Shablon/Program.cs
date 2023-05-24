using Shablon;
using Shablon.Command;
using Shablon.Decorator;
using Shablon.Factory;
using Shablon.Singleton;
using System.Diagnostics;

Restaurant restaurant = Restaurant.GetInstance();
Cashier cashier = new Cashier();
Chef chef = new Chef();
BurgerFactory burgerFactory = new BurgerFactory();

while (true)
{
    // take order from customer
    Console.WriteLine("Please enter your burger order (royal, classic, or veggie):");
    string burgerType = Console.ReadLine().ToLower();

    // create burger using factory
    IBurger burger;
    switch (burgerType)
    {
        case "royal":
            burger = burgerFactory.CreateBurger(burgerType);
            break;
        case "classic":
            burger = burgerFactory.CreateBurger(burgerType);
            break;
        case "veggie":
            burger = burgerFactory.CreateBurger(burgerType);
            break;
        default:
            throw new ArgumentException("Invalid burger type");
    }

    // add sauce to burger using decorator
    Console.WriteLine("Would you like garlic sauce with your burger? (y/n)");
    string answer = Console.ReadLine().ToLower();
    if (answer == "y")
    {
        burger = new GarlicSauce(burger);
    }

    Console.WriteLine("Would you like ketchup with your burger? (y/n)");
    answer = Console.ReadLine().ToLower();
    if (answer == "y")
    {
        burger = new Ketchup(burger);
    }

    // set command based on burger type
    ICommand command;
    switch (burgerType)
    {
        case "royal":
            command = new MakeRoyalBurgerCommand(chef);
            break;
        case "classic":
            command = new MakeClassicBurgerCommand(chef);
            break;
        case "veggie":
            command = new MakeVeggieBurgerCommand(chef);
            break;
        default:
            throw new ArgumentException("Invalid burger type");
    }

    // set command for cashier and take order
    cashier.SetCommand(command);
    cashier.TakeOrder();

    // serve burger
    Console.WriteLine("Here is your " + burger.GetDescription() + ".");
}