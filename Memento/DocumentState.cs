namespace Memento
{
    /// <summary>
    /// Memento: the restorable state
    /// </summary>
    class DocumentState
    {
        public string Content { get; set; } = string.Empty;
        public string FontName { get; set; } = string.Empty;
        public int FontSize { get; set; }
    }
}