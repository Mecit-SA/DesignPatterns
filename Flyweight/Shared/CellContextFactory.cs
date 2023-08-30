namespace Flyweight
{
    public class CellContextFactory
    {
        private readonly Dictionary<int, CellContext> _contexts = new();

        public CellContext GetContext(string fontFamily, int fontSize, bool isBold)
        {
            // Generate a unique key for the combination of fontFamily, fontSize and isBold attributes.
            var hash = HashCode.Combine(fontFamily, fontSize, isBold);

            if (!_contexts.ContainsKey(hash))
                _contexts.Add(hash, new CellContext(fontFamily, fontSize, isBold));

            return _contexts[hash];
        }
    }
}