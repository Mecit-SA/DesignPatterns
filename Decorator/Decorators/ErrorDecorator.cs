namespace Decorator
{
    internal class ErrorDecorator : IArtefact
    {
        private readonly IArtefact _artefact;

        public ErrorDecorator(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return _artefact.Render() + " [HasError]";
        }
    }
}