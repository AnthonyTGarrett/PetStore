namespace PetStore
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product()
        {
            Name = string.Empty;
            Price = 0;
            Quantity = 0;
            Description = string.Empty;
        }

        public Product(string name, decimal price, int quantity, string description)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} : ${Price} \nQty: {Quantity}\nDescription: {Description}\n";
        }
    }
}
