namespace State
{
    /// <summary>
    /// Context
    /// </summary>
    class DirectionService
    {
        private readonly ITravelMode _mode;

        public DirectionService(ITravelMode mode)
        {
            _mode = mode;
        }

        public object GetETA() => _mode.GetETA();
        public object GetDirection() => _mode.GetDirection();
    }
}