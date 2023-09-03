namespace Prototype
{
    class ContextMenu
    {
        private readonly Timeline _timeline;

        public ContextMenu(Timeline timeline)
        {
            _timeline = timeline;
        }

        public void Duplicate(IComponent component) => _timeline.Add(component.Clone());
    }
}