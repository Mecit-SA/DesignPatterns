namespace Command
{
    class History
    {
        private readonly Stack<IUndoableCommand> _commands = new();

        public int Count { get => _commands.Count; }

        public void Push(IUndoableCommand command) => _commands.Push(command);

        public IUndoableCommand Pop() => _commands.Pop();
    }
}