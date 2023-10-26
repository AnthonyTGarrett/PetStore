// See https://aka.ms/new-console-template for more information
using PetStore;

ShoppingList shoppingList = new ShoppingList();

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (int.Parse(userInput) == 1)
    {
        Console.WriteLine("\nWhat product would you like to add('dog leash' or 'cat food')? ");
        string userProduct = Console.ReadLine();

        if (userProduct.ToLower() == "dog leash")
        {
            DogLeash dogLeash = new DogLeash();
            Console.WriteLine("\nHow long of a leash do you need? ");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat material should the leash be made of? ");
            dogLeash.Material = Console.ReadLine();

            // Console.WriteLine(dogLeash);
            // Console.WriteLine(JsonSerializer.Serialize(dogLeash));
            shoppingList.Add(dogLeash);

        }

        if (userProduct.ToLower() == "cat food")
        {
            Catfood catfood = new Catfood();
            Console.WriteLine("\nHow many pounds of cat food do you need? ");
            catfood.WeightPounds = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIs the food for a kitten(yes/no)? ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                catfood.KittenFood = true;
                // Console.WriteLine(catfood);
                // Console.WriteLine(JsonSerializer.Serialize(catfood));
                shoppingList.Add(catfood);

            }
            else
            {
                catfood.KittenFood = false;
                // Console.WriteLine(catfood);
                // Console.WriteLine(JsonSerializer.Serialize(catfood));
                shoppingList.Add(catfood);
            }
        }
    }
    else if (int.Parse(userInput) == 2)
    {
        shoppingList.PrintShoppingList();
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
    Console.WriteLine("Press 2 to Print shopping List.");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

    Console.WriteLine();
}
