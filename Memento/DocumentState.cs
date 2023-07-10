namespace Memento
{
    /// <summary>
    /// Memento: the restorable state
    /// </summary>
    class DocumentState
    {
        public string Content { get; }
        public string FontName { get; }
        public int FontSize { get; }

        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    }
}