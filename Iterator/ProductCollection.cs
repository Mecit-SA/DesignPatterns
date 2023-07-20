namespace Iterator
{
    /// <summary>
    /// Aggregate
    /// </summary>
    class ProductCollection
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product) => _products.Add(product);

        public IIterator CreateIterator() => new ListIterator(this);


        /// <summary>
        /// Concrete Iterator
        /// </summary>
        class ListIterator : IIterator
        {
            private readonly ProductCollection _productCollection;
            private int _index;

            public ListIterator(ProductCollection productCollection)
            {
                _productCollection = productCollection;
            }

            public bool HasNext => _index < _productCollection._products.Count();

            public Product Current => _productCollection._products[_index];

            public void Next() => _index++;
        }
    }
}