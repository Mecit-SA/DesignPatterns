namespace ChainOfResponsibility
{
    class DataReader
    {
        private readonly FileHandler _fileHandler;

        public DataReader(FileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }

        public void Read(string fileName)
        {
            _fileHandler.Handle(fileName);
        }
    }
}