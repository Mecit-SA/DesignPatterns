using ChainOfResponsibility;

var quickBookHandler = new QuickBooksHandler(null);
var numbersSpreadsheetHandler = new NumbersSpreadsheetHandler(quickBookHandler);
var excelSpreadsheetHandler = new ExcelSpreadsheetHandler(numbersSpreadsheetHandler);

var dataReader  = new DataReader(excelSpreadsheetHandler);
dataReader.Read("test.numbers");