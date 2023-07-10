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

        public DocumentState CreateState() => new(Content, FontName, FontSize);

        public void RestoreState(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

        public override string ToString() =>
            "Document { " +
            "content='" + Content + '\'' +
            ", fontName='" + FontName + '\'' +
            ", fontSize=" + FontSize +
            " }";
    }
}