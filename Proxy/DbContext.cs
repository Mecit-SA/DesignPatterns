namespace Proxy
{
    class DbContext
    {
        private readonly ICollection<Product> _updatedObjects = new List<Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine($"SELECT * FROM products WHERE product_id = {id}\n");

            // Simulate reading a product object from a database.
            var product = new ProductProxy(this, id, "Product 1");

            return product;
        }

        public void SaveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in _updatedObjects)
                Console.WriteLine($"UPDATE products SET name = '{updatedObject.Name}' WHERE product_id = {updatedObject.Id} \n");

            _updatedObjects.Clear();
        }

        public void MarkAsChanged(Product product) => _updatedObjects.Add(product);
    }
}
