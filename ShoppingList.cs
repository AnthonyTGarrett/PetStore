namespace PetStore
{
    class ShoppingList
    {
        private List<Product> _shoppingList = new List<Product>();

        public void Add(Product product)
        {
            _shoppingList.Add(product);
        }

        public void PrintShoppingList()
        {
            foreach (Product product in _shoppingList)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
            }
        }
    }
}
