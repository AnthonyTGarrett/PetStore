// See https://aka.ms/new-console-template for more information
using PetStore;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (int.Parse(userInput) == 1)
    {
        Console.WriteLine("What product would you like to add('dogleash' or 'catfood'? ");
        string userProduct = Console.ReadLine();

        if (userProduct.ToLower() == "dogleash")
        {
            DogLeash dogLeash = new DogLeash();
            Console.WriteLine("How long of a leash do you need? ");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());

            Console.WriteLine("What material should the leash be made of? ");
            dogLeash.Material = Console.ReadLine();

        }

        if (userProduct.ToLower() == "catfood")
        {
            Catfood catfood = new Catfood();
            Console.WriteLine("How many pounds of cat food do you need? ");
            catfood.WeightPounds = int.Parse(Console.ReadLine());

            Console.WriteLine("Is the food for a kitten? ");
            catfood.KittenFood = bool.Parse(Console.ReadLine());
        }
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

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}
