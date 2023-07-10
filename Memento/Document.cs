namespace Memento
{
    /// <summary>
    /// Originator: the object with undo mechanism
    /// </summary>
    class Document
    {
        public string Content { get; set; } = string.Empty;
        public string FontName { get; set; } = "Arial";
        public int FontSize { get; set; } = 12;

        public DocumentState CreateState() =>
            new()
            { 
                Content = Content, 
                FontName = FontName, 
                FontSize = FontSize 
            };

        public void RestoreState(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

        public override string ToString()
        {
            return "Document { " +
                   "content='" + Content + '\'' +
                   ", fontName='" + FontName + '\'' +
                   ", fontSize=" + FontSize +
                   " }";
        }
    }
}