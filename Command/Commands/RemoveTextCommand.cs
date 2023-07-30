namespace Command
{
    class RemoveTextCommand : UndoableCommand
    {
        private string? _previousText;

        public RemoveTextCommand(VideoEditor videoEditor, History history):
            base(history, videoEditor)
        {
        }

        public override void OnExecute()
        {
            _previousText = _videoEditor.Text;
            _videoEditor.RemoveText();
        }

        public override void Unexecute()
        {
            _videoEditor.Text = _previousText!;
        }
    }
}