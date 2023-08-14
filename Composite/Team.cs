namespace Composite
{
    /// <summary>
    /// Composite
    /// </summary>
    class Team : IResource
    {
        private readonly ICollection<IResource> _resources = new List<IResource>();

        public void Add(IResource resource) => _resources.Add(resource);

        public void Deploy()
        {
            foreach (var resource in _resources)
                resource.Deploy();
        }
    }
}