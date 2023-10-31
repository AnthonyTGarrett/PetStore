namespace PetStore
{
    class ProductLogic
    {
        private List<Product> _products { get; set; }
        Dictionary<string, DogLeash> _dogLeash { get; set; }
        Dictionary<string, Catfood> _catfood { get; set; }

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeash = new Dictionary<string, DogLeash>();
            _catfood = new Dictionary<string, Catfood>();
        }

        public void AddProduct(Product product)
        {
            if (product is DogLeash)
            {
                _dogLeash.Add(product.Name, product as DogLeash);
            }

            if (product is Catfood)
            {
                _catfood.Add(product.Name, product as Catfood);
            }

        }

        public DogLeash GetDogLeashByName(string name)
        {
            return _dogLeash[name];
        }

        public Catfood GetCatFoodByName(string name)
        {
            return _catfood[name];
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }


    }
}
