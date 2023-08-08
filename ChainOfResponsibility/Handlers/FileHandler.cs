namespace ChainOfResponsibility
{
    abstract class FileHandler
    {
        protected readonly FileHandler? _next;

        protected FileHandler(FileHandler? next)
        {
            _next = next;
        }

        public void Handle(string fileName)
        {
            var extension = GetExtension();

            if (fileName.EndsWith(extension))
            {
                DoHandle(fileName);
                return;
            }

            if (_next == null)
            {
                Console.WriteLine("File format not supported.");
                return;
            }

            _next.Handle(fileName);
        }

        protected abstract string GetExtension();
        protected abstract void DoHandle(string fileName);
    }
}