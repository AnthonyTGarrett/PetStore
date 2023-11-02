// See https://aka.ms/new-console-template for more information
using PetStore;


var productLogic = new ProductLogic();
Console.WriteLine("Welcome to Tony's pet supplies!");
Console.WriteLine("-------------------------------");
Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

Found:
while (userInput.ToLower() != "exit")
{
    if (int.Parse(userInput) == 1)
    {
        Console.WriteLine("\nWhat product would you like to add('dog leash' or 'cat food')? ");
        string userProduct = Console.ReadLine();

        if (userProduct.ToLower() == "dog leash")
        {
            var dogLeash = new DogLeash();

            Console.WriteLine("\nWhat brand of Dog Leash(name)? ");
            dogLeash.Name = Console.ReadLine();

            Console.WriteLine("\nWhat was the price of the dog leash ");
            dogLeash.Price = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many do you need? ");
            dogLeash.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDescribe the Leash: ");
            dogLeash.Description = Console.ReadLine();

            Console.WriteLine("\nHow long of a leash do you need? ");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat material should the leash be made of? ");
            dogLeash.Material = Console.ReadLine();

            productLogic.AddProduct(dogLeash);
            Console.WriteLine("Your product was added to the list.");

        }

        if (userProduct.ToLower() == "cat food")
        {
            Catfood catfood = new Catfood();

            Console.WriteLine("\nWhat brand of Cat Food(name)? ");
            catfood.Name = Console.ReadLine();

            Console.WriteLine("\nWhat was the price of the cat food ");
            catfood.Price = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many do you need? ");
            catfood.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDescribe the Cat Food: ");
            catfood.Description = Console.ReadLine();

            Console.WriteLine("\nHow many pounds of cat food do you need? ");
            catfood.WeightPounds = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIs the food for a kitten(yes/no)? ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                catfood.KittenFood = true;

                productLogic.AddProduct(catfood);
                Console.WriteLine("Your product was added to the list.");

            }
            else
            {
                catfood.KittenFood = false;

                productLogic.AddProduct(catfood);
                Console.WriteLine("Your product was added to the list.");
            }
        }
    }
    else if (int.Parse(userInput) == 2)
    {
        Console.WriteLine("What Dog Leash would you like to view?");
        try
        {
            Console.WriteLine(productLogic.GetDogLeashByName(Console.ReadLine()));
        }
        catch (Exception ex)
        {
            Console.WriteLine("That product does not exist.");

        }
    }

    else if (int.Parse(userInput) == 3)
    {
        Console.WriteLine("What Cat Food would you like to view?");
        try
        {
            Console.WriteLine(productLogic.GetCatFoodByName(Console.ReadLine()));
        }
        catch (Exception ex)
        {
            Console.WriteLine("That product does not exist.");

        }

    }
    else if (int.Parse(userInput) == 4)
    {
        productLogic.GetAllProducts();
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

    Console.WriteLine("\nPress 1 to add a product");

    if (productLogic.hasLeash())
    {
        Console.WriteLine("Press 2 to Get your dog leash by name.");
    }
    if (productLogic.hasFood())
    {
        Console.WriteLine("Press 3 to Get your cat food by name.");
    }
    if (productLogic.hasFood() || productLogic.hasLeash())
    {
        Console.WriteLine("Press 4 to Get a list of all products.");
    }

    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

    Console.WriteLine();
}
