using Observer;

var usdStock = new Stock("USD", 1.00f);
var euroStock = new Stock("EURO", 0.90f);
var turkishLiraStock = new Stock("TL", 27.00f);
var syrianLiraStock = new Stock("SYP", 14000.00f);

var statusBar =  new StatusBar();
statusBar.AddStock(usdStock);
statusBar.AddStock(euroStock);

var listView = new StockListView();
listView.AddStock(usdStock);
listView.AddStock(euroStock);
listView.AddStock(turkishLiraStock);
listView.AddStock(syrianLiraStock);

euroStock.Price = 0.93f; // Updates both StatusBar and StockListView
turkishLiraStock.Price = 26.50f; // Updates only ListView