namespace Command
{
    class UndoCommand : ICommand
    {
        private readonly History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Count <= 0) return;

            _history.Pop().Unexecute();
        }
    }
}