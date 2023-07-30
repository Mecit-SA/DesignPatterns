namespace Command
{
    abstract class UndoableCommand : IUndoableCommand
    {
        private readonly History _history;
        protected readonly VideoEditor _videoEditor;

        public UndoableCommand(History history, VideoEditor videoEditor)
        {
            _history = history;
            _videoEditor = videoEditor;
        }

        public void Execute()
        {
            OnExecute();
            _history.Push(this);
        }

        public abstract void OnExecute();
        public abstract void Unexecute();
    }
}