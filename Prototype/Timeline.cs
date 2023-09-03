namespace Prototype
{
    class Timeline
    {
        private ICollection<IComponent> _components = new List<IComponent>();

        public void Add(IComponent component) => _components.Add(component);
    
        public void Print()
        {
            foreach (var component in _components)
                component.Print();
        }
    }
}