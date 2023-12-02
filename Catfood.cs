namespace PetStore
{
    public class CatFood : Product
    {

        public bool KittenFood { get; set; }

        //public CatFood() : base("Cat Food", 2.99m, 1, "Cat Food")
        //{
        //    KittenFood = false;

        //}

        //public CatFood(string name, decimal price, int quantity, string description, bool kittenFood) : base(name, price, quantity, description)
        //{
        //    KittenFood = kittenFood;

        //}

        public override string ToString()
        {
            return base.ToString() + $"\nKitten Food?: {KittenFood}\n";
        }
    }
}
