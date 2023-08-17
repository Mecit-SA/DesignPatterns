namespace Decorator
{
    class Editor
    {
        public void Open(string path)
        {
            var artefacts = new List<IArtefact>()
            {
                new Artefact(),
                new Artefact(),
                new Artefact()
            };

            artefacts[0] = new MainDecorator(new ErrorDecorator(artefacts[0]));
            artefacts[1] = new ErrorDecorator(artefacts[1]);

            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}