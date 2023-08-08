namespace ChainOfResponsibility
{
    class NumbersSpreadsheetHandler : FileHandler
    {
        public NumbersSpreadsheetHandler(FileHandler? next) : base(next)
        {
        }

        protected override void DoHandle(string fileName)
        {
            Console.WriteLine("Numbers Spreadsheet Handler");
        }

        protected override string GetExtension()
        {
            return ".numbers";
        }
    }
}