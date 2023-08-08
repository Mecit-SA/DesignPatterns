namespace ChainOfResponsibility
{
    class QuickBooksHandler : FileHandler
    {
        public QuickBooksHandler(FileHandler? next) : base(next)
        {
        }

        protected override void DoHandle(string fileName)
        {
            Console.WriteLine("QuickBook Handler");
        }

        protected override string GetExtension()
        {
            return ".qbw";
        }
    }
}