using Proxy;

var dbContext = new DbContext();

// We read an object (eg a product) from a database.
var product = dbContext.GetProduct(1);

// We modify the properties of the object in memory.
product.UpdateName("Updated Name");

// DbContext should keep track of changed objects in memory.
// When we call saveChanges(), it'll automatically generate
// the right SQL statements to update our database.
dbContext.SaveChanges();

// After saving the changes to the database, we can
// change our in-memory object again and save the changes.
product.UpdateName("Another name");
dbContext.SaveChanges();