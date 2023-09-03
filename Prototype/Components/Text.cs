namespace Prototype
{
    class Text : IComponent
    {
        public string Content { get; private set; }

        public Text(string content)
        {
            Content = content;
        }

        public IComponent Clone()
        {
            return new Text(Content);
        }

        public void Print()
        {
            Console.WriteLine("Text Component { Content = " + Content + " }");
        }
    }
}