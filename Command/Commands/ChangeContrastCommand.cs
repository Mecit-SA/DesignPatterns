namespace Command
{
    class ChangeContrastCommand : UndoableCommand
    {
        private float _contrast;
        private float _previousContrast;

        public ChangeContrastCommand(VideoEditor videoEditor, History history, float contrast)
            :base(history, videoEditor)
        {
            _contrast = contrast;
        }

        public override void OnExecute()
        {
            _previousContrast = _videoEditor.Contrast;
            _videoEditor.Contrast = _contrast;
        }

        public override void Unexecute()
        {
            _videoEditor.Contrast = _previousContrast;
        }
    }
}