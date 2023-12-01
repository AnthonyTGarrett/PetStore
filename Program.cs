// See https://aka.ms/new-console-template for more information
using PetStore;


var productLogic = new ProductLogic();
Console.WriteLine("Welcome to Tony's pet supplies!");
Console.WriteLine("-------------------------------");
Console.WriteLine("Press 1 to add a Dog leash");
Console.WriteLine("Press 2 to add Cat Food");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();


while (userInput.ToLower() != "exit")
{
    if (int.Parse(userInput) == 1)
    {
        var dogLeash = new DogLeash();

        Console.Write("What brand of Dog Leash(name)? ");
        dogLeash.Name = Console.ReadLine();

        Console.Write("What is the price of the dog leash ");
        dogLeash.Price = Decimal.Parse(Console.ReadLine());

        Console.Write("How many on hand? ");
        dogLeash.Quantity = int.Parse(Console.ReadLine());

        Console.Write("Describe the Leash: ");
        dogLeash.Description = Console.ReadLine();

        Console.Write("How long is the leash? ");
        dogLeash.LengthInches = int.Parse(Console.ReadLine());

        Console.Write("What material is the leash made of? ");
        dogLeash.Material = Console.ReadLine();

        productLogic.AddProduct(dogLeash);
        Console.WriteLine("Your dog leash was added to the list.");
        Console.WriteLine("");


    }

    else if(int.Parse(userInput) == 2)
    {
        var catfood = new CatFood();

        Console.Write("\nWhat brand of Cat Food(name)? ");
        catfood.Name = Console.ReadLine();

        Console.Write("\nWhat is the price of the cat food ");
        catfood.Price = Decimal.Parse(Console.ReadLine());

        Console.Write("\nHow many on hand? ");
        catfood.Quantity = int.Parse(Console.ReadLine());

        Console.Write("\nDescribe the Cat Food: ");
        catfood.Description = Console.ReadLine();

        Console.Write("\nIs the food for a kitten(yes/no)? ");
        if (Console.ReadLine().ToLower() == "yes")
        {
            catfood.KittenFood = true;

            productLogic.AddProduct(catfood);
            Console.WriteLine("Your kitten food was added to the list.");
            Console.WriteLine("");

        }
        else
        {
            catfood.KittenFood = false;

            productLogic.AddProduct(catfood);
            Console.WriteLine("Your cat food was added to the list.");
            Console.WriteLine("");
        }
    }

    else if (int.Parse(userInput) == 3)
    {
        Console.WriteLine("What Dog Leash would you like to view?");

        var dogLeash = productLogic.GetDogLeashByName(Console.ReadLine());

        if (dogLeash == null)
        {
            Console.WriteLine("That product does not exist.");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine(dogLeash);
        }



    }

    else if (int.Parse(userInput) == 4)
    {
        Console.WriteLine("What Cat Food would you like to view?");

        var catfood = productLogic.GetCatFoodByName(Console.ReadLine());
        if (catfood == null)
        {
            Console.WriteLine("That product does not exist.");
        }
        else
        {
            Console.WriteLine(catfood);
        }

    }
    else if (int.Parse(userInput) == 5)
    {
        productLogic.GetAllProducts();
    }
    else if (int.Parse(userInput) == 6)
    {
        productLogic.GetOnlyInStockProducts();
    }

    else if (userInput.ToLower() == "exit")
    {
        Console.WriteLine("Goodbye");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Please enter a valid command.");

    }

    Console.WriteLine("Press 1 to add a Dog leash");
    Console.WriteLine("Press 2 to add Cat Food");

    if (productLogic.hasLeash())
    {
        Console.WriteLine("Press 3 to Get your dog leash by name.");
    }
    if (productLogic.hasFood())
    {
        Console.WriteLine("Press 4 to Get your cat food by name.");
    }
    if (productLogic.hasFood() || productLogic.hasLeash())
    {
        Console.WriteLine("Press 5 to Get a list of all products.");
        Console.WriteLine("Press 6 to list all in stock products.");
    }

    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

    Console.WriteLine();
}
