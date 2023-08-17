namespace Decorator
{
    class MainDecorator : IArtefact
    {
        private readonly IArtefact _artefact;

        public MainDecorator(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return _artefact.Render() + " [IsMain]";
        }
    }
}