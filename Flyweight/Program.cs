using Flyweight;

var contextFactory = new CellContextFactory();
var sheet = new SpreadSheet(contextFactory);
sheet.SetContent(0, 0, "Hello");
sheet.SetContent(1, 0, "World");
sheet.SetFontFamily(0, 0, "Arial");
sheet.Render();