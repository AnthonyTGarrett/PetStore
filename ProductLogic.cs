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

            var product1 = new DogLeash();
            product1.Name = "Kobe Leash";
            product1.Price = 12.99m;
            product1.Quantity = 1;
            product1.Description = "Very Nice Leash";
            product1.LengthInches = 30;
            product1.Material = "Leather";

            var product2 = new DogLeash();
            product2.Name = "Spammy Leash";
            product2.Price = 13.99m;
            product2.Quantity = 0;
            product2.Description = "Terrible Leash";
            product2.LengthInches = 24;
            product2.Material = "Fake Leather";

            var product3 = new CatFood();
            product3.Name = "Spicy meals";
            product3.Price = 8.99m;
            product3.Quantity = 3;
            product3.Description = "Very spicy food";
            product3.KittenFood = false;


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
            catch (Exception ex)
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
        public List<Product> GetAllProducts()
        {
            foreach (var item in _products)
            {
                Console.WriteLine(item.ToString());
            }

            return _products;
        }

        public List<Product> GetOnlyInStockProducts()
        {
            return _products.InStock();
        }

        public bool hasLeash()
        {
            return _dogLeash.Count != 0;
        }

        public bool GetLeash(String name)
        {
            return _dogLeash.ContainsKey(name);
        }

        public bool hasFood()
        {
            return _catfood.Count != 0;
        }

        public decimal GetTotalPriceOfInventory()
        {
            return _products.InStock().Select(x => x.Price).Sum();
        }
    }
}