namespace Proxy
{
    class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual void UpdateName(string name)
        {
            Name = name;
        }
    }
}