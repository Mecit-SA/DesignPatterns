namespace ChainOfResponsibility
{
    class ExcelSpreadsheetHandler : FileHandler
    {
        public ExcelSpreadsheetHandler(FileHandler? next) : base(next)
        {
        }

        protected override void DoHandle(string fileName)
        {
            Console.WriteLine("Excel Spreadsheet Handler");
        }

        protected override string GetExtension()
        {
            return ".xls";
        }
    }
}