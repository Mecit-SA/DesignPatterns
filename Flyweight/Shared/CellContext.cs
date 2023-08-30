namespace Flyweight
{
    public class CellContext
    {
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public bool IsBold { get; set; }

        public CellContext(string fontFamily, int fontSize, bool isBold)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;
            IsBold = isBold;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FontFamily, FontSize, IsBold);
        }
    }
}