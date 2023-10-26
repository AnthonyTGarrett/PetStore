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

            if (_shoppingList.Count > 0)
            {
                foreach (Product product in _shoppingList)
                {
                    Console.Write("Product: " + product.Name + " Quantity: " + product.Quantity);

                    Console.WriteLine(" Price: " + product.Price + "\n");
                }
            }
            else { Console.WriteLine("Shopping List is Empty"); }

        }
    }
}
