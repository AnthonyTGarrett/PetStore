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

        public override string ToString()
        {
            return base.ToString() + $"Amount: {WeightPounds}\nKitten Food?: {KittenFood}\n";
        }
    }
}
