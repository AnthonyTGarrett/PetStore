namespace PetStore
{
    class Catfood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public Catfood() : base("Cat Food", 2.99m, 1, "Cat Food")
        {
            WeightPounds = 0;
            KittenFood = false;

        }

        public Catfood(string name, decimal price, int quantity, string description, double weightPounds, bool kittenFood) : base(name, price, quantity, description)
        {
            WeightPounds = weightPounds;
            KittenFood = kittenFood;

        }

        public override string ToString()
        {
            return base.ToString() + $"\nAmount: {WeightPounds}\nKitten Food?: {KittenFood}\n";
        }
    }
}
