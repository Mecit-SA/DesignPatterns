using Iterator;

var product1 = new Product(1, "First Product");
var product2 = new Product(2, "Second Product");
var product3 = new Product(3, "Third Product");

var productCollection = new ProductCollection();

productCollection.Add(product1);
productCollection.Add(product2);
productCollection.Add(product3);

var iterator = productCollection.CreateIterator();

while (iterator.HasNext)
{
    Console.WriteLine(iterator.Current);
    iterator.Next();
}