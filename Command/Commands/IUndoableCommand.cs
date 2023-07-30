namespace Command
{
    interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}