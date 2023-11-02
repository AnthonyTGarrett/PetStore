namespace PetStore
{
    class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }

        public DogLeash() : base("Dog Leash", 4.99m, 1, "Dog Leash")
        {
            LengthInches = 0;
            Material = string.Empty;
        }

        public DogLeash(int lengthInches, string material) : base("Dog Leash", 4.99m, 1, "Dog Leash")
        {
            LengthInches = lengthInches;
            Material = material;
        }

        public DogLeash(string name, decimal price, int quantity, string description, int lengthInches, string material) : base(name, price, quantity, description)
        {
            LengthInches = lengthInches;
            Material = material;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nLength: {LengthInches}\nMaterial: {Material}\n";
        }
    }
}
