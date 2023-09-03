namespace Singleton
{
    class Logger
    {
        private string _fileName;
        private static IDictionary<string, Logger> _instances = new Dictionary<string, Logger>();

        public static Logger GetInstance(string fileName)
        {
            if (!_instances.ContainsKey(fileName))
                _instances.Add(fileName, new Logger(fileName));

            return _instances[fileName];
        }

        private Logger(string fileName)
        {
            _fileName = fileName;
        }

        public void Log(string message) => Console.WriteLine(message);

        public static int InstanceCount => _instances.Count;
    }
}