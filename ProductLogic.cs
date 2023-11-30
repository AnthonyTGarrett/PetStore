namespace PetStore
{
    class ProductLogic : IProductLogic
    {
        private List<Product> _products { get; set; }
        Dictionary<string, DogLeash> _dogLeash { get; set; }
        Dictionary<string, CatFood> _catfood { get; set; }

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeash = new Dictionary<string, DogLeash>();
            _catfood = new Dictionary<string, CatFood>();

            Product product1 = new DogLeash("Kobe Leash", 12.99m, 1, "Very Nice Leash", 30, "Leather");
            Product product2 = new DogLeash("Spammy Leash", 13.99m, 0, "Terrible Leash", 24, "Fake Leather");
            Product product3 = new CatFood("Spicy meals", 8.99m, 3, "Very spicy food", false);


            _products.Add(product1);
            _products.Add(product2);
            _products.Add(product3);
        }
        // Adding the product to the individual dictionaries and the overall List
        public void AddProduct(Product product)
        {
            if (product is DogLeash)
            {
                _dogLeash.Add(product.Name, product as DogLeash);
            }

            if (product is CatFood)
            {
                _catfood.Add(product.Name, product as CatFood);
            }
            _products.Add(product);

        }

        // Retrieve the dog leash properties from the dictionary
        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeash[name];
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        // Retrieve the cat food properties from the dictionary
        public CatFood GetCatFoodByName(string name)
        {
            try
            {
                return _catfood[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // Retrieve all of the products from the Lists
        public void GetAllProducts()
        {
            foreach (var item in _products)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public bool hasLeash()
        {
            return _dogLeash.Count != 0;
        }

        public bool hasLeash(string name)
        {
            return _dogLeash.ContainsKey(name);
        }

        public bool hasFood(string name)
        {
            return _catfood.ContainsKey(name);
        }

        public bool hasFood()
        {
            return _catfood.Count != 0;
        }

        public List<String> GetOnlyInStockProducts()
        {
            return _products.Where(x => x.Quantity > 0).Select(x => x.Name).ToList();
        }
    }
}
