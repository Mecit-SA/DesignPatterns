namespace Memento
{
    /// <summary>
    /// Caretaker: state manager
    /// </summary>
    class History
    {
        private readonly Stack<DocumentState> _states = new();

        public void Push(DocumentState state) => _states.Push(state);

        public DocumentState Pop() => _states.Count == 1 ? _states.Peek() : _states.Pop();
    }
}